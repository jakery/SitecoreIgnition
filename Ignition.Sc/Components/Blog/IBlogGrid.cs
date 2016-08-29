using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Ignition.Data.Fields;
using Ignition.Core.Models.BaseModels;

namespace Ignition.Sc.Components.Blog
{
    [SitecoreType(TemplateId = "{0353258B-0A2A-4EDD-93DE-66693E820BBD}", AutoMap = true)]
    public interface IBlogGrid : IHeading
    {
        [SitecoreField(FieldId = "{490239D1-6142-49A0-AEC9-F16968513AC5}", Setting = SitecoreFieldSettings.InferType)]
        IEnumerable<IBlogPost> BlogPosts { get; set; }
    }
}