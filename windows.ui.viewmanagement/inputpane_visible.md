---
-api-id: P:Windows.UI.ViewManagement.InputPane.Visible
-api-type: winrt property
---

<!-- Property syntax
public bool Visible { get;  set; }
-->

# Windows.UI.ViewManagement.InputPane.Visible

## -description
Gets or sets a value that indicates whether the input pane is shown.

> [!IMPORTANT]
> Valid for Xbox device family only.

For universal apps, the [OccludedRect](inputpane_occludedrect.md) property indicates the region of the app window obstructed by the input pane.

## -property-value
**true** if the input pane is shown; otherwise, **false**.

## -remarks
> In some cases, overlay UI such as an [InputPane](inputpane.md) is not fully supported. This includes:+ [ apps](https://msdn.microsoft.com/en-us/windows/uwp/gaming/index) in full-screen mode.
+ Windows Holographic apps in [holographic view](https://developer.microsoft.com/en-us/windows/holographic/app_model#app_views).


## -examples

## -see-also
[OccludedRect](inputpane_occludedrect.md)