using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyAPITestApp.PlaylistServiceTests
{
    public class WhenThePlaylistServiceIsCalledToAddTracksToPlaylist_WithInvalidFormat
    {
        
        readonly SinglePlaylistService _playlistService = new SinglePlaylistService();

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            await _playlistService.AddTracksRequestAsync("7o2CTH4ctstm8TNelqjb51,5CeL9C3bsoe4yzYS1Qz8cw");
        }
        [Category("Sad Path")]
        [Test]
        public void SnapshotIdGenerated_IsNull()
        {
            Assert.That(_playlistService.PlaylistResponseDTO.Response.snapshot_id, Is.Null);
        }
    }
}
