---
-api-id: P:Windows.System.TimeZoneSettings.CanChangeTimeZone
-api-type: winrt property
---

<!-- Property syntax
public bool CanChangeTimeZone { get; }
-->

# Windows.System.TimeZoneSettings.CanChangeTimeZone

## -description
Gets whether the time zone can be changed.

## -property-value
True if the time zone can be changed; otherwise, false.

## -remarks
This API requires the use of the IoT **systemManagement** capability, and the inclusion of **iot** in the **IgnorableNamespaces** list. Users can add the following to their **Package.appmanifest**:`
<iot:Capability Name="systemManagement"/>`, and add **iot** to their existing list of **IgnorableNamespaces**.

## -examples

## -see-also


## -capabilities
systemManagement
