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
Gets a [TargetFileRequestDeferral](targetfilerequestdeferral.md) that the app providing the save location can use to respond asynchronously to a [TargetFileRequested](filesavepickerui_targetfilerequested.md) event.

## -returns
The [TargetFileRequestDeferral](targetfilerequestdeferral.md) that the providing app can use asynchronously to indicate that it is finished responding to a [TargetFileRequested](filesavepickerui_targetfilerequested.md) event.

## -remarks
Use this method to finish responding to a [TargetFileRequest](targetfilerequest.md) event asynchronously. If this method is not called, the request is considered complete after the [TargetFileRequested](filesavepickerui_targetfilerequested.md) event handler returns— regardless of outstanding asynchronous operations.

To signal that your app has finished its asynchronous response to the [TargetFileRequested](filesavepickerui_targetfilerequested.md) event, call the [TargetFileRequestDeferral.complete](targetfilerequestdeferral_complete_1807836922.md) method.

Learn more about responding asynchronously to a [TargetFileRequested](filesavepickerui_targetfilerequested.md) event in [TargetFileRequestedEventArgs](targetfilerequestedeventargs.md).

## -examples

## -see-also
[FileSavePickerUI.TargetFileRequested event](filesavepickerui_targetfilerequested.md), [Object class](/dotnet/api/system.object?view=dotnet-uwp-10.0&preserve-view=true), [TargetFileRequest class](targetfilerequest.md), [TargetFileRequestDeferral class](targetfilerequestdeferral.md), [TargetFileRequestDeferral.Complete method](targetfilerequestdeferral_complete_1807836922.md), [TargetFileRequestedEventArgs class](targetfilerequestedeventargs.md), [Windows.Storage.StorageFile class](../windows.storage/storagefile.md)