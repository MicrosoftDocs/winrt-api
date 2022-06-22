---
-api-id: T:Windows.UI.Xaml.Controls.LightDismissOverlayMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.LightDismissOverlayMode : int
-->

# LightDismissOverlayMode

## -description
Defines constants that specify whether the area outside of a *light-dismiss* UI is darkened.


## -enum-fields
### -field Auto:0
The device-family the app is running on determines whether the area outside of a *light-dismiss* UI is darkened.

### -field On:1
The area outside of a *light-dismiss* UI is darkened for all device families.

### -field Off:2
The area outside of a *light-dismiss* UI is not darkened for all device families.


## -remarks
Transient UI, such as a [Flyout](flyout.md) or the open drop-down of a [ComboBox](combobox.md), closes when you click or tap outside of it. This is called light-dismiss. "Overlay" refers to the area outside of a light-dismiss UI.

By default, the "overlay" is darkened on the Xbox, and not darkened on other devices families. You can set [LightDismissOverlayMode](../windows.ui.xaml.controls.primitives/flyoutbase_lightdismissoverlaymode.md) to **On** to make your app darken the "overlay" area on all device families, or set it to **Off** to not darken the "overlay" area on all device families.

## -examples

## -see-also
