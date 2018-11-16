---
-api-id: M:Windows.System.AppUriHandlerRegistrationManager.GetForUser(Windows.System.User)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public AppUriHandlerRegistrationManager AppUriHandlerRegistrationManager.GetForUser(User user)
-->

# Windows.System.AppUriHandlerRegistrationManager.GetForUser

## -description
Creates an [AppUriHandlerRegistrationManager](AppUriHandlerRegistrationManager.md) for the calling app for the requested user context.

## -parameters
### -param user
[User](user.md) context to perform operations for.

## -returns
An [AppUriHandlerRegistrationManager](AppUriHandlerRegistrationManager.md) which can be used to access [AppUriHandlerRegistrations](appurihandlerregistration.md).

## -remarks
This API will fail if the caller has not set the "SupportedUsers" property in their AppxManifest to "multiple".

Apps which do not support multiple users should instead use [AppUriHandlerRegistrationManager.GetDefault](appurihandlerregistrationmanager_getdefault_846721868.md).

## -see-also
[AppUriHandlerRegistrationManager.GetDefault](appurihandlerregistrationmanager_getdefault_846721868.md)

## -examples

