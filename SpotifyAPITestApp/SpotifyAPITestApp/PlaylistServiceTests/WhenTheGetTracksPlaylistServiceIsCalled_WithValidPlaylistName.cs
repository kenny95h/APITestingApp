using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyAPITestApp.PlaylistServiceTests
{
    public class WhenTheGetTracksPlaylistServiceIsCalled_WithValidPlaylistName
    {
        readonly SinglePlaylistService _playlistService = new SinglePlaylistService();

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            await _playlistService.GetTracksRequestAsync("6QuKSXmuJpiHZec1mYrKwZ");
        }

        [Test]
        public void NumberOfTracks_Is3()
        {
            Assert.That(_playlistService.Json_Response["total"].ToString(), Is.EqualTo("6"));
        }
    }
}
