---
-api-id: M:Windows.Devices.PointOfService.CashDrawer.GetStatisticsAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> GetStatisticsAsync(Windows.Foundation.Collections.IIterable<System.String> statisticsCategories)
-->

# Windows.Devices.PointOfService.CashDrawer.GetStatisticsAsync

## -description
Retrieves the requested statistics from the cash drawer.

## -parameters
### -param statisticsCategories
The list of statistics to retrieve.
+ An empty string ("") retrieves all statistics.
+ "U_" retrieves all UnifiedPOS defined statistics.
+ "M_" retrieves all manufacturer defined statistics.
+ "name1" and/or "name2" retrieves specific named statistics as defined by the UnifiedPOS or manufacturer.
+ Any combination of individual and groups names ("name3", "U_", "M_").


## -returns
String representing the requested statistics.

## -remarks

## -examples

## -see-also
