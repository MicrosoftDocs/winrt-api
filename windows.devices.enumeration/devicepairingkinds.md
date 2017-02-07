---
-api-id: T:Windows.Devices.Enumeration.DevicePairingKinds
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Enumeration.DevicePairingKinds : uint
-->

# DevicePairingKinds

## -description
Indicates the kinds of pairing supported by your application or requested by the system. As an input value, use this value to indicate what kinds of pairing your application supports. When this datatype is received as an output value, it indicates the kind of pairing requested by the system. In this case, your code will need to respond accordingly.

## -enum-fields
### -field None:0
No pairing is supported.

### -field ConfirmOnly:1
The application must confirm they wish to perform the pairing action. You can present an optional confirmation dialog to the user. With a value of **ConfirmOnly**, [Accept](devicepairingrequestedeventargs_accept.md) the pairing if you want it to complete.

### -field DisplayPin:2
The application must display the given PIN to the user. The user will then need to enter or confirm that PIN on the device that is being paired. With a value of **DisplayPin**, [Accept](devicepairingrequestedeventargs_accept.md) the pairing if you want it to complete. If your application cancels the pairing at this point, the device might still be paired. This is because the system and the target device don't need any confirmation for this [DevicePairingKinds](devicepairingkinds.md) value.

### -field ProvidePin:4
The application must request a PIN from the user. The PIN will typically be displayed on the target device. With a value of **ProvidePin**, [Accept](devicepairingrequestedeventargs_accept.md) the pairing and pass in the PIN as a parameter.

### -field ConfirmPinMatch:8
The application must display the given PIN to the user and ask the user to confirm that the PIN matches the one show on the target device. With a value of **ConfirmPinMatch**, [Accept](devicepairingrequestedeventargs_accept.md) the pairing if you want it to complete.


## -remarks
This value is a collection of flags. It is possible to have multiple values set for a single pairing action.

## -examples

## -see-also