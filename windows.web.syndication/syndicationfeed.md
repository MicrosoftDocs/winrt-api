---
-api-id: T:Windows.Web.Syndication.SyndicationFeed
-api-type: winrt class
---

<!-- Class syntax.
public class SyndicationFeed : Windows.Web.Syndication.ISyndicationFeed, Windows.Web.Syndication.ISyndicationNode
-->

# Windows.Web.Syndication.SyndicationFeed

## -description
Contains information about a feed. This class encapsulates the information in the **/rss/channel** element in *RSS 2.0* or the **atom:feed** element in *Atom 1.0*.

## -remarks
The following table maps SyndicationFeed properties to RSS and Atom feed elements.

| SyndicationFeed | RSS Channel | Atom Feed |
|---|---|---|
| [Authors](syndicationfeed_authors.md) | managingEditor | author |
| [Categories](syndicationfeed_categories.md) | category | category |
| [Contributors](syndicationfeed_contributors.md) | contributor |
| [Generator](syndicationfeed_generator.md) | generator | generator |
| [IconUri](syndicationfeed_iconuri.md) | icon |
| [Id](syndicationfeed_id.md) | id |
| [LastUpdatedTime](syndicationfeed_lastupdatedtime.md) | lastBuildDate | updated |
| [Rights](syndicationfeed_rights.md) | copyright | rights |
| [Subtitle](syndicationfeed_subtitle.md) | description | subtitle |
| [Title](syndicationfeed_title.md) | title | title |
| [Items](syndicationfeed_items.md) | item | entry |
| [Links](syndicationfeed_links.md) | link | link |
| [ImageUri](syndicationfeed_imageuri.md) | image | logo |
| [FirstUri](syndicationfeed_firsturi.md) | link with rel="first" |
| [LastUri](syndicationfeed_lasturi.md) | link with rel="last" |
| [NextUri](syndicationfeed_nexturi.md) | link with rel="next" |
| [PreviousUri](syndicationfeed_previousuri.md) | link with rel="previous" |
| [SourceFormat](syndicationfeed_sourceformat.md) |


## -examples

## -see-also
[Quickstart: Accessing a web feed](/previous-versions/windows/apps/hh700374(v=win.10)), [Syndication sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/%5BC%23%5D-Windows%208.1%20Store%20app%20samples/Syndication%20sample), [AtomPub sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/AtomPub%20sample)
