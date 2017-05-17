---
-api-id: M:Windows.System.UserProfile.DiagnosticsSettings.GetForUser(Windows.System.User)
-api-type: winrt method
---

<!-- Method syntax.
public DiagnosticsSettings DiagnosticsSettings.GetForUser(User user)
-->

# Windows.System.UserProfile.DiagnosticsSettings.GetForUser

## -description

Retrieves the diagnostics settings for the specified user.

## -parameters

### -param user

The user to get settings for.

## -returns

A settings object that contains the user's current diagnostics settings.

## -remarks

## -see-also

## -examples


```csharp
// From a multi-user environment.
// (This example queries for all users, but you presumably
// know the user you want to query in your app.)

Task<IReadOnlyList<Windows.System.User>> getUsersTask =
    Windows.System.User.FindAllAsync().AsTask();
if (!getUsersTask.IsCompleted)
{
    getUsersTask.Wait();
}

IEnumerable<Windows.System.User> users = getUsersTask.Result;

foreach(Windows.System.User user in users)
{
    Windows.System.UserProfile.DiagnosticsSettings userSettings =
        Windows.System.UserProfile.DiagnosticsSettings.GetForUser(user);

    System.Diagnostics.Debug.WriteLine(user.NonRoamableId.ToString() +
        " user tailored experiences enabled: " +
        userSettings.CanUseDiagnosticsToTailorExperiences.ToString());
}
```

