﻿using Newtonsoft.Json.Linq;
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
        // a Newtonsoft object representing the json response
        public JObject Json_Response { get; set; }
        // the response DTO. Note, that it is a generic type, but we can specify the type of reponse we want. We will come back to this later!
        public DTO<GetPlaylistResponse> PlaylistResponseDTO { get; set; }
        // the postcode used in this API request
        public string PlaylistSelected { get; set; }
        // the response content as a string
        public string PlaylistResponse { get; set; }

        public GetPlaylistService()
        {
            CallManager = new CallManager();
            PlaylistResponseDTO = new DTO<GetPlaylistResponse>();
        }
        public async Task MakeRequestAsync(string playlist)
        {
            PlaylistSelected = playlist;
            // make request
            PlaylistResponse = await CallManager.MakeRequestAsync(Resource.playlists, playlist, Method.Get);
            // Parse JSON string into a JObject
            Json_Response = JObject.Parse(PlaylistResponse);
            // use DTO to convert JSON string to an object tree
            PlaylistResponseDTO.DeserializeResponse(PlaylistResponse);
        }

        // Test Help Methods:
        public int GetTotalNumTracks()
        {
            return PlaylistResponseDTO.Response.total;
        }

    }
}