using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace MyGPS.Controllers
{
    public class PositionController : Controller
    {
        private static List<GPSRecord> _records = new List<GPSRecord>();
        public ActionResult Upload(string latitude, string longitude, string trackid)
        {
            _records.Add(new GPSRecord() { Latitude = latitude, Longtitude = longitude, TrackId = trackid });

            return new ContentResult();
        }

        public ActionResult Index()
        {
            return new ContentResult { Content = JsonConvert.SerializeObject(_records) };
        }

    }

    public class GPSRecord
    {
        public string Latitude { get; set; }
        public string Longtitude { get; set; }
        public string TrackId { get; set; }


    }
}
