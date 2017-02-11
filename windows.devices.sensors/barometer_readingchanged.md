---
-api-id: E:Windows.Devices.Sensors.Barometer.ReadingChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ReadingChanged<Windows.Devices.Sensors.Barometer,  Windows.Devices.Sensors.BarometerReadingChangedEventArgs>
-->

# Windows.Devices.Sensors.Barometer.ReadingChanged

## -description
Occurs each time the barometer sensor reports a new value.

## -remarks
An application may register this event handler to obtain sensor readings. The application must establish a desired [ReportInterval](barometer_reportinterval.md). This sets the frequency of the **ReadingChanged** event.

## -examples

## -see-also
