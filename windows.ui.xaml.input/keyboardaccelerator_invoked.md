---
-api-id: E:Windows.UI.Xaml.Input.KeyboardAccelerator.Invoked
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler Invoked<KeyboardAccelerator, KeyboardAcceleratorInvokedEventArgs>
-->

# Windows.UI.Xaml.Input.KeyboardAccelerator.Invoked

## -description
Occurs when the key combination for this [KeyboardAccelerator](keyboardaccelerator.md) is pressed.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Input.KeyboardAccelerator.Invoked](/windows/winui/api/microsoft.ui.xaml.input.keyboardaccelerator.invoked) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
Handle this event to override the default [KeyboardAccelerator](keyboardaccelerator.md) behavior.

## -examples
This example shows how to override the "Select all" command (Ctrl+A keyboard accelerator) in a custom ListView control. We also set the Handled property to true to stop the event bubbling further.

```csharp
public class MyListView : ListView
{
  …
  protected override void OnKeyboardAcceleratorInvoked(KeyboardAcceleratorInvokedEventArgs args) 
  {
    if(args.KeyboardAccelerator.Key == VirtualKey.A 
      && args.KeyboardAccelerator.Modifiers == VirtualKeyModifiers.Control)
    {
      CustomSelectAll(TypeOfSelection.OnlyNumbers); 
      args.Handled = true;
    }
  }
  …
}
```

## -see-also
[KeyboardAcceleratorInvokedEventArgs](keyboardacceleratorinvokedeventargs.md), [Keyboard Accelerators](/windows/uwp/design/input/keyboard-accelerators)

