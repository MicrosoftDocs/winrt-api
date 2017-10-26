---
-api-id: P:Windows.Networking.NetworkOperators.UssdReply.ResultCode
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Networking.NetworkOperators.UssdResultCode ResultCode { get; }
-->

# Windows.Networking.NetworkOperators.UssdReply.ResultCode

## -description
Gets the result code for the USSD response.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.



> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/en-us/windows/uwp/packaging/app-capability-declarations). 

## -property-value
The result code for the USSD response.

## -remarks
If the [ResultCode](ussdreply_resultcode.md) property returns **ActionRequired**, the session is still open and you can respond by sending a message or closing the session.

> [!NOTE]
> The USSD protocol supports only a single USSD session at a time. An application must ensure that a session is closed when it is no longer needed. If an unused USSD session is not explicitly closed, other applications cannot use USSD until the unused USSD session times out.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
