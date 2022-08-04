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
        // a Newtonsoft object representing the json response
        public JObject Json_Response { get; set; }
        // the response DTO. Note, that it is a generic type, but we can specify the type of reponse we want. We will come back to this later!
        public DTO<TrackResponse> TrackResponseDTO { get; set; }
        // the postcode used in this API request
        public string TrackSelected { get; set; }
        // the response content as a string
        public string TrackResponse { get; set; }


        // DRY Code Methods:
        public async Task MakeRequestAsync(string track)
        {
            TrackSelected = track;
            // make request
            TrackResponse = await CallManager.MakeRequestAsync(Resource.tracks, track, Method.Get);
            // Parse JSON string into a JObject
            Json_Response = JObject.Parse(TrackResponse);
            // use DTO to convert JSON string to an object tree
            TrackResponseDTO.DeserializeResponse(TrackResponse);
        }

        public async Task PutRequestAsync(string track) // Hopefull Save a track.
        {
            TrackSelected = track;
            // make request
            TrackResponse = await CallManager.MakeRequestAsync(Resource.tracks, track, Method.Put);
            // Parse JSON string into a JObject
            Json_Response = JObject.Parse(TrackResponse);
            // use DTO to convert JSON string to an object tree
            TrackResponseDTO.DeserializeResponse(TrackResponse);
        }

        public async Task DeleteRequestAsync(string track) // Hopefully Deletes a track.
        {
            TrackSelected = track;
            // make request
            TrackResponse = await CallManager.MakeRequestAsync(Resource.tracks, track, Method.Delete);
            // Parse JSON string into a JObject
            Json_Response = JObject.Parse(TrackResponse);
            // use DTO to convert JSON string to an object tree
            TrackResponseDTO.DeserializeResponse(TrackResponse);
        }
    }
}
