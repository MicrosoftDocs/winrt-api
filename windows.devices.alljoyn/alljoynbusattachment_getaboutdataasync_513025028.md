---
-api-id: M:Windows.Devices.AllJoyn.AllJoynBusAttachment.GetAboutDataAsync(Windows.Devices.AllJoyn.AllJoynServiceInfo)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax.
public IAsyncOperation<AllJoynAboutDataView> AllJoynBusAttachment.GetAboutDataAsync(AllJoynServiceInfo serviceInfo)
-->

# Windows.Devices.AllJoyn.AllJoynBusAttachment.GetAboutDataAsync

## -description
Gets the About data for a specific AllJoyn endpoint. This method is intended to replace the less intuitive static [AllJoynAboutDataView.GetDataBySessionPortAsync()](alljoynaboutdataview_getdatabysessionportasync_660342083.md).

## -parameters

### -param serviceInfo
The AllJoyn endpoint from which to retrieve About data.

## -returns

## -remarks
This method makes acquiring About data more intuitive than it was in previous Windows releases.

## -see-also
[GetAboutDataAsync(AllJoynServiceInfo serviceInfo, Language language)](alljoynbusattachment_getaboutdataasync_522145388.md)

## -examples

## -capabilities
allJoyn