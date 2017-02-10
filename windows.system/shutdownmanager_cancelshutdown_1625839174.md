---
-api-id: M:Windows.System.ShutdownManager.CancelShutdown
-api-type: winrt method
---

<!-- Method syntax
public void CancelShutdown()
-->

# Windows.System.ShutdownManager.CancelShutdown

## -description
Cancels a shutdown of a fixed-purpose device that is already in progress.

## -remarks
This API requires the use of the IoT **systemManagement** capability, and the inclusion of **iot** in the **IgnorableNamespaces** list. Users can add the following to their **Package.appmanifest**:`
<iot:Capability Name="systemManagement"/>`, and add **iot** to their existing list of **IgnorableNamespaces**.

## -examples

## -see-also
[ShutdownManager.BeginShutdown](shutdownmanager_beginshutdown.md)

## -capabilities
systemManagement