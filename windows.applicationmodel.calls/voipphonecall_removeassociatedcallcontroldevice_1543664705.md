---
-api-id: M:Windows.ApplicationModel.Calls.VoipPhoneCall.RemoveAssociatedCallControlDevice(System.String)
-api-type: winrt method
---

# Windows.ApplicationModel.Calls.VoipPhoneCall.RemoveAssociatedCallControlDevice(System.String)

<!--
public void RemoveAssociatedCallControlDevice (string deviceId);
-->


## -description

Removes from the list of associated devices for a call.

## -parameters

### -param deviceId

A device ID to be removed from the list of associated devices for a call while it's active. If the ID isn't present in the list, then trying to remove it with **RemoveAssociatedCallControlDevice** will have no effect.

## -remarks

If removing this device ID leaves the list empty, then no call control device will be able to interact with the call. But the call's [IsUsingAssociatedDevicesList](./voipphonecall_isusingassociateddeviceslist.md) won't be set back to `false`.

## -see-also

## -examples

## -capabilities
voipCall
