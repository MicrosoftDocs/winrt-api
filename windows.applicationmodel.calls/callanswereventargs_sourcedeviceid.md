---
-api-id: P:Windows.ApplicationModel.Calls.CallAnswerEventArgs.SourceDeviceId
-api-type: winrt property
---

# Windows.ApplicationModel.Calls.CallAnswerEventArgs.SourceDeviceId

<!--
public string SourceDeviceId { get; }
-->


## -description

Gets the ID of the call control peripheral device that initiated the answer request.

## -property-value

The ID of the call control peripheral device that initiated the answer request. If the request wasn't initiated by a peripheral device, or if the device was of a [VoipCallControlDeviceKind](./voipcallcontroldevicekind.md) that's not currently supported for association, then it will be an empty string.

## -remarks

## -see-also

## -examples

## -capabilities
voipCall
