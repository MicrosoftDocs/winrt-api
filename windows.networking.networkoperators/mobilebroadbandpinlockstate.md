---
-api-id: T:Windows.Networking.NetworkOperators.MobileBroadbandPinLockState
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Networking.NetworkOperators.MobileBroadbandPinLockState : int
-->

# MobileBroadbandPinLockState

## -description
Describes the possible PIN lock states of a mobile broadband PIN.

## -enum-fields
### -field Unknown:0
The PIN lock state is unknown.

An example is no SIM card present.

### -field Unlocked:1
The PIN lock state is unlocked.

Examples are if the user has provided a PIN already or no PIN is required.

### -field PinRequired:2
A PIN input is required. The [MobileBroadbandPinType](mobilebroadbandpintype.md) will contain more information on which PIN is needed.

### -field PinUnblockKeyRequired:3
An invalid PIN has been entered too often and a PIN Unblock Key (PUK) is needed to proceed.


## -remarks

## -examples

## -see-also
[MobileBroadbandPin](mobilebroadbandpin.md), [MobileBroadbandPinType](mobilebroadbandpintype.md)