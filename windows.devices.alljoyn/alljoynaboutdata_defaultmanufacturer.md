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

> [!IMPORTANT]
> The types in the **Windows.Devices.AllJoyn** namespace are deprecated, and might not be available in future versions of Windows. [AllJoyn](https://openconnectivity.org/technology/reference-implementation/alljoyn/)&mdash;sponsored by AllSeen Alliance&mdash;was an open-source discovery and communication protocol for Internet of Things (IoT) scenarios such as turning lights on and off, and reading temperatures. For alternatives, such as [IoTivity Lite](https://github.com/iotivity/iotivity-lite) and [IoTivity](https://github.com/iotivity/iotivity), refer to the [iotivity.org](https://iotivity.org/) website.

The name of the manufacturer of the app. This property is a shortcut to the entry in the [Manufacturers](alljoynaboutdata_manufacturers.md) property for the [DefaultLanguage](alljoynaboutdataview_defaultlanguage.md).

## -property-value
The manufacturer name.

## -remarks
By default the value returned is pulled from the "Publisher display name" field in the app manifest of a UWP app, from the "CompanyName" property of the EXE for a Desktop app, or from the device as defined by the manufacturer.

## -examples

## -see-also


## -capabilities
allJoyn
