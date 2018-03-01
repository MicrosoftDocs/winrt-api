---
-api-id: P:Windows.UI.Xaml.UIElement.KeyboardAcceleratorPlacementTarget
-api-type: winrt property
---

<!-- Property syntax.
public DependencyObject KeyboardAcceleratorPlacementTarget { get;  set; }
-->

# Windows.UI.Xaml.UIElement.KeyboardAcceleratorPlacementTarget

## -description
Gets or sets a value that indicates the control tooltip that displays the accelerator key combination.

## -property-value
The control tooltip that displays the accelerator key combination.

## -remarks
Use the [KeyboardAcceleratorToolTipTarget](uielement_keyboardacceleratortooltiptarget.md) property to specify the control tooltip that displays the accelerator key combination. For example, a Pivot control can display the tooltip for a PivotItem with the Pivot header. 

Use the [KeyboardAcceleratorPlacementMode](uielement_keyboardacceleratorplacementmode.md) property to specify whether the control tooltip displays the key combination for it's associated keyboard accelerator.

## -examples 

```xaml
<Grid x:Name="Container">
    <Button Content="Click" 
        ToolTipService.ToolTip="Tooltip"
        ToolTipService.PlacementTarget="{x:Bind Container}" 
        KeyboardAcceleratorPlacementTarget="{x:Bind Container}">
        <Button.KeyboardAccelerators>
            <KeyboardAccelerator Key="S" Modifiers="Control"/>
        </Button.KeyboardAccelerators>
    </Button>
</Grid>
```

## -see-also
[Keyboard Accelerators](https://docs.microsoft.com/windows/uwp/design/input/keyboard-accelerators)

