---
-api-id: P:Windows.ApplicationModel.Calls.VoipPhoneCall.IsUsingAssociatedDevicesList
-api-type: winrt property
---

# Windows.ApplicationModel.Calls.VoipPhoneCall.IsUsingAssociatedDevicesList

<!--
public bool IsUsingAssociatedDevicesList { get; }
-->


## -description

Gets a value that represents whether or not the associated devices list is being used by the call.

## -property-value

`true` if call control devices will be able to interact with the call only if their device ID is included in the associated devices list. `false` if all connected call control devices will be able to show the call state, and control the call. 

## -remarks

If a new call is requested using a call options object created with a list of associated call control device IDs included (including an empty list), then **IsUsingAssociatedDevicesList** will be initialized to `true`. Otherwise, it will be initialized to `false`. If initialized to `false`, and the list of associated devices for the call is later added to or set (including set to an empty list), then **IsUsingAssociatedDevicesList** will be updated to `true` for the remaining lifetime of the call.

## -see-also

## -examples

## -capabilities
voipCall
