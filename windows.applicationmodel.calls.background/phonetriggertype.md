---
-api-id: T:Windows.ApplicationModel.Calls.Background.PhoneTriggerType
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Calls.Background.PhoneTriggerType : int
-->

# PhoneTriggerType

## -description
Indicates a type of event for a phone trigger.

## -enum-fields
### -field NewVoicemailMessage:0
The system received a new voice mail message or the voice mail count went to 0.

### -field CallHistoryChanged:1
The call history has changed.

### -field LineChanged:2
The [PhoneLineProperties](phonelineproperties.md) have changed.

### -field AirplaneModeDisabledForEmergencyCall:3
Airplane mode on a phone line was disabled so the phone could make an emergency call.

### -field CallOriginDataRequest:4
A request was made for the origin of the phone call.

> [!NOTE]
> This constant is deprecated.

### -field CallBlocked:5
The call was blocked.

### -field IncomingCallDismissed:6
The incoming call was dismissed.

> [!NOTE]
> This constant is deprecated.

### -field IncomingCallNotification: 7
There is a new incoming call.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | IncomingCallDismissed |

## -examples

## -see-also
## -capabilities
phoneCallHistory, phoneCallHistorySystem

