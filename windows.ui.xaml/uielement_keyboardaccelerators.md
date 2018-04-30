---
-api-id: P:Windows.UI.Xaml.UIElement.KeyboardAccelerators
-api-type: winrt property
---

<!-- Property syntax.
public IVector<KeyboardAccelerator> KeyboardAccelerators { get; }
-->

# Windows.UI.Xaml.UIElement.KeyboardAccelerators

## -description
Gets the the collection of key combinations that invoke an action using the keyboard. 

Accelerators are typically assigned to buttons or menu items.

![Example of a menu showing keyboard accelerators for various menu items](images/keyboard-accelerators.png)

*Example of a menu showing keyboard accelerators for various menu items*

## -property-value
The collection of [**KeyboardAccelerator**](https://docs.microsoft.com/uwp/api/windows.ui.xaml.input.keyboardaccelerator) objects. 

## -remarks
Windows 10, version 1703, introduced keyboard accelerator shortcuts. However, these shortcuts were not displayed with the UI of their corresponding controls.

Starting with Windows 10, version 1803, when KeyboardAccelerators are declared, controls present the corresponding key combinations by default (unless they are associated with [MenuFlyoutItem](https://docs.microsoft.com/uwp/api/Windows.UI.Xaml.Controls.MenuFlyoutItem) and [ToggleMenuFlyoutItem](https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.togglemenuflyoutitem) objects).

You can override the the default key combination string associated with a [keyboard accelerator](uielement_keyboardaccelerators.md) using the text override properties [MenuFlyoutItem.KeyboardAcceleratorTextOverride](../windows.ui.xaml.controls/menuflyoutitem_keyboardacceleratortextoverride.md), [AppBarButton.KeyboardAcceleratorTextOverride](../windows.ui.xaml.controls/appbarbutton_keyboardacceleratortextoverride.md), and [AppBarToggleButton.KeyboardAcceleratorTextOverride](../windows.ui.xaml.controls/appbartogglebutton_keyboardacceleratortextoverride.md).

An accelerator key can be a single key, such as F1 - F12 and Esc, or a combination of keys (Ctrl + Shift + B, or Ctrl C) that invoke a command. They differ from access keys (mnemonics), which are typically modified with the Alt key and simply activate a command or control.

An accelerator can be executed even if the element associated with the accelerator is not visible. For example, an item in the [**SecondaryCommands**](https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.commandbar.SecondaryCommands) collection of the [**CommandBar**](https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.commandbar) can be invoked using an accelerator without expanding the overflow menu and displaying the element.

By default, an accelerator has global scope. However, you can constrain scope using [ScopeOwner](keyboardaccelerator_scopeowner.md) or disable an accelerator completely using [IsEnabled](keyboardaccelerator_isenabled.md).

## -examples

## -see-also
[Keyboard Accelerators](https://docs.microsoft.com/windows/uwp/design/input/keyboard-accelerators)


