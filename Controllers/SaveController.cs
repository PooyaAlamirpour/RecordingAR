using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Base64Saver.Controllers
{
    public class SaveController : Controller
    {
        // GET: Save
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void asImage(string base64image)
        {
            if (string.IsNullOrEmpty(base64image))
                return;

            var t = base64image.Substring(22);  // remove data:image/png;base64,

            byte[] bytes = Convert.FromBase64String(t);

            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }
            var randomFileName = Guid.NewGuid().ToString().Substring(0, 4) + ".png";
            var fullPath = Path.Combine(Server.MapPath("~/Content/Images/"), randomFileName);
            image.Save(fullPath, System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}