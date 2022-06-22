---
-api-id: T:Windows.UI.Xaml.ElementSoundMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.ElementSoundMode : int
-->

# ElementSoundMode

## -description
Defines constants that specify a control's preference for whether sounds are played.



## -enum-fields
### -field Default:0
Sound is played based on the [ElementSoundPlayer.State](elementsoundplayer_state.md) setting.

### -field FocusOnly:1
Sound is played only when focus on the control changes.

### -field Off:2
No sounds are played.


## -remarks
This enumeration is used by the **ElementSoundMode** property on [Control](../windows.ui.xaml.controls/control_elementsoundmode.md), [FlyoutBase](../windows.ui.xaml.controls.primitives/flyoutbase_elementsoundmode.md), and [Hyperlink](../windows.ui.xaml.documents/hyperlink_elementsoundmode.md).

For more info, see [Sound in UWP apps](/windows/uwp/style/sound).

## -examples

## -see-also
[Sound in UWP apps](/windows/uwp/style/sound), [ElementSoundPlayer.State](elementsoundplayer_state.md), [ElementSoundPlayer](elementsoundplayer.md), [Control.ElementSoundMode](../windows.ui.xaml.controls/control_elementsoundmode.md), [FlyoutBase.ElementSoundMode](../windows.ui.xaml.controls.primitives/flyoutbase_elementsoundmode.md), [Hyperlink.ElementSoundMode](../windows.ui.xaml.documents/hyperlink_elementsoundmode.md)
