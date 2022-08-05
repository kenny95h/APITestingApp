using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyAPITestApp.SpotifyIOService.DataHandling
{
    public class DTO<ResponseType> where ResponseType : IResponse, new()
    {
        public ResponseType Response { get; set; }
        public void DeserializeResponse(string spotifyResponse)
        {
            Response = JsonConvert.DeserializeObject<ResponseType>(spotifyResponse);
        }
    }
}
