---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemSessionInvitationReceivedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class RemoteSystemSessionInvitationReceivedEventArgs 
-->

# Windows.System.RemoteSystems.RemoteSystemSessionInvitationReceivedEventArgs

## -description
Contains information about a [RemoteSystemSessionInvitationListener.InvitationReceived](RemoteSystemSessionInvitationListener_InvitationReceived.md) event, namely the associated [RemoteSystemSessionInvitation](RemoteSystemSessionInvitation.md) object.

## -remarks
This class is instantiated whenever the [RemoteSystemSessionInvitationListener.InvitationReceived](RemoteSystemSessionInvitationListener_InvitationReceived.md) event is raised, and it should be handled by the method(s) registered to this event.

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