using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyAPITestApp.PlaylistServiceTests
{
    public class WhenThePlaylistServiceIsCalled_WithValidPlaylistName
    {
        readonly SinglePlaylistService _playlistService = new SinglePlaylistService();

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            await _playlistService.MakeRequestAsync("New Playlist");
        }

        [Test]
        public void i()
        {
            Assert.That(_playlistService.PlaylistResponseDTO.Response.name, Is.EqualTo("New Playlist"));
        }
    }
}
