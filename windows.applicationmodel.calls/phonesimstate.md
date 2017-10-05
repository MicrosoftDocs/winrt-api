---
-api-id: T:Windows.ApplicationModel.Calls.PhoneSimState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Calls.PhoneSimState : int
-->

# PhoneSimState

## -description
The current state of the SIM card for a cellular phone line.

## -enum-fields
### -field Unknown:0
The SIM card state is unknown.

### -field PinNotRequired:1
The SIM card does not require a PIN code.

### -field PinUnlocked:2
The SIM card is unlocked, but requires a PIN code to unlock again if it becomes locked.

### -field PinLocked:3
The SIM card is locked and requires a PIN code to unlock.

### -field PukLocked:4
The SIM card is locked due to too many incorrect PIN entries, and requires a Personal Unlocking Key (PUK) to unlock.

### -field NotInserted:5
There is no SIM card inserted into the phone.

### -field Invalid:6
The SIM card is not valid.

### -field Disabled:7
The SIM card is disabled.


## -remarks

## -examples

## -see-also
## -capabilities
phoneCallHistory, phoneCallHistorySystem
