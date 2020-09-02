---
-api-id: P:Windows.Devices.AllJoyn.AllJoynAboutData.DefaultAppName
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string DefaultAppName { get;  set; }
-->

# Windows.Devices.AllJoyn.AllJoynAboutData.DefaultAppName

## -description
The default app name assigned by the manufacturer- either the developer or the OEM. This property is a shortcut to the entry in the [AppNames](alljoynaboutdata_appnames.md) property for the [DefaultLanguage](alljoynaboutdataview_defaultlanguage.md).

## -property-value
The default app name.

## -remarks
By default the returned value is a single entry that indicates in the [DefaultLanguage](alljoynaboutdataview_defaultlanguage.md), with value either pulled from the "Display name" field in a UWP app's app manifest, or the [ProductName](/windows/desktop/properties/props-system-software-productname) property of a Desktop app.

This property serves as a shortcut to the entry in the [Descriptions](alljoynaboutdata_descriptions.md) property for the [DefaultLanguage](alljoynaboutdataview_defaultlanguage.md).

## -examples

## -see-also


## -capabilities
allJoyn
