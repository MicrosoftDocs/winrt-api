---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemStatusType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.System.RemoteSystems.RemoteSystemStatusType : int
-->

# RemoteSystemStatusType

## -description
Contains the values that describe a remote system's status type. This is a simplification of the [RemoteSystemStatus](remotesystemstatus.md) enumeration and is used to construct a [RemoteSystemStatusTypeFilter](remotesystemstatustypefilter.md) object.

## -enum-fields
### -field Any:0
The remote system can have any availability status and be discoverable.

### -field Available:1
The remote system must have a [Status](remotesystem_status.md) property value of **Available** in order to be discoverable.


## -remarks

## -examples

## -see-also
[Connected apps and devices (Project Rome)](/windows/uwp/launch-resume/connected-apps-and-devices)

## -capabilities
remoteSystem
