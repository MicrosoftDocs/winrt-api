---
-api-id: T:Windows.System.PowerState
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum PowerState : int 
-->

# Windows.System.PowerState

## -description

Represents power states for fixed-purpose devices.  

## -enum-fields
### -field SleepS3:1

Represents the Sleep S3 state. 

### -field ConnectedStandby:0

Represents the Connected Standby state. 

## -remarks

This API requires the use of the IoT **systemManagement** capability, and the inclusion of **iot** in the **IgnorableNamespaces** list. Users can add the following to their **Package.appmanifest**:`
<iot:Capability Name="systemManagement"/>`, and add **iot** to their existing list of **IgnorableNamespaces**.

## -see-also

## -examples

