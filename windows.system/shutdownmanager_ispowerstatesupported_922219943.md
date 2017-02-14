---
-api-id: M:Windows.System.ShutdownManager.IsPowerStateSupported(Windows.System.PowerState)
-api-type: winrt method
---

<!-- Method syntax.
public bool ShutdownManager.IsPowerStateSupported(PowerState powerState)
-->

# Windows.System.ShutdownManager.IsPowerStateSupported

## -description

Gets whether a given [power state](powerstate.md) is supported on a fixed-purpose device. 
## -parameters

### -param powerState

## -returns

## -remarks

This API requires the use of the IoT **systemManagement** capability, and the inclusion of **iot** in the **IgnorableNamespaces** list. Users can add the following to their **Package.appmanifest**:`
<iot:Capability Name="systemManagement"/>`, and add **iot** to their existing list of **IgnorableNamespaces**.

## -see-also

## -examples

