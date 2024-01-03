---
-api-id: P:Windows.System.RemoteSystems.RemoteSystem.Kind
-api-type: winrt property
---

<!-- Property syntax
public string Kind { get; }
-->

# Windows.System.RemoteSystems.RemoteSystem.Kind

## -description
Gets a String representation of the device type of the given remote system.

## -property-value
The device type of the remote system.

## -remarks
This property should not be used to make functionality or experience decisions regarding connected devices. Instead, device capabilities should be checked with the [GetCapabilitySupportedAsync](remotesystem_getcapabilitysupportedasync_1130940389.md) method. The **Kind** property is meant to provide developers with information about the types of devices being connected to so that they can display this information in the UI.

## -examples

## -see-also


## -capabilities
remoteSystem
