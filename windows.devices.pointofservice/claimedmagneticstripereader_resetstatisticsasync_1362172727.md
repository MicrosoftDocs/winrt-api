---
-api-id: M:Windows.Devices.PointOfService.ClaimedMagneticStripeReader.ResetStatisticsAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ResetStatisticsAsync(Windows.Foundation.Collections.IIterable<System.String> statisticsCategories)
-->

# Windows.Devices.PointOfService.ClaimedMagneticStripeReader.ResetStatisticsAsync

## -description
Resets the specified statistics to zero for all statistics that can be reset.

## -parameters
### -param statisticsCategories
The list of names of the statistics to reset. 
+ An empty string ("") retrieves all statistics.
+ "U_" retrieves all UnifiedPOS defined statistics.
+ "M_" retrieves all manufacturer defined statistics.
+ "name1" and/or "name2" retrieves specific named statistics as defined by the UnifiedPOS or manufacturer.


## -returns
No object or value is returned by this method when it completes.

## -remarks

## -examples

## -see-also
