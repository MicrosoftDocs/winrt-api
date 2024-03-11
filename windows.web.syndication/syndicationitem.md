---
-api-id: T:Windows.Web.Syndication.SyndicationItem
-api-type: winrt class
---

<!-- Class syntax.
public class SyndicationItem : Windows.Web.Syndication.ISyndicationItem, Windows.Web.Syndication.ISyndicationNode
-->

# Windows.Web.Syndication.SyndicationItem

## -description

Represents an item in the feed. This class encapsulates information in the **/rss/channel/item** element in *RSS 2.0* or the **atom:entry** element in *Atom 1.0*.

## -remarks

The following code demonstrates how to access the property values of a SyndicationItem object.

```csharp

using Windows.Foundation;
using Windows.Web.Syndication;

private void DisplayCurrentItem()
{
    SyndicationItem item = currentFeed.Items[currentItemIndex];

    // Title
    FeedItemTitle.Text = item.Title != null ? item.Title.Text : "(no title)";

    // Display the main link
    string link = string.Empty;
    if (item.Links.Count > 0)
    {
    link = item.Links[0].Uri.AbsoluteUri;
    }
    FeedLink.Content = link;

    // Display the body as HTML
    string content = "(no content)";
    if (item.Content != null)
    {
        content = item.Content.Text;
    }
    else if (item.Summary != null)
    {
        content = item.Summary.Text;
    }
    FeedWebView.NavigateToString(content);
}
```

For additional examples that demonstrate how this class is used to represent feed content, see [Quickstart: Accessing a web feed](/previous-versions/windows/apps/hh700374(v=win.10)).

The following table maps SyndicationItem properties to RSS and Atom feed elements.

| SyndicationItem | RSS Channel/Item | Atom entry | [AtomPub](../windows.web.atompub/windows_web_atompub.md) |
|---|---|---|---|
| [AttributeExtensions](syndicationitem_attributeextensions.md) (foreign markup) |---|---|---|
| [Authors](syndicationitem_authors.md) | author | authors |---|
| [BaseUri](syndicationitem_baseuri.md) |---|---|---|
| [Categories](syndicationitem_categories.md) | category | category |---|
| [CommentsUri](syndicationitem_commentsuri.md) | comments |---|---|
| [Content](syndicationitem_content.md) |---| content |---|
| [Contributors](syndicationitem_contributors.md) |---| contributor |---|
| [EditMediaUri](syndicationitem_editmediauri.md) |---| link with rel="edit-media" |---|
| [EditUri](syndicationitem_edituri.md) |---| link with rel="edit" |---|
| [ElementExtensions](syndicationitem_elementextensions.md) (foreign markup) |---|---|---|
| **Etag** |---|---| ETag header after [CreateResourceAsync](../windows.web.atompub/atompubclient_createresourceasync_823380555.md) |
| [Id](syndicationitem_id.md) | guid | id | Location header after [CreateResourceAsync](../windows.web.atompub/atompubclient_createresourceasync_823380555.md) |
| [ItemUri](syndicationitem_itemuri.md) |---|---|---|
| [Language](syndicationitem_language.md) | xml:lang | xml:lang |---|
| [LastUpdatedTime](syndicationitem_lastupdatedtime.md) |---| updated |---|
| [Links](syndicationitem_links.md) | link/enclosure | link |---|
| [NodeName](syndicationitem_nodename.md) |---|---|---|
| [NodeNamespace](syndicationitem_nodenamespace.md) |---|---|---|
| [NodeValue](syndicationitem_nodevalue.md) |---|---|---|
| [PublishedDate](syndicationitem_publisheddate.md) | pubDate | published |---|
| [Rights](syndicationitem_rights.md) |---| rights |---|
| [Source](syndicationitem_source.md) | source | source |---|
| [Summary](syndicationitem_summary.md) | description | summary |---|
| [Title](syndicationitem_title.md) | title | title |---|

## -examples

## -see-also

[Quickstart: Accessing a web feed](/previous-versions/windows/apps/hh700374(v=win.10)), [Syndication sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Syndication%20sample), [AtomPub sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/AtomPub%20sample), [Syndication sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Syndication)