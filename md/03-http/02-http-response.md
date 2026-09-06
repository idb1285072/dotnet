## HTTP Response

```bash
HTTP/1.1 StatusCode StatusDescription - Start Line
Key: Value                            - Response Header
Key: Value
                                      - Empty Line
Response Body                         - Response Body
...
```

## HTTP Response Status Code

- 1xx (Information)
  - 101 Switching Protocols
- 2xx (Success)
  - 200 OK
- 3xx (Redirection)
  - 302 Found
  - 304 Not Modified
- 4xx (Client Error)
  - 400 Bad Request
  - 401 Unauthorized
  - 404 Not Found
- 5xx (Server Error)
  - 500 Internal Server Error

## HTTP Response Headers

- **Date**: Date and time of the response
- **Server**: Name of Server. Kestrel
- **Content-Type**: MIME type of response body
- **Content-Length**: Length (bytes) of response body
- **Cache-Control**: Indicates number of seconds that the response can be cached at the browser.
- **Set-Cookie**: Contains cookies to send to browser.
- **Access-Control-Allow-Origin**: Used to enable CORS (Cross-Origin-Resource-Sharing)
- **Location**: Contains url to redirect
