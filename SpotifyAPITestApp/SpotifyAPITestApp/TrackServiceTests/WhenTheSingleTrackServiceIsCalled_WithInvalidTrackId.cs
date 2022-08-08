using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace SpotifyAPITestApp.TrackServiceTests
{
    public class WhenTheSingleTrackServiceIsCalled_WithInvalidTrackId
    {
        readonly SingleTrackService _singleTrackService = new SingleTrackService();

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            await _singleTrackService.MakeRequestAsync("invalid");
        }

        [Category("Sad Path")]
        [Test]
        public void GetStatusCode_Is400()
        {
            Assert.That(_singleTrackService.GetStatusCode, Is.EqualTo(400));
        }

    }
}
