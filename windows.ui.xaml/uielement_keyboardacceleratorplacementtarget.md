---
-api-id: P:Windows.UI.Xaml.UIElement.KeyboardAcceleratorPlacementTarget
-api-type: winrt property
---

<!-- Property syntax.
public DependencyObject KeyboardAcceleratorPlacementTarget { get;  set; }
-->

# Windows.UI.Xaml.UIElement.KeyboardAcceleratorPlacementTarget

## -description

Gets or sets a value that indicates the control [tooltip](../windows.ui.xaml.controls/tooltip.md) that displays the accelerator key combination.



## -property-value

The control tooltip that displays the accelerator key combination.

## -remarks

<!-- 
Use the [KeyboardAcceleratorToolTipTarget](uielement_keyboardacceleratortooltiptarget.md) property to specify the control tooltip that displays the accelerator key combination. For example, a Pivot control can display the tooltip for a PivotItem with the Pivot header.  
-->

Use the [KeyboardAcceleratorPlacementMode](uielement_keyboardacceleratorplacementmode.md) property to specify whether the control tooltip displays the key combination for its associated keyboard accelerator.

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

In some cases, you might need to present a tooltip relative to another element (typically a container object). For example, a Pivot control that displays the tooltip for a PivotItem with the Pivot header. 

Here, we show how to use the KeyboardAcceleratorPlacementTarget property to display the keyboard accelerator key combination for a Save button with the Grid container instead of the button.

```xaml
<Grid x:Name="Container">

  <Button Content="Save" Click="OnSave">
    <Button.KeyboardAccelerators>
      <KeyboardAccelerator  Key="S" Modifiers="Control" 
        KeyboardAcceleratorPlacementTarget="{x:Bind Container}"/>
    </Button.KeyboardAccelerators>
  </Button>

</Grid>
```

## -see-also

[Keyboard Accelerators](/windows/uwp/design/input/keyboard-accelerators)
