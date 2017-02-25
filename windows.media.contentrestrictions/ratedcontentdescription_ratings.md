---
-api-id: P:Windows.Media.ContentRestrictions.RatedContentDescription.Ratings
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<string> Ratings { get;  set; }
-->

# Windows.Media.ContentRestrictions.RatedContentDescription.Ratings

## -description
Provides all existing third-party and Windows Store age ratings for a piece of content.



## -property-value
Specifies the age rating, for a piece of content.

## -remarks
If a piece of content doesn’t have neither a third-party rating nor a Store age rating, the app must pass NULL as the rating. If NULL rating is provided, the [RequestContentAccessAsync](ratedcontentrestrictions_requestcontentaccessasync.md) method will display a **Content blocked by Family Safety** dialog, with options to request a parental override.

Family Safety uses the [ContentRestrictionBrowsePolicy.GeographicRegion](contentrestrictionsbrowsepolicy_geographicregion.md) and [RatedContentDescription.Category](ratedcontentdescription_category.md) properties, to determine the appropriate rating system for a piece of content. If  contain a rating value in this rating system, then it’s used as the content rating. If  don’t contain value in this rating system, the Store age rating value is used. If it’s not available, the content is considered Not rated, for the Family Safety content settings region, and [RequestContentAccessAsync](ratedcontentrestrictions_requestcontentaccessasync.md) method will display a **Content blocked by Family Safety** dialog, with options to request a parental override. For more info, see [Using content ratings](http://msdn.microsoft.com/library/1e647a84-21e3-47bf-b034-c280612729a7).

## -examples

## -see-also
[Using content ratings](http://msdn.microsoft.com/library/1e647a84-21e3-47bf-b034-c280612729a7), [Store age ratings](http://msdn.microsoft.com/library/4819f0ae-2090-4954-b495-2dfbf6cd2de9)