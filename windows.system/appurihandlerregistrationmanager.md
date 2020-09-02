---
-api-id: T:Windows.System.AppUriHandlerRegistrationManager
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class AppUriHandlerRegistrationManager 
-->

# Windows.System.AppUriHandlerRegistrationManager

## -description
Retrieves [AppUriHandlerRegistrations](appurihandlerregistration.md) for the calling package. This can be used to access AppUriHandler registrations.

## -remarks
In order to create this object to manage host registrations in addition to those declared in the AppxManifest, a windows.AppUriHandler contract registration must exist in the manifest with a name field provided.

## -see-also
[AppUriHandler](/windows/uwp/launch-resume/web-to-app-linking)

## -examples

```csharp
    // Get the default AppUriHandlerRegistrationManager and query it for our registration.
    AppUriHandlerRegistrationManager manager = AppUriHandlerRegistrationManager.GetDefault();
    AppUriHandlerRegistration registration =  manager.TryGetRegistration("MyRuntimeRegistrationName");
 ```
