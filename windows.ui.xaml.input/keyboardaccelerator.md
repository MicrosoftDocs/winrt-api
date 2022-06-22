---
-api-id: T:Windows.UI.Xaml.Input.KeyboardAccelerator
-api-type: winrt class
---

<!-- Class syntax.
public class KeyboardAccelerator : DependencyObject, DependencyObject
-->

# Windows.UI.Xaml.Input.KeyboardAccelerator

## -description

Represents a keyboard shortcut (or accelerator) that lets a user perform an action using the keyboard instead of navigating the app UI (directly or through access keys).

Accelerators are typically assigned to buttons or menu items.



## -remarks

An accelerator key can be a single key, such as F1 - F12 and Esc, or a combination of keys (Ctrl + Shift + B, or Ctrl C) that invoke a command. They differ from access keys (mnemonics), which are typically modified with the Alt key and simply activate a command or control.

An accelerator can be executed even if the element associated with the accelerator is not visible. For example, an item in the [SecondaryCommands](../windows.ui.xaml.controls/commandbar_secondarycommands.md) collection of the [CommandBar](../windows.ui.xaml.controls/commandbar.md) can be invoked using an accelerator without expanding the overflow menu and displaying the element.

By default, an accelerator has global scope. However, you can constrain scope using [ScopeOwner](keyboardaccelerator_scopeowner.md) or disable an accelerator completely using [IsEnabled](keyboardaccelerator_isenabled.md).

## -examples

## -see-also

[Keyboard Accelerators](/windows/uwp/design/input/keyboard-accelerators)
