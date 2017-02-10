---
-api-id: P:Windows.Media.ContentRestrictions.ContentRestrictionsBrowsePolicy.MaxBrowsableAgeRating
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<uint> MaxBrowsableAgeRating { get; }
-->

# Windows.Media.ContentRestrictions.ContentRestrictionsBrowsePolicy.MaxBrowsableAgeRating

## -description
Gets the maximum allowed age rating level to show in a content catalog. No content rated above this level should be displayed. For example, if the **MaxBrowsableAgeRating** is 13, MPAA:R rated movies should not be displayed.

## -property-value
An integer, that represents an age.

## -remarks
If user doesn’t have any content restrictions enforced by Family Safety, the return value is NULL. The app is still expected to call [RequestContentAccessAsync](ratedcontentrestrictions_requestcontentaccessasync.md) for every piece of content a user is trying to use.

## -examples

## -see-also
