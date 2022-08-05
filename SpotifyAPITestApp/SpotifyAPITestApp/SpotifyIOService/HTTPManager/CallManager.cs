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

        public async Task<string> MakeRequestAsync(Resource resource, string code, Method method)
        {
                _request.Resource = $"{resource}/{code}";
                _request.Method = method;
                Response = await _client.ExecuteAsync(_request);
                return Response.Content;


        }
    }
}
