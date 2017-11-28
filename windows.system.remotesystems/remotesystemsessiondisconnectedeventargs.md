---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemSessionDisconnectedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class RemoteSystemSessionDisconnectedEventArgs 
-->

# Windows.System.RemoteSystems.RemoteSystemSessionDisconnectedEventArgs

## -description
Contains information about a [RemoteSystemSession.Disconnected](RemoteSystemSession_Disconnected.md) event, namely the reason that this device was disconnected from the session.

## -remarks
This class is instantiated whenever the [RemoteSystemSession.Disconnected](RemoteSystemSession_Disconnected.md) event is raised, and it should be handled by the method(s) registered to this event.

## -see-also

## -examples
See the code example below for the process of joining a remote session (including using a [RemoteSystemSessionDisconnectedEventArgs](RemoteSystemSessionDisconnectedEventArgs.md) instance).

```csharp

public async void JoinExistingSession() {
    
    // request to join. sessionInfo has already been selected by user.
    RemoteSystemSessionJoinResult joinResult = await sessionInfo.JoinAsync();
    
    // process the result
    if (joinResult.Status == RemoteSystemSessionJoinStatus.Success) {
        
        // if the join was successful, acquire a reference to the session
        currentSession = joinResult.Session;
        
        // optionally handle the disconnected event
        currentSession.Disconnected += async (sender, args) => {
            // update the UI, using args.Reason
        };
        
        // update the UI with the session.DisplayName and 
        // session.ControllerDisplayName strings. Save a reference to 
        // this RemoteSystemSession, to use when the user selects
        // this session from the UI

    } else {
        // join request failed. optionally update UI
    }
}
```


## -capabilities
remoteSystem
