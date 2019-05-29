---
-api-id: T:Windows.Web.Syndication.SyndicationContent
-api-type: winrt class
---

<!-- Class syntax.
public class SyndicationContent : Windows.Web.Syndication.ISyndicationContent, Windows.Web.Syndication.ISyndicationNode, Windows.Web.Syndication.ISyndicationText
-->

# Windows.Web.Syndication.SyndicationContent

## -description
Represents feed content including Text, HTML, XHTML, URL, and XML. This object encapsulates the **atom:content** element in *Atom 1.0* and can contain a link to external content.

## -remarks
The following table maps SyndicationContent properties to RSS and Atom feed elements.

<table>
   <tr><th>SyndicationContent</th><th>RSS</th><th>Atom</th></tr>
   <tr><td>[SourceUri](syndicationcontent_sourceuri.md)</td><td /><td>src (attribute)</td></tr>
   <tr><td>[Text](syndicationcontent_text.md)</td><td>(node value)</td><td>(node value)</td></tr>
   <tr><td>[Type](syndicationcontent_type.md)</td><td /><td>type (attribute)</td></tr>
   <tr><td>[Xml](syndicationcontent_xml.md)</td><td /><td>(xhtml node value)</td></tr>
</table>

## -examples

## -see-also
[Quickstart: Accessing a web feed](https://docs.microsoft.com/previous-versions/windows/apps/hh700374(v=win.10)), [Syndication sample](https://go.microsoft.com/fwlink/p/?linkid=245062), [AtomPub sample](https://go.microsoft.com/fwlink/p/?linkid=245061)
