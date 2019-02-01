---
-api-id: T:Windows.Web.Syndication.SyndicationCategory
-api-type: winrt class
---

<!-- Class syntax.
public class SyndicationCategory : Windows.Web.Syndication.ISyndicationCategory, Windows.Web.Syndication.ISyndicationNode
-->

# Windows.Web.Syndication.SyndicationCategory

## -description
Represents the category of a feed or an item. This class encapsulates information in the **/rss/channel/item/category** element in *RSS 2.0* or the **atom:category** element in *Atom 1.0*.

## -remarks
The following table maps [SyndicationCategory](syndicationcategory.md) properties to RSS and Atom feed elements.

<table>
   <tr><th>SyndicationCategory</th><th>RSS</th><th>Atom</th></tr>
   <tr><td>[Label](syndicationcategory_label.md)</td><td /><td>label (attribute)</td></tr>
   <tr><td>[Scheme](syndicationcategory_scheme.md)</td><td>domain (attribute)</td><td>scheme (attribute)</td></tr>
   <tr><td>[Term](syndicationcategory_term.md)</td><td>(node value)</td><td>uri (attribute)</td></tr>
</table>

## -examples

## -see-also
[Quickstart: Accessing a web feed](https://msdn.microsoft.com/library/bde79bfb-f566-4dbe-b861-f849ab8bc574), [Syndication sample](https://go.microsoft.com/fwlink/p/?linkid=245062)
