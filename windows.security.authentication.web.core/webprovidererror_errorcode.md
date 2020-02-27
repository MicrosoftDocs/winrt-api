---
-api-id: P:Windows.Security.Authentication.Web.Core.WebProviderError.ErrorCode
-api-type: winrt property
---

<!-- Property syntax
public uint ErrorCode { get; }
-->

# Windows.Security.Authentication.Web.Core.WebProviderError.ErrorCode

## -description
Gets the error code.

## -property-value
The error code.

## -remarks


### HTTP API error returns

| Error code| Message ID | Description |
| -- | -- | -- |
| 0x4AA30064 | INFO_HTTP_STATUS_CONTINUE | The request can be continued. | 
| 0x4AA30065 | INFO_HTTP_STATUS_SWITCH_PROTOCOLS | The server has switched protocols in an upgrade header. | 
| 0x4AA30066 | INFO_HTTP_STATUS_1STCLASS_MAX | Unknown HTTP information code. | 
| 0x0AA300C8 | SUCCESS_HTTP_STATUS_OK | The request completed successfully. | 
| 0x0AA300C9 | SUCCESS_HTTP_STATUS_CREATED | The request has been fulfilled and resulted in the creation of a new resource. | 
| 0x0AA300CA | SUCCESS_HTTP_STATUS_ACCEPTED | The request has been accepted for processing, but the processing has not been completed. | 
| 0x0AA300CB | SUCCESS_HTTP_STATUS_PARTIAL | The returned meta information in the entity-header is not the definitive set available from the origin server. | 
| 0x0AA300CC | SUCCESS_HTTP_STATUS_NO_CONTENT | The server has fulfilled the request, but there is no new information to send back. | 
| 0x0AA300CD | SUCCESS_HTTP_STATUS_RESET_CONTENT | The request has been completed, and the client program should reset the document view that caused the request to be sent to allow the user to easily initiate another input action. | 
| 0x0AA300CE | SUCCESS_HTTP_STATUS_PARTIAL_CONTENT | The server has fulfilled the partial GET request for the resource. | 
| 0x0AA300CF | SUCCESS_HTTP_STATUS_2NDCLASS_MAX | Unknown HTTP success code. | 
| 0xCAA3012C | ERROR_HTTP_STATUS_AMBIGUOUS | The server couldn't decide what to return. | 
| 0xCAA3012D | ERROR_HTTP_STATUS_MOVED | The requested resource has been assigned to a new permanent URI (Uniform Resource Identifier), and any future references to this resource should be done using one of the returned URIs. | 
| 0xCAA3012E | ERROR_HTTP_STATUS_REDIRECT | The requested resource resides temporarily under a different URI (Uniform Resource Identifier). | 
| 0xCAA3012F | ERROR_HTTP_STATUS_REDIRECT_METHOD | The response to the request can be found under a different URI (Uniform Resource Identifier) and should be retrieved using a GET HTTP verb on that resource. | 
| 0xCAA30130 | ERROR_HTTP_STATUS_NOT_MODIFIED | The requested resource has not been modified. | 
| 0xCAA30131 | ERROR_HTTP_STATUS_USE_PROXY | The requested resource must be accessed through the proxy given by the location field. | 
| 0xCAA30133 | ERROR_HTTP_STATUS_REDIRECT_KEEP_VERB | The redirected request keeps the same HTTP verb. HTTP/1.1 behavior. | 
| 0xCAA30134 | ERROR_HTTP_STATUS_3RDCLASS_MAX | Unknown HTTP error. | 
| 0xCAA30190 | ERROR_HTTP_STATUS_BAD_REQUEST | The request could not be processed by the server due to invalid syntax. | 
| 0xCAA30191 | ERROR_HTTP_STATUS_DENIED | The requested resource requires user authentication. | 
| 0xCAA30192 | ERROR_HTTP_STATUS_PAYMENT_REQ | Not currently implemented in the HTTP protocol. | 
| 0xCAA30193 | ERROR_HTTP_STATUS_FORBIDDEN | The server understood the request, but is refusing to fulfill it. | 
| 0xCAA30194 | ERROR_HTTP_STATUS_NOT_FOUND | The server has not found anything matching the requested URI (Uniform Resource Identifier). | 
| 0xCAA30195 | ERROR_HTTP_STATUS_BAD_METHOD | The HTTP verb used is not allowed. | 
| 0xCAA30196 | ERROR_HTTP_STATUS_NONE_ACCEPTABLE | No responses acceptable to the client were found. | 
| 0xCAA30197 | ERROR_HTTP_STATUS_PROXY_AUTH_REQ | Proxy authentication required. | 
| 0xCAA30198 | ERROR_HTTP_STATUS_REQUEST_TIMEOUT | The server timed out waiting for the request. | 
| 0xCAA30199 | ERROR_HTTP_STATUS_CONFLICT | The request could not be completed due to a conflict with the current state of the resource. The user should resubmit with more information. | 
| 0xCAA3019A | ERROR_HTTP_STATUS_GONE | The requested resource is no longer available at the server, and no forwarding address is known. | 
| 0xCAA3019B | ERROR_HTTP_STATUS_LENGTH_REQUIRED | The server refuses to accept the request without a defined content length. | 
| 0xCAA3019C | ERROR_HTTP_STATUS_PRECOND_FAILED | The precondition given in one or more of the request header fields evaluated to false when it was tested on the server. | 
| 0xCAA3019D | ERROR_HTTP_STATUS_REQUEST_TOO_LARGE | The server is refusing to process a request because the request entity is larger than the server is willing or able to process. | 
| 0xCAA3019E | ERROR_HTTP_STATUS_URI_TOO_LONG | The server is refusing to service the request because the request URI (Uniform Resource Identifier) is longer than the server is willing to interpret. | 
| 0xCAA3019F | ERROR_HTTP_STATUS_UNSUPPORTED_MEDIA | The server is refusing to service the request because the entity of the request is in a format not supported by the requested resource for the requested method. | 
| 0xCAA301A0 | ERROR_HTTP_STATUS_4THCLASS_MAX | Unknown HTTP error. | 
| 0xCAA301C1 | ERROR_HTTP_STATUS_RETRY_WITH | The request should be retried after doing the appropriate action. | 
| 0xCAA301F4 | ERROR_HTTP_STATUS_SERVER_ERROR | The server encountered an unexpected condition that prevented it from fulfilling the request. | 
| 0xCAA301F5 | ERROR_HTTP_STATUS_NOT_SUPPORTED | The server does not support the functionality required to fulfill the request. | 
| 0xCAA301F6 | ERROR_HTTP_STATUS_BAD_GATEWAY | The server, while acting as a gateway or proxy, received an invalid response from the upstream server it accessed in attempting to fulfill the request. | 
| 0xCAA301F7 | ERROR_HTTP_STATUS_SERVICE_UNAVAIL | The service is temporarily overloaded. | 
| 0xCAA301F8 | ERROR_HTTP_STATUS_GATEWAY_TIMEOUT | The request was timed out waiting for a gateway. | 
| 0xCAA301F9 | ERROR_HTTP_STATUS_VERSION_NOT_SUP | The server does not support, or refuses to support, the HTTP protocol version that was used in the request message. | 
| 0xCAA301FA | ERROR_HTTP_STATUS_5THCLASS_MAX | Unknown HTTP error. | 


