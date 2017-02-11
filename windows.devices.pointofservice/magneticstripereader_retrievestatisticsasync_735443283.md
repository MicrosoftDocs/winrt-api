---
-api-id: M:Windows.Devices.PointOfService.MagneticStripeReader.RetrieveStatisticsAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IBuffer> RetrieveStatisticsAsync(Windows.Foundation.Collections.IIterable<System.String> statisticsCategories)
-->

# Windows.Devices.PointOfService.MagneticStripeReader.RetrieveStatisticsAsync

## -description
Retrieves the requested statistics from the magnetic stripe reader.

## -parameters
### -param statisticsCategories
The list of statistics to retrieve.
+ An empty string ("") retrieves all statistics.
+ "U_" retrieves all UnifiedPOS defined statistics.
+ "M_" retrieves all manufacturer defined statistics.
+ "name1" and/or "name2" retrieves specific named statistics as defined by the UnifiedPOS or manufacturer.
+ Any combination of individual and groups names ("name3", "U_", "M_").


## -returns
IBuffer representing the requested statistics.

## -remarks
The result does not contain any duplicate statistics even if the input contains duplicates.

## -examples

## -see-also
