---
-api-id: M:Windows.System.TimeZoneSettings.ChangeTimeZoneByDisplayName(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void ChangeTimeZoneByDisplayName(System.String timeZoneDisplayName)
-->

# Windows.System.TimeZoneSettings.ChangeTimeZoneByDisplayName

## -description
Changes the time zone using the display name.

## -parameters
### -param timeZoneDisplayName
The display name of the time zone to change to.

## -remarks
This API requires the use of the IoT **systemManagement** capability, and the inclusion of **iot** in the **IgnorableNamespaces** list. Users can add the following to their **Package.appmanifest**:`
<iot:Capability Name="systemManagement"/>`, and add **iot** to their existing list of **IgnorableNamespaces**.

## -examples

## -see-also


## -capabilities
systemManagement