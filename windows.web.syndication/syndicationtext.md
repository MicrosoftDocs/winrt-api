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

<table>
   <tr><th>SyndicationText</th><th>RSS</th><th>Atom</th></tr>
   <tr><td>[Text](syndicationtext_text.md)</td><td>(node value)</td><td>(node value)</td></tr>
   <tr><td>[Type](syndicationtext_type.md)</td><td /><td>type (attribute)</td></tr>
   <tr><td>[Xml](syndicationtext_xml.md)</td><td /><td>(xhtml node value)</td></tr>
</table>

## -examples

## -see-also
[Quickstart: Accessing a web feed](https://docs.microsoft.com/previous-versions/windows/apps/hh700374(v=win.10)), [Syndication sample](https://go.microsoft.com/fwlink/p/?linkid=245062), [AtomPub sample](https://go.microsoft.com/fwlink/p/?linkid=245061)
