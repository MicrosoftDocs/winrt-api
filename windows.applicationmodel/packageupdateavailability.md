---
-api-id: T:Windows.ApplicationModel.PackageUpdateAvailability
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum PackageUpdateAvailability : int 
-->

# Windows.ApplicationModel.PackageUpdateAvailability

## -description
An enum that indicates if an application has an update, and if the update is required.

## -enum-fields

### -field Unknown:0
This value is returned when this function is called on a package that does not have an AppInstaller file association.

### -field Required:3 
This value is returned when an update for the application is available, and the update is required.

### -field NoUpdates:1 
This value is returned when no updates are available for the application.

### -field Available:2
This value is returned when an update for the application is available, and the update is not required.

### -field Error:4
This value is returned when an error is encountered.

## -remarks

## -see-also
[Package.CheckUpdateAvailabilityAsync](package_checkupdateavailabilityasync_726867427.md)

## -examples

For related code examples, see the [Package.CheckUpdateAvailabilityAsync](package_checkupdateavailabilityasync_726867427.md) article.
