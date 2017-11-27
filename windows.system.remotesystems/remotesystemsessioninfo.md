---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemSessionInfo
-api-type: winrt class
---

<!-- Class syntax.
public class RemoteSystemSessionInfo 
-->

# Windows.System.RemoteSystems.RemoteSystemSessionInfo

## -description
Contains identifying information about a remote session.

## -remarks
A session that has been joined is represented by a [RemoteSystemSession](RemoteSystemSession.md) object. A session that is known about but has not been joined is represented by a [RemoteSystemSessionInfo](RemoteSystemSessionInfo.md) object.

## -see-also

## -examples
See the code example below for the full process of discovering a remote session (including obtaining a reference to a [RemoteSystemSessionInfo](RemoteSystemSessionInfo.md) instance).

```csharp

// Discover an existing shared experience.
public void DiscoverExistingSessions() {
    
    // create a watcher for remote system sessions
    RemoteSystemSessionWatcher sessionWatcher = RemoteSystemSession.CreateWatcher();
    
    // register a handler for the "added" event
    sessionWatcher.Added += async (sender, args) => {
        
        // get a reference to the info about the discovered session
        RemoteSystemSessionInfo sessionInfo = args.RemoteSystemSessionInfo;
        
        // update the UI with the sessionInfo.DisplayName and 
        // sessionInfo.ControllerDisplayName strings. Save a reference to 
        // this RemoteSystemSessionInfo, to use when the user selects
        // this session from the UI
        
        //...
    };
    
    // Begin watching
    sessionWatcher.Start();
}
```

Once a [RemoteSystemSessionInfo](RemoteSystemSessionInfo.md) reference has be acquired, it can be used to issue a join request. See the code example below for the process of joining a remote session.

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
