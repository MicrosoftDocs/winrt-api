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

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.TryInvokeKeyboardAccelerator](/windows/winui/api/microsoft.ui.xaml.controls.primitives.flyoutbase.tryinvokekeyboardaccelerator) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param args
The [ProcessKeyboardAcceleratorEventArgs](../windows.ui.xaml.input/processkeyboardacceleratoreventargs.md).

## -remarks
Call this method in the [OnProcessKeyboardAccelerators](flyoutbase_onprocesskeyboardaccelerators_1771064317.md) override when an accelerator is invoked and you want to influence the default accelerator handling.

## -examples

## -see-also

[ProcessKeyboardAccelerators](../windows.ui.xaml/uielement_processkeyboardaccelerators.md)
