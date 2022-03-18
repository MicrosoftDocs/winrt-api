---
-api-id: T:Windows.Networking.BackgroundTransfer.ContentPrefetcher
-api-type: winrt class
---

<!-- Class syntax.
public class ContentPrefetcher 
-->

# Windows.Networking.BackgroundTransfer.ContentPrefetcher

## -description
Provides properties for specifying web resources to be prefetched. Windows will use heuristics to attempt to download the specified resources in advance of your app being launched by the user.

## -remarks
Many categories of apps need to download significant amounts of web content upon launch. This can result in poor user experiences where users must wait for content to load before the app becomes fully functional. The ContentPrefetcher class provides mechanisms for specifying resources that Windows should attempt to download in advance of your app being launched by the user.

Heuristics are used to determine when prefetching should occur and which resources will be downloaded. These heuristics take into account system network and power conditions, user app usage history, and the results of prior prefetch attempts to provide maximum user benefit, but there is no guarantee that any particular resource will have been downloaded before a given app launch.

Resources that have been successfully prefetched will be placed in the app-specific [WinINet](/windows/desktop/WinInet/about-wininet) cache. No changes are required to existing HTTP requests for these resources once the app is running; [WinINet](/windows/desktop/WinInet/about-wininet) will simply transparently serve the content from cache if it is available. In the event that a requested resource was not prefetched, an HTTP request for content simply results in a cache miss, and the request is made to the server. Note that this caching strategy works for HTTP requests made using [WinJS.xhr](/previous-versions/windows/apps/br229787(v=win.10)), [Windows.Web.Http.HttpClient](../windows.web.http/httpclient.md), and [IXMLHTTPRequest2](/previous-versions/windows/desktop/api/msxml6/nn-msxml6-ixmlhttprequest2) interface. The .NET Framework  [HttpClient](/dotnet/api/system.net.http.httpclient?view=dotnet-uwp-10.0&preserve-view=true) is not supported.

The ContentPrefetcher class provides two mechanisms for specifying resources that should be prefetched:


+ The [ContentUris](contentprefetcher_contenturis.md) property allows direct, client-side specification of resources to prefetch. This is useful for content with URIs that are fairly static in that they don’t change between subsequent use of the application. An example would be the URIs associated with sections of an app a user is subscribed to which would only change when the user updates their subscription options with the application.
+ The [IndirectContentUri](contentprefetcher_indirectcontenturi.md) property provides for specifying the location of an XML file that lists resources to prefetch. The resources to prefetch can then be dynamically updated by modifying the contents of the XML. This is useful in cases where content is more dynamic in that the content URIs are expected to change between subsequent use of the application.

An example would be prefetching images for the latest news articles, the news articles and corresponding images change frequently and the XML file can be kept up to date with the latest URIs to prefetch. Apps may use both properties to specify resources to prefetch. Note that a maximum of 40 content URIs are supported and resources specified via the [ContentUri](contentprefetcher_contenturis.md) property will be downloaded in preference to those specified by the [IndirectContentUri](contentprefetcher_indirectcontenturi.md) XML.
You should prioritize prefetching content that a user first sees, or that a user frequently uses in order to gain the most benefit from the prefetching operation. You should indicate content that has a reasonably long lifetime for your app. Do not prefetch content that has an immediate or very short expire time, or content that would be retired from a user’s view in a short period of time. Short lived content is a poor choice for prefetched content as it is likely that the content would expire or not be show before the app is used and hence not be a benefit for users.

As mentioned above, the system determines when prefetching is performed for an app. For development purposes, however, you can initiate immediate prefetch for your app by calling the **IContentPrefetcherTaskTrigger** interface desktop API.

To aid in debugging, you can listen to ETW events on the **Microsoft-Windows-BackgroundTransfer-ContentPrefetcher** channel. Occurrences like initiation and completion of prefetching, initiation and completion of an HTTP request, and XML validation will trigger events.

## -examples

## -see-also
