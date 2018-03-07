---
-api-id: P:Windows.UI.Xaml.UIElement.KeyboardAcceleratorPlacementMode
-api-type: winrt property
---

<!-- Property syntax.
public KeyboardAcceleratorPlacementMode KeyboardAcceleratorPlacementMode { get;  set; }
-->

# Windows.UI.Xaml.UIElement.KeyboardAcceleratorPlacementMode

## -description
Gets or sets a value that indicates whether the control tooltip displays the key combination for it's associated keyboard accelerator.

## -xaml-syntax
```xaml
<uiElement KeyboardAcceleratorPlacementMode="keyboardAcceleratorPlacementModeMemberName"/>
```

## -property-value
A value of the enumeration. The default is **Auto**.

## -remarks
If more than one accelerator is associated with a control, the key combination for the first registered accelerator is displayed in the control tooltip.

Use the [KeyboardAcceleratorToolTipTarget](uielement_keyboardacceleratortooltiptarget.md) property to specify the control tooltip that displays the accelerator key combination. For example, a Pivot control can display the tooltip for a PivotItem with the Pivot header. 

## -examples

## -see-also
[Keyboard Accelerators](https://docs.microsoft.com/windows/uwp/design/input/keyboard-accelerators)

