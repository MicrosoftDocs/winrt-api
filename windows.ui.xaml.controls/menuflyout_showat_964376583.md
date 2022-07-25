---
-api-id: M:Windows.UI.Xaml.Controls.MenuFlyout.ShowAt(Windows.UI.Xaml.UIElement,Windows.Foundation.Point)
-api-type: winrt method
---

<!-- Method syntax
public void ShowAt(Windows.UI.Xaml.UIElement targetElement, Windows.Foundation.Point point)
-->

# Windows.UI.Xaml.Controls.MenuFlyout.ShowAt

## -description

Shows the flyout placed at the specified offset in relation to the specified target element.



## -parameters

### -param targetElement

The element to use as the flyout's placement target.

### -param point

The point at which to offset the flyout from the specified target element.

## -remarks

When you call this method to show a MenuFlyout, it automatically renders outside the application window if possible and required.

Some properties might not flow as expected, such as [FlowDirection](../windows.ui.xaml/frameworkelement_flowdirection.md). To ensure correct flow, you can set the flow direction in the [MenuFlyoutPresenter](menuflyoutpresenter.md) The MenuFlyoutPresenter must be set before the MenuFlyout is first shown.

## -examples

To position the menu relative to a UI element, specify the element and offset.

```csharp
MenuFlyout.ShowAt(element, new Point(0,0));
```

To position the menu relative to the application window, set the *targetElement* parameter to **null**.

```csharp
MenuFlyout.ShowAt(null, new Point(x, y));
```

## -see-also

[FlyoutBase.ShowAt](../windows.ui.xaml.controls.primitives/flyoutbase_showat_157739403.md)
