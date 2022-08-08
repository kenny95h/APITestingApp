using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyAPITestApp.SpotifyIOService.HTTPManager
{
    public class CallManager
    {
        private readonly RestClient _client;

        private RestRequest _request;
        public RestResponse Response { get; set; }

        public CallManager()
        {
            _client = new RestClient(AppConfigReader.BaseUrl);
            _request = new RestRequest();
            _request.AddHeader("Content-Type", "application/json");
            _request.AddHeader("Authorization", AppConfigReader.AuthToken);
        }

        public async Task<(string,int)> MakeRequestAsync(Resource resource, string code, Method method)
        {
            switch(resource)
            {
                //Add or delete tracks from playlist
                case Resource.playlisttracks:
                    _request.Resource = $"{AppConfigReader.BaseUrl}playlists/{AppConfigReader.PlaylistId}/tracks/";
                    _request.AddJsonBody(new { uris = code.Split(',') });
                    _request.Method = method;
                    Response = await _client.ExecuteAsync(_request);
                    return (Response.Content, (int)Response.StatusCode);
                //Create a new playlist
                case Resource.playlists:
                    _request.Resource = $"{AppConfigReader.BaseUrl}users/{AppConfigReader.UserID}/{resource}/";
                    _request.AddJsonBody(new { Name = code });
                    _request.Method = method;
                    Response = await _client.ExecuteAsync(_request);
                    return (Response.Content, (int)Response.StatusCode);
                //Get track
                case Resource.gettrack:
                    _request.Resource = $"{AppConfigReader.BaseUrl}tracks/{code}";
                    _request.Method = method;
                    Response = await _client.ExecuteAsync(_request);
                    return (Response.Content, (int)Response.StatusCode);
                //Get tracks from playlist
                case Resource.gettracks:
                    _request.Resource = $"{AppConfigReader.BaseUrl}playlists/{code}/tracks/";
                    _request.Method = method;
                    Response = await _client.ExecuteAsync(_request);
                    return (Response.Content, (int)Response.StatusCode);
                //Add or delete tracks from liked list
                case Resource.tracks:
                    _request.Resource = $"{AppConfigReader.BaseUrl}me/{resource}/";
                    _request.AddJsonBody(new { ids = code.Split(',') });
                    _request.Method = method;
                    Response = await _client.ExecuteAsync(_request);
                    return (Response.Content, (int)Response.StatusCode);
                default:
                    throw new ArgumentException();

            }
               
            //if (method == Method.Post || method == Method.Delete)
            //{
            //    if (resource == Resource.playlisttracks)
            //    {
            //        _request.Resource = $"{AppConfigReader.BaseUrl}playlists/{AppConfigReader.PlaylistId}/tracks/";
            //        _request.AddJsonBody(new { uris = code.Split(',') });
            //        _request.Method = method;
            //        Response = await _client.ExecuteAsync(_request);
            //        return (Response.Content, (int)Response.StatusCode);
            //    }
            //    else
            //    {
            //        _request.Resource = $"{AppConfigReader.BaseUrl}users/{AppConfigReader.UserID}/{resource}/";
            //        _request.AddJsonBody(new { Name = code });
            //        _request.Method = method;
            //        Response = await _client.ExecuteAsync(_request);
            //        return (Response.Content, (int)Response.StatusCode);
            //    }
               
            //}
            //else 
            //{
            //    if (resource == Resource.tracks)
            //    {
            //        _request.Resource = $"{AppConfigReader.BaseUrl}{resource}/{code}";
            //    }
            //    else
            //    {
            //        _request.Resource = $"{AppConfigReader.BaseUrl}{resource}/{code}/tracks/";
            //    }
            //    _request.Method = method;
            //    Response = await _client.ExecuteAsync(_request);
            //    return (Response.Content, (int)Response.StatusCode);
            //}
        }
    }
}
