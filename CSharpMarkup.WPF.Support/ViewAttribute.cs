namespace CSharpMarkup.WPF.Support
{
    [AttributeUsage (AttributeTargets.Class, Inherited = false)]
    public class ViewAttribute : Attribute
    {
        public string Description { get; }

        public ViewAttribute()
        {
        }

        public ViewAttribute(string description)
        {
            Description = description;
        }
    }
}
