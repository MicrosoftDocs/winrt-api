---
-api-id: T:Windows.System.ShutdownManager
-api-type: winrt class
---

<!-- Class syntax.
public class ShutdownManager 
-->

# Windows.System.ShutdownManager

## -description
Manages the shutdown of devices that run in fixed-purpose mode.

## -remarks
All methods of this class are static, so you do not need to get a ShutdownManager object to use the methods.

This API requires the use of the IoT **systemManagement** capability. Users can add the following to their **Package.appmanifest**:`
<iot:Capability Name="systemManagement"/>`

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | EnterPowerState(PowerState) |
| 1703 | 15063 | EnterPowerState(PowerState,TimeSpan) |
| 1703 | 15063 | IsPowerStateSupported |

## -examples

## -see-also
[ShutdownKind](shutdownkind.md)

## -capabilities
systemManagement
