using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;
using System.Xml.Serialization;
using System.Xml;
using WildFiresBackend.Data;
using WildFiresBackend.Models;
using System.Net;
using System.Security.AccessControl;
using System.Data.SqlTypes;

namespace WildFiresBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]

    public class WildFiresController : ControllerBase
    {
        public WildFiresController() 
        {

        }

        [AllowAnonymous]
        [HttpGet("")]
        public async Task<List<Fire>> GetFiresData()
        {            
            List<Fire> fires = new List<Fire>();
            string url = "https://inciweb.nwcg.gov/incidents/rss.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(Rss));
            using (XmlTextReader reader = new XmlTextReader(url))
            {
                var rss = (Rss)serializer.Deserialize(reader);
                foreach (Item i in rss.Channel.Item)
                {
                    Fire f = new Fire();

                    f.title = i.Title;
                    f.description = i.Description;
                    f.link = i.Link;
                    f.pub_date = i.PubDate;
                    fires.Add(f);
                }
            }
            return fires;
        }
    }
}
