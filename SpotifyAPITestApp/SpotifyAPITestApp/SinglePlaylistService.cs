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
    public class SinglePlaylistService
    {
        public CallManager CallManager { get; set; }
        // a Newtonsoft object representing the json response
        public JObject Json_Response { get; set; }
        // the response DTO. Note, that it is a generic type, but we can specify the type of reponse we want. We will come back to this later!
        public DTO<PlaylistResponse> PlaylistResponseDTO { get; set; }
        // the postcode used in this API request
        public string PlaylistSelected { get; set; }
        // the response content as a string
        public string PlaylistResponse { get; set; }

        public SinglePlaylistService()
        {
            CallManager = new CallManager();
            PlaylistResponseDTO = new DTO<PlaylistResponse>();
        }

        public async Task MakeRequestAsync(string playlist)
        {
            PlaylistSelected = playlist;
            // make request
            PlaylistResponse = await CallManager.MakeRequestAsync(Resource.playlists, playlist, Method.Post);
            // Parse JSON string into a JObject
            Json_Response = JObject.Parse(PlaylistResponse);
            // use DTO to convert JSON string to an object tree
            PlaylistResponseDTO.DeserializeResponse(PlaylistResponse);
        }

        public async Task AddTracksRequestAsync(string tracks)
        {
            PlaylistSelected = tracks;
            // make request
            PlaylistResponse = await CallManager.MakeRequestAsync(Resource.playlisttracks, tracks, Method.Post);
            // Parse JSON string into a JObject
            Json_Response = JObject.Parse(PlaylistResponse);
            // use DTO to convert JSON string to an object tree
            PlaylistResponseDTO.DeserializeResponse(PlaylistResponse);
        }

        public async Task DeleteTracksRequestAsync(string tracks)
        {
            PlaylistSelected = tracks;
            // make request
            PlaylistResponse = await CallManager.MakeRequestAsync(Resource.playlisttracks, tracks, Method.Delete);
            // Parse JSON string into a JObject
            Json_Response = JObject.Parse(PlaylistResponse);
            // use DTO to convert JSON string to an object tree
            PlaylistResponseDTO.DeserializeResponse(PlaylistResponse);
        }

        // Test Help Methods:
        public string GetPlaylistID()
        {
            return PlaylistResponseDTO.Response.id;
        }

        public string GetPlaylistName()
        {
            return PlaylistResponseDTO.Response.name;
        }

        public int GetPlaylistTotalFollowers()
        {
            return PlaylistResponseDTO.Response.followers.total;
        }

        public bool CheckIfPlaylistIsCollaborative()
        {
            return PlaylistResponseDTO.Response.collaborative;
        }

        public string GetPlaylistOwnerDisplayName()
        {
            return PlaylistResponseDTO.Response.owner.display_name;
        }

        public int GetPlaylistTotalTracks()
        {
            return PlaylistResponseDTO.Response.tracks.total;
        }
        // tracks.items.track.name string (possible loop)
        public int GetPlaylistTrackName()
        {
            throw new NotImplementedException();
        }
    }
}
