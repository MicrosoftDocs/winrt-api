---
-api-id: T:Windows.Devices.Bluetooth.Background.BluetoothEventTriggeringMode
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum BluetoothEventTriggeringMode : int
-->

# Windows.Devices.Bluetooth.Background.BluetoothEventTriggeringMode

## -description
Specifies the frequency at which the trigger is activated.

## -enum-fields
### -field Serial:0
The background task is triggered when the first advertisement comes in. Subsequent advertisements activate new background tasks.

### -field KeepLatest:2
The background task is triggered only after the last advertisement is received.

### -field Batch:1
Useful for higher frequency data. The trigger activates a background task when data arrives. Any data that is received until the background task completes is batched together and delivered to the next background task that is  activated when the prior background task completes.

## -remarks

## -see-also

## -examples
