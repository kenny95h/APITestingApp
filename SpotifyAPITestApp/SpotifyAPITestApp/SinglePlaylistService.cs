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
        public JObject Json_Response { get; set; }
        public DTO<PlaylistResponse> PlaylistResponseDTO { get; set; }
        public string PlaylistResponse { get; set; }

        public int status;

        public SinglePlaylistService()
        {
            CallManager = new CallManager();
            PlaylistResponseDTO = new DTO<PlaylistResponse>();
        }

        public async Task MakeRequestAsync(string playlist)
        {
            (PlaylistResponse, status) = await CallManager.MakeRequestAsync(Resource.playlists, playlist, Method.Post);
            Json_Response = JObject.Parse(PlaylistResponse);
            PlaylistResponseDTO.DeserializeResponse(PlaylistResponse);
        }

        public async Task AddTracksRequestAsync(string tracks)
        {
            (PlaylistResponse, status) = await CallManager.MakeRequestAsync(Resource.playlisttracks, tracks, Method.Post);
            Json_Response = JObject.Parse(PlaylistResponse);
            PlaylistResponseDTO.DeserializeResponse(PlaylistResponse);
        }

        public async Task DeleteTracksRequestAsync(string tracks)
        {
            (PlaylistResponse, status) = await CallManager.MakeRequestAsync(Resource.playlisttracks, tracks, Method.Delete);
            Json_Response = JObject.Parse(PlaylistResponse);
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
        public string GetPlaylistTrackName(int index)
        {
            return PlaylistResponseDTO.Response.tracks.items[index].track.name;
        }
        public int GetStatusCode()
        {
            return status;
        }
    }
}
