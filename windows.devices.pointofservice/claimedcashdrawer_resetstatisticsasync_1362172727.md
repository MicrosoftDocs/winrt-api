---
-api-id: M:Windows.Devices.PointOfService.ClaimedCashDrawer.ResetStatisticsAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> ResetStatisticsAsync(Windows.Foundation.Collections.IIterable<System.String> statisticsCategories)
-->

# Windows.Devices.PointOfService.ClaimedCashDrawer.ResetStatisticsAsync

## -description
Resets the specified device statistics to their defaults.

## -parameters
### -param statisticsCategories
The list of names of the statistics to reset. 
+ An empty string ("") retrieves all statistics.
+ "U_" retrieves all UnifiedPOS defined statistics.
+ "M_" retrieves all manufacturer defined statistics.
+ "name1" and/or "name2" retrieves specific named statistics as defined by the UnifiedPOS or manufacturer.
+ Any combination of individual and groups names ("name3", "U_", "M_").


## -returns
True on success; otherwise false.

## -remarks
This method represents a change in state.

## -examples

## -see-also
