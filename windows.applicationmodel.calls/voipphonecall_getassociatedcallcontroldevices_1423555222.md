---
-api-id: M:Windows.ApplicationModel.Calls.VoipPhoneCall.GetAssociatedCallControlDevices
-api-type: winrt method
---

# Windows.ApplicationModel.Calls.VoipPhoneCall.GetAssociatedCallControlDevices

<!--
public System.Collections.Generic.IReadOnlyList<string> GetAssociatedCallControlDevices ();
-->


## -description

Retrieves the list of call control device IDs that are associated with the call.

## -returns

The list of call control device IDs that are associated with the call.

## -remarks

The returned list of device IDs is only those that were manually added on call creation, or via another method that modifies the associated call control devices list. If the call's [IsUsingAssociatedDevicesList](./voipphonecall_isusingassociateddeviceslist.md) is `false`, then **GetAssociatedCallControlDevices** will return an empty list but all connected call control devices will be able to interact with the call. 
Note that a device’s ID is not automatically removed from this list when that device is disconnected, and that that device will still be able to interact with the call if it is later reconnected. 

## -see-also

## -examples

## -capabilities
voipCall
