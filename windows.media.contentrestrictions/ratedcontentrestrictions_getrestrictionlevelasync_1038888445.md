---
-api-id: M:Windows.Media.ContentRestrictions.RatedContentRestrictions.GetRestrictionLevelAsync(Windows.Media.ContentRestrictions.RatedContentDescription)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.ContentRestrictions.ContentAccessRestrictionLevel> GetRestrictionLevelAsync(Windows.Media.ContentRestrictions.RatedContentDescription RatedContentDescription)
-->

# Windows.Media.ContentRestrictions.RatedContentRestrictions.GetRestrictionLevelAsync

## -description
Gets the policy that applies to a piece of content, for content browsing and consumption.

## -parameters
### -param RatedContentDescription
The rated content info.

## -returns

This method returns these values:

+ **Allow**– The content can be shown in the app's catalog, and is allowed for consumption by [RequestContentAccessAsync](ratedcontentrestrictions_requestcontentaccessasync_637668410.md).
+ **Block**– The content can be shown in the app’s catalog, but it’s consumption is not allowed by [RequestContentAccessAsync](ratedcontentrestrictions_requestcontentaccessasync_637668410.md).
+ **Hide**– The content can’t be shown in the catalog, since its rating is higher than [MaxBrowsableAgeRating](contentrestrictionsbrowsepolicy_maxbrowsableagerating.md).


## -remarks

## -examples

## -see-also
