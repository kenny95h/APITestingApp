using Newtonsoft.Json.Linq;
using RestSharp;
using SpotifyAPITestApp.SpotifyIOService.DataHandling;
using SpotifyAPITestApp.SpotifyIOService.HTTPManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyAPITestApp
{
    public class SingleTrackService
    {
        public CallManager CallManager { get; set; }
        public JObject Json_Response { get; set; }
        public DTO<TrackResponse> TrackResponseDTO { get; set; }
        public string TrackResponse { get; set; }

        public int status;

        public SingleTrackService()
        {
            CallManager = new CallManager();
            TrackResponseDTO = new DTO<TrackResponse>();
        }
        public async Task MakeRequestAsync(string track)
        {
            (TrackResponse, status) = await CallManager.MakeRequestAsync(Resource.gettrack, track, Method.Get);
            Json_Response = JObject.Parse(TrackResponse);
            TrackResponseDTO.DeserializeResponse(TrackResponse);
        }

        public async Task PutRequestAsync(string track)
        {
            (TrackResponse, status) = await CallManager.MakeRequestAsync(Resource.tracks, track, Method.Put);
            //Json_Response = JObject.Parse(TrackResponse);
            //TrackResponseDTO.DeserializeResponse(TrackResponse);
        }

        public async Task DeleteRequestAsync(string track)
        {
            (TrackResponse, status) = await CallManager.MakeRequestAsync(Resource.tracks, track, Method.Delete);
            //Json_Response = JObject.Parse(TrackResponse);
            //TrackResponseDTO.DeserializeResponse(TrackResponse);
        }

        public int GetStatusCode()
        {
            return status;
        }
    }
}
