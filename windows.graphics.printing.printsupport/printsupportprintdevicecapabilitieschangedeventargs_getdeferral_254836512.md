---
-api-id: M:Windows.Graphics.Printing.PrintSupport.PrintSupportPrintDeviceCapabilitiesChangedEventArgs.GetDeferral
-api-type: winrt method
---

# Windows.Graphics.Printing.PrintSupport.PrintSupportPrintDeviceCapabilitiesChangedEventArgs.GetDeferral

<!--
public Windows.Foundation.Deferral GetDeferral ();
-->


## -description

Requests that the print capability change operation be delayed and gets a deferral object that will be invoked upon completion of the deferred action.

## -returns

The deferral object.

## -remarks

The print capability change operation is delayed until the app calls the [Deferral.Complete](/uwp/api/windows.foundation.deferral.complete) method.

## -see-also

## -examples


