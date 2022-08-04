using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyAPITestApp.TrackServiceTests
{
    public class WhenTheSingleTrackServiceIsCalled_WithValidTrackId
    {
        readonly SingleTrackService _singleTrackService = new SingleTrackService();

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            await _singleTrackService.MakeRequestAsync("2TpxZ7JUBn3uw46aR7qd6V");
        }
        [Test]
        public void StatusIs200_InJsonResponseBody()
        {
            Assert.That(_singleTrackService.Json_Response["status"].ToString(), Is.EqualTo("200"));
        }
    }
}
