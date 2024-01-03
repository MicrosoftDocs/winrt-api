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

> [!IMPORTANT]
> The types in the **Windows.Devices.AllJoyn** namespace are deprecated, and might not be available in future versions of Windows. [AllJoyn](https://openconnectivity.org/technology/reference-implementation/alljoyn/)&mdash;sponsored by AllSeen Alliance&mdash;was an open-source discovery and communication protocol for Internet of Things (IoT) scenarios such as turning lights on and off, and reading temperatures. For alternatives, such as [IoTivity Lite](https://github.com/iotivity/iotivity-lite) and [IoTivity](https://github.com/iotivity/iotivity), refer to the [iotivity.org](https://iotivity.org/) website.

The default description of the app. This property is a shortcut to the entry in the [Descriptions](alljoynaboutdata_descriptions.md) property for the [DefaultLanguage](alljoynaboutdataview_defaultlanguage.md).

## -property-value
The app description.

## -remarks
By default the returned value is pulled from either the "Description" field in a UWP app's app manifest, or [FileDescription](/windows/desktop/properties/props-system-filedescription) property of the EXE in a Desktop app.

## -examples

## -see-also


## -capabilities
allJoyn
