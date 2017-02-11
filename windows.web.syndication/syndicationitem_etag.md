---
-api-id: P:Windows.Web.Syndication.SyndicationItem.ETag
-api-type: winrt property
---

<!-- Property syntax
public string ETag { get; }
-->

# Windows.Web.Syndication.SyndicationItem.ETag

## -description
Gets an ETag HTTP header.

## -property-value
An Etag HTTP header.

## -remarks
When an **AtomPub** endpoint returns a syndication entry, it may include an ETag HTTP header, which will be tied to the [SyndicationItem](syndicationitem.md) object and show up in this property. **AtomPubClient** will also use ETag when updating or deleting a resource for synchronization control.

## -examples

## -see-also
