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
The following code demonstrates how to access the property values of a [SyndicationItem](syndicationitem.md) object.



```javascript

function displayCurrentItem() {
    var item = currentFeed.items[currentItemIndex];

    // Title.
    var title = item.title || "(no title)";
    document.getElementById("feedItemTitle").innerText = title;

    // Display the main link.
    var link = "";
    if (item.links.size > 0) {
        link = item.links[0].uri.absoluteUri;
    }

    var feedLink = document.getElementById("feedLink");
    feedLink.innerText = link;
    feedLink.href = link;

    // Display the body as HTML.
    var content = item.content || item.summary || "(no content)";
    document.getElementById("feedWebView").innerHTML = content;
}
```

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

For additional examples that demonstrate how this class is used to represent feed content, see [Quickstart: Accessing a web feed](http://msdn.microsoft.com/library/bde79bfb-f566-4dbe-b861-f849ab8bc574).

The following table maps [SyndicationItem](syndicationitem.md) properties to RSS and Atom feed elements.

<table>
   <tr><th>SyndicationItem</th><th>RSS Channel/Item</th><th>Atom entry</th><th>[AtomPub](../windows.web.atompub/windows_web_atompub.md)</th></tr>
   <tr><td>[AttributeExtensions](syndicationitem_attributeextensions.md) (foreign markup)</td><td /><td /><td /></tr>
   <tr><td>[Authors](syndicationitem_authors.md)</td><td>author</td><td>authors</td><td /></tr>
   <tr><td>[BaseUri](syndicationitem_baseuri.md)</td><td /><td /><td /></tr>
   <tr><td>[Categories](syndicationitem_categories.md)</td><td>category</td><td>category</td><td /></tr>
   <tr><td>[CommentsUri](syndicationitem_commentsuri.md)</td><td>comments</td><td /><td /></tr>
   <tr><td>[Content](syndicationitem_content.md)</td><td /><td>content</td><td /></tr>
   <tr><td>[Contributors](syndicationitem_contributors.md)</td><td /><td>contributor</td><td /></tr>
   <tr><td>[EditMediaUri](syndicationitem_editmediauri.md)</td><td /><td>link with rel="edit-media"</td><td /></tr>
   <tr><td>[EditUri](syndicationitem_edituri.md)</td><td /><td>link with rel="edit"</td><td /></tr>
   <tr><td>[ElementExtensions](syndicationitem_elementextensions.md) (foreign markup)</td><td /><td /><td /></tr>
   <tr><td>**Etag**</td><td /><td /><td>ETag header after [CreateResourceAsync](../windows.web.atompub/atompubclient_createresourceasync.md)</td></tr>
   <tr><td>[Id](syndicationitem_id.md)</td><td>guid</td><td>id</td><td>Location header after [CreateResourceAsync](../windows.web.atompub/atompubclient_createresourceasync.md)</td></tr>
   <tr><td>[ItemUri](syndicationitem_itemuri.md)</td><td /><td /><td /></tr>
   <tr><td>[Language](syndicationitem_language.md)</td><td>xml:lang</td><td>xml:lang</td><td /></tr>
   <tr><td>[LastUpdatedTime](syndicationitem_lastupdatedtime.md)</td><td /><td>updated</td><td /></tr>
   <tr><td>[Links](syndicationitem_links.md)</td><td>link/enclosure</td><td>link</td><td /></tr>
   <tr><td>[NodeName](syndicationitem_nodename.md)</td><td /><td /><td /></tr>
   <tr><td>[NodeNamespace](syndicationitem_nodenamespace.md)</td><td /><td /><td /></tr>
   <tr><td>[NodeValue](syndicationitem_nodevalue.md)</td><td /><td /><td /></tr>
   <tr><td>[PublishedDate](syndicationitem_publisheddate.md)</td><td>pubDate</td><td>published</td><td /></tr>
   <tr><td>[Rights](syndicationitem_rights.md)</td><td /><td>rights</td><td /></tr>
   <tr><td>[Source](syndicationitem_source.md)</td><td>source</td><td>source</td><td /></tr>
   <tr><td>[Summary](syndicationitem_summary.md)</td><td>description</td><td>summary</td><td /></tr>
   <tr><td>[Title](syndicationitem_title.md)</td><td>title</td><td>title</td><td /></tr>
</table>

## -examples

## -see-also
[Quickstart: Accessing a web feed](http://msdn.microsoft.com/library/bde79bfb-f566-4dbe-b861-f849ab8bc574), [Syndication sample](http://go.microsoft.com/fwlink/p/?linkid=245062), [AtomPub sample](http://go.microsoft.com/fwlink/p/?linkid=245061), [Syndication sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620610)