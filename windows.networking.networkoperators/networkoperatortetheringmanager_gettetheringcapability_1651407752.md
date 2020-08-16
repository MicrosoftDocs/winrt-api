---
-api-id: M:Windows.Networking.NetworkOperators.NetworkOperatorTetheringManager.GetTetheringCapability(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Networking.NetworkOperators.TetheringCapability GetTetheringCapability(System.String networkAccountId)
-->

# Windows.Networking.NetworkOperators.NetworkOperatorTetheringManager.GetTetheringCapability

## -description
Indicates if a device is capable of creating a tethering network. Possible values are defined by [TetheringCapability](tetheringcapability.md).

## -parameters
### -param networkAccountId
The network account ID.

## -returns
The tethering capabilities of a network account.

## -remarks
Always call GetTetheringCapability prior to the creation of the tethering network using [CreateFromNetworkAccountId](mobilebroadbandaccount_createfromnetworkaccountid_2015090244.md) to first confirm that the system is capable of creating a tethering network.

## -examples

## -see-also

## -capabilities
wiFiControl
