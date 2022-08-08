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
    public class GetPlaylistService
    {
        public CallManager CallManager { get; set; }
        public JObject Json_Response { get; set; }
        public DTO<GetPlaylistResponse> PlaylistResponseDTO { get; set; }
        public string PlaylistResponse { get; set; }

        public int status;
        public GetPlaylistService()
        {
            CallManager = new CallManager();
            PlaylistResponseDTO = new DTO<GetPlaylistResponse>();
        }
        public async Task MakeRequestAsync(string playlist)
        {
            (PlaylistResponse, status) = await CallManager.MakeRequestAsync(Resource.gettracks, playlist, Method.Get);
            Json_Response = JObject.Parse(PlaylistResponse);
            PlaylistResponseDTO.DeserializeResponse(PlaylistResponse);
        }

        // Test Help Methods:
        public int GetTotalNumTracks()
        {
            return PlaylistResponseDTO.Response.total;
        }

        public int GetStatusCode()
        {
            return status;
        }

    }
}
