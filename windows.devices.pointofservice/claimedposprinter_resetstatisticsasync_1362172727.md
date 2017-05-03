---
-api-id: M:Windows.Devices.PointOfService.ClaimedPosPrinter.ResetStatisticsAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> ResetStatisticsAsync(Windows.Foundation.Collections.IIterable<System.String> statisticsCategories)
-->

# Windows.Devices.PointOfService.ClaimedPosPrinter.ResetStatisticsAsync

## -description
Resets the specified statistics to zero for all statistics for the point-of-service printer that can be reset.

## -parameters
### -param statisticsCategories
A list of the names of the statistics that you want to reset.


+ An empty string ("") retrieves all statistics.
+ "U_" retrieves all UnifiedPOS-defined statistics.
+ "M_" retrieves all manufacturer-defined statistics.
+ *Name1* and/or *Name2* retrieves specific named statistics as defined by the UnifiedPOS or manufacturer.
+ Any combination of individual and group names (*Name3*, "U_", "M_").
 .

## -returns
An operation that returns true if the reset succeeds, or otherwise returns false.

## -remarks
This method represents a change in state.

## -examples

## -see-also
