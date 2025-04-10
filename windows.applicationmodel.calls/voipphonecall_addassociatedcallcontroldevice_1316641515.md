---
-api-id: M:Windows.ApplicationModel.Calls.VoipPhoneCall.AddAssociatedCallControlDevice(System.String)
-api-type: winrt method
---

# Windows.ApplicationModel.Calls.VoipPhoneCall.AddAssociatedCallControlDevice(System.String)

<!--
public void AddAssociatedCallControlDevice (string deviceId);
-->


## -description

Adds to the list of associated devices for a call.

## -parameters

### -param deviceId

A new device ID to add to the list of associated devices for a call while it's active. If the ID is already in the list, then it will be ignored. The ID of a device whose [VoipCallControlDeviceKind](./voipcallcontroldevicekind.md) isn't currently supported for association will still be added, but will have no effect. If the ID is already present in the list, then trying to add it with **AddAssociatedCallControlDevice** will have no effect.

## -remarks

If this is the first time any device ID has been added to the list, then the call's [IsUsingAssociatedDevicesList](./voipphonecall_isusingassociateddeviceslist.md) will be set to `true`; and only this device will be used going forward.

## -see-also

## -examples

## -capabilities
voipCall
