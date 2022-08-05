# APITestingApp

## Authorization and  Tokens on Spotify

In order to do 'useful stuff' on the Spotify API, such as create a playlist, add, update tracks to a playlist, etc. it is necessary to have a _token_ with which to specify which user account to do these things to.

### Specific Steps

1. Create / Load GET request as follows, supplying the client_id of the profile
   1. https://accounts.spotify.com/authorize?response_type=code&client_id=<CLIENT_ID>&scope=user-read-private+user-read-email+user-library-modify+user-library-read+playlist-read-collaborative+playlist-modify-public+playlist-read-private+playlist-modify-private&redirect_uri=https://spartaglobal.com&state=spartan
   2. You will be redirected to the sparta global website. In the URL of that website, copy the "code" value. It will needed for the next stage
2. Go to https://postman.com. Login
3. In postman, create a POST request to: https://accounts.spotify.com/api/token, Follow the directions in https://developer.spotify.com/documentation/general/guides/authorization/code-flow/ to generate a TOKEN using the CODE.

