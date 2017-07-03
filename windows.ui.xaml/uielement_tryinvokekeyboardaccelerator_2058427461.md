---
-api-id: M:Windows.UI.Xaml.UIElement.TryInvokeKeyboardAccelerator(Windows.UI.Xaml.Input.ProcessKeyboardAcceleratorEventArgs)
-api-type: winrt method
---

<!-- Method syntax.
public void UIElement.TryInvokeKeyboardAccelerator(ProcessKeyboardAcceleratorEventArgs args)
-->

# Windows.UI.Xaml.UIElement.TryInvokeKeyboardAccelerator

## -description
Attempts to invoke a keyboard shortcut (accelerator).

## -parameters
### -param args
The [ProcessKeyboardAcceleratorEventArgs](..\windows.ui.xaml.input\processkeyboardacceleratoreventargs.md).

## -remarks
Call this method in the [**OnProcessKeyboardAccelerators**](uielement_onprocesskeyboardaccelerators_1771064317.md) override when an accelerator is invoked and you want to influence the default accelerator handling.

## -examples

## -see-also

- [ProcessKeyboardAccelerators](uielement_processkeyboardaccelerators.md)