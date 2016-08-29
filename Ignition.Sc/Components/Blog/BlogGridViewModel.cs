using System.Collections;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;
using Ignition.Core.Mvc;
using Ignition.Data.Fields;

namespace Ignition.Sc.Components.Blog
{
    public class BlogGridViewModel : BaseViewModel
    {
        public IHeading Heading { get; set; }
        public IEnumerable<IBlogPost> BlogPosts { get; set; }
        public IBlogGrid EditFrameItem { get; set; }
    }
}