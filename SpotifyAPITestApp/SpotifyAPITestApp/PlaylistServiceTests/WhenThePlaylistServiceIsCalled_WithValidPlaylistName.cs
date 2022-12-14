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
            await _playlistService.MakeRequestAsync("This is David's");
        }

        [Category("Create")]
        [Test]
        public void GetStatusCode_Is201()
        {
            Assert.That(_playlistService.GetStatusCode, Is.EqualTo(201));
        }

        [Test]
        public void IDOfPlaylist_IsNotNull()
        {
            Assert.That(_playlistService.GetPlaylistID(), Is.Not.Null);
        }

        [Test]
        public void NameOfPlaylist_IsThisIsDavids()
        {
            Assert.That(_playlistService.GetPlaylistName(), Is.EqualTo("This is David's"));
        }

        [Test]
        public void TotalPlaylistFollowers_IsZero()
        {
            Assert.That(_playlistService.GetPlaylistTotalFollowers(), Is.EqualTo(0));
        }

        [Test]
        public void PlaylistCollabartive_IsFalse()
        {
            Assert.That(_playlistService.CheckIfPlaylistIsCollaborative(), Is.EqualTo(false));
        }

        [Test]
        public void OwnerDisplayNameOfPlaylist_IsGuns_n_Spartans()
        {
            Assert.That(_playlistService.GetPlaylistOwnerDisplayName(), Is.EqualTo("Guns-n-Spartans"));
        }

        [Test]
        public void PlaylistTotalTracks_IsZero()
        {
            Assert.That(_playlistService.GetPlaylistTotalTracks(), Is.EqualTo(0));
        }

        [Test]
        [Ignore("Not a possible test")]
        public void NameOfTrackInPlaylist_IsTrackNameHere()
        {
            Assert.That(_playlistService.GetPlaylistTrackName(0), Is.EqualTo("Vetenskapsradion Historia"));
        }
    }
}
