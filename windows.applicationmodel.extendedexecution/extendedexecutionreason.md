---
-api-id: T:Windows.ApplicationModel.ExtendedExecution.ExtendedExecutionReason
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.ExtendedExecution.ExtendedExecutionReason : int
-->

# ExtendedExecutionReason

## -description
Describes the reason for the background execution request.

## -enum-fields
### -field Unspecified:0
No reason specified.

### -field LocationTracking:1
To support location tracking.

### -field SavingData:2
To save data.

## -remarks

Lifetime data for the various reasons:

| Reason | Extended execution session lifetime |
|----------|--------------------------------------------|
| LocationTracking | No limit. Only one app at a time may request this reason. |
| SavingData | 10 minutes maximum. |
| Unspecified |  10 minutes maximum on battery power. No limit when the device is connected to power. |

## -examples

## -see-also