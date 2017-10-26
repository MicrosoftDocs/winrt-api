---
-api-id: T:Windows.Networking.Sockets.ControlChannelTriggerStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.Sockets.ControlChannelTriggerStatus : int
-->

# ControlChannelTriggerStatus

## -description
Specifies if the system was able to complete configuration of a [ControlChannelTrigger](controlchanneltrigger.md) object for use by class elements in the [Windows.Networking.Sockets](windows_networking_sockets.md) and related namespaces. 

> [!NOTE]
> This enumeration is not supported on Windows Phone.

## -enum-fields
### -field HardwareSlotRequested:0
The policy check succeeded and a hardware slot has been requested from the system.

### -field SoftwareSlotAllocated:1
The policy check succeeded and a software slot was allocated by the system.

### -field HardwareSlotAllocated:2
A hardware slot was allocated by the system.

### -field PolicyError:3
A policy error occurred when the system tried to complete configuration of a [ControlChannelTrigger](controlchanneltrigger.md). This error can occur when an app has requested more connections for hardware or software slots than are permitted by system policy.

### -field SystemError:4
A system error occurred when the system tried to complete configuration of a [ControlChannelTrigger](controlchanneltrigger.md) for a hardware slot.

### -field TransportDisconnected:5
The network transport associated with the [ControlChannelTrigger](controlchanneltrigger.md) was disconnected. The underlying TCP connection was already disconnected by a TCP reset received from the remote destination or a graceful disconnect by either the app or the remote destination. The most common occurrence is a TCP reset or a graceful disconnect sent by the remote destination.

### -field ServiceUnavailable:6
The service provided by the [ControlChannelTrigger](controlchanneltrigger.md) is unavailable. This can happen if the network connection broker service is not yet ready but the app is trying to establish a [ControlChannelTrigger](controlchanneltrigger.md) channel. This status code is provided under the following conditions:


+ When there is fast user switching and the new user is trying to establish the [ControlChannelTrigger](controlchanneltrigger.md) channel.
+ When the system is entering a low power mode (Connected standby mode) and the app is trying to create a software slot. Software slots are available only when the system is active and not in low power mode.


The mitigation in both these cases is to listen for System Event broker events and register the [ControlChannelTrigger](controlchanneltrigger.md) channel at that point.


## -remarks
The system maintains a policy on the number of [ControlChannelTrigger](controlchanneltrigger.md) instances that can be configured for a UWP app, to limit resource usage and extend battery life. Once configuration by the system is complete, each [ControlChannelTrigger](controlchanneltrigger.md) instance represents either a hardware or software slot for an established TCP connection that is to be maintained even when the app is suspended (moved from the foreground to the background).

A local computer system can be in several power states:


+ System active
+ Connected standby
+ Shutdown
An app in the system active mode can receive a control channel trigger when either a software or hardware slot is used. An app in the connected standby mode can only receive a control channel trigger when a hardware slot is used.

## -examples

## -see-also
[ControlChannelTrigger](controlchanneltrigger.md), [ControlChannelTriggerResetReason](controlchanneltriggerresetreason.md)