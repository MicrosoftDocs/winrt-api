---
-api-id: P:Windows.Media.ContentRestrictions.ContentRestrictionsBrowsePolicy.PreferredAgeRating
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<uint> PreferredAgeRating { get; }
-->

# Windows.Media.ContentRestrictions.ContentRestrictionsBrowsePolicy.PreferredAgeRating

## -description
Gets the maximum allowed rating level for content consumption.

## -property-value
An integer that represents the rating level.

## -remarks
Apps may choose to tailor their content catalog based on this value. For example, an app may show more movies appropriate for young children to a user whose preferred rating is 6, even though the user’s maximum allowed browse rating may be 12.

If user doesn’t have any content restrictions enforced by Family Safety the return value is NULL. The app is still expected to call [RequestContentAccessAsync](ratedcontentrestrictions_requestcontentaccessasync.md) for every piece of content a user is trying to use.

## -examples

## -see-also
