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
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -property-value
The result code for the USSD response.

## -remarks
If the [ResultCode](ussdreply_resultcode.md) property returns **ActionRequired**, the session is still open and you can respond by sending a message or closing the session.

> [!NOTE]
> The USSD protocol supports only a single USSD session at a time. An application must ensure that a session is closed when it is no longer needed. If an unused USSD session is not explicitly closed, other applications cannot use USSD until the unused USSD session times out.

## -examples

## -see-also
