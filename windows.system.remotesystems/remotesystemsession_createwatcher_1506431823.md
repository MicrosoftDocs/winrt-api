---
-api-id: M:Windows.System.RemoteSystems.RemoteSystemSession.CreateWatcher
-api-type: winrt method
---

<!-- Method syntax.
public RemoteSystemSessionWatcher RemoteSystemSession.CreateWatcher()
-->

# Windows.System.RemoteSystems.RemoteSystemSession.CreateWatcher

## -description
Initializes and returns a [RemoteSystemSessionWatcher](remotesystemsessionwatcher.md) object to monitor the presence of remote sessions.

## -returns
A watcher object to be used in discovering remote sessions.

## -remarks

## -see-also

## -examples
See the code example below for the process of discovering a remote session. 

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

