---
-api-id: T:Windows.Phone.Networking.Voip.VoipCallRejectReason
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Phone.Networking.Voip.VoipCallRejectReason : int
-->

# VoipCallRejectReason

## -description

> [!IMPORTANT]
> The types in the **Windows.Phone.Networking.Voip** namespace are deprecated, and may not be available in future versions of Windows. Instead, use the equivalent types in the [Windows.ApplicationModel.Calls](/uwp/api/windows.applicationmodel.calls) namespace.

Specifies the reason that an incoming call was rejected.

## -enum-fields

### -field UserIgnored:0
The user pressed a button to ignore the call.

### -field TimedOut:1
The incoming call timed out.

### -field OtherIncomingCall:2
Another incoming call was accepted.

### -field EmergencyCallExists:3
An emergency call is in progress.

### -field InvalidCallState:4
The call is in an invalid state.

## -remarks

## -examples

## -see-also

## -capabilities
ID_CAP_VOIP [Windows Phone]
