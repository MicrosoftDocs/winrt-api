---
-api-id: T:Windows.System.AppUriHandlerRegistration
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class AppUriHandlerRegistration 
-->

# Windows.System.AppUriHandlerRegistration

## -description
Sets and retrieves dynamic [AppUriHandlerHost](appurihandlerhost.md) entries for a given AppUriHandler registration.

## -remarks
Registrations follow the same structure as entries in the AppxManifest:

```xml
<uap3:Extension Category="windows.appUriHandler">
    <uap3:AppUriHandler uap7:Name ="Runtime">
        <uap3:Host Name="appurihandler.example.com" />
    </uap3:AppUriHandler>
</uap3:Extension>
```

## -see-also
[AppUriHandler](/windows/uwp/launch-resume/web-to-app-linking)

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
