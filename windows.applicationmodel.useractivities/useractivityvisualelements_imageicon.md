---
-api-id: P:Windows.ApplicationModel.UserActivities.UserActivityVisualElements.ImageIcon
-api-type: winrt property
---

<!-- Property syntax.
public Uri ImageIcon { get;  set; }
-->

# Windows.ApplicationModel.UserActivities.UserActivityVisualElements.ImageIcon

## -description

Gets and sets the Uniform Resource Identifier (URI) of the icon image for the details tile for this **UserActivity**.

## -property-value

The URI of the icon image.

## -remarks

The URI should refer to a remote source for the icon image

## -see-also

## -examples
```cs
userActivity.VisualElements.ImageIcon = new Uri("https://unsplash.it/360/202?image=883"); // must be a remote source
```
