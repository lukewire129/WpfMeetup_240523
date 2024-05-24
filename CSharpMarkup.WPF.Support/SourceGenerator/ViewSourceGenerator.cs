using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMarkup.WPF.Support.SourceGenerator;

[Generator]
public class ViewSourceGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
        if (context.SyntaxReceiver is not SyntaxReceiver receiver)
            return;

        var compilation = context.Compilation;

        foreach (var classDeclaration in receiver.CandidateClasses)
        {
            var model = compilation.GetSemanticModel (classDeclaration.SyntaxTree);
            var classSymbol = model.GetDeclaredSymbol (classDeclaration) as INamedTypeSymbol;

            var methods = new StringBuilder ();
            foreach (var property in classSymbol.GetMembers ().OfType<IPropertySymbol> ())
            {
                var attribute = property.GetAttributes ().FirstOrDefault (a =>
                    a.AttributeClass.ToDisplayString () == typeof (ViewAttribute).FullName);

                if (attribute == null)
                    continue;

                methods.Append ($@"
                    public partial class {classSymbol.Name}
                    {{
                        public override void Build()
                        {{
                            this.Content = this.Body;
                        }}
                    }}
                   
                    ");
                var source = methods.ToString ();
                context.AddSource ($"{classSymbol.Name}.g.cs", source);
            }
        }
    }

    public void Initialize(GeneratorInitializationContext context)
    {
        context.RegisterForSyntaxNotifications (() => new SyntaxReceiver ());
    }
}

public class SyntaxReceiver : ISyntaxReceiver
{
    public List<ClassDeclarationSyntax> CandidateClasses { get; } = new List<ClassDeclarationSyntax> ();

    public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
    {
        if (syntaxNode is ClassDeclarationSyntax classDeclaration &&
            classDeclaration.AttributeLists.Count > 0)
        {
            CandidateClasses.Add (classDeclaration);
        }
    }
}
