---
-api-id: P:Windows.UI.Xaml.Input.KeyboardAccelerator.ScopeOwner
-api-type: winrt property
---

<!-- Property syntax.
public DependencyObject ScopeOwner { get;  set; }
-->

# Windows.UI.Xaml.Input.KeyboardAccelerator.ScopeOwner

## -description
Gets or sets the scope (or target) of the keyboard accelerator. 



## -property-value
The default is null (global scope).

## -remarks
By default, an accelerator has global scope. However, you can constrain scope using ScopeOwner or disable an accelerator completely using [IsEnabled](keyboardaccelerator_isenabled.md).

## -see-also
[Keyboard Accelerators](/windows/uwp/design/input/keyboard-accelerators)

## -examples

This example demonstrates how to create a scoped accelerator. The Ctrl+Menu+S accelerator is invoked only if the focus is on a child of `MainGrid`.

```xaml
<Grid x:Name="MainGrid">
    …
    <Button Content="Save" Click="OnSave">
        <Button.KeyboardAccelerators>
            <KeyboardAccelerator 
                Key="S"
                Modifiers="Control, Menu"
                ScopeOwner="{x:Bind MainGrid}" />
        </Button.KeyboardAccelerators>
    </Button>
    …
</Grid>
<Grid x:Name="SecondaryGrid">
    …
    <Button Content="Edit" Click="OnEdit" />
    …
</Grid>
```
