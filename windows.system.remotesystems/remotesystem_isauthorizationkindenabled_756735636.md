---
-api-id: M:Windows.System.RemoteSystems.RemoteSystem.IsAuthorizationKindEnabled(Windows.System.RemoteSystems.RemoteSystemAuthorizationKind)
-api-type: winrt method
---

<!-- Method syntax.
public bool RemoteSystem.IsAuthorizationKindEnabled(RemoteSystemAuthorizationKind kind)
-->

# Windows.System.RemoteSystems.RemoteSystem.IsAuthorizationKindEnabled

## -description
Checks whether the client device is authorized to discover other users' devices or just same-user devices.

## -parameters

### -param kind
The [RemoteSystemAuthorizationKind](remotesystemauthorizationkind.md) to check.

## -returns
Returns **true** if the client device is set to *kind* authorization scheme, otherwise **false**.

## -remarks
This authorization is a system-wide setting. The user can view and change it by going to Settings > System > Shared experiences.

## -see-also

## -examples


## -capabilities
remoteSystem
