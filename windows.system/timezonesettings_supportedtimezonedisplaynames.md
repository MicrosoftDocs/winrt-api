---
-api-id: P:Windows.System.TimeZoneSettings.SupportedTimeZoneDisplayNames
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<string> SupportedTimeZoneDisplayNames { get; }
-->

# Windows.System.TimeZoneSettings.SupportedTimeZoneDisplayNames

## -description
Gets the display names for all supported time zones.

## -property-value
The display names for all supported time zones.

## -remarks
This API requires the use of the IoT **systemManagement** capability, and the inclusion of **iot** in the **IgnorableNamespaces** list. Users can add the following to their **Package.appmanifest**:`
<iot:Capability Name="systemManagement"/>`, and add **iot** to their existing list of **IgnorableNamespaces**.

## -examples

## -see-also


## -capabilities
systemManagement
