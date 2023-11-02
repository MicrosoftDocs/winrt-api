---
-api-id: P:Windows.Devices.AllJoyn.AllJoynAboutDataView.Status
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public int Status { get; }
-->

# Windows.Devices.AllJoyn.AllJoynAboutDataView.Status

## -description

> [!IMPORTANT]
> The types in the **Windows.Devices.AllJoyn** namespace are deprecated, and might not be available in future versions of Windows. [AllJoyn](https://openconnectivity.org/technology/reference-implementation/alljoyn/)&mdash;sponsored by AllSeen Alliance&mdash;was an open-source discovery and communication protocol for Internet of Things (IoT) scenarios such as turning lights on and off, and reading temperatures. For alternatives, such as [IoTivity Lite](https://github.com/iotivity/iotivity-lite) and [IoTivity](https://github.com/iotivity/iotivity), refer to the [iotivity.org](https://iotivity.org/) website.

The status returned by the [GetDataBySessionPortAsync](alljoynaboutdataview_getdatabysessionportasync_561097955.md) operation that created the [AllJoynAboutDataView](alljoynaboutdataview.md) object.

## -property-value
The status code.

## -remarks
If the returned value is an error, (i.e. anything other than Ok), it can mean that the other properties aren’t populated, opposed to being populated with actual values that might happen to be empty.

## -examples

## -see-also


## -capabilities
allJoyn
