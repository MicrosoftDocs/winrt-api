---
-api-id: P:Windows.Devices.Power.PowerGridForecast.Forecast
-api-type: winrt property
---

# Windows.Devices.Power.PowerGridForecast.Forecast

<!--
public System.Collections.Generic.IReadOnlyList<Windows.Devices.Power.PowerGridData> Forecast { get; }
-->


## -description

Gets a vector that contains the forecast data. The forecast is contiguous, and begins at [StartTime](./powergridforecast_starttime.md). The start time of each element can be calculated with `StartTime + (index * BlockDuration)`.

## -property-value

A vector that contains the forecast data.

## -remarks

## -see-also

## -examples
