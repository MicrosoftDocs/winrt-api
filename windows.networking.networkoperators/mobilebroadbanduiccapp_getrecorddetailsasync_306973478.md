---
-api-id: M:Windows.Networking.NetworkOperators.MobileBroadbandUiccApp.GetRecordDetailsAsync(Windows.Foundation.Collections.IIterable{System.UInt32})
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.NetworkOperators.MobileBroadbandUiccAppRecordDetailsResult> GetRecordDetailsAsync(Windows.Foundation.Collections.IIterable<System.UInt32> uiccFilePath)
-->

# Windows.Networking.NetworkOperators.MobileBroadbandUiccApp.GetRecordDetailsAsync

## -description
Asynchronously retrieves details about a UICC application.

## -parameters
### -param uiccFilePath
A sequence of characters specifying the UICC file path of the application. Use the [MobileBroadbandUiccApp.Id](mobilebroadbanduiccapp_id.md) property value of this instance, to get app record details for this application.

## -returns
An asynchronous retrieval operation. On successful completion, returns a [MobileBroadbandUiccAppRecordDetailsResult](mobilebroadbanduiccapprecorddetailsresult.md) instance initialized for the specified application's details.

## -remarks

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
