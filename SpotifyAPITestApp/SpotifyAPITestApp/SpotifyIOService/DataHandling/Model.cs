using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyAPITestApp.SpotifyIOService.DataHandling
{

    public class GetPlaylistResponse : IResponse
    {
        public string href { get; set; }
        public Item[] items { get; set; }
        public int limit { get; set; }
        public object next { get; set; }
        public int offset { get; set; }
        public object previous { get; set; }
        public int total { get; set; }
    }

    public class PlaylistResponse : IResponse
    {
        public bool collaborative { get; set; }
        public string description { get; set; }
        public External_Urls external_urls { get; set; }
        public Followers followers { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public Image1[] images { get; set; }
        public string name { get; set; }
        public Owner owner { get; set; }
        public object primary_color { get; set; }
        public bool _public { get; set; }
        public string snapshot_id { get; set; }
        public Tracks tracks { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class External_Urls
    {
        public string spotify { get; set; }
    }

    public class Followers
    {
        public object href { get; set; }
        public int total { get; set; }
    }

    public class Owner
    {
        public string display_name { get; set; }
        public External_Urls1 external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class External_Urls1
    {
        public string spotify { get; set; }
    }

    public class Tracks
    {
        public string href { get; set; }
        public Item[] items { get; set; }
        public int limit { get; set; }
        public object next { get; set; }
        public int offset { get; set; }
        public object previous { get; set; }
        public int total { get; set; }
    }

    public class Item
    {
        public DateTime added_at { get; set; }
        public Added_By added_by { get; set; }
        public bool is_local { get; set; }
        public object primary_color { get; set; }
        public Track track { get; set; }
        public Video_Thumbnail video_thumbnail { get; set; }
    }

    public class Added_By
    {
        public External_Urls2 external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class External_Urls2
    {
        public string spotify { get; set; }
    }

    public class Track
    {
        public Album album { get; set; }
        public Artist1[] artists { get; set; }
        public string[] available_markets { get; set; }
        public int disc_number { get; set; }
        public int duration_ms { get; set; }
        public bool episode { get; set; }
        public bool _explicit { get; set; }
        public External_Ids external_ids { get; set; }
        public External_Urls5 external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public bool is_local { get; set; }
        public string name { get; set; }
        public int popularity { get; set; }
        public string preview_url { get; set; }
        public bool track { get; set; }
        public int track_number { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class Album
    {
        public string album_type { get; set; }
        public Artist[] artists { get; set; }
        public string[] available_markets { get; set; }
        public External_Urls3 external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public Image[] images { get; set; }
        public string name { get; set; }
        public string release_date { get; set; }
        public string release_date_precision { get; set; }
        public int total_tracks { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class External_Urls3
    {
        public string spotify { get; set; }
    }

    public class Artist
    {
        public External_Urls4 external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class External_Urls4
    {
        public string spotify { get; set; }
    }

    public class Image
    {
        public int height { get; set; }
        public string url { get; set; }
        public int width { get; set; }
    }

    public class External_Ids
    {
        public string isrc { get; set; }
    }

    public class External_Urls5
    {
        public string spotify { get; set; }
    }

    public class Artist1
    {
        public External_Urls6 external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class External_Urls6
    {
        public string spotify { get; set; }
    }

    public class Video_Thumbnail
    {
        public object url { get; set; }
    }

    public class Image1
    {
        public object height { get; set; }
        public string url { get; set; }
        public object width { get; set; }
    }

    public class TrackResponse : IResponse
    {
        public Album album { get; set; }
        public Artist1[] artists { get; set; }
        public string[] available_markets { get; set; }
        public int disc_number { get; set; }
        public int duration_ms { get; set; }
        public bool _explicit { get; set; }
        public External_Ids external_ids { get; set; }
        public External_Urls2 external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public bool is_local { get; set; }
        public string name { get; set; }
        public int popularity { get; set; }
        public string preview_url { get; set; }
        public int track_number { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    //public class Album
    //{
    //    public string album_type { get; set; }
    //    public Artist[] artists { get; set; }
    //    public string[] available_markets { get; set; }
    //    public External_Urls external_urls { get; set; }
    //    public string href { get; set; }
    //    public string id { get; set; }
    //    public Image[] images { get; set; }
    //    public string name { get; set; }
    //    public string release_date { get; set; }
    //    public string release_date_precision { get; set; }
    //    public int total_tracks { get; set; }
    //    public string type { get; set; }
    //    public string uri { get; set; }
    //}

    //public class External_Urls
    //{
    //    public string spotify { get; set; }
    //}

    //public class Artist
    //{
    //    public External_Urls1 external_urls { get; set; }
    //    public string href { get; set; }
    //    public string id { get; set; }
    //    public string name { get; set; }
    //    public string type { get; set; }
    //    public string uri { get; set; }
    //}

    //public class External_Urls1
    //{
    //    public string spotify { get; set; }
    //}

    //public class Image
    //{
    //    public int height { get; set; }
    //    public string url { get; set; }
    //    public int width { get; set; }
    //}

    //public class External_Ids
    //{
    //    public string isrc { get; set; }
    //}

    //public class External_Urls2
    //{
    //    public string spotify { get; set; }
    //}

    //public class Artist1
    //{
    //    public External_Urls3 external_urls { get; set; }
    //    public string href { get; set; }
    //    public string id { get; set; }
    //    public string name { get; set; }
    //    public string type { get; set; }
    //    public string uri { get; set; }
    //}

    //public class External_Urls3
    //{
    //    public string spotify { get; set; }
    //}

}
