---
-api-id: M:Windows.Networking.NetworkOperators.NetworkOperatorTetheringManager.CreateFromNetworkAccountId(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Networking.NetworkOperators.NetworkOperatorTetheringManager CreateFromNetworkAccountId(System.String networkAccountId)
-->

# Windows.Networking.NetworkOperators.NetworkOperatorTetheringManager.CreateFromNetworkAccountId

## -description
Creates an instance of [NetworkOperatorTetheringManager](networkoperatortetheringmanager.md) for a specific network account using the provided network account ID for the mobile broadband device.

## -parameters
### -param networkAccountId
The network account ID.

## -returns
A [NetworkOperatorTetheringManager](networkoperatortetheringmanager.md) object.

## -remarks
Always call [GetTetheringCapability](networkoperatortetheringmanager_gettetheringcapability_1651407752.md) prior to the creation of the tethering network using [CreateFromNetworkAccountId](mobilebroadbandaccount_createfromnetworkaccountid_2015090244.md) to first confirm that the system is capable of creating a tethering network.

## -examples

## -see-also

## -capabilities
wiFiControl
