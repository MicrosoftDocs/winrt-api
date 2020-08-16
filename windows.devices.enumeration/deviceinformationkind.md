---
-api-id: T:Windows.Devices.Enumeration.DeviceInformationKind
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Enumeration.DeviceInformationKind : int
-->

# DeviceInformationKind

## -description

Represents the kind of [DeviceInformation](deviceinformation.md) object.

## -enum-fields

### -field Unknown:0

The object is of an unknown type. This value is not used.

### -field DeviceInterface:1

The [DeviceInformation](deviceinformation.md) object represents a PnP device interface. These are exposed by device drivers to enable an app to talk to the device, typically using device IOCTLS (input output controls).

This type of [DeviceInformation](deviceinformation.md) object contains all the properties of the PnP *DeviceInterface* object plus some properties from the parent PnP *DeviceContainer* object. This combination of properties can be presented to the user when the user needs to select a device to complete an app scenario. A *DeviceInterface* object can only be a child to one *DeviceContainer* object.

This is the default DeviceInformationKind when enumerating devices without specifying a specific kind.

The [Id](deviceinformation_id.md) for this object is the device interface id, or the device interface path.

### -field DeviceContainer:2

The [DeviceInformation](deviceinformation.md) object represents a device container. *DeviceContainer* objects describe a collection of device objects that exist in the same physical device. For example, a multi-function printer may have several different devices included, but they would all exist as part of the parent *DeviceContainer* object.

The [Id](deviceinformation_id.md) for this object is the device container [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) as a string.

### -field Device:3

The [DeviceInformation](deviceinformation.md) object represents a device object. This could also be referred to as a devnode. These devices are objects that represent a piece of the device functionality and optionally have drivers loaded on them. When a physical device is paired with windows, multiple *Device* objects are created for it. A device contains 0 or more *DeviceInterface* objects, is a child to one *DeviceContainer* object, and is related to 0 or 1 *AssociationEndpoint* objects.

The [Id](deviceinformation_id.md) for this object is the device instance id for this object.

### -field DeviceInterfaceClass:4

The [DeviceInformation](deviceinformation.md) object represents a device interface class. Every *DeviceInterface* object belongs to a certain *DeviceInterfaceClass*. This is similar to a contract definition. These contracts are represented with an id and properties, just like every other PnP object. *DeviceInterfaceClass* objects contain little more information than a unique identifier and possibly a name.

The [Id](deviceinformation_id.md) for this object is the device interface class [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) as a string.

### -field AssociationEndpoint:5

The [DeviceInformation](deviceinformation.md) object represents a device association endpoint (AEP). AEPs usually represent a device discovered over a wireless or network protocol. Some of these endpoints can be used without needing to first pair the device. Use [CanPair](deviceinformationpairing_canpair.md) to determine if a device supports pairing and [IsPaired](deviceinformationpairing_ispaired.md) to determine if a device is already paired with the system. Only *AssociationEndpoint* objects have a non-NULL value for [Pairing](deviceinformation_pairing.md). For more information about pairing over a network, see [Enumerate devices over a network](https://docs.microsoft.com/windows/uwp/devices-sensors/enumerate-devices-over-a-network). An *AssociationEndpoint* object is a child of a single *AssociationEndpointContainer* object and can contain 0 or more *AssociationEndpointService* objects.

The [Id](deviceinformation_id.md) for this object.

### -field AssociationEndpointContainer:6

The [DeviceInformation](deviceinformation.md) object represents an association endpoint (AEP) container. An *AssociationEndpointContainer* object represents a single physical device that might have more than one *AssociationEndpoint* objects associated with it. For example, if a television supports two different network protocols, the *AssociationEndpointContainer* would be the television. It would also have two *AssociationEndpoint* objects to represent each protocol.

The [Id](deviceinformation_id.md) for this object is the AEP container [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) as a string.

### -field AssociationEndpointService:7

The [DeviceInformation](deviceinformation.md) object represents an association endpoint (AEP) Service. An *AssociationEndpointService* object represents a functional service contract exposed by the device. Not all protocols support AEP services. An *AssociationEndpointService* can have a single parent *AssociationEndpointContainer* object.

The [Id](deviceinformation_id.md) for this object as a string.

### -field DevicePanel:8

The [DeviceInformation](deviceinformation.md) object represents a single physical face of a device enclosure.

The [Id](deviceinformation_id.md) for this object as a string.

## -remarks

A DeviceInformationKind value can be passed to the various enumeration APIs to indicate the specific kind of device you want to enumerate. In most scenarios, you will receive the [DeviceInformation](deviceinformation.md) from the device selector. To see how to enumerate over specific kinds of devices using DeviceInformationKind, see [Enumerate devices](https://docs.microsoft.com/windows/uwp/devices-sensors/enumerate-devices).

The following diagram show how the different device types interact with each other. It also indicates the properties that tie the relationships together. For performance reasons, many of the relationship connections only go in one direction. The exception to this is **AepContainer**. It contains a list of its child objects thanks to **AepContainer.Children**.

<img src="images/device_type_interaction.png" alt="DeviceInformationKind relationships" />

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | DevicePanel |

## -examples

## -see-also

[[DeviceInformation.Kind](deviceinformation_kind.md), [DeviceInformationUpdate.Kind](deviceinformationupdate_kind.md), [CreateFromIdAsync(System.String deviceId, Windows.Foundation.Collections.IIterable<System.String> additionalProperties, Windows.Devices.Enumeration.DeviceInformationKind kind)](deviceinformation_createfromidasync_270724983.md), [deviceinformation_createwatcher_990788373.md](CreateWatcher(System.String,Windows.Foundation.Collections.IIterable{System.String},Windows.Devices.Enumeration.DeviceInformationKind)), [FindAllAsync(System.String,Windows.Foundation.Collections.IIterable{System.String},Windows.Devices.Enumeration.DeviceInformationKind)](deviceinformation_findallasync_1907805458.md), [devicepairingresultstatus.md](devicepairingresultstatus.md)
