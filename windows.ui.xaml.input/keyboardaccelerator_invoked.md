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

