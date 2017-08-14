---
-api-id: M:Windows.System.ShutdownManager.BeginShutdown(Windows.System.ShutdownKind,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public void BeginShutdown(Windows.System.ShutdownKind shutdownKind, Windows.Foundation.TimeSpan timeout)
-->

# Windows.System.ShutdownManager.BeginShutdown

## -description
Shuts down a device that runs in fixed-purpose mode, and optionally restarts the device after the specified number of seconds.

## -parameters
### -param shutdownKind
The type of shutdown to perform, either with or without restarting the device.

### -param timeout
The amount of time in seconds to wait before restarting the device if *shutdownKind* is **ShutdownKind.Restart**.

## -remarks
This API requires the use of the IoT **systemManagement** capability, and the inclusion of **iot** in the **IgnorableNamespaces** list. Users can add the following to their **Package.appmanifest**:`
<iot:Capability Name="systemManagement"/>`, and add **iot** to their existing list of **IgnorableNamespaces**.

## -examples

## -see-also


## -capabilities
systemManagement
