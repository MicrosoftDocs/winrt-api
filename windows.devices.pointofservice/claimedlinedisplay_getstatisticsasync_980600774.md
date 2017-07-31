---
-api-id: M:Windows.Devices.PointOfService.ClaimedLineDisplay.GetStatisticsAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<string> ClaimedLineDisplay.GetStatisticsAsync(IIterable<String> statisticsCategories)
-->

# Windows.Devices.PointOfService.ClaimedLineDisplay.GetStatisticsAsync

## -description
Retrieves the requested statistics from the line display.

## -parameters
### -param statisticsCategories
The list of statistics to retrieve.
+ An empty list retrieves all statistics.
+ To retrieve specific statistics defined by the manufacturer, include the manufacturer-specified statistic names such as "name1" or "name2".
+ Include [LineDisplayStatisticsCategorySelector.ManufacturerStatistics](linedisplaystatisticscategoryselector_manufacturerstatistics.md) and [LineDisplayStatisticsCategorySelector.UnifiedPosStatistics](linedisplaystatisticscategoryselector_unifiedposstatistics.md) to retrieve manufacturer-specific and UnifiedPOS statistics respectively.

## -returns
An XML string representing the requested statistics.

## -remarks

## -see-also
[LineDisplayStatisticsCategorySelector](linedisplaystatisticscategoryselector.md)

## -examples

