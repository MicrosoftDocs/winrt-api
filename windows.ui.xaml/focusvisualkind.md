---
-api-id: T:Windows.UI.Xaml.FocusVisualKind
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.FocusVisualKind : int
-->

# FocusVisualKind

## -description

Specifies the visual feedback used to indicate the UI element with focus when navigating with a keyboard or gamepad.



## -enum-fields

### -field DottedLine:0

A dotted line rectangle. Also known as "marching ants". 

The default on Windows 10 November Update (Windows 10 version 1511 - build number 10.0.10586, codenamed "Threshold 2") and earlier.

### -field HighVisibility:1

A solid line rectangle composed of an inner and outer rectangle of contrasting colors.

The default on Windows 10 Anniversary Update (Windows 10 version 1607 - build number 10.0.14393, codenamed "Redstone 1") and earlier. 

DottedLine visual is difficult to see in 10-foot experience.

### -field Reveal:2

A solid line rectangle, surrounded by a glowing light effect to simulate depth. 

Opt-in feature for Xbox with Windows 10 version 1803 (codenamed "Redstone 4") and later.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | Reveal |

## -examples

## -see-also

[FocusVisualKind](/uwp/api/windows.ui.xaml.application.FocusVisualKind)
