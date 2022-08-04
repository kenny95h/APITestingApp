# APITestingApp

## Authorization and  Tokens on Spotify

In order to do 'useful stuff' on the Spotify API, such as create a playlist, add, update tracks to a playlist, etc. it is necessary to have a _token_ with which to specify which user account to do these things to.

Here are some relevant points that allowed us to generate a token to use within the API testing framework:

- Use [Postman](https://www.postman.com/postman/workspace/postman-team-collections/collection/1559645-e1dfc9cb-3de7-4a73-82cd-602334bae284?ctx=documentation) in the browser to generate the token - Its necessary to sign in
- In the Postman Teams Collection look for the OAuth collection group. Spotify - Client Credentials (helper) request.
- Under Authorization specify your CLIENT_ID for the username and CLIENT_SECRET for the password
- Response - if successful - will contain the access token