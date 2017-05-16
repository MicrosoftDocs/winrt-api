---
-api-id: M:Windows.System.RemoteSystems.RemoteSystemSession.SendInvitationAsync(Windows.System.RemoteSystems.RemoteSystem)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> RemoteSystemSession.SendInvitationAsync(RemoteSystem invitee)
-->

# Windows.System.RemoteSystems.RemoteSystemSession.SendInvitationAsync

## -description
Invites a given remote device to join this remote session. 

## -parameters

### -param invitee
The RemoteSystem object representing the system to which this invitation is being sent.

## -returns
An asynchronous operation with a boolean value: **true** if the invitation was sent successfully, otherwise **false**.

## -remarks
The device receiving the invitation will need to use a [RemoteSystemSessionInvitationListener](RemoteSystemSessionInvitationListener.md) to handle it.

## -see-also

## -examples

