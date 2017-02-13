---
-api-id: M:Windows.Devices.Sensors.Compass.GetDefault
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Sensors.Compass GetDefault()
-->

# Windows.Devices.Sensors.Compass.GetDefault

## -description
Returns the default compass.

## -returns
The default compass or null if no integrated compasses are found.

## -remarks
This method only returns values for a compass that has been integrated into the computer by the manufacturer. A null value will be returned if the specified sensor is not available in the system.

When a system is in Connected Standby, a call to the [GetDefault](compass_getdefault.md) method will return immediately with a null result.

The following example demonstrates how a Windows Store app built with XAML and C# used this method to establish a connection to the default compass.



[!code-csharp[GetDefaultCS](../windows.devices.sensors/code/compass/csharp/Scenario1.xaml.cs#SnippetGetDefaultCS)]

The following example demonstrates how a Windows Store app built for Windows using JavaScript used this method to establish a connection to the default compass.



[!code-js[GetDefaultJS](../windows.devices.sensors/code/compass/javascript/scenario1.js#SnippetGetDefaultJS)]

## -examples

## -see-also
