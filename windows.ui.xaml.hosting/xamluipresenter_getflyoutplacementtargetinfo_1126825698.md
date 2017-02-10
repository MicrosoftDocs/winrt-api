---
-api-id: M:Windows.UI.Xaml.Hosting.XamlUIPresenter.GetFlyoutPlacementTargetInfo(Windows.UI.Xaml.FrameworkElement,Windows.UI.Xaml.Controls.Primitives.FlyoutPlacementMode,Windows.UI.Xaml.Controls.Primitives.FlyoutPlacementMode@,System.Boolean@)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Rect GetFlyoutPlacementTargetInfo(Windows.UI.Xaml.FrameworkElement placementTarget, Windows.UI.Xaml.Controls.Primitives.FlyoutPlacementMode preferredPlacement, Windows.UI.Xaml.Controls.Primitives.FlyoutPlacementMode targetPreferredPlacement, System.Boolean allowFallbacks)
-->

# Windows.UI.Xaml.Hosting.XamlUIPresenter.GetFlyoutPlacementTargetInfo

## -description
Returns calculated bounds of a placement target that is intended to also display a flyout in the host. Additional **out** parameters provide more info on how the bounds were calculated.

## -parameters
### -param placementTarget
The placement target element that the [Flyout](../windows.ui.xaml.controls/flyout.md) should be positioned in relation to.

### -param preferredPlacement
A value of the enumeration that declares the host's preferred placement of the [Flyout](../windows.ui.xaml.controls/flyout.md) relative to the target. 
<!--The default is ?-->

### -param targetPreferredPlacement
A value of the enumeration that declares preferred placement of the [Flyout](../windows.ui.xaml.controls/flyout.md).

### -param allowFallbacks
**true** if fallback placements are permitted for the [Flyout](../windows.ui.xaml.controls/flyout.md) placement logic. **false** if only the *targetPreferredPlacement* value should be considered.

## -returns
The calculated placement target bounds.

## -remarks

## -examples

## -see-also
