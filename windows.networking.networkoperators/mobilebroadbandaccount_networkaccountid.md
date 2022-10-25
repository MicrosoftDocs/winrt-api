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
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -property-value
A unique identifier for the mobile broadband account.

## -remarks
The network account identifier is supplied by the mobile broadband provider when an account is activated and is stored locally in metadata that describes account information for the mobile broadband device.

The network account identifier for a mobile broadband account matches the value passed to the [CreateFromNetworkAccountId](ussdsession_createfromnetworkaccountid_2015090244.md) method.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
