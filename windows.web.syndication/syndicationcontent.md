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
[Quickstart: Accessing a web feed](/previous-versions/windows/apps/hh700374(v=win.10)), [Syndication sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/%5BC%23%5D-Windows%208.1%20Store%20app%20samples/Syndication%20sample/C%23), [AtomPub sample](https://go.microsoft.com/fwlink/p/?linkid=245061)
