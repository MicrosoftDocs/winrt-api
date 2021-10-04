---
-api-id: P:Windows.System.AppUriHandlerRegistration.PackageFamilyName
-api-type: winrt property
---

# Windows.System.AppUriHandlerRegistration.PackageFamilyName

<!--
public string PackageFamilyName { get; }
-->


## -description

Gets the package family name for the app originally specified when creating the associated [AppUriHandlerRegistrationManager](appurihandlerregistrationmanager.md) object. 

## -property-value

The package family name for the app.

## -remarks

This method is useful in cases where the calling app hosts multiple hosted apps, and each one has its own app URI registrations. If the associated **AppUriHandlerRegistrationManager** was retrieved with by calling [GetForUser](appurihandlerregistrationmanager_getforuser_2058550280.md), empty string is returned. 

## -see-also

## -examples


