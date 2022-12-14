using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyAPITestApp.PlaylistServiceTests
{
    public class WhenThePlaylistServiceIsCalledToAddTracksToPlaylist_WithValidTracks
    {
        readonly SinglePlaylistService _playlistService = new SinglePlaylistService();

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            await _playlistService.AddTracksRequestAsync("spotify:track:7o2CTH4ctstm8TNelqjb51,spotify:track:5CeL9C3bsoe4yzYS1Qz8cw");
        }

        [Category("Add")]
        [Test]
        public void SnapshotIdGenerated_IsNotNullAndNotEmpty()
        {
            Assert.That(_playlistService.PlaylistResponseDTO.Response.snapshot_id, Is.Not.Null);
            Assert.That(_playlistService.PlaylistResponseDTO.Response.snapshot_id, Is.Not.Empty);
        }

        [Category("Add")]
        [Test]
        public void GetStatusCode_Is201()
        {
            Assert.That(_playlistService.GetStatusCode, Is.EqualTo(201));
        }
    }
}
