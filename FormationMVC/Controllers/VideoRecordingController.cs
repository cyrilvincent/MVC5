using FormationMVC.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormationMVC.Controllers
{
    public class VideoRecordingController : Controller
    {
        // GET: VideoRecording
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetById(int id)
        {
            IMainService service = UnityHelper.Resolve<IMainService>();
            VideoRecording vr = service.GetVideoRecordingById(id);
            ViewBag.VideoRecording = vr;
            return View("VideoRecordingById");
        }

        //public ActionResult Create()
        //{
        //    return View();
        //}
        public ActionResult Create(VideoRecording vr)
        {
            IMainService service = UnityHelper.Resolve<IMainService>();
            service.CreateVideoRecording(vr);
            return View();
        }
    }
}