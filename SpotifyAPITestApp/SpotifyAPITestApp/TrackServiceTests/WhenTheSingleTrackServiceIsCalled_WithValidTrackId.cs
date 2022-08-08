using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

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
        public void GetStatusCode_Is200()
        {
            Assert.That(_singleTrackService.GetStatusCode, Is.EqualTo(200));
        }

        [Test]
        public void ObjectNameOfTrack_IsAllIWant()
        {
            Assert.That(_singleTrackService.TrackResponseDTO.Response.name.ToString(), Is.EqualTo("All I Want"));
        }

        [Test]
        public void NameOfTrack_IsPlaceInTheSun()
        {
            Assert.That(_singleTrackService.Json_Response["name"].ToString(), Is.EqualTo("All I Want"));
        }
    }
}
