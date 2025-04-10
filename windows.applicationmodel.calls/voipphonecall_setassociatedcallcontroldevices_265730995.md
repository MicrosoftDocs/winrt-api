---
-api-id: M:Windows.ApplicationModel.Calls.VoipPhoneCall.SetAssociatedCallControlDevices(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

# Windows.ApplicationModel.Calls.VoipPhoneCall.SetAssociatedCallControlDevices(Windows.Foundation.Collections.IIterable{System.String})

<!--
public void SetAssociatedCallControlDevices (System.Collections.Generic.IEnumerable<string> associatedDeviceIds);
-->


## -description

Sets the list of call control device IDs that are associated with the call. In the scenario where control of a call is desired to be transferred from one device to another (such as due to a change in audio endpoint), this allows the change to be made in a single transaction, rather than with sequential add and remove calls.

## -parameters

### -param associatedDeviceIds

The new list of call control devices to associate with the call. This replaces any existing list of associated devices. Must be non-null, and contain no duplicate IDs (otherwise returns E_INVALIDARG).

## -remarks

If this is the first time that the list has been set (including if it is being set to empty), then the call's [IsUsingAssociatedDevicesList](./voipphonecall_isusingassociateddeviceslist.md) will be set to `true`, and only the given devices will be used going forward.

## -see-also

## -examples

## -capabilities
voipCall
