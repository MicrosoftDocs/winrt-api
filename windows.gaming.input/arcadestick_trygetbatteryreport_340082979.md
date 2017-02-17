---
-api-id: M:Windows.Gaming.Input.ArcadeStick.TryGetBatteryReport
-api-type: winrt method
---

<!-- Method syntax.
public BatteryReport ArcadeStick.TryGetBatteryReport()
-->

# Windows.Gaming.Input.ArcadeStick.TryGetBatteryReport

## -description

Gets information about the arcade stick's current battery state.

## -returns

Information about the arcade stick's current battery state.

## -remarks

## -see-also

* [Windows.Devices.Power.BatteryReport](../windows.devices.power/batteryreport.md)

## -examples

<!--In the following example, the app tries to get a battery report from the given arcade stick.

```csharp
private void UpdateBatteryIcon(ArcadeStick arcadeStick)
{
    BatteryReport report = arcadeStick.TryGetBatteryReport();

    if (report != null)
    {
        // Update UI from information contained in battery report.
    }
}
```-->