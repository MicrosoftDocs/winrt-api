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

Provides a base class for defining the command behavior of an interactive UI element that performs an action when invoked (such as sending an email, deleting an item, or submitting a form).


## -remarks

Implements the ICommand interface ([Windows.UI.Xaml.Input.ICommand](icommand.md) for C++ or [System.Windows.Input.ICommand](/dotnet/api/system.windows.input.icommand?view=dotnet-uwp-10.0&preserve-view=true) for C#), adding various UI properties, methods, and events.

### XamlUICommand derived classes

XamlUICommand is the parent class for [StandardUICommand](standarduicommand.md), which exposes a set of standard platform commands with pre-defined properties.

For a basic commanding example see the [Button](../windows.ui.xaml.controls/button.md) control, which is designed to make something happen when a user clicks it.

There are two ways to process a Button command (controls with a Command property support similar functionality):

- Handle the Click event
- Bind the Command property to an ICommand implementation that describes the command logic

XamlUICommand lets you specify UI through the control binding, such as an icon, label, description, and keyboard shortcuts (both an access key and a keyboard accelerator), without setting the individual properties.

## -see-also

[StandardUICommand](standarduicommand.md), [Commanding in Universal Windows Platform apps using StandardUICommand, XamlUICommand, and ICommand](/windows/uwp/design/controls-and-patterns/commanding)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Command design basics](/windows/uwp/layout/commanding-basics).
>
> If you have the **WinUI 2 Gallery** app installed, click here to [open the app and see the StandardUICommand in action](winui2gallery:/item/StandardUICommand).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)
