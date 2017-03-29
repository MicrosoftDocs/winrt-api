---
-api-id: P:Windows.Devices.AllJoyn.AllJoynBusAttachment.AuthenticationMechanisms
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.Devices.AllJoyn.AllJoynAuthenticationMechanism> AuthenticationMechanisms { get; }
-->

# Windows.Devices.AllJoyn.AllJoynBusAttachment.AuthenticationMechanisms

## -description
A list of [AllJoynAuthenticationMechanism](alljoynauthenticationmechanism.md) objects representing the acceptable authentication mechanisms. Default values include Rsa and None.

## -property-value
The supported authentication mechanisms.

## -remarks
These values are used to negotiate on a per API interface basis. Any API interface marked as secure will ignore the "None" value.

## -examples

## -see-also


## -capabilities
allJoyn