### INET API error returns

| Error code| Message ID | Description |
| -- | -- | -- |
| 0xCAA70001 | ERROR_INET_INVALID_URL | The URL could not be parsed. | 
| 0xCAA70002 | ERROR_INET_NO_SESSION | No Internet session was established. | 
| 0xCAA70003 | ERROR_INET_CANNOT_CONNECT | The attempt to connect to the Internet has failed. | 
| 0xCAA70004 | ERROR_INET_RESOURCE_NOT_FOUND | The server or proxy was not found. | 
| 0xCAA70005 | ERROR_INET_OBJECT_NOT_FOUND | The object was not found. | 
| 0xCAA70006 | ERROR_INET_DATA_NOT_AVAILABLE | An Internet connection was established, but the data cannot be retrieved. | 
| 0xCAA70007 | ERROR_INET_DOWNLOAD_FAILURE | The download has failed (the connection was interrupted). | 
| 0xCAA70008 | ERROR_INET_AUTHENTICATION_REQUIRED | Authentication is needed to access the object. | 
| 0xCAA70009 | ERROR_INET_NO_VALID_MEDIA | The object is not in one of the acceptable MIME types. | 
| 0xCAA7000A | ERROR_INET_CONNECTION_TIMEOUT | The Internet connection has timed out. | 
| 0xCAA7000B | ERROR_INET_INVALID_REQUEST | The request was invalid. | 
| 0xCAA7000C | ERROR_INET_UNKNOWN_PROTOCOL | The protocol is not known and no pluggable protocols have been entered that match. | 
| 0xCAA7000D | ERROR_INET_SECURITY_PROBLEM | A security problem was encountered. Please check settings for IE. | 
| 0xCAA7000E | ERROR_INET_CANNOT_LOAD_DATA | The object could not be loaded. | 
| 0xCAA7000F | ERROR_INET_CANNOT_INSTANTIATE_OBJECT | CoCreateInstance failed. | 
| 0xCAA70010 | ERROR_INET_INVALID_CERTIFICATE | Certificate is invalid. | 
| 0xCAA70011 | ERROR_INET_REDIRECT_FAILED | Redirect request failed. | 
| 0xCAA70012 | ERROR_INET_REDIRECT_TO_DIR | The request is being redirected to a directory. | 
| 0xCAA70013 | ERROR_INET_CANNOT_LOCK_REQUEST | The requested resource could not be locked. | 
| 0xCAA70014 | ERROR_INET_CODE_DOWNLOAD_DECLINED | The component download was declined by the user. | 
| 0xCAA70015 | ERROR_INET_RESULT_DISPATCHED | The binding has already been completed and the result has been dispatched, so your abort call has been canceled. | 
| 0xCAA70016 | ERROR_INET_CANNOT_REPLACE_SFP_FILE | The exact version requested by a component download cannot be found. | 

### Internet API error returns

