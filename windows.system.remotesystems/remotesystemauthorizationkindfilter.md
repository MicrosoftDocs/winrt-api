---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemAuthorizationKindFilter
-api-type: winrt class
---

<!-- Class syntax.
public class RemoteSystemAuthorizationKindFilter : IRemoteSystemFilter
-->

# Windows.System.RemoteSystems.RemoteSystemAuthorizationKindFilter

## -description
An [IRemoteSystemFilter](iremotesystemfilter.md) that alters the set of discoverable remote systems by allowing those of a specific authorization kind.

## -remarks
In order to discover cross-user devices, the client device must both use the appropriate filter *and* be set to allow sharing with anonymous devices. Check this system-wide setting with the [RemoteSystem.isAuthorizationKindEnabled](RemoteSystem_isAuthorizationKindEnabled_756735636.md) method. If the client device is not set to allow anonymous sharing, prompt the user to change this setting in Settings > System > Shared experiences.

## -see-also
[IRemoteSystemFilter](iremotesystemfilter.md)

## -examples


## -capabilities
remoteSystem
