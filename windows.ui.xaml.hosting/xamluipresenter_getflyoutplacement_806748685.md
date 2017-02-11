---
-api-id: M:Windows.UI.Xaml.Hosting.XamlUIPresenter.GetFlyoutPlacement(Windows.Foundation.Rect,Windows.Foundation.Size,Windows.Foundation.Size,Windows.Foundation.Rect,Windows.UI.Xaml.Controls.Primitives.FlyoutPlacementMode,System.Boolean,Windows.UI.Xaml.Controls.Primitives.FlyoutPlacementMode@)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Rect GetFlyoutPlacement(Windows.Foundation.Rect placementTargetBounds, Windows.Foundation.Size controlSize, Windows.Foundation.Size minControlSize, Windows.Foundation.Rect containerRect, Windows.UI.Xaml.Controls.Primitives.FlyoutPlacementMode targetPreferredPlacement, System.Boolean allowFallbacks, Windows.UI.Xaml.Controls.Primitives.FlyoutPlacementMode chosenPlacement)
-->

# Windows.UI.Xaml.Hosting.XamlUIPresenter.GetFlyoutPlacement

## -description
Invokes the [FlyoutBase](../windows.ui.xaml.controls.primitives/flyoutbase.md) placement logic, using a suggested size of a control that will show a placement target and its flyout. Returns the bounds that are the result of running the placement logic.

## -parameters
### -param placementTargetBounds
The bounds of the placement target element, which are passed to [FlyoutBase](../windows.ui.xaml.controls.primitives/flyoutbase.md) presenter logic.

### -param controlSize
The desired size of the control that should display the flyout.

### -param minControlSize
The minimum size of the control that should display the flyout.

### -param containerRect
The bounds of the area that should hold the placement target and flyout.

### -param targetPreferredPlacement
The desired placement mode to use for [FlyoutBase](../windows.ui.xaml.controls.primitives/flyoutbase.md) placement logic.

### -param allowFallbacks
**true** if fallbacks can be used for the placement mode. **false** if fallbacks cannot be used.

### -param chosenPlacement
The actual placement mode used by the invoked [FlyoutBase](../windows.ui.xaml.controls.primitives/flyoutbase.md) placement logic.

## -returns
The bounds as calculated by [FlyoutBase](../windows.ui.xaml.controls.primitives/flyoutbase.md) placement logic.

## -remarks

## -examples

## -see-also
