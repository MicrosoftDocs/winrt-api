---
-api-id: P:Windows.System.AppUriHandlerRegistrationManager.PackageFamilyName
-api-type: winrt property
---

# Windows.System.AppUriHandlerRegistrationManager.PackageFamilyName

<!--
public string PackageFamilyName { get; }
-->


## -description

Gets the package family name for the app originally specified when creating the [AppUriHandlerRegistrationManager](appurihandlerregistrationmanager.md) object. 

## -property-value

## -remarks

This method is useful in cases where the calling app hosts multiple hosted apps, and each one has its own app URI registrations. If the **AppUriHandlerRegistrationManager** was retrieved with by calling [GetForUser](appurihandlerregistrationmanager_getforuser_2058550280.md), empty string is returned. 

## -see-also

## -examples


