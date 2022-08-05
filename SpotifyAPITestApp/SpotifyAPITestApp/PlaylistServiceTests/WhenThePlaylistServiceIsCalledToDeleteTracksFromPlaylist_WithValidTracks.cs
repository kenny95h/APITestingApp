using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyAPITestApp.PlaylistServiceTests
{
    public class WhenThePlaylistServiceIsCalledToDeleteTracksFromPlaylist_WithValidTracks
    {
        readonly SinglePlaylistService _playlistService = new SinglePlaylistService();

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            await _playlistService.DeleteTracksRequestAsync("spotify:track:4iV5W9uYEdYUVa79Axb7Rh,spotify:track:1301WleyT98MSxVHPZCA6M");
        }

        [Test]
        public void i()
        {
            Assert.That(_playlistService.PlaylistResponseDTO.Response.snapshot_id, Is.EqualTo("New Playlist"));
        }
    }
}
