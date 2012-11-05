using System.Web.Mvc;

namespace CondominioSaoMiguel.Controllers
{
    public class PhotoGalleryController : BaseController
    {
        public ActionResult OpenImageModal(string imageSource)
        {
            //return GetImageModalJSON(imageSource, true);
            return PartialView("_ModalImage", imageSource);
        }

        private ActionResult GetImageModalJSON(string model, bool success)
        {
            return GetJSON(model, "_ModalImage", success);
        }
    }
}