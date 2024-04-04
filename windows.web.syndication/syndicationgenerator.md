---
-api-id: T:Windows.Web.Syndication.SyndicationGenerator
-api-type: winrt class
---

<!-- Class syntax.
public class SyndicationGenerator : Windows.Web.Syndication.ISyndicationGenerator, Windows.Web.Syndication.ISyndicationNode
-->

# Windows.Web.Syndication.SyndicationGenerator

## -description
Describes the agent or the tool used to generate the feed. This class encapsulates information in the **/rss/channel/generator** element in *RSS 2.0* or the **/atom:feed/atom:generator** element in *Atom 1.0*.

## -remarks
The following table maps SyndicationGenerator properties to RSS and Atom feed elements.

| SyndicationGenerator | RSS | Atom |
|---|---|---|
| [Text](syndicationgenerator_text.md) | (node value) | (node value) |
| [Uri](syndicationgenerator_uri.md) | uri (attribute) |
| [Version](syndicationgenerator_version.md) | version (attribute) |

## -examples

## -see-also
[Quickstart: Accessing a web feed](/previous-versions/windows/apps/hh700374(v=win.10)), [Syndication sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Syndication%20sample)
