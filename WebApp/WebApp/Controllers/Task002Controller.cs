using System.Web.Mvc;

using WebApp.Models.Task002;

namespace WebApp.Controllers
{
    public class Task002Controller : Controller
    {
        // GET: Task002
        public ActionResult Index()
        {
            var model = new PictureModel
                            {
                                Width = 280,
                                Height = 185
                            };
            return View();
        }

        /// <summary>
        /// Action for uploading image. Change the type of image to appropriate one.
        /// </summary>
        /// <param name="image">Image data.</param>
        /// <returns>View.</returns>
        [HttpPost]
        public ActionResult Upload(object image)
        {
            // Just save uploaded image to the file somewhere. It will be enough for this action.
            return new EmptyResult();
        }
    }
}