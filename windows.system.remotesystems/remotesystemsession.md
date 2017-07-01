---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemSession
-api-type: winrt class
---

<!-- Class syntax.
public class RemoteSystemSession : IClosable
-->

# Windows.System.RemoteSystems.RemoteSystemSession

## -description
Represents and handles a remote session that can be shared between two or more connected devices. See Remarks for information on this feature.

## -remarks
Remote System Sessions is a part of the broader Remote Systems feature set. It allows an app to establish a session object as an intermediate third party that two or more devices can continually communicate through, enabling a number of new cross-device scenarios such as remote app messaging.

A session that has been joined is represented by a [RemoteSystemSession](RemoteSystemSession.md) object. A session that is known about but has not been joined is represented by a [RemoteSystemSessionInfo](RemoteSystemSessionInfo.md) object.

## -see-also

## -examples
See the code example below for the process of joining a remote session (including obtaining a reference to a [RemoteSystemSession](RemoteSystemSession.md) instance).

```csharp
public async void JoinExistingSession() {
    
    // request to join. sessionInfo has already been selected by user.
    RemoteSystemSessionJoinResult joinResult = await sessionInfo.JoinAsync();
    
    // process the result
    if (joinResult.Status == RemoteSystemSessionJoinStatus.Success) {
        
        // if the join was successful, acquire a reference to the session
        currentSession = joinResult.RemoteSystemSession;
        
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

Alternatively, see the following code for an example of how to create a remote session and handle join requests.

```csharp
public async void StartNewSharedExperience() {
    
    var manager = new RemoteSystemSessionController("Bob’s Minecraft game");
    
    // register the following code to handle the JoinRequested event
    manager.JoinRequested += async (sender, args) => {
        // Get the deferral
        var deferral = args.GetDeferral();
        
        // display the participant (args.JoinRequest.Participant) on UI, giving the 
        // user an opportunity to respond
        // ...
        
        // If the user chooses "accept", accept this remote system as a participant
        args.JoinRequest.Accept();
    };
    
    // create and start the session
    RemoteSystemSessionCreationResult createResult = await manager.CreateSessionAsync();
    
    // handle the creation result
    if (createResult.Status == RemoteSystemSessionCreateStatus.Success) {
        // creation was successful
        RemoteSystemSession currentSession = createResult.RemoteSystemSession;
        
        // optionally subscribe to the disconnection event
        currentSession.Disconnected += async (sender, args) => {
            // update the UI, using args.Reason
            // ...
        };
    
        // Use session ...
    
    } else if (createResult.Status == RemoteSystemSessionCreateStatus.SessionLimitsExceeded) {
        // creation failed. Optionally update UI to indicate that there are too many sessions in progress
    } else {
        // creation failed for an unknown reason. Optionally update UI
    }
}
```
