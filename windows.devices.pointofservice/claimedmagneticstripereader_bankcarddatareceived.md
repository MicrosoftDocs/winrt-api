---
-api-id: E:Windows.Devices.PointOfService.ClaimedMagneticStripeReader.BankCardDataReceived
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler BankCardDataReceived<Windows.Devices.PointOfService.ClaimedMagneticStripeReader,  Windows.Devices.PointOfService.MagneticStripeReaderBankCardDataReceivedEventArgs>
-->

# Windows.Devices.PointOfService.ClaimedMagneticStripeReader.BankCardDataReceived

## -description
Occurs when a bank card is swiped.

## -remarks
An application can register for this event handler to get the bank card data each time a bank card is swiped through the magnetic stripe reader.

## -examples
The following example shows how to setup the magnetic stripe reader to receive data after a scanning event.



[!code-cpp[SetupMagStripeReader](../windows.devices.pointofservice/code/MagneticStripeReader/cpp/Scenario1.xaml.cpp#SnippetSetupMagStripeReader)]

[!code-csharp[SetupMagStripeReader](../windows.devices.pointofservice/code/MagneticStripeReader/cs/Scenario1.xaml.cs#SnippetSetupMagStripeReader)]



[!code-cpp[MagStripeReaderDataReceived](../windows.devices.pointofservice/code/MagneticStripeReader/cpp/Scenario1.xaml.cpp#SnippetMagStripeReaderDataReceived)]

[!code-csharp[MagStripeReaderDataReceived](../windows.devices.pointofservice/code/MagneticStripeReader/cs/Scenario1.xaml.cs#SnippetMagStripeReaderDataReceived)]

## -see-also
[Magnetic stripe reader sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/MagneticStripeReader)
