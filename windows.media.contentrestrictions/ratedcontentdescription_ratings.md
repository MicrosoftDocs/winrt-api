---
-api-id: P:Windows.Media.ContentRestrictions.RatedContentDescription.Ratings
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<string> Ratings { get;  set; }
-->

# Windows.Media.ContentRestrictions.RatedContentDescription.Ratings

## -description
Provides all existing third-party and Microsoft Store age ratings for a piece of content.



## -property-value
Specifies the age rating, for a piece of content.

## -remarks
If a piece of content doesn’t have neither a third-party rating nor a Store age rating, the app must pass NULL as the rating. If NULL rating is provided, the [RequestContentAccessAsync](ratedcontentrestrictions_requestcontentaccessasync_637668410.md) method will display a **Content blocked by Family Safety** dialog, with options to request a parental override.

Family Safety uses the [ContentRestrictionBrowsePolicy.GeographicRegion](contentrestrictionsbrowsepolicy_geographicregion.md) and [RatedContentDescription.Category](ratedcontentdescription_category.md) properties, to determine the appropriate rating system for a piece of content. If  contain a rating value in this rating system, then it’s used as the content rating. If  don’t contain value in this rating system, the Store age rating value is used. If it’s not available, the content is considered Not rated, for the Family Safety content settings region, and [RequestContentAccessAsync](ratedcontentrestrictions_requestcontentaccessasync_637668410.md) method will display a **Content blocked by Family Safety** dialog, with options to request a parental override. For more info, see [Using content ratings](/previous-versions/windows/apps/dn481558(v=win.10)).

## -examples

## -see-also
[Using content ratings](/previous-versions/windows/apps/dn481558(v=win.10)), [Store age ratings](/previous-versions/windows/apps/dn481556(v=win.10))
