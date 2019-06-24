---
-api-id: P:Windows.Devices.AllJoyn.AllJoynAboutData.DefaultDescription
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string DefaultDescription { get;  set; }
-->

# Windows.Devices.AllJoyn.AllJoynAboutData.DefaultDescription

## -description
The default description of the app. This property is a shortcut to the entry in the [Descriptions](alljoynaboutdata_descriptions.md) property for the [DefaultLanguage](alljoynaboutdataview_defaultlanguage.md).

## -property-value
The app description.

## -remarks
By default the returned value is pulled from either the "Description" field in a UWP app 's app manifest, or [FileDescription](https://docs.microsoft.com/windows/desktop/properties/props-system-filedescription) property of the EXE in a Desktop app.

## -examples

## -see-also


## -capabilities
allJoyn
