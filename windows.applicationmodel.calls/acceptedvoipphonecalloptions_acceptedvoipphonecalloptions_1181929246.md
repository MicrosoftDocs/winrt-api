---
-api-id: M:Windows.ApplicationModel.Calls.AcceptedVoipPhoneCallOptions.#ctor(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt constructor
---

# Windows.ApplicationModel.Calls.AcceptedVoipPhoneCallOptions.#ctor(Windows.Foundation.Collections.IIterable{System.String})

<!--
public AcceptedVoipPhoneCallOptions (System.Collections.Generic.IEnumerable<string> associatedDeviceIds);
-->


## -description

Creates an instance of [AcceptedVoipPhoneCallOptions](./acceptedvoipphonecalloptions.md) from a list of device interface ids of call control devices to associate with the call.

## -parameters

### -param associatedDeviceIds

A list of device interface ids of call control devices to associate with the call. The list may be empty, but *associatedDeviceIds* may not be null (otherwise returns **E_INVALIDARG**). Specifying this parameter results in the [VoipPhoneCall.IsUsingAssociatedDevicesList](./voipphonecall_isusingassociateddeviceslist.md) property of a new call created with these options to be initialized to `true`, meaning that only associated devices will show the call state and be able to answer the call.

## -remarks

## -see-also

## -examples

## -capabilities
voipCall
