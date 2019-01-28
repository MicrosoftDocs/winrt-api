---
-api-id: T:Windows.UI.Xaml.Input.XamlUICommand
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class XamlUICommand : DependencyObject, DependencyObject, ICommand
-->

# Windows.UI.Xaml.Input.XamlUICommand

## -description

Implements the [ICommand](icommand.md) interface, adding various UI properties, methods, and events to provide a base class for defining the command behavior of an interactive UI element that performs an action when invoked (such as sending an email, deleting an item, or submitting a form).

## -remarks

### XamlUICommand derived classes

XamlUICommand is the parent class for [StandardUICommand](standarduicommand.md), which exposes a set of standard platform commands with pre-defined properties.

For a basic commanding example see the [Button](../windows.ui.xaml.controls/button.md) control, which is designed to make something happen when a user clicks it.

There are two ways to process a Button command (controls with a Command property support similar functionality):

- Handle the Click event
- Bind the Command property to an ICommand implementation that describes the command logic

XamlUICommand lets you specify UI through the control binding, such as an icon, label, description, and keyboard shortcuts (both an access key and a keyboard accelerator), without setting the individual properties.

## -see-also

[StandardUICommand](standarduicommand.md)

## -examples
