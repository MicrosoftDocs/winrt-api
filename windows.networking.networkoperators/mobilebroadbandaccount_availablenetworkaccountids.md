---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandAccount.AvailableNetworkAccountIds
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<string> AvailableNetworkAccountIds { get; }
-->

# Windows.Networking.NetworkOperators.MobileBroadbandAccount.AvailableNetworkAccountIds

## -description
A list of all network account IDs for the network service provider.

> [!NOTE]
> This functionality is available only to mobile operator apps, and apps given privileged access by mobile network operators. If you want to use this API, and publish your app to the Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -property-value
A list of all network account IDs for the network service provider in the form of GUIDs. You can pass those GUIDs to the [MobileBroadbandAccount.CreateFromNetworkAccountId](/uwp/api/windows.networking.networkoperators.mobilebroadbandaccount.createfromnetworkaccountid) method, and access the proprties of the resulting **MobileBroadbandAccount** object for more info about it.

## -remarks

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
