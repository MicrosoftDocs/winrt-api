---
-api-id: M:Windows.Storage.Pickers.Provider.TargetFileRequest.GetDeferral
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Storage.Pickers.Provider.TargetFileRequestDeferral GetDeferral()
-->

# Windows.Storage.Pickers.Provider.TargetFileRequest.GetDeferral

## -description
Gets a [targetFileRequestDeferral](targetfilerequestdeferral.md) that the app providing the save location can use to respond asynchronously to a [targetfilerequested](filesavepickerui_targetfilerequested.md) event.

## -returns
The [targetFileRequestDeferral](targetfilerequestdeferral.md) that the providing app can use asynchronously to indicate that it is finished responding to a [targetfilerequested](filesavepickerui_targetfilerequested.md) event.

## -remarks
Use this method to finish responding to a [targetFileRequest](targetfilerequest.md) event asynchronously. If this method is not called, the request is considered complete after the [targetfilerequested](filesavepickerui_targetfilerequested.md) event handler returns— regardless of outstanding asynchronous operations.

To signal that your app has finished its asynchronous response to the [targetfilerequested](filesavepickerui_targetfilerequested.md) event, call the [targetFileRequestDeferral.complete](targetfilerequestdeferral_complete_1807836922.md) method.

Learn more about responding asynchronously to a [targetfilerequested](filesavepickerui_targetfilerequested.md) event in [targetFileRequestedEventArgs](targetfilerequestedeventargs.md).

## -examples

## -see-also
[FileSavePickerUI.TargetFileRequested event](filesavepickerui_targetfilerequested.md), [Object class](https://msdn.microsoft.com/library/system.object.aspx), [TargetFileRequest class](targetfilerequest.md), [TargetFileRequestDeferral class](targetfilerequestdeferral.md), [TargetFileRequestDeferral.Complete method](targetfilerequestdeferral_complete_1807836922.md), [TargetFileRequestedEventArgs class](targetfilerequestedeventargs.md), [Windows.Storage.StorageFile class](../windows.storage/storagefile.md)