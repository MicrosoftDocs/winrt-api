---
-api-id: M:Windows.System.AppUriHandlerRegistrationManager.TryGetRegistration(System.String)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public AppUriHandlerRegistration AppUriHandlerRegistrationManager.TryGetRegistration(String name)
-->

# Windows.System.AppUriHandlerRegistrationManager.TryGetRegistration

## -description
Attempts to retrieve a registration object for the windows.AppUriHandler extension present in the caller's AppxManifest with the given name.

## -parameters
### -param name
Name corresponding to an entry in the caller's AppxManfiest.

## -returns
[AppUriHandlerRegistration](appurihandlerregistration.md) object representing the AppxManifest extension registration. This can be used to update dynamic registrations.

Null if there is no corresponding entry in the caller's AppxManifest.

## -remarks
The registration retrieved by this API represents a "windows.appUriHandler" extension like the example below.
<uap3:Extension Category="windows.appUriHandler">
    <uap3:AppUriHandler uap7:Name ="Runtime">
        <uap3:Host Name="www.appurihandler.com" />
</uap3:AppUriHandler>

## -see-also

## -examples

