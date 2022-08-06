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

        //[Test]
        //public void StatusIs200_InJsonResponseBody()
        //{
        //    Assert.That(_singleTrackService.TrackResponseDTO.Response, Is.EqualTo("200"));
        //}

        [Test]
        public void ObjectNameOfTrack_IsPlaceInTheSun()
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
