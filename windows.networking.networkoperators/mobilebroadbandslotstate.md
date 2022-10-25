---
-api-id: T:Windows.Networking.NetworkOperators.MobileBroadbandSlotState
-api-type: winrt enum
---

# Windows.Networking.NetworkOperators.MobileBroadbandSlotState

<!--
public enum MobileBroadbandSlotState
-->

## -description

Defines constants that specify possible SIM slot states. This API is for use by OEMs and partners who are familiar with cellular concepts, and therefore can interpret the enum.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic.

## -enum-fields

### -field Active:6

Specifies that the SIM in the slot is active.

### -field ActiveEsim:8

Specifies that the SIM in the slot is an eSIM with an active profile, and is ready to accept commands.

### -field ActiveEsimNoProfile:9

Specifies that the SIM in the slot is an eSIM with no active profiles, and is ready to accept commands.

### -field Empty:4

Specifies that the SIM slot is powered on, but empty.

### -field Error:7

Specifies that the SIM in the slot is in an error state.

### -field NotReady:5

Specifies that the SIM in the slot is not ready.

### -field Off:3

Specifies that the SIM slot is powered off, and a SIM is present

### -field OffEmpty:2

Specifies that the SIM slot is powered off, and empty.

### -field Unknown:1

Specifies that the SIM slot state is unknown.

### -field Unmanaged:0

Specifies that the SIM slot is not managed. For example, this is the case for devices with a single SIM slot.

## -remarks

## -see-also

## -examples

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
