---
-api-id: M:Windows.Media.ContentRestrictions.RatedContentRestrictions.RequestContentAccessAsync(Windows.Media.ContentRestrictions.RatedContentDescription)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> RequestContentAccessAsync(Windows.Media.ContentRestrictions.RatedContentDescription RatedContentDescription)
-->

# Windows.Media.ContentRestrictions.RatedContentRestrictions.RequestContentAccessAsync

## -description
Determines whether the user is allowed to consume a piece of content.

## -parameters
### -param RatedContentDescription
The rated content info.

## -returns
Returns true, if the user can consume the content. Otherwise, returns false.

## -remarks
If the content is not allowed, this method will display a **Content blocked by Family Safety** dialog with options to request a parental override. Apps are expected to take no action if this method returns false.

## -examples

## -see-also
