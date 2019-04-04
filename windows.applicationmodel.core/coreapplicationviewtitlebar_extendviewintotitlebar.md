---
-api-id: P:Windows.ApplicationModel.Core.CoreApplicationViewTitleBar.ExtendViewIntoTitleBar
-api-type: winrt property
---

<!-- Property syntax
public bool ExtendViewIntoTitleBar { get;  set; }
-->

# Windows.ApplicationModel.Core.CoreApplicationViewTitleBar.ExtendViewIntoTitleBar

## -description
Gets or sets a value that specifies whether this title bar should replace the default window title bar.

## -property-value
Set to **true** to replace the default window title bar; otherwise, **false**.

## -remarks
The first time the app runs, and for secondary views, the default value is **false**. For the main view of an app, this value persists between application runs.

When **ExtendViewIntoTitleBar** is true, the view's content will extend by **CoreApplicationViewTitleBar.Height** into the title bar region. The region will still be treated like a title bar, meaning you can still drag the window with it, double-click to maximize, and right-click to bring up the system menu. For this reason, you should avoid putting pointer-interactive content in the region. However, if you call Window.SetTitleBar to set a Xaml element as the title bar, the unclickable region is removed and it is no longer necessary to avoid putting pointer-interactive content in the region.

## -examples

## -see-also
