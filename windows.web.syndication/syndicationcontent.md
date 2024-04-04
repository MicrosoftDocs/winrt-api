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

| SyndicationContent | RSS | Atom |
|---|---|---|
| [SourceUri](syndicationcontent_sourceuri.md) | src (attribute) |
| [Text](syndicationcontent_text.md) | (node value) | (node value) |
| [Type](syndicationcontent_type.md) | type (attribute) |
| [Xml](syndicationcontent_xml.md) | (xhtml node value) |

## -examples

## -see-also
[Quickstart: Accessing a web feed](/previous-versions/windows/apps/hh700374(v=win.10)), [Syndication sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Syndication%20sample), [AtomPub sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/AtomPub%20sample)