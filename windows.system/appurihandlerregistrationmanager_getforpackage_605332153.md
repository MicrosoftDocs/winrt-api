---
-api-id: M:Windows.System.AppUriHandlerRegistrationManager.GetForPackage(System.String)
-api-type: winrt method
---

# Windows.System.AppUriHandlerRegistrationManager.GetForPackage(System.String)

<!--
public static Windows.System.AppUriHandlerRegistrationManager GetForPackage (string packageFamilyName);
-->


## -description

Retrieves an [AppUriHandlerRegistrationManager](appurihandlerregistrationmanager.md) instance for a given package. 

## -parameters

### -param packageFamilyName

The package family name for which the **AppUriHandlerRegistrationManager** is retrieved. The specified name can be for the calling app itself or any hosted app that is hosted by the calling app. 

## -returns

An [AppUriHandlerRegistrationManager](appurihandlerregistrationmanager.md) instance.

## -remarks

With the returned **AppUriHandlerRegistrationManager**, the caller can then call [AppUriHandlerRegistrationManager.TryGetRegistration](appurihandlerregistrationmanager_trygetregistration_907258794.md) method to get an [AppUriHandlerRegistration](appurihandlerregistration.md) object.

## -see-also

## -examples


