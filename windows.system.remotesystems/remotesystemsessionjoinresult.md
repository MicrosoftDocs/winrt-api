---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemSessionJoinResult
-api-type: winrt class
---

<!-- Class syntax.
public class RemoteSystemSessionJoinResult 
-->

# Windows.System.RemoteSystems.RemoteSystemSessionJoinResult

## -description
Represents the result of this device's attempt to join a remote session.

## -remarks

## -see-also

## -examples
See the code example below for the process of joining a remote session.

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
