---
-api-id: M:Windows.Web.Syndication.ISyndicationClient.RetrieveFeedAsync(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Web.Syndication.SyndicationFeed, Windows.Web.Syndication.RetrievalProgress> RetrieveFeedAsync(Windows.Foundation.Uri uri)
-->

# Windows.Web.Syndication.ISyndicationClient.RetrieveFeedAsync

## -description
Initiates an asynchronous operation to download the syndication feed from the given URI. This method instantiates a [SyndicationFeed](syndicationfeed.md) object from the feed string, which can be in one of the formats specified in [SyndicationFormat](syndicationformat.md).

## -parameters
### -param uri
The URI from which the feed is downloaded.

## -returns
Contains the results of the operation.

## -remarks
You can call this method multiple times to get several feeds simultaneously.

## -examples

## -see-also
