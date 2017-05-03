---
-api-id: M:Windows.Devices.PointOfService.ClaimedMagneticStripeReader.UpdateStatisticsAsync(Windows.Foundation.Collections.IIterable{Windows.Foundation.Collections.IKeyValuePair{System.String,System.String}})
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction UpdateStatisticsAsync(Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, System.String>> statistics)
-->

# Windows.Devices.PointOfService.ClaimedMagneticStripeReader.UpdateStatisticsAsync

## -description
Updates the specified statistics.

## -parameters
### -param statistics
The list of key-value pairs of statistics to update. 
+ An empty string ("", "value1") sets all statistics that can be set to value1.
+ "U_", "value2" sets all UnifiedPOS defined statistics that can be set to value2.
+ "M_", "value3" sets all manufacturer defined statistics that can be set to value3.
+ "name1", "value4" sets specific named statistics as defined by the UnifiedPOS or manufacturer to value4.


## -returns
No object or value is returned by this method when it completes.

## -remarks

## -examples

## -see-also
