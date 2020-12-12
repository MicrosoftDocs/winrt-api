---
-api-id: T:Windows.Web.Syndication.SyndicationClient
-api-type: winrt class
---

<!-- Class syntax.
public class SyndicationClient : Windows.Web.Syndication.ISyndicationClient
-->

# Windows.Web.Syndication.SyndicationClient

## -description

Implements the [ISyndicationClient](isyndicationclient.md) interface which retrieves feeds from a URI asynchronously.

## -remarks

The following code demonstrates how to retrieve a feed using [RetrieveFeedAsync](syndicationclient_retrievefeedasync_2072117461.md).

```csharp
using Windows.Foundation;
using Windows.Web.Syndication;

async Task GetFeedAsync(string feedUri)
{
    var uri = new Uri(feedUri);
    var client = new SyndicationClient(){ BypassCacheOnRetrieve = true };
    currentFeed = await client.RetrieveFeedAsync(uri);
}
```

For additional examples that demonstrate how this class is used to retrieve syndicated content from the web, see [Quickstart: Accessing a web feed](/previous-versions/windows/apps/hh700374(v=win.10)).

## -examples

## -see-also

[Quickstart: Accessing a web feed](/previous-versions/windows/apps/hh700374(v=win.10)), [Syndication sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/%5BC%23%5D-Windows%208.1%20Store%20app%20samples/Syndication%20sample/), [Syndication sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Syndication), [RssReader sample](/samples/microsoft/windows-appsample-rssreader/rssreader-sample/)
