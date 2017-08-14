---
-api-id: P:Windows.System.TimeZoneSettings.CurrentTimeZoneDisplayName
-api-type: winrt property
---

<!-- Property syntax
public string CurrentTimeZoneDisplayName { get; }
-->

# Windows.System.TimeZoneSettings.CurrentTimeZoneDisplayName

## -description
Gets the display name of the current time zone.

## -property-value
The display name of the current time zone.

## -remarks
This API requires the use of the IoT **systemManagement** capability, and the inclusion of **iot** in the **IgnorableNamespaces** list. Users can add the following to their **Package.appmanifest**:`
<iot:Capability Name="systemManagement"/>`, and add **iot** to their existing list of **IgnorableNamespaces**.

## -examples

## -see-also


## -capabilities
systemManagement
