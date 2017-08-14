---
-api-id: T:Windows.UI.Input.KeyboardDeliveryInterceptor
-api-type: winrt class
---

<!-- Class syntax.
public class KeyboardDeliveryInterceptor : Windows.UI.Input.IKeyboardDeliveryInterceptor
-->

# Windows.UI.Input.KeyboardDeliveryInterceptor

## -description
Enables an app to override the system processing of raw keyboard input, including key combinations such as shortcut keys, access keys (or hot keys), accelerator keys, and application keys.

The raw keyboard input is intercepted, suppressed, and routed to the app (when in the foreground) for processing.

> [!NOTE]
> Secure attention sequence (SAS) key combinations, including Ctrl-Alt-Del and Windows-L, continue to be processed by the system.

## -remarks
The value of the [RepeatCount](../windows.ui.core/corephysicalkeystatus.md) property returned by [KeyEventArgs.KeyStatus](../windows.ui.core/keyeventargs_keystatus.md) is always 0.

The value of the [WasKeyDown](../windows.ui.core/corephysicalkeystatus.md) property returned by [KeyEventArgs.KeyStatus](../windows.ui.core/keyeventargs_keystatus.md) is always false.

If [Handled](../windows.ui.core/keyeventargs_handled.md) is set to false, an error occurs.

## -examples

## -see-also
[Windows.UI.Input Classes](windows_ui_input_classes.md)

## -capabilities
inputForegroundObservation
