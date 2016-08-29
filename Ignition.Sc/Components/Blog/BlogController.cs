using System.Web.Mvc;
using Ignition.Core.Mvc;
using Ignition.Sc.Components.Blog;

namespace Ignition.Sc.Components.About
{
    public class BlogController : IgnitionController
    {
        public ActionResult BlogGrid() => View<BlogGridAgent, BlogGridViewModel>();

        public ActionResult BlogTile() => View<BlogTileViewModel>();

        public ActionResult BlogPost() => View<BlogPostViewModel>();
    }
}