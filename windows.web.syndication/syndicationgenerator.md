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

<table>
   <tr><th>SyndicationGenerator</th><th>RSS</th><th>Atom</th></tr>
   <tr><td>[Text](syndicationgenerator_text.md)</td><td>(node value)</td><td>(node value)</td></tr>
   <tr><td>[Uri](syndicationgenerator_uri.md)</td><td /><td>uri (attribute)</td></tr>
   <tr><td>[Version](syndicationgenerator_version.md)</td><td /><td>version (attribute)</td></tr>
</table>

## -examples

## -see-also
[Quickstart: Accessing a web feed](/previous-versions/windows/apps/hh700374(v=win.10)), [Syndication sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/%5BC%23%5D-Windows%208.1%20Store%20app%20samples/Syndication%20sample/C%23)
