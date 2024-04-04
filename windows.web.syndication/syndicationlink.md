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

| SyndicationLink | RSS | Atom |
|---|---|---|
| [Length](syndicationlink_length.md) | length (attribute) |
| [MediaType](syndicationlink_mediatype.md) | type (attribute) |
| [Relationship](syndicationlink_relationship.md) | rel (attribute) |
| [Title](syndicationlink_title.md) | title (attribute) |
| [Uri](syndicationlink_uri.md) | (node value) | href (attribute) |
| [ResourceLanguage](syndicationlink_resourcelanguage.md) | hreflang (attribute) |

## -examples

## -see-also
[Quickstart: Accessing a web feed](/previous-versions/windows/apps/hh700374(v=win.10)), [Syndication sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Syndication%20sample), [AtomPub sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/AtomPub%20sample)