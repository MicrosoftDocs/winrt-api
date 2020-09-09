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
The following table maps SyndicationCategory properties to RSS and Atom feed elements.

<table>
   <tr><th>SyndicationCategory</th><th>RSS</th><th>Atom</th></tr>
   <tr><td>[Label](syndicationcategory_label.md)</td><td /><td>label (attribute)</td></tr>
   <tr><td>[Scheme](syndicationcategory_scheme.md)</td><td>domain (attribute)</td><td>scheme (attribute)</td></tr>
   <tr><td>[Term](syndicationcategory_term.md)</td><td>(node value)</td><td>uri (attribute)</td></tr>
</table>

## -examples

## -see-also
[Quickstart: Accessing a web feed](/previous-versions/windows/apps/hh700374(v=win.10)), [Syndication sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/%5BC%23%5D-Windows%208.1%20Store%20app%20samples/Syndication%20sample/C%23)
