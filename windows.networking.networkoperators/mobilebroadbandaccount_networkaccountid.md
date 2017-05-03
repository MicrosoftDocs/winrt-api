---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandAccount.NetworkAccountId
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string NetworkAccountId { get; }
-->

# Windows.Networking.NetworkOperators.MobileBroadbandAccount.NetworkAccountId

## -description
Gets a unique identifier for the mobile broadband account.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -property-value
A unique identifier for the mobile broadband account.

## -remarks
The network account identifier is supplied by the mobile broadband provider when an account is activated and is stored locally in metadata that describes account information for the mobile broadband device.

The network account identifier for a mobile broadband account matches the value passed to the [CreateFromNetworkAccountId](ussdsession_createfromnetworkaccountid.md) method.

## -examples

## -see-also
