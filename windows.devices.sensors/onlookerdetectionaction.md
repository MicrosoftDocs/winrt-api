---
-api-id: T:Windows.Devices.Sensors.OnlookerDetectionAction
-api-type: winrt enum
---

# Windows.Devices.Sensors.OnlookerDetectionAction

<!--
public enum OnlookerDetectionAction
-->


## -description
Specifies the action taken when an onlooker is detected by the human presence sensors. 

## -enum-fields

### -field Dim: 0
Device screen will dim when onlooker is detected.

### -field Notify: 1
When an onlooker is detected a windows notification will be displayed.

### -field DimAndNotify: 2
When an onlooker is detected the screen will dim and a windows notification will be displayed.

## -remarks
The action taken on onlooker detection can be disabled through the top level toggle for this feature. 

The user can specify their preferred onlooker detection behavior in the System settings (see [Launch Windows Settings](/windows/apps/develop/launch/launch-settings#system)).

## -see-also

[IsOnlookerDetectionEnabled](humanpresencesettings_isonlookerdetectionenabled.md), 
[IsOnlookerDetectionSupported](humanpresencefeatures_isonlookerdetectionsupported.md)
[Device experiences - Onlooker Detection](/windows-hardware/design/device-experiences/sensors-presence-onlooker-detection)

## -examples


