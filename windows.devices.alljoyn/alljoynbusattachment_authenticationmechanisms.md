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

> [!IMPORTANT]
> The types in the **Windows.Devices.AllJoyn** namespace are deprecated, and might not be available in future versions of Windows. [AllJoyn](https://openconnectivity.org/technology/reference-implementation/alljoyn/)&mdash;sponsored by AllSeen Alliance&mdash;was an open-source discovery and communication protocol for Internet of Things (IoT) scenarios such as turning lights on and off, and reading temperatures. For alternatives, such as [IoTivity Lite](https://github.com/iotivity/iotivity-lite) and [IoTivity](https://github.com/iotivity/iotivity), refer to the [iotivity.org](https://iotivity.org/) website.

A list of [AllJoynAuthenticationMechanism](alljoynauthenticationmechanism.md) objects representing the acceptable authentication mechanisms. Default values include Rsa and None.

## -property-value
The supported authentication mechanisms.

## -remarks
These values are used to negotiate on a per API interface basis. Any API interface marked as secure will ignore the "None" value.

## -examples

## -see-also


## -capabilities
allJoyn
