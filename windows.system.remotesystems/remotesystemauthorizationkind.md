---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemAuthorizationKind
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum RemoteSystemAuthorizationKind : int 
-->

# Windows.System.RemoteSystems.RemoteSystemAuthorizationKind

## -description
Contains values specifying whether the client device can discover only same-user devices or other users' devices as well. Cross-user devices must be available through a proximal connection in order to be discovered (see [RemoteSystemDiscoveryType](remotesystemdiscoverytype.md) for details).

## -enum-fields
### -field SameUser:0
The client device can only discover devices signed in by the same user.

### -field Anonymous:1
The client device can discover other users' devices, provided they are available for proximal connection.

## -remarks
If a [RemoteSystemAuthorizationKindFilter](RemoteSystemAuthorizationKindFilter.md) is not used in device discovery, the default behavior is to discover same-user devices only.

## -see-also

## -examples


## -capabilities
remoteSystem
