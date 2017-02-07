---
-api-id: T:Windows.Web.Http.Filters.HttpCacheWriteBehavior
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Web.Http.Filters.HttpCacheWriteBehavior : int
-->

# HttpCacheWriteBehavior

## -description
Indicates if content returned by requests used by class methods in the [Windows.Web.Http](../windows.web.http/windows_web_http.md) and [Windows.Web.Http.Filters](windows_web_http_filters.md) namespaces is written to the local HTTP cache.

## -enum-fields
### -field Default:0
Use the default behavior of WinInet. This usually results in writing the response to the local HTTP cache.

### -field NoCache:1
Never write the response to the local HTTP cache.


## -remarks

## -examples

## -see-also
[HttpCacheControl](httpcachecontrol.md)