| Error code| Message ID | Description |
| -- | -- | -- |
| 0xCAA82EE1 | ERROR_ADAL_INTERNET_OUT_OF_HANDLES | No more handles could be generated at this time. | 
| 0xCAA82EE2 | ERROR_ADAL_INTERNET_TIMEOUT | The request has timed out. | 
| 0xCAA82EE3 | ERROR_ADAL_INTERNET_EXTENDED_ERROR | An extended error was returned from the server. This is typically a string or buffer containing a verbose error message. Call InternetGetLastResponseInfo to retrieve the error text. | 
| 0xCAA82EE4 | ERROR_ADAL_INTERNET_INTERNAL_ERROR | An internal error has occurred. | 
| 0xCAA82EE5 | ERROR_ADAL_INTERNET_INVALID_URL | An internal error has occurred. | 
| 0xCAA82EE6 | ERROR_ADAL_INTERNET_UNRECOGNIZED_SCHEME | The URL scheme could not be recognized, or is not supported. | 
| 0xCAA82EE7 | ERROR_ADAL_INTERNET_NAME_NOT_RESOLVED | The server name could not be resolved. | 
| 0xCAA82EE8 | ERROR_ADAL_INTERNET_PROTOCOL_NOT_FOUND | The requested protocol could not be located. | 
| 0xCAA82EE9 | ERROR_ADAL_INTERNET_INVALID_OPTION | A request to InternetQueryOption or InternetSetOption specified an invalid option value. | 
| 0xCAA82EEA | ERROR_ADAL_INTERNET_BAD_OPTION_LENGTH | The length of an option supplied to InternetQueryOption or InternetSetOption is incorrect for the type of option specified. | 
| 0xCAA82EEB | ERROR_ADAL_INTERNET_OPTION_NOT_SETTABLE | The requested option cannot be set, only queried. | 
| 0xCAA82EEC | ERROR_ADAL_INTERNET_SHUTDOWN | Internet API support is being shut down or unloaded. | 
| 0xCAA82EED | ERROR_ADAL_INTERNET_INCORRECT_USER_NAME | Supplied username is not correct. | 
| 0xCAA82EEE | ERROR_ADAL_INTERNET_INCORRECT_PASSWORD | Supplied password is not correct. | 
| 0xCAA82EEF | ERROR_ADAL_INTERNET_LOGIN_FAILURE | The request to connect and log on to an server failed. | 
| 0xCAA82EF0 | ERROR_ADAL_INTERNET_INVALID_OPERATION | The requested operation is invalid. | 
| 0xCAA82EF1 | ERROR_ADAL_INTERNET_OPERATION_CANCELLED | The requested operation is cancelled. | 
| 0xCAA82EF2 | ERROR_ADAL_INTERNET_INCORRECT_HANDLE_TYPE | The type of handle supplied is incorrect for this operation. | 
| 0xCAA82EF3 | ERROR_ADAL_INTERNET_INCORRECT_HANDLE_STATE | The requested operation cannot be carried out because the handle supplied is not in the correct state. | 
| 0xCAA82EF4 | ERROR_ADAL_INTERNET_NOT_PROXY_REQUEST | The request cannot be made via a proxy. | 
| 0xCAA82EF5 | ERROR_ADAL_INTERNET_REGISTRY_VALUE_NOT_FOUND | A required registry value could not be located. | 
| 0xCAA82EF6 | ERROR_ADAL_INTERNET_BAD_REGISTRY_PARAMETER | A required registry value was located but is an incorrect type or has an invalid value. | 
| 0xCAA82EF7 | ERROR_ADAL_INTERNET_NO_DIRECT_ACCESS | Direct network access cannot be made at this time. | 
| 0xCAA82EF8 | ERROR_ADAL_INTERNET_NO_CONTEXT | An asynchronous request could not be made because a zero context value was supplied. | 
| 0xCAA82EF9 | ERROR_ADAL_INTERNET_NO_CALLBACK | An asynchronous request could not be made because a callback function has not been set. | 
| 0xCAA82EFA | ERROR_ADAL_INTERNET_REQUEST_PENDING | The required operation could not be completed because one or more requests are pending. | 
| 0xCAA82EFB | ERROR_ADAL_INTERNET_INCORRECT_FORMAT | The format of the request is invalid. | 
| 0xCAA82EFC | ERROR_ADAL_INTERNET_ITEM_NOT_FOUND | The requested item could not be located. | 
| 0xCAA82EFD | ERROR_ADAL_INTERNET_CANNOT_CONNECT | The attempt to connect to the server failed. | 
| 0xCAA82EFE | ERROR_ADAL_INTERNET_CONNECTION_ABORTED | The connection with the server has been terminated. | 
| 0xCAA82EFF | ERROR_ADAL_INTERNET_CONNECTION_RESET | The connection with the server has been reset. | 
| 0xCAA82F00 | ERROR_ADAL_INTERNET_FORCE_RETRY | The function needs to redo the request. | 
| 0xCAA82F01 | ERROR_ADAL_INTERNET_INVALID_PROXY_REQUEST | The request to the proxy was invalid. | 
| 0xCAA82F02 | ERROR_ADAL_INTERNET_NEED_UI | A user interface or other blocking operation has been requested. | 
| 0xCAA82F04 | ERROR_ADAL_INTERNET_HANDLE_EXISTS | The request failed because the handle already exists. | 
| 0xCAA82F05 | ERROR_ADAL_INTERNET_SEC_CERT_DATE_INVALID | SSL certificate date that was received from the server is bad. The certificate is expired. | 
| 0xCAA82F06 | ERROR_ADAL_INTERNET_SEC_CERT_CN_INVALID | SSL certificate common name (host name field) is incorrect-for example, if you entered www.server.com and the common name on the certificate says www.different.com. | 
| 0xCAA82F07 | ERROR_ADAL_INTERNET_HTTP_TO_HTTPS_ON_REDIR | The application is moving from a non-SSL to an SSL connection because of a redirect. | 
| 0xCAA82F08 | ERROR_ADAL_INTERNET_HTTPS_TO_HTTP_ON_REDIR | The application is moving from an SSL to an non-SSL connection because of a redirect. | 
| 0xCAA82F09 | ERROR_ADAL_INTERNET_MIXED_SECURITY | The content is not entirely secure. Some of the content being viewed may have come from unsecured servers. | 
| 0xCAA82F0A | ERROR_ADAL_INTERNET_CHG_POST_IS_NON_SECURE | The application is posting and attempting to change multiple lines of text on a server that is not secure. | 
| 0xCAA82F0B | ERROR_ADAL_INTERNET_POST_IS_NON_SECURE | The application is posting data to a server that is not secure. | 
| 0xCAA82F0C | ERROR_ADAL_INTERNET_CLIENT_AUTH_CERT_NEEDED | The server is requesting client authentication. | 
| 0xCAA82F0D | ERROR_ADAL_INTERNET_INVALID_CA | The function is unfamiliar with the Certificate Authority that generated the server's certificate. | 
| 0xCAA82F0E | ERROR_ADAL_INTERNET_CLIENT_AUTH_NOT_SETUP | Client authorization is not set up on this computer. | 
| 0xCAA82F0F | ERROR_ADAL_INTERNET_ASYNC_THREAD_FAILED | The application could not start an asynchronous thread. | 
| 0xCAA82F10 | ERROR_ADAL_INTERNET_REDIRECT_SCHEME_CHANGE | The function could not handle the redirection, because the scheme changed (for example, HTTP to FTP). | 
| 0xCAA82F11 | ERROR_ADAL_INTERNET_DIALOG_PENDING | Another thread has a password dialog box in progress. | 
| 0xCAA82F12 | ERROR_ADAL_INTERNET_RETRY_DIALOG | The dialog box should be retried. | 
| 0xCAA82F14 | ERROR_ADAL_INTERNET_HTTPS_HTTP_SUBMIT_REDIR | The data being submitted to an SSL connection is being redirected to a non-SSL connection. | 
| 0xCAA82F15 | ERROR_ADAL_INTERNET_INSERT_CDROM | The request requires a CD-ROM to be inserted in the CD-ROM drive to locate the resource requested. | 
| 0xCAA82F16 | ERROR_ADAL_INTERNET_FORTEZZA_LOGIN_NEEDED | The requested resource requires Fortezza authentication. | 
| 0xCAA82F17 | ERROR_ADAL_INTERNET_SEC_CERT_ERRORS | The SSL certificate contains errors. | 
| 0xCAA82F18 | ERROR_ADAL_INTERNET_SEC_CERT_NO_REV | The SSL certificate was not revoked. | 
| 0xCAA82F19 | ERROR_ADAL_INTERNET_SEC_CERT_REV_FAILED | Revocation of the SSL certificate failed. | 
| 0xCAA82F44 | ERROR_ADAL_INTERNET_CANNOT_CALL_BEFORE_OPEN | Returned by the HttpRequest object if a requested operation cannot be performed before calling the Open method. | 
| 0xCAA82F45 | ERROR_ADAL_INTERNET_CANNOT_CALL_BEFORE_SEND | Returned by the HttpRequest object if a requested operation cannot be performed before calling the Send method. | 
| 0xCAA82F46 | ERROR_ADAL_INTERNET_CANNOT_CALL_AFTER_SEND | Returned by the HttpRequest object if a requested operation cannot be performed after calling the Send method. | 
| 0xCAA82F47 | ERROR_ADAL_INTERNET_CANNOT_CALL_AFTER_OPEN | Returned by the HttpRequest object if a specified option cannot be requested after the Open method has been called. | 
| 0xCAA82F76 | ERROR_ADAL_INTERNET_HEADER_NOT_FOUND | The requested header could not be located. | 
| 0xCAA82F77 | ERROR_ADAL_INTERNET_DOWNLEVEL_SERVER | The server did not return any headers. | 
| 0xCAA82F78 | ERROR_ADAL_INTERNET_INVALID_SERVER_RESPONSE | The server response could not be parsed. | 
| 0xCAA82F79 | ERROR_ADAL_INTERNET_INVALID_HEADER | The supplied header is invalid. | 
| 0xCAA82F7A | ERROR_ADAL_INTERNET_INVALID_QUERY_REQUEST | The request made to HttpQueryInfo is invalid. | 
| 0xCAA82F7B | ERROR_ADAL_INTERNET_HEADER_ALREADY_EXISTS | The header could not be added because it already exists. | 
| 0xCAA82F7C | ERROR_ADAL_INTERNET_REDIRECT_FAILED | The redirection failed. | 
| 0xCAA82F7D | ERROR_ADAL_INTERNET_SECURE_CHANNEL_ERROR | Indicates that an error occurred having to do with a secure channel. | 
| 0xCAA82F80 | ERROR_ADAL_INTERNET_NOT_REDIRECTED | The HTTP request was not redirected. | 
| 0xCAA82F81 | ERROR_ADAL_INTERNET_COOKIE_NEEDS_CONFIRMATION | The HTTP cookie requires confirmation. | 
| 0xCAA82F82 | ERROR_ADAL_INTERNET_COOKIE_DECLINED | The HTTP cookie was declined by the server. | 
| 0xCAA82F86 | ERROR_ADAL_INTERNET_BAD_AUTO_PROXY_SCRIPT | An error occurred executing the script code in the Proxy Auto-Configuration (PAC) file. | 
| 0xCAA82F87 | ERROR_ADAL_INTERNET_UNABLE_TO_DOWNLOAD_SCRIPT | The PAC file cannot be downloaded. For example, the server referenced by the PAC URL may not have been reachable, or the server returned a 404 NOT FOUND response. | 
| 0xCAA82F88 | ERROR_ADAL_INTERNET_REDIRECT_NEEDS_CONFIRMATION | The redirection requires user confirmation. | 
| 0xCAA82F89 | ERROR_ADAL_INTERNET_SECURE_INVALID_CERT | Indicates that a certificate is invalid. | 
| 0xCAA82F8A | ERROR_ADAL_INTERNET_SECURE_CERT_REVOKED | Indicates that a certificate has been revoked. | 
| 0xCAA82F8B | ERROR_ADAL_INTERNET_SECURE_CERT_WRONG_USAGE | Indicates that a certificate is not valid for the requested usage. | 
| 0xCAA82F8F | ERROR_ADAL_INTERNET_SECURE_FAILURE | One or more errors were found in the Secure Sockets Layer (SSL) certificate sent by the server. | 
| 0xCAA82F92 | ERROR_ADAL_INTERNET_AUTO_PROXY_SERVICE_ERROR | A proxy for the specified URL cannot be located. | 
| 0xCAA82F94 | ERROR_ADAL_INTERNET_AUTODETECTION_FAILED | WinHTTP was unable to discover the URL of the Proxy Auto-Configuration (PAC) file. | 
| 0xCAA82F95 | ERROR_ADAL_INTERNET_HEADER_COUNT_EXCEEDED | Larger number of headers were present in a response than WinHTTP could receive. | 
| 0xCAA82F96 | ERROR_ADAL_INTERNET_HEADER_SIZE_OVERFLOW | The size of headers received exceeds the limit for the request handle. | 
| 0xCAA82F97 | ERROR_ADAL_INTERNET_CHUNKED_ENCODING_HEADER_SIZE_OVERFLOW | An overflow condition is encountered in the course of parsing chunked encoding. | 
| 0xCAA82F98 | ERROR_ADAL_INTERNET_RESPONSE_DRAIN_OVERFLOW | Returned when an incoming response exceeds an internal WinHTTP size limit. | 
| 0xCAA82F99 | ERROR_ADAL_INTERNET_CLIENT_CERT_NO_PRIVATE_KEY | The context for the SSL client certificate does not have a private key associated with it. The client certificate may have been imported to the computer without the private key. | 
| 0xCAA82F9A | ERROR_ADAL_INTERNET_CLIENT_CERT_NO_ACCESS_PRIVATE_KEY | The application does not have the required privileges to access the private key associated with the client certificate. | 
| 0xCAAA0001 | ERROR_ADAL_UNEXPECTED | An unexpected error has occurred. | 
| 0xCAAA0002 | ERROR_ADAL_BASE64_ENCODE_FAILED | Base64 encode failed. | 
| 0xCAAA0003 | ERROR_ADAL_COMPRESSION_FAILED | Compression of the data blob failed. | 
| 0xCAAA0004 | ERROR_ADAL_BASE64_URL_DECODE_FAILED | Base64 URL decode failed. | 
| 0xCAAA0005 | ERROR_ADAL_HEX_TO_BYTE_CONVERSION_FAILED | Conversion of hex to byte failed. | 
| 0xCAAA0006 | ERROR_ADAL_CERT_STORE_NOT_OPEN | Certificate store is not opened. | 
| 0xCAA40001 | ERROR_ADAL_SERIALIZED_BLOB_INVALID | Serialization blob is invalid. | 
| 0xCAA20001 | ERROR_ADAL_SERVER_ERROR_UNAUTHORIZED_CLIENT | The client is not authorized to request an authorization code using this method. | 
| 0xCAA20002 | ERROR_ADAL_SERVER_ERROR_INVALID_REQUEST | The request is missing a required parameter, includes an invalid parameter value, includes a parameter more than once, or is otherwise malformed. | 
| 0xCAA20003 | ERROR_ADAL_SERVER_ERROR_INVALID_GRANT | Authorization grant failed for this assertion. | 
| 0xCAA20004 | ERROR_ADAL_SERVER_ERROR_ACCESS_DENIED | The resource owner or authorization server denied the request. | 
| 0xCAA20005 | ERROR_ADAL_SERVER_ERROR_TEMPORARILY_UNAVAILABLE | The authorization server is currently unable to handle the request due to a temporary overloading or maintenance of the server. | 
| 0xCAA20006 | ERROR_ADAL_SERVER_ERROR_UNSUPPORTED_RESPONSE_TYPE | The authorization server does not support obtaining an authorization code using this method. | 
| 0xCAA20007 | ERROR_ADAL_SERVER_ERROR_INVALID_SCOPE | The requested scope is invalid, unknown, or malformed. | 
| 0xCAA20008 | ERROR_ADAL_SERVER_ERROR_RECEIVED | The authorization server encountered an unexpected condition that prevented it from fulfilling the request. | 
| 0xCAA20009 | ERROR_ADAL_SERVER_ERROR_INVALID_CLIENT | Client authentication failed (e.g., unknown client, no client authentication included, or unsupported authentication method). | 
| 0xCAA2000A | ERROR_ADAL_SERVER_ERROR_UNSUPPORTED_UNSUPPORTED_GRANT_TYPE | The authorization grant type is not supported by the authorization server. | 
| 0xCAA2000B | ERROR_ADAL_SERVER_ERROR_INVALID_RESOURCE | The resource is invalid due to configuration state or not existing. | 
| 0xCAA2000C | ERROR_ADAL_SERVER_ERROR_INTERACTION_REQUIRED | The request requires user interaction. | 
| 0xCAA20064 | ERROR_ADAL_SERVER_ERROR_CODE_UNKNOWN | Server return error code, but it is unknown. | 
| 0xCAA90001 | ERROR_ADAL_SERVER_NO_AUTHORIZATION_CODE_FOUND | The response from the server did not have an authorization code. | 
| 0xCAA90002 | ERROR_ADAL_SERVER_ERROR_SAML_ASSERTION_NOT_FOUND | WSTrust response does not have SAML assertion. | 
| 0xCAA90003 | ERROR_ADAL_NO_REFRESH_TOKEN | There is no refresh token. | 
| 0xCAA90004 | ERROR_ADAL_RENEW_BY_REFRESH_TOKEN | Getting token by refresh token failed. | 
| 0xCAA90005 | ERROR_ADAL_RESOURCE_OWNER_PASSWORD_CREDENTIAL_GRANT_FAIL | Failed to get a token by username/password. | 
| 0xCAA90006 | ERROR_ADAL_WSTRUST_TOKEN_REQUEST_FAIL | It failed to get token by WS-Trust flow. | 
| 0xCAA90007 | ERROR_ADAL_URL_INVALID | Url is invalid or too long. | 
| 0x4AA90008 | INFO_ADAL_TOKEN_VALID | Cached token is valid, returning cached token | 
| 0x4AA90009 | INFO_ADAL_TOKEN_EXPIRED | Token is expired | 
| 0x4AA9000A | INFO_ADAL_REFRESHTOKEN_SUCCESS | Access token was renewed by refresh token | 
| 0x4AA9000B | INFO_ADAL_CHANGE_AUTHCODE_TOKEN_SUCCESS | Change authorization code on token completed successfully | 
| 0x4AA9000C | INFO_ADAL_RESOURCE_OWNER_PASSWORD_CREDENTIAL_GRANT_SUCCESS | Getting token by username/password is completed successfully. | 
| 0x4AA9000D | INFO_ADAL_WSTRUST_TOKEN_REQUEST_SUCCESS | WStrust token request is completed successfully | 
| 0x4AA9000E | INFO_ADAL_UI_FLOW_COMPLETE | UI Flow is completed | 
| 0x4AA9000F | INFO_ADAL_REQUEST_COMPLETE | Sending request completed successfully | 
| 0x4AA90010 | INFO_ADAL_REQUEST_SENDING | Sending web request | 
| 0x4AA90011 | INFO_ADAL_HEADERS | Information about request headers | 
| 0xCAA90012 | ERROR_ADAL_SILENT_LOGIN_THREAD_MANUAL_TERMINATED | Background thread for silent login did not terminate on time, so it is manually terminated. | 
| 0xCAA90013 | ERROR_ADAL_FAILED_TO_PARSE_WSTRUST_RESPONSE | It failed to parse WS-Trust(xml format) message. | 
| 0xCAA90014 | ERROR_ADAL_WSTRUST_REQUEST_SECURITYTOKEN_FAILED | Server WS-Trust response reported fault exception and it failed to get assertion | 
| 0xCAA90015 | ERROR_ADAL_OAUTH_RESPONSE_INVALID | Server returned invalid OAuth response | 
| 0xCAA90016 | ERROR_ADAL_IDTOKEN_INVALID | User identifier token is not valid Base64 encoded | 
| 0xCAA90017 | ERROR_ADAL_PROTOCOL_NOT_SUPPORTED | Protocol is not supported by the client library. | 
| 0xCAA90018 | ERROR_ADAL_COULDNOT_DISCOVER_USERREALM | Could not discover a user realm. | 
| 0xCAA90019 | ERROR_ADAL_UNEXPECTED_RESPONSE | Unexpected response from the server. | 
| 0xCAA9001A | ERROR_ADAL_USERREALM_NOENDPOINT | No endpoint information in discovery response. | 
| 0xCAA9001B | ERROR_ADAL_USERREALM_RESPONSE_INVALID_JSON | User realm response is invalid json object. | 
| 0xCAA9001C | ERROR_ADAL_USERREALM_RESPONSE_FEDERATION_PROTOCOL_INVALID | User realm response has unknown federation protocol. | 
| 0xCAA9001D | ERROR_ADAL_USERREALM_RESPONSE_ACCOUNT_TYPE_INVALID | User realm response has unknown account type. | 
| 0xCAA9001E | ERROR_ADAL_USERREALM_RESPONSE_PARSE_FAILED | User realm response is failed to parse. | 
| 0xCAA9001F | ERROR_ADAL_INTEGRATED_AUTH_WITHOUT_FEDERATION | Integrated Windows authentication supported only in federation flow. | 
| 0xCAA90020 | ERROR_ADAL_WS_TRUST_METADATAURL_NOT_SECURE | Url for WS-Trust metadata exchange endpoint is not a secure (https). | 
| 0x8AA90021 | WARNING_ADAL_WS_TRUST_POLICY_VALIDATION | There is an error occurred during WS-Trust policy validation. | 
| 0xCAA90022 | ERROR_ADAL_COULDNOT_DISCOVER_INTEGRATED_AUTH_ENDPOINT | Could not discover endpoint for Integrate Windows Authentication. Check your ADFS settings. It should support Integrate Widows Authentication for WS-Trust 1.3. | 
| 0xCAA90023 | ERROR_ADAL_COULDNOT_DISCOVER_USERNAME_PASSWORD_ENDPOINT | Could not discover endpoint for username/password authentication. Check your ADFS settings. It should support username/password authentication for WS-Trust 1.3. | 
| 0x8AA90024 | WARNING_ADAL_WS_TRUST_MEX_NO_ADDRESS | No address element found in port element. Continue the search. | 
| 0x8AA90025 | WARNING_ADAL_WS_TRUST_MEX_ADDRESS_INSECURE | Address element is found, but contains not a secure Url. Continue the search. | 
| 0x8AA90026 | WARNING_ADAL_WS_TRUST_MEX_NO_BINDING_IN_PORT | No 'binding' attribute is found in port element. | 
| 0x8AA90027 | WARNING_ADAL_WS_TRUST_MEX_NO_SOAP_TRANSPORT | No soap transport found in the element. Continue the search. | 
| 0x8AA90028 | WARNING_ADAL_WS_TRUST_MEX_NO_SOAP_ACTION | No soap action found in the element. Continue the search. | 
| 0x8AA90029 | WARNING_ADAL_WS_TRUST_MEX_NO_NAME_IN_BINDING | No name attribute in binding element. Continue the search. | 
| 0x8AA9002A | WARNING_ADAL_WS_TRUST_MEX_NO_URI_IN_REF | No uri attribute in PolicyReference element. Continue the search. | 
| 0xCAA9002B | ERROR_ADAL_WS_TRUST_MEX_REQUEST | WS-Trust metadata exchange request failed. | 
| 0xCAA9002C | ERROR_ADAL_FAILED_TO_PARSE_XML | Failed to parse XML blob. | 
| 0xCAA9002D | ERROR_ADAL_CLIENT_CREDENTIAL_GRANT_FAIL | Failed to get a token by client credential grant. | 
| 0x4AA9002E | INFO_ADAL_CLIENT_CREDENTIAL_GRANT_SUCCESS | Getting token by the client credential grant is completed successfully. | 
| 0xCAA9002F | ERROR_ADAL_NO_USER_INFO | No user information found. | 
| 0x4AA90030 | INFO_ADAL_PKEYAUTH_CHALLENGE_RECEIVED | PKeyauth challenge is received. | 
| 0x4AA90031 | INFO_ADAL_NAVIGATE_WITH_PKEYAUTH_CHALLENGE_RESPONSE | Browser starts navigating with pkeyauth challange response header. | 
| 0xCAA90032 | ERROR_ADAL_PKEYAUTH_CHALLENGE_RESPONSE_EMPTY | Challenge response header is returned empty. | 
| 0x4AA90033 | INFO_ADAL_PKEYAUTH_SIGNED_WITH_CNG_KEY | PKeyAuth challange is signed with CNG key. | 
| 0x4AA90034 | INFO_ADAL_PKEYAUTH_SIGNED_WITH_CAPI_KEY | PKeyAuth challange is signed with CAPI key. | 
| 0x4AA90035 | INFO_ADAL_PKEYAUTH_SENDING_RESPONSE_FOR_REFRESH_TOKEN | It is sending response for PKeyAuth challenge at refresh token request. | 
| 0xCAA90036 | ERROR_ADAL_PKEYAUTH_NONCE_EMPTY | Nonce in Pkeyauth challenge is empty. | 
| 0xCAA90037 | ERROR_ADAL_PKEYAUTH_AUDIENCE_EMPTY | Audience in Pkeyauth challenge is empty. | 
| 0xCAA90038 | ERROR_ADAL_JWT_BEARER_GRANT_FAIL | Failed to get a token by JWT bearer grant. | 
| 0x4AA90039 | INFO_ADAL_JWT_BEARER_GRANT_SUCCESS | Getting token by the JWT bearer grant is completed successfully. | 
| 0xCAA50001 | ERROR_ADAL_MSXML_NOT_REGISTERED | It could not initialize MSXML class | 
| 0xCAA50002 | ERROR_ADAL_SYSTEM_ERROR_OCCURRED | System error occurred. Please see Details tab for additional info. | 
| 0x8AA50003 | ERROR_ADAL_USER_DOMAIN_STATUS | Failed to determine whether the current user is a domain or local account. | 
| 0x4AA60001 | ERROR_ADAL_JSON_SUCCESS | The operation completed successfully. | 
| 0xCAA60002 | ERROR_ADAL_JSON_OUTOFMEMORY | Out of memory. | 
| 0xCAA60003 | ERROR_ADAL_JSON_INVALID_PARAMETER | The parameter is incorrect. | 
| 0xCAA60004 | ERROR_ADAL_JSON_INSUFFICIENT_BUFFER | The data area passed to a system call is too small. | 
| 0xCAA60005 | ERROR_ADAL_JSON_NOT_FOUND | Element not found. | 
| 0xCAA60006 | ERROR_ADAL_JSON_INTERNAL | Unexpected Failure. | 
| 0xCAA60007 | ERROR_ADAL_JSON_MALFORMED | The JSON text being parsed is malformed. | 
| 0xCAA60008 | ERROR_ADAL_IDTOKEN_JSON_MALFORMED | The id_token JSON text being parsed is malformed. | 
| 0xCAA10001 | ERROR_ADAL_NEED_CREDENTIAL | Need user interface to continue. | 
| 0xCAA10002 | ERROR_UI_PENDING | User interface is waits for user input. | 
| 0xCAA10003 | ERROR_ADAL_INVALID_HTTP_REQUEST_STATE | There was an error while creating a web browser control. | 
| 0xCAA10004 | ERROR_ADAL_WINHTTP_CONNECTION_MISSING | HTTP request state is invalid and connection is missing | 
| 0xCAA10005 | ERROR_ADAL_AUTHORITY_IS_NOT_VALID_URL | The value specified for 'authority' must be Url of the format http(s)://hostname/subpath. | 
| 0xCAA10006 | ERROR_ADAL_AUTHORITY_IS_INVALID | The value specified for 'authority' is invalid. It is not in the valid authority list or not discovered. | 
| 0xCAA10007 | ERROR_ADAL_AUTHORITY_EMPTY | The value specified for 'authority' must be non-empty. | 
| 0xCAA10008 | ERROR_ADAL_AUTHORITY_STATUS_PARAM_IS_NULL | Parameter for status param is null. | 
| 0xCAA10009 | ERROR_ADAL_CLIENTID_EMPTY | The value specified for 'clientId' must be non-empty. | 
| 0xCAA1000A | ERROR_ADAL_RESOURCE_EMPTY | The value specified for 'resource' must be non-empty. | 
| 0xCAA1000B | ERROR_ADAL_REDIRECTURI_EMPTY | The value specified for redirect URI must be non-empty. | 
| 0xCAA1000C | ERROR_ADAL_REDIRECTURI_IS_INVALID | The value specified for redirect URI has invalid format. | 
| 0xCAA1000D | ERROR_ADAL_REDIRECTURI_FRAGMENT | The value specified for redirect URI should not contain fragment (#fragment). | 
| 0xCAA1000E | ERROR_ADAL_HANDLE | The handle is invalid. | 
| 0xCAA1000F | ERROR_ADAL_HANDLE_PROTECTED | The handle specified could not be freed. You don't need to free this handle. | 
| 0xCAA10010 | ERROR_ADAL_TOKEN_LENGTH | Token length is invalid. | 
| 0xCAA10011 | ERROR_ADAL_EXPIRESON | ExpiresOn parameter is invalid. | 
| 0xCAA10012 | ERROR_ADAL_WEBBROWSER_NOINTERFACE | IE parameter does not implement IWebBrowser2 interface. | 
| 0xCAA10013 | ERROR_ADAL_DESCRIPTION_LENGTH | Error description length is invalid. | 
| 0xCAA10014 | ERROR_ADAL_REFRESH_TOKEN_EMPTY | Refresh token is empty. | 
| 0xCAA10015 | ERROR_ADAL_HOST_REQUIREMENTS | Host requirements parameter should not be null. | 
| 0xCAA10016 | ERROR_ADAL_HOST_REQUIREMENTS_INVALIDSIZE | Invalid field size for the host requirements parameter. | 
| 0xCAA10017 | ERROR_ADAL_LOG_OPTIONS_NULL | Log options must not be null for setting the log options | 
| 0xCAA10018 | ERROR_ADAL_LOG_OPTIONS_INVALIDSIZE | Invalid field size for the log options parameter. | 
| 0xCAA10019 | ERROR_ADAL_LOG_TYPE_INVALID | Invalid logger type | 
| 0xCAA1001A | ERROR_ADAL_SERIALIZED_BLOB_EMPTY | Serialized blob is empty. | 
| 0xCAA1001B | ERROR_ADAL_SERIALIZED_BLOB_LENGTH_NULL | Serialized context is null. | 
| 0xCAA1001C | ERROR_ADAL_SERIALIZED_BUFFER_LENGTH | The buffer for output of the serialization is too small. | 
| 0xCAA1001D | ERROR_ADAL_WEB_BROWSER_NULL | Pointer on 'WebBrowser' is null. | 
| 0xCAA1001E | ERROR_ADAL_NON_STA_THREAD | Current thread is not a single thread apartment (STA) thread. This thread must run with COM initialized with 'COINIT_APARTMENTTHREADED' | 
| 0xCAA1001F | ERROR_ADAL_NOT_IMPLEMENTED | Not implemented | 
| 0xCAA10020 | ERROR_ADAL_WINHTTP_CONTENT_INVALID | Content is larger than ULONG_MAX | 
| 0xCAA10021 | ERROR_ADAL_WINHTTP_REQUEST_INVALID | Previous request handle is not closed | 
| 0xCAA10022 | ERROR_ADAL_WINHTTP_REUSE_NOT_PERMITTED | WebRequest object can be used to make one request | 
| 0xCAA10023 | ERROR_ADAL_WINHTTP_STATUS_NOT_OK | WebRequest status is not 200 | 
| 0xCAA10024 | ERROR_ADAL_WINHTTP_EXCEEDS_TOTAL_DOWNLOAD_SIZE | WebRequest total download size is exceeding the current limit | 
| 0xCAA10025 | ERROR_ADAL_WINHTTP_INVALID_ASYNC_CALLBACK | WebRequest needs callback for async calls | 
| 0xCAA10026 | ERROR_ADAL_JSON_STACK_SIZE_LIMIT | Json nested roots are limited | 
| 0xCAA10027 | ERROR_ADAL_WEBREQUEST_ADDITIONAL_HEADERS_INVALID | Additional headers are supposed to have CRLF line ending | 
| 0xCAA10028 | ERROR_ADAL_EVENTREGISTER_PROVIDER_NAME_EMPTY | Registry root name is empty for event log | 
| 0xCAA10029 | ERROR_ADAL_EVENTREGISTER_MESSAGE_DLL_PATH_EMPTY | Message file path is empty | 
| 0xCAA1002A | ERROR_ADAL_NO_UI | No user interface needed to complete request. | 
| 0xCAA1002B | ERROR_ADAL_INVALID_METADATA | Metadata is invalid. | 
| 0xCAA1002C | ERROR_ADAL_GUID_GENERATE_FAILED | It failed to generate GUID | 
| 0xCAA1002D | ERROR_OPERATION_PENDING | Operation is pending. | 
| 0xCAA1002E | ERROR_ADAL_OUT_PARAM_IS_NULL | In_out parameter is null. It is required to set the correct length for the output string. | 
| 0xCAA1002F | ERROR_ENDPOINT_INVALID | Invalid endpoint identifier. | 
| 0xCAA10030 | ERROR_AUTH_ENUM_INVALID | Authentication context options is invalid. Only one option in a time allowed to get, multiple allowed to set. | 
| 0xCAA10031 | ERROR_OPTION_VALUE_INVALID | An option value is invalid. | 
| 0xCAA10032 | ERROR_OPTION_VALUE_NULL | An option value is null. | 
| 0xCAA10033 | ERROR_ACCOUNT_TYPE_NULL | Account type is null. | 
| 0xCAA10034 | ERROR_ACCOUNT_TYPE_INVALID | Account type has invalid value. | 
| 0xCAA10035 | ERROR_USERNAME_EMPTY | User name could not be null or empty. | 
| 0xCAA10036 | ERROR_ADAL_CLIENT_SECRET_LENGTH | Client secret length is null. | 
| 0xCAA10037 | ERROR_ADAL_NO_CREDENTIAL_NEEDED | We don't need credentials for this flow. | 
| 0xCAA10038 | ERROR_ADAL_NO_UI_SUPPORTED | Authentication context doesn't support UI flow. | 
| 0xCAA10039 | ERROR_ASSERTION_TYPE_INVALID | Invalid assertion type. | 
| 0xCAA1003A | ERROR_ADAL_NO_PASSWORD_EXPIRY | Password expiry information is not available with this request. | 
| 0xCAA1003B | ERROR_ADAL_FAILED_TO_OPEN_CERTSTORE | Failed to open local user local certificate store. | 
| 0xCAA1003C | ERROR_ADAL_FAILED_TO_CLOSE_CERTSTORE | Failed to close local user local certificate store | 
| 0xCAA1003D | ERROR_ADAL_OUT_OF_MEMORY | Failed to allocate memory. | 
| 0xCAA1003E | ERROR_ADAL_INVALID_THUMBPRINT | Given certificate thumbprint is invalid. | 
| 0xCAA1003F | ERROR_ADAL_NULL_SIGN_INPUT_MESSAGE | Sign input message is null. | 
| 0xCAA10040 | ERROR_ADAL_SIGNATURE_FAILED | Failed to sign the message. | 
| 0xCAA10041 | ERROR_ADAL_ISSUER_NOT_SET | Certificate issuer is not set. | 
| 0xCAA10042 | ERROR_ADAL_NULL_HASH | Hash input is null. | 



## -examples

## -see-also
[Web account management code sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/WebAccountManagement)
