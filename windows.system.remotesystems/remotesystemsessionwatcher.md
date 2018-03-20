---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemSessionWatcher
-api-type: winrt class
---

<!-- Class syntax.
public class RemoteSystemSessionWatcher 
-->

# Windows.System.RemoteSystems.RemoteSystemSessionWatcher

## -description
Watches for activity related to the discovery of remote sessions and raises the appropriate events.

## -remarks
This class is instantiated when the [RemoteSystemSession.CreateWatcher](RemoteSystemSession_CreateWatcher_1506431823.md) method is called.

> [!IMPORTANT]
> You must confirm access to the remote system platform with a call to **[RemoteSystem.RequestAccessAsync](remotesystem_requestaccessasync_380675631.md)** before you instantiate this class.

> [!IMPORTANT]
> RemoteSystemSession discovery requirements:
> 1.	Bluetooth must be be on, on both client and host devices.
> 2.	On the host device, the "Share Across Devices" setting in the "Shared Experiences" page (under System) in the Settings app must be “Everyone nearby”.
> 3.	Client and host apps must have the same PackageFamilyName.
>
> RemoteSystemSession discovery may work via LAN discovery, but it isn’t guaranteed (depends on the network configuration).

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


## -capabilities
remoteSystem
