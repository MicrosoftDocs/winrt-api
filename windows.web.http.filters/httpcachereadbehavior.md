---
-api-id: T:Windows.Web.Http.Filters.HttpCacheReadBehavior
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Web.Http.Filters.HttpCacheReadBehavior : int
-->

# HttpCacheReadBehavior

## -description
Indicates if read requests by class methods in the [Windows.Web.Http](../windows.web.http/windows_web_http.md) and [Windows.Web.Http.Filters](windows_web_http_filters.md) namespaces use the local HTTP cache for the response.

## -enum-fields
### -field Default:0
Always use the cache algorithm specified in [RFC 2616](https://tools.ietf.org/html/rfc2616) by the IETF to optimize network bandwidth.

### -field MostRecent:1
Use the local HTTP cache if possible but always ask the server if more recent content is available.

The server returns an HTTP status code of 200 (OK) or 304 (Not Modified) when the local content is the most recent.

### -field OnlyFromCache:2
Only use data from the local HTTP cache. This is the offline behavior.

### -field NoCache:3
Do not use cache nor do a conditional request. This ensures that all HTTP requests go directly to the server.


## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | NoCache |

## -examples

## -see-also
[HttpCacheControl](httpcachecontrol.md)
