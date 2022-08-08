# Spotify API Testing App

The aim of this project was to produce a testing framework for the Spotify API - a music-sharing and collating website. Functionality tested included:

- Creating a playlist
- Adding a track to a playlist
- Retrieving track / playlist information
- Searching for a track / song

The API base endpoint is located at https://api.spotify.com/v1

Since many of these functions require a user account on Spotify (creating a playlist, for example), one was created purely to aid in developing the framework. And since using certain functions in the API require authorization, it was necessary to follow the OAuth [Authorization Code Flow](https://developer.spotify.com/documentation/general/guides/authorization/code-flow/) , thereby gaining access and refresh tokens to use with the API.

## Authorization and  Tokens on Spotify

In order to do 'useful stuff' on the Spotify API, such as create a playlist, add, update tracks to a playlist, etc. it is necessary to have a _token_ with which to specify which user account to do these things to.

Here are some relevant points that allowed us to generate a token to use within the API testing framework:

- Use [Postman](https://www.postman.com/postman/workspace/postman-team-collections/collection/1559645-e1dfc9cb-3de7-4a73-82cd-602334bae284?ctx=documentation) in the browser to generate the token - Its necessary to sign in
- In the Postman Teams Collection look for the OAuth collection group. Spotify - Client Credentials (helper) request.
- Under Authorization specify your CLIENT_ID for the username and CLIENT_SECRET for the password
- Response - if successful - will contain the access token

