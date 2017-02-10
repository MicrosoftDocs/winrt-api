---
-api-id: T:Windows.Media.ContentRestrictions.RatedContentDescription
-api-type: winrt class
---

<!-- Class syntax.
public class RatedContentDescription : Windows.Media.ContentRestrictions.IRatedContentDescription
-->

# Windows.Media.ContentRestrictions.RatedContentDescription

## -description
Contains information about a piece of content. An app creates a **RatedContentDescription** object, for each piece of content to be used in the [GetRestrictionLevelAsync](ratedcontentrestrictions_getrestrictionlevelasync.md) and [RequestContentAccessAsync](ratedcontentrestrictions_requestcontentaccessasync.md) methods.

## -remarks
If a piece of content doesn't have a 3rd-party rating, nor a Store age rating, the app must pass NULL as the rating.

## -examples

## -see-also
