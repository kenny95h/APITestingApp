using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyAPITestApp.PlaylistServiceTests
{
    public class WhenTheGetTracksPlaylistServiceIsCalled_WithValidPlaylistName
    {
        readonly GetPlaylistService _playlistService = new GetPlaylistService();

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            await _playlistService.MakeRequestAsync("3hw5F0vnHiJkqyjpUO639e");
        }

        [Test]
        public void NumberOfTracks_Is3()
        {
            Assert.That(_playlistService.Json_Response["total"].ToString(), Is.EqualTo("3"));
        }

        [Test]
        public void ObjectNumberOfTracks_Is3()
        {
            Assert.That(_playlistService.PlaylistResponseDTO.Response.total, Is.EqualTo(3));
        }

        [Test]
        public void GetTotalNumTracks_Is3()
        {
            Assert.That(_playlistService.GetTotalNumTracks, Is.EqualTo(3));
        }

        [Test]
        public void GetStatusCode_Is200()
        {
            Assert.That(_playlistService.GetStatusCode, Is.EqualTo(200));
        }
    }
}
