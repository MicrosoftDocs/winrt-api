---
-api-id: P:Windows.UI.Xaml.Controls.Primitives.FlyoutBase.LightDismissOverlayMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.LightDismissOverlayMode LightDismissOverlayMode { get;  set; }
-->

# Windows.UI.Xaml.Controls.Primitives.FlyoutBase.LightDismissOverlayMode

## -description
Gets or sets a value that specifies whether the area outside of a *light-dismiss* UI is darkened.



## -property-value
A value of the enumeration that specifies whether the area outside of a light-dismiss UI is darkened. The default is `Auto`.

## -remarks
Transient UI, such as a [Flyout](../windows.ui.xaml.controls/flyout.md) or [MenuFlyout](../windows.ui.xaml.controls/menuflyout.md), closes when you click or tap outside of it. This is called light-dismiss. "Overlay" refers to the area outside of a light-dismiss UI.

By default, the "overlay" is darkened on the Xbox, and not darkened on other devices families. You can set LightDismissOverlayMode to `On` to make your app darken the "overlay" area on all device families, or set it to `Off` to not darken the "overlay" area on all device families.

For more info, see [Light dismiss behavior](/windows/uwp/design/controls-and-patterns/dialogs-and-flyouts/flyouts#light-dismiss-behavior) in the Flyouts article.

## -examples

## -see-also

[Flyouts](/windows/uwp/design/controls-and-patterns/dialogs-and-flyouts/flyouts), [OverlayInputPassThroughElement](flyoutbase_overlayinputpassthroughelement.md)
