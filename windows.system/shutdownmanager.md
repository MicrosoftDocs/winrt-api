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
All methods of this class are static, so you do not need to get a [ShutdownManager](shutdownmanager.md) object to use the methods.

This API requires the use of the IoT **systemManagement** capability. Users can add the following to their **Package.appmanifest**:`
<iot:Capability Name="systemManagement"/>`

## -examples

## -see-also
[ShutdownKind](shutdownkind.md)

## -capabilities
systemManagement