using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace SpotifyAPITestApp.TrackServiceTests
{
    public class WhenTheSingleTrackServiceIsCalledToAddTracks_WithValidTrackIds
    {
        readonly SingleTrackService _singleTrackService = new SingleTrackService();

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            await _singleTrackService.PutRequestAsync("7o2CTH4ctstm8TNelqjb51,5CeL9C3bsoe4yzYS1Qz8cw");
        }

        [Category("Like")]
        [Test]
        public void GetStatusCode_Is200()
        {
            Assert.That(_singleTrackService.GetStatusCode, Is.EqualTo(200));
        }
    }
}
