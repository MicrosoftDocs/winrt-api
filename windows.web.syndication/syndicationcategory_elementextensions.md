---
-api-id: P:Windows.Web.Syndication.SyndicationCategory.ElementExtensions
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.Web.Syndication.ISyndicationNode> ElementExtensions { get; }
-->

# Windows.Web.Syndication.SyndicationCategory.ElementExtensions

## -description
Gets the list of child elements within the element.

## -property-value
The list of child elements within the element.

## -remarks
The following elements in the RSS 2.0 documents do not have public accessors;they can be accessed by searching the ElementExtensions collection on the [SyndicationFeed](syndicationfeed.md) object: 
+ /rss/channel/docs
+ /rss/channel/cloud
+ /rss/channel/pubDate
+ /rss/channel/webmaster
+ /rss/channel/ttl
+ /rss/channel/rating
+ /rss/channel/textInput
+ /rss/channel/skipDays
+ /rss/channel/skipHours


## -examples

## -see-also
