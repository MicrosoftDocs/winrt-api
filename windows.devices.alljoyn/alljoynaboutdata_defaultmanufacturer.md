---
-api-id: P:Windows.Devices.AllJoyn.AllJoynAboutData.DefaultManufacturer
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string DefaultManufacturer { get;  set; }
-->

# Windows.Devices.AllJoyn.AllJoynAboutData.DefaultManufacturer

## -description
The name of the manufacturer of the app. This property is a shortcut to the entry in the [Manufacturers](alljoynaboutdata_manufacturers.md) property for the [DefaultLanguage](alljoynaboutdataview_defaultlanguage.md).

## -property-value
The manufacturer name.

## -remarks
By default the value returned is pulled from the "Publisher display name" field in the app manifest of a Windows Store app, from the "CompanyName" property of the EXE for a Desktop app, or from the device as defined by the manufacturer.

## -examples

## -see-also


## -capabilities
allJoyn