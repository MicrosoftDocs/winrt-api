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

<table>
   <tr><th>SyndicationFeed</th><th>RSS Channel</th><th>Atom Feed</th></tr>
   <tr><td>[Authors](syndicationfeed_authors.md)</td><td>managingEditor</td><td>author</td></tr>
   <tr><td>[Categories](syndicationfeed_categories.md)</td><td>category</td><td>category</td></tr>
   <tr><td>[Contributors](syndicationfeed_contributors.md)</td><td /><td>contributor</td></tr>
   <tr><td>[Generator](syndicationfeed_generator.md)</td><td>generator</td><td>generator</td></tr>
   <tr><td>[IconUri](syndicationfeed_iconuri.md)</td><td /><td>icon</td></tr>
   <tr><td>[Id](syndicationfeed_id.md)</td><td /><td>id</td></tr>
   <tr><td>[LastUpdatedTime](syndicationfeed_lastupdatedtime.md)</td><td>lastBuildDate</td><td>updated</td></tr>
   <tr><td>[Rights](syndicationfeed_rights.md)</td><td>copyright</td><td>rights</td></tr>
   <tr><td>[Subtitle](syndicationfeed_subtitle.md)</td><td>description</td><td>subtitle</td></tr>
   <tr><td>[Title](syndicationfeed_title.md)</td><td>title</td><td>title</td></tr>
   <tr><td>[Items](syndicationfeed_items.md)</td><td>item</td><td>entry</td></tr>
   <tr><td>[Links](syndicationfeed_links.md)</td><td>link</td><td>link</td></tr>
   <tr><td>[ImageUri](syndicationfeed_imageuri.md)</td><td>image</td><td>logo</td></tr>
   <tr><td>[FirstUri](syndicationfeed_firsturi.md)</td><td /><td>link with rel="first"</td></tr>
   <tr><td>[LastUri](syndicationfeed_lasturi.md)</td><td /><td>link with rel="last"</td></tr>
   <tr><td>[NextUri](syndicationfeed_nexturi.md)</td><td /><td>link with rel="next"</td></tr>
   <tr><td>[PreviousUri](syndicationfeed_previousuri.md)</td><td /><td>link with rel="previous"</td></tr>
   <tr><td>[SourceFormat](syndicationfeed_sourceformat.md)</td><td /><td /></tr>
</table>

## -examples

## -see-also
[Quickstart: Accessing a web feed](/previous-versions/windows/apps/hh700374(v=win.10)), [Syndication sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/%5BC%23%5D-Windows%208.1%20Store%20app%20samples/Syndication%20sample/C%23), [AtomPub sample](/samples/browse/)