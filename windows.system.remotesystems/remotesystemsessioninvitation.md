---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemSessionInvitation
-api-type: winrt class
---

<!-- Class syntax.
public class RemoteSystemSessionInvitation 
-->

# Windows.System.RemoteSystems.RemoteSystemSessionInvitation

## -description
Represents an invitation from a session participant to join their remote session.

## -remarks
An instance of this class is contained in the [RemoteSystemSessionInvitationReceivedEventArgs](RemoteSystemSessionInvitationReceivedEventArgs.md) object that was passed in with the [RemoteSystemSessionInvitationListener.InvitationReceived](RemoteSystemSessionInvitationListener_InvitationReceived.md) event.

The device receiving an invitation will need to use a [RemoteSystemSessionInvitationListener](RemoteSystemSessionInvitationListener.md) to handle it.

## -see-also

## -examples
See the following code for an example of how to receive and handle remote session invitations.

```csharp
public void SubscribeAndHandleInvites() {
    var invitationListener = new RemoteSystemSessionInvitationListener();
    
    // register the following code to handle this event:
    invitationListener.InvitationReceived += async (sender, args) => {
        
        // issue a join request to the session
        RemoteSystemSessionJoinResult joinResult = await args.Invitation.RemoteSystemSessionInfo.JoinAsync();
        
        // handle the join result as in the normal session discovery scenario
        // ...
    };
}
```
## -capabilities
remoteSystem
