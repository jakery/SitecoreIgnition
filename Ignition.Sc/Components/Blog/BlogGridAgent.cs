using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ignition.Core.Models.Page;
using Ignition.Core.Mvc;

namespace Ignition.Sc.Components.Blog
{

    public class BlogGridAgent : Agent<BlogGridViewModel>
    {
        public override void PopulateModel()
        {
            var ds = Datasource as IBlogGrid;
            if (ds == null) return;

            ViewModel.Heading = ds;
            ViewModel.BlogPosts = ds.BlogPosts;
            ViewModel.EditFrameItem = ds;
        }
    }
}

