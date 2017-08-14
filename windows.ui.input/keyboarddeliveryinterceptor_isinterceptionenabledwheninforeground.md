---
-api-id: P:Windows.UI.Input.KeyboardDeliveryInterceptor.IsInterceptionEnabledWhenInForeground
-api-type: winrt property
---

<!-- Property syntax
public bool IsInterceptionEnabledWhenInForeground { get;  set; }
-->

# Windows.UI.Input.KeyboardDeliveryInterceptor.IsInterceptionEnabledWhenInForeground

## -description
Gets or sets whether the app overrides the system processing of raw keyboard input, including key combinations such as shortcut keys, access keys (or hot keys), accelerator keys, and application keys.

The raw keyboard input is intercepted, suppressed, and routed to the app (when in the foreground) for processing.

> [!NOTE]
> Secure attention sequence (SAS) key combinations, including Ctrl-Alt-Del and Windows-L, continue to be processed by the system.

## -property-value
True if the app processes raw keyboard input instead of the system. Otherwise, false.

## -remarks

## -examples

## -see-also


## -capabilities
inputForegroundObservation
