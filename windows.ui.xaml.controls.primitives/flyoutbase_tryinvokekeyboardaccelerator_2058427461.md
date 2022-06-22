---
-api-id: M:Windows.UI.Xaml.Controls.Primitives.FlyoutBase.TryInvokeKeyboardAccelerator(Windows.UI.Xaml.Input.ProcessKeyboardAcceleratorEventArgs)
-api-type: winrt method
---

<!-- Method syntax.
public void FlyoutBase.TryInvokeKeyboardAccelerator(ProcessKeyboardAcceleratorEventArgs args)
-->

# Windows.UI.Xaml.Controls.Primitives.FlyoutBase.TryInvokeKeyboardAccelerator

## -description
Attempts to invoke a keyboard shortcut (accelerator).



## -parameters
### -param args
The [ProcessKeyboardAcceleratorEventArgs](../windows.ui.xaml.input/processkeyboardacceleratoreventargs.md).

## -remarks
Call this method in the [OnProcessKeyboardAccelerators](flyoutbase_onprocesskeyboardaccelerators_1771064317.md) override when an accelerator is invoked and you want to influence the default accelerator handling.

## -examples

## -see-also

[ProcessKeyboardAccelerators](../windows.ui.xaml/uielement_processkeyboardaccelerators.md)
