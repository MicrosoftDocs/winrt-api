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
The status returned by the [GetDataBySessionPortAsync](alljoynaboutdataview_getdatabysessionportasync_561097955.md) operation that created the [AllJoynAboutDataView](alljoynaboutdataview.md) object.

## -property-value
The status code.

## -remarks
If the returned value is an error, (i.e. anything other than Ok), it can mean that the other properties aren’t populated, opposed to being populated with actual values that might happen to be empty.

## -examples

## -see-also


## -capabilities
allJoyn
