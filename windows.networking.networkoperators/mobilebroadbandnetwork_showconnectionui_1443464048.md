---
-api-id: M:Windows.Networking.NetworkOperators.MobileBroadbandNetwork.ShowConnectionUI
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void ShowConnectionUI()
-->

# Windows.Networking.NetworkOperators.MobileBroadbandNetwork.ShowConnectionUI

## -description
Displays the connect UI for a specific mobile network.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -remarks
The ShowConnectionUI method is useful if you determine that connecting to a different network is preferred due to a roaming relationship, pricing changes, and so on. For example, when your app determines that a different network is preferred, you can inform the user of the preferred network. If the user decides to change networks, you can call the ShowConnectionUI for the preferred network to complete the connection.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
