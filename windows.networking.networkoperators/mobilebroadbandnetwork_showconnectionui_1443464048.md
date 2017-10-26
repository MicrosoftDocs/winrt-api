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
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.



> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/en-us/windows/uwp/packaging/app-capability-declarations). 

## -remarks
The [ShowConnectionUI](mobilebroadbandnetwork_showconnectionui.md) method is useful if you determine that connecting to a different network is preferred due to a roaming relationship, pricing changes, and so on. For example, when your app determines that a different network is preferred, you can inform the user of the preferred network. If the user decides to change networks, you can call the [ShowConnectionUI](mobilebroadbandnetwork_showconnectionui.md) for the preferred network to complete the connection.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
