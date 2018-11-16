---
-api-id: M:Windows.System.AppUriHandlerRegistrationManager.GetDefault
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public AppUriHandlerRegistrationManager AppUriHandlerRegistrationManager.GetDefault()
-->

# Windows.System.AppUriHandlerRegistrationManager.GetDefault

## -description
Creates an [AppUriHandlerRegistrationManager](AppUriHandlerRegistrationManager.md) for the calling app for the current user.

## -returns
An [AppUriHandlerRegistrationManager](AppUriHandlerRegistrationManager.md) which can be used to access [AppUriHandlerRegistrations](appurihandlerregistration.md).

## -remarks
Apps which support multiple users should instead use [AppUriHandlerRegistrationManager.GetForUser](appurihandlerregistrationmanager_getforuser_2058550280.md).

## -see-also
[AppUriHandlerRegistrationManager.GetForUser](appurihandlerregistrationmanager_getforuser_2058550280.md)

## -examples
```csharp
string uriHandlerName = "Runtime"; 
Windows.System.AppUriHandlerRegistrationManager manager = AppUriHandlerRegistrationManager.GetDefault(); // Or GetForUser() for multi user-aware apps. 
AppUriHandlerRegistration registration = manager.TryGetRegistration(uriHandlerName);
if (registration != null)
{
    // App can get or set hosts as needed
}
```
