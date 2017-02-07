---
-api-id: T:Windows.Services.Maps.LocalSearch.LocalLocationFinderStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Services.Maps.LocalSearch.LocalLocationFinderStatus : int
-->

# LocalLocationFinderStatus

## -description
Specifies the status of a search performed by the [FindLocalLocationsAsync](locallocationfinder_findlocallocationsasync.md) method.

> [!NOTE]
> This API is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to this API will fail at runtime. For more information about the [Windows.Services.Maps.LocalSearch](windows_services_maps_localsearch.md) namespace, please work with your Microsoft Account Team representative.

## -enum-fields
### -field Success:0
The search completed successfully.

### -field UnknownError:1
The search encountered an unknown error.

### -field InvalidCredentials:2
The app does not have the credentials necessary to perform the search.

### -field InvalidCategory:3
One or more of the specified categories are not valid.

### -field InvalidSearchTerm:4
The specified search text is not valid.

### -field InvalidSearchArea:5
The specified geographic area is not valid.

### -field NetworkFailure:6
The search encountered a network failure.

### -field NotSupported:7
The search is not supported on this device.


## -remarks

## -examples

## -see-also