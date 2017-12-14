---
-api-id: P:Windows.System.User.NonRoamableId
-api-type: winrt property
---

<!-- Property syntax
public string NonRoamableId { get; }
-->

# Windows.System.User.NonRoamableId

## -description
Gets the user's non-roamable id.

## -property-value
The user's non-roamable Id.

## -remarks

In a multi-user app, you might need to remember what user the app was working with prior to the app being de-activated or suspended. You can save the NonRoamableId, then use it as a key to retrieve the user object again on activation (see User.GetFromId).   

The NonRoamableId for a user object is a string that is unique to the device, app, and user. It can’t roam to other devices or other apps. In addition, if the user logs in remotely, resulting in a different User.Type value, the NonRoamableId is different.

## -examples

This example shows how to save the NonRoamableId when an app is suspended, then get the NonRoamableId when the app is activated. The NonRoamableId is then used to retrieve the User object, which is set as the current user. This code is placed in _App.xaml.cs_, and extraneous code has been removed.

```csharp

User ActiveUser = null;

protected async override void OnLaunched(LaunchActivatedEventArgs e)
{
    // ... code removed ...

        if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
        {
            //TODO: Load state from previously suspended application
            var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            if (localSettings.Values.ContainsKey("previousUser"))
            {
                var previousId = (string)localSettings.Values["previousUser"];
                ActiveUser = User.GetFromId(previousId);
            }
            else
            {
                IReadOnlyList<User> users = await Windows.System.User.FindAllAsync();
                ActiveUser = users[0];
            }
        }

    // ... code removed ...
}

private void OnSuspending(object sender, SuspendingEventArgs e)
{
    var deferral = e.SuspendingOperation.GetDeferral();
    //TODO: Save application state and stop any background activity

    // If the user is authenticated and not a guest, save the  
    // NonRoamableId so we can retrieve this specific user later. 
    var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;

    if (ActiveUser != null &&
       (ActiveUser.AuthenticationStatus != UserAuthenticationStatus.Unauthenticated) &&
       (ActiveUser.Type == UserType.LocalUser || ActiveUser.Type == UserType.RemoteUser))
    {
        localSettings.Values.Add("previousUser", ActiveUser.NonRoamableId);
    }
    else
    {
        if (localSettings.Values.ContainsKey("previousUser"))
        {
            localSettings.Values.Remove("previousUser");
        }
    }

    deferral.Complete();
}
```

## -see-also
