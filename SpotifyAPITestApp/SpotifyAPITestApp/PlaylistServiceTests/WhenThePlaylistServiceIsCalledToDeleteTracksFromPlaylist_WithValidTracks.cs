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
            await _playlistService.DeleteTracksRequestAsync("spotify:track:7o2CTH4ctstm8TNelqjb51,spotify:track:5CeL9C3bsoe4yzYS1Qz8cw");
        }
        [Category("Delete")]
        [Test]
        public void SnapshotIdGenerated_IsNotNullAndNotEmpty()
        {
            Assert.That(_playlistService.PlaylistResponseDTO.Response.snapshot_id, Is.Not.Null);
            Assert.That(_playlistService.PlaylistResponseDTO.Response.snapshot_id, Is.Not.Empty);
        }
        [Category("Delete")]
        [Test]
        public void GetStatusCode_Is200()
        {
            Assert.That(_playlistService.GetStatusCode, Is.EqualTo(200));
        }
    }
}
