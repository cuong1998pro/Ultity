using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZingMp3CrawData
{
    public class Rootobject
    {
        public int err { get; set; }
        public string msg { get; set; }
        public Data data { get; set; }
        public long timestamp { get; set; }
    }

    public class Data
    {
        public string banner { get; set; }
        public string playlistId { get; set; }
        public int chartId { get; set; }
        public string cover { get; set; }
        public string country { get; set; }
        public string type { get; set; }
        public Group[] group { get; set; }
        public string link { get; set; }
        public int week { get; set; }
        public int year { get; set; }
        public int latestWeek { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public Item[] items { get; set; }
        public string sectionId { get; set; }
    }

    public class Group
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string link { get; set; }
    }

    public class Item
    {
        public string encodeId { get; set; }
        public string title { get; set; }
        public string alias { get; set; }
        public bool isOffical { get; set; }
        public string username { get; set; }
        public string artistsNames { get; set; }
        public Artist[] artists { get; set; }
        public bool isWorldWide { get; set; }
        public string thumbnailM { get; set; }
        public string link { get; set; }
        public string thumbnail { get; set; }
        public int duration { get; set; }
        public bool isZMA { get; set; }
        public bool zingChoise { get; set; }
        public bool isPrivate { get; set; }
        public bool preRelease { get; set; }
        public int releaseDate { get; set; }
        public int streamingStatus { get; set; }
        public bool allowAudioAds { get; set; }
        public bool hasLyric { get; set; }
        public int rakingStatus { get; set; }
        public int score { get; set; }
        public string mvlink { get; set; }
    }

    public class Artist
    {
        public string id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public bool spotlight { get; set; }
    }
}