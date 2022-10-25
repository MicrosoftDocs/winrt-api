---
-api-id: E:Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher.AccountRemoved
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler AccountRemoved<Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher,  Windows.Networking.NetworkOperators.MobileBroadbandAccountEventArgs>
-->

# Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher.AccountRemoved

## -description
Occurs when a Mobile Broadband Account is removed from the client.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -remarks
The network account id of the account is available in the event handler from the [NetworkAccountId](mobilebroadbandaccounteventargs_networkaccountid.md) property.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
