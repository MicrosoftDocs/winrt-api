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

```javascript
function GetFeed(feedUri) {
     var uri = new Windows.Foundation.Uri(feedUri);
     var client = new Windows.Web.Syndication.SyndicationClient();
     client.bypassCacheOnRetrieve = true;
     client.retrieveFeedAsync(uri).then(function (feed) {
            currentFeed = feed;
     }
}
```

```csharp

using Windows.Foundation;
using Windows.Web.Syndication;

async Task GetFeedAsync(string feedUri){
      var uri = new Uri(feedUri);
      var client = new SyndicationClient() {
          BypassCacheOnRetrieve = true
      };
      currentFeed = await client.RetrieveFeedAsync(uri);
}

```

For additional examples that demonstrate how this class is used to retrieve syndicated content from the web, see [Quickstart: Accessing a web feed](http://msdn.microsoft.com/library/bde79bfb-f566-4dbe-b861-f849ab8bc574).

## -examples

## -see-also

[Quickstart: Accessing a web feed](http://msdn.microsoft.com/library/bde79bfb-f566-4dbe-b861-f849ab8bc574), [Syndication sample](http://go.microsoft.com/fwlink/p/?linkid=245062), [Syndication sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620610), [RSS reader end-to-end (JavaScript) sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620542)
