---
-api-id: T:Windows.Web.Syndication.SyndicationText
-api-type: winrt class
---

<!-- Class syntax.
public class SyndicationText : Windows.Web.Syndication.ISyndicationNode, Windows.Web.Syndication.ISyndicationText
-->

# Windows.Web.Syndication.SyndicationText

## -description
Implements the [ISyndicationText](isyndicationtext.md) interface that encapsulates elements in *RSS 2.0* or *Atom 1.0* that can have either text, HTML, or XHTML. In *Atom 1.0*, this object maps to an **atomTextConstruct** in the schema, which can be **atom:title**, **atom:subtitle**, **atom:rights**, or **atom:summary** elements.

## -remarks
The following table maps SyndicationText properties to RSS and Atom feed elements.

| SyndicationText | RSS | Atom |
|---|---|---|
| [Text](syndicationtext_text.md) | (node value) | (node value) |
| [Type](syndicationtext_type.md) |---| type (attribute) |
| [Xml](syndicationtext_xml.md) |---| (xhtml node value) |

## -examples

## -see-also
[Quickstart: Accessing a web feed](/previous-versions/windows/apps/hh700374(v=win.10)), [Syndication sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Syndication%20sample), [AtomPub sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/AtomPub%20sample)