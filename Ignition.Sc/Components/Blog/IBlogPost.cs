using Glass.Mapper.Sc.Configuration.Attributes;
using Ignition.Data.Fields;

namespace Ignition.Sc.Components.Blog
{
    [SitecoreType(TemplateId = "{1F823928-EAEB-4B24-B9C9-A12CAF2941F9}", AutoMap = true)]
    public interface IBlogPost : IHeading, IImage, IDateField1, IAbstract
    {      
    }
}