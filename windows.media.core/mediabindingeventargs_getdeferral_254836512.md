---
-api-id: M:Windows.Media.Core.MediaBindingEventArgs.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Deferral GetDeferral()
-->

# Windows.Media.Core.MediaBindingEventArgs.GetDeferral

## -description
Informs the system that the app might continue to perform work after the [Binding](mediabinder_binding.md) event handler returns.

## -returns
The requested deferral.

## -remarks
Since retrieving and binding the media content may take a significant amount of time, this should typically be performed asynchronously. Requesting a deferral lets the system know that your app is continuing to perform asynchronous work after the [Binding](mediabinder_binding.md) event handler has returned. Call the [Complete](../windows.foundation/deferral_complete_1807836922.md) method when your binding operation is finished.

Subscribe to the [Canceled](mediabindingeventargs_canceled.md) event to be alerted by the system if the binding operation should be canceled.

## -examples

## -see-also
