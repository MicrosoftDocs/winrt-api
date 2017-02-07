---
-api-id: T:Windows.Networking.Sockets.ControlChannelTriggerResourceType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.Sockets.ControlChannelTriggerResourceType : int
-->

# ControlChannelTriggerResourceType

## -description
The resource type used by a control channel trigger. 

> [!NOTE]
> This enumeration is not supported on Windows Phone.

## -enum-fields
### -field RequestSoftwareSlot:0
Request a software slot from the system.

### -field RequestHardwareSlot:1
Request a hardware slot from the system.


## -remarks
A local computer system can be in several power states:


+ System active
+ Connected standby
+ Shutdown
An app in the system active mode can receive a control channel trigger when either a software or hardware slot is used. An app in the connected standby mode can only receive a control channel trigger when a hardware slot is used.

## -examples

## -see-also
[ControlChannelTrigger](controlchanneltrigger.md), [ControlChannelTrigger constructor](controlchanneltrigger_controlchanneltrigger_2092736614.md), [IControlChannelTriggerEventDetails](icontrolchanneltriggereventdetails.md), [IControlChannelTriggerResetEventDetails](icontrolchanneltriggerreseteventdetails.md)