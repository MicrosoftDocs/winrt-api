---
-api-id: M:Windows.System.ShutdownManager.EnterPowerState(Windows.System.PowerState)
-api-type: winrt method
---

<!-- Method syntax.
public void ShutdownManager.EnterPowerState(PowerState powerState)
-->

# Windows.System.ShutdownManager.EnterPowerState

## -description
Instructs a fixed-purpose device to enter the given power state.

## -parameters

### -param powerState

The power state to enter. 

## -remarks

This API requires the use of the IoT **systemManagement** capability, and the inclusion of **iot** in the **IgnorableNamespaces** list. Users can add the following to their **Package.appmanifest**:`
<iot:Capability Name="systemManagement"/>`, and add **iot** to their existing list of **IgnorableNamespaces**.

## -see-also
[EnterPowerState(PowerState powerState, TimeSpan wakeUpAfter)](shutdownmanager_enterpowerstate_1157290732.md)

## -examples

