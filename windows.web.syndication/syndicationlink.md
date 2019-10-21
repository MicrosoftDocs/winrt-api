---
-api-id: T:Windows.Web.Syndication.SyndicationLink
-api-type: winrt class
---

<!-- Class syntax.
public class SyndicationLink : Windows.Web.Syndication.ISyndicationLink, Windows.Web.Syndication.ISyndicationNode
-->

# Windows.Web.Syndication.SyndicationLink

## -description
Represents a link within a syndication feed or item. This class encapsulates information in the **/rss/channel/link** or /**rss/channel/item/link** element in *RSS 2.0* or the **atom:link** element in *Atom 1.0*.

## -remarks
The following table maps SyndicationLink properties to RSS and Atom feed elements.

<table>
   <tr><th>SyndicationLink</th><th>RSS</th><th>Atom</th></tr>
   <tr><td>[Length](syndicationlink_length.md)</td><td /><td>length (attribute)</td></tr>
   <tr><td>[MediaType](syndicationlink_mediatype.md)</td><td /><td>type (attribute)</td></tr>
   <tr><td>[Relationship](syndicationlink_relationship.md)</td><td /><td>rel (attribute)</td></tr>
   <tr><td>[Title](syndicationlink_title.md)</td><td /><td>title (attribute)</td></tr>
   <tr><td>[Uri](syndicationlink_uri.md)</td><td>(node value)</td><td>href (attribute)</td></tr>
   <tr><td>[ResourceLanguage](syndicationlink_resourcelanguage.md)</td><td /><td>hreflang (attribute)</td></tr>
</table>

## -examples

## -see-also
[Quickstart: Accessing a web feed](https://docs.microsoft.com/previous-versions/windows/apps/hh700374(v=win.10)), [Syndication sample](https://go.microsoft.com/fwlink/p/?linkid=245062), [AtomPub sample](https://go.microsoft.com/fwlink/p/?linkid=245061)
