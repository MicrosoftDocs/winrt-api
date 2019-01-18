---
-api-id: M:Windows.System.UserProfile.AssignedAccessSettings.GetForUser(Windows.System.User)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public AssignedAccessSettings AssignedAccessSettings.GetForUser(User user)
-->

# Windows.System.UserProfile.AssignedAccessSettings.GetForUser

## -description

Retrieves the assigned access settings for the specified user.

## -parameters

### -param user

The user to get settings for.

## -returns

A settings object that contains the user's current assigned access settings.

## -remarks

## -see-also

## -examples
```csharp
using Windows.System.UserProfile; 

// Retrieve AssignedAccessSettings for all users
async void GetAssignedAccessSettingsForAllUsers()
{
    foreach (var user in await Windows.System.User.FindAllAsync())
    {
        var targetUserSettings = AssignedAccessSettings.GetForUser(user);
        // determine the behavior according to the user's AssignedAccessSettings
    }
}

```
