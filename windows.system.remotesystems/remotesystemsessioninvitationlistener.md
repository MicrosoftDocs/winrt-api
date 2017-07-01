---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemSessionInvitationListener
-api-type: winrt class
---

<!-- Class syntax.
public class RemoteSystemSessionInvitationListener 
-->

# Windows.System.RemoteSystems.RemoteSystemSessionInvitationListener

## -description
Contains the functionality for receiving and handling invitations to join remote sessions. This class begins listening for invitations when it is instantiated.

## -remarks

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