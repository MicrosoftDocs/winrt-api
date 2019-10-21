---
-api-id: M:Windows.System.UserProfile.AssignedAccessSettings.GetDefault
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public AssignedAccessSettings AssignedAccessSettings.GetDefault()
-->

# Windows.System.UserProfile.AssignedAccessSettings.GetDefault

## -description

Retrieves the default assigned access settings.

## -returns

A settings object that contains the user's current assigned access settings.

## -remarks

## -see-also

## -examples
```csharp
using Windows.System.UserProfile; 

// Retrieve AssignedAccessSettings for current user
void GetAssignedAccessSettingsForCurrentUser()
{
    AssignedAccessSettings settings = AssignedAccessSettings.GetDefault();
    var assignedAccessEnabled = settings.IsEnabled;
    var singleAppKioskMode = settings.IsSingleAppKioskMode;
    
    // determine the behavior according to the AssignedAccessSettings
}

```
