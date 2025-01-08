---
-api-id: M:Windows.Graphics.Printing.PrintSupport.PrintSupportCommunicationErrorDetectedEventArgs.GetDeferral
-api-type: winrt method
---

# Windows.Graphics.Printing.PrintSupport.PrintSupportCommunicationErrorDetectedEventArgs.GetDeferral

<!--
public Windows.Foundation.Deferral GetDeferral ();
-->


## -description

Informs the system that the resource response task might continue to perform work after the [PrintSupportExtensionSession.CommunicationErrorDetected](printsupportextensionsession_communicationerrordetected.md) handler returns.

## -returns

A [Deferral](/uwp/api/windows.foundation.deferral) object.

## -remarks

The print job operation is delayed until the app calls the [Deferral.Complete](/uwp/api/windows.foundation.deferral.complete) method.

## -see-also

## -examples


