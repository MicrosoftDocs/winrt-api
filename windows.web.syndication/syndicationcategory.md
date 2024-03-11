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

| SyndicationCategory | RSS | Atom |
|---|---|---|
| [Label](syndicationcategory_label.md) | label (attribute) |
| [Scheme](syndicationcategory_scheme.md) | domain (attribute) | scheme (attribute) |
| [Term](syndicationcategory_term.md) | (node value) | uri (attribute) |

## -examples

## -see-also
[Quickstart: Accessing a web feed](/previous-versions/windows/apps/hh700374(v=win.10)), [Syndication sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Syndication%20sample)
