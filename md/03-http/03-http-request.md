## HTTP Request

```bash
Method Url HTTP/1.1 - Start Line
Key: Value          - Request Headers
Key: Value
                    - Empty Line
Request Body        - Request Body
...
```

> QueryString
> /student?id=1&name=raj

## HTTP Request Headers

- **Accept**: Represents MIME type of response content to be accepted by the client
- **Accept-Language**: Represents natural language of response content to be accepted by the client
- **Content-Type**: MIME type of request body
- **Content-Length**: Length (bytes) of request body
- **Date**: Date and time of request
- **Host**: Server domain name
- **User-Agent**: Browser (client) details
- **Cookie**: Contains cookies to send to server.

## HTTP Request Methods

- **GET**: Requests to retrieve information (page, entity object or a static file)
- **POST**: Sends an entity object to server; generally it will be inserted into the database
- **PUT**: Sends an entity object to server; generally updates all properties (full-update) it in the database
- **PATCH**: Sends an entity object to server; generally updates few properties (partial-update) it in the database
- **DELETE**: Requests to delete an entity in the database
