---
-api-id: T:Windows.Devices.Enumeration.DevicePairingKinds
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax
public enum Windows.Devices.Enumeration.DevicePairingKinds : uint
-->

# DevicePairingKinds

## -description

Defines constants that specify kinds of pairing supported by your application or requested by the system. As an input value, use this value to indicate what kinds of pairing your application supports. When this datatype is received as an output value, it indicates the kind of pairing requested by the system; in that case, your code will need to respond accordingly.

## -enum-fields

### -field None:0
No pairing is supported.

### -field ConfirmOnly:1
The application must confirm they wish to perform the pairing action. You can present an optional confirmation dialog to the user. With a value of **ConfirmOnly**, call [Accept](devicepairingrequestedeventargs_accept_1944939200.md) from the event args of the [PairingRequested](deviceinformationcustompairing_pairingrequested.md) event handler if you want the pairing to complete.

### -field DisplayPin:2
The application must display the given PIN to the user. The user will then need to enter or confirm that PIN on the device that is being paired. With a value of **DisplayPin**, call [Accept](devicepairingrequestedeventargs_accept_1944939200.md) from the event args of the [PairingRequested](deviceinformationcustompairing_pairingrequested.md) event handler if you want the pairing to complete. If your application cancels the pairing at this point, the device might still be paired. This is because the system and the target device don't need any confirmation for this DevicePairingKinds value.

### -field ProvidePin:4
The application must request a PIN from the user. The PIN will typically be displayed on the target device. With a value of **ProvidePin**, call [Accept](/uwp/api/windows.devices.enumeration.devicepairingrequestedeventargs.accept) from the event args of the [PairingRequested](deviceinformationcustompairing_pairingrequested.md) event handler if you want the pairing to complete. Pass in the PIN as a parameter.

### -field ConfirmPinMatch:8
The application must display the given PIN to the user and ask the user to confirm that the PIN matches the one show on the target device. With a value of **ConfirmPinMatch**, call [Accept](/uwp/api/windows.devices.enumeration.devicepairingrequestedeventargs.accept) from the event args of the [PairingRequested](deviceinformationcustompairing_pairingrequested.md) event handler if you want the pairing to complete.

### -field ProvidePasswordCredential:16
The application must request a user name and password from the user. With a value of **ProvidePasswordCredential**, call [AcceptWithPasswordCredential](devicepairingrequestedeventargs_acceptwithpasswordcredential_1073078053.md) from the event args of the [PairingRequested](deviceinformationcustompairing_pairingrequested.md) event handler to accept the pairing. Pass in the [PasswordCredential](../windows.security.credentials/passwordcredential.md) that encapsulates the user name and password as a parameter.

### -field ProvideAddress:32
The application must provide an address from the device. This is typically used for directed discovery over a network protocol such as IPP or UPnP, where the application already knows the IP/address/URL of the device. With a value of **ProvideAddress**, you should call [AcceptWithAddress](./devicepairingrequestedeventargs_acceptwithaddress_1238468511.md) on the event args of the [PairingRequested](/uwp/api/windows.devices.enumeration.deviceinformationcustompairing.pairingrequested) event handler, if you want the pairing to complete. Pass in the address as a parameter.

## -remarks
This value is a collection of flags. It's possible to have multiple values set for a single pairing action.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | ProvidePasswordCredential |

## -examples

## -see-also
[Device enumeration and pairing sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/DeviceEnumerationAndPairing),[Pair devices](/windows/uwp/devices-sensors/pair-devices)
