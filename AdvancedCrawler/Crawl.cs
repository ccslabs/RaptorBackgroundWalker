using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCrawler
{
    public class Crawl
    {

        public string UrlToCrawl { get; set; }


        public Crawl()
        {

        }


    }

    public class CurrentSite
    {
        public string ParentUrl { get; set; }
        public ArrayList alAllCollectedUrls { get; set; }
        public ArrayList alImageUrls { get; set; }
        public ArrayList alContentObjects { get; set; }
        public DateTime ProcessedOn = DateTime.UtcNow;
         

    }


}
