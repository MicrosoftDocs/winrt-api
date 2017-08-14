---
-api-id: M:Windows.Devices.AllJoyn.AllJoynBusAttachment.GetAboutDataAsync(Windows.Devices.AllJoyn.AllJoynServiceInfo,Windows.Globalization.Language)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax.
public IAsyncOperation<AllJoynAboutDataView> AllJoynBusAttachment.GetAboutDataAsync(AllJoynServiceInfo serviceInfo, Language language)
-->

# Windows.Devices.AllJoyn.AllJoynBusAttachment.GetAboutDataAsync

## -description
Gets the About data for a specific AllJoyn endpoint in a specific language. This method is intended to replace the less intuitive static [AllJoynAboutDataView.GetDataBySessionPortAsync()](alljoynaboutdataview_getdatabysessionportasync_561097955.md).

## -parameters

### -param serviceInfo
The AllJoyn endpoint from which to retrieve About data.

### -param language
The language in which to request About data. If the requested language is not supported, the remote device's default language will be used.

## -returns
This method makes acquiring About data more intuitive than it was in previous Windows releases.

## -remarks

## -see-also
[AllJoynBusAttachment.GetAboutDataAsync(AllJoynServiceInfo serviceInfo)](alljoynbusattachment_getaboutdataasync_513025028.md)

## -examples

## -capabilities
allJoyn
