using Ignition.Core.Mvc;
using Ignition.Data.Fields;

namespace Ignition.Sc.Components.Blog
{
    public class BlogPostViewModel : BaseViewModel
    {
        public IHeading Heading { get; set; }
        public IImage Image { get; set; }
        public IDateField1 DateField1 { get; set; }
        public IAbstract Abstract { get; set; }
    }
}