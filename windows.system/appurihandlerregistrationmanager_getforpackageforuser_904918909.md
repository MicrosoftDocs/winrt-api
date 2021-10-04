---
-api-id: M:Windows.System.AppUriHandlerRegistrationManager.GetForPackageForUser(System.String,Windows.System.User)
-api-type: winrt method
---

# Windows.System.AppUriHandlerRegistrationManager.GetForPackageForUser(System.String,Windows.System.User)

<!--
public static Windows.System.AppUriHandlerRegistrationManager GetForPackageForUser (string packageFamilyName, Windows.System.User user);
-->


## -description

Retrieves an [AppUriHandlerRegistrationManager](appurihandlerregistrationmanager.md) instance for a given package and user.

## -parameters

### -param packageFamilyName

The package family name for which the **AppUriHandlerRegistrationManager** is retrieved. The specified name can be for the calling app itself or any hosted app that is hosted by the calling app. 

### -param user

The user for which the **AppUriHandlerRegistrationManager** is retrieved.

## -returns

An [AppUriHandlerRegistrationManager](appurihandlerregistrationmanager.md) instance.

## -remarks

With the returned **AppUriHandlerRegistrationManager**, the caller can then call [AppUriHandlerRegistrationManager.TryGetRegistration](appurihandlerregistrationmanager_trygetregistration_907258794.md) method to get an [AppUriHandlerRegistration](appurihandlerregistration.md) object.

## -see-also

## -examples


