using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawData
{
    public class Rootobject
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
    {
        public string name { get; set; }
        public int size { get; set; }
        public string type { get; set; }
        public object error { get; set; }
        public string url { get; set; }
        public string delete_url { get; set; }
        public string info_url { get; set; }
        public string delete_type { get; set; }
        public string delete_hash { get; set; }
        public bool hash { get; set; }
        public string stats_url { get; set; }
        public string short_url { get; set; }
        public string file_id { get; set; }
        public string unique_hash { get; set; }
        public string url_html { get; set; }
        public string url_bbcode { get; set; }
        public string success_result_html { get; set; }
    }
}