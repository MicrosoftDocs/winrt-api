---
-api-id: M:Windows.Storage.Pickers.Provider.TargetFileRequestDeferral.Complete
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Complete()
-->

# Windows.Storage.Pickers.Provider.TargetFileRequestDeferral.Complete

## -description
Signals that the app providing the save location finished responding to a [targetfilerequested](filesavepickerui_targetfilerequested.md) event.

## -remarks
Learn about responding asynchronously to a [targetfilerequested](filesavepickerui_targetfilerequested.md) event in [targetFileRequestedEventArgs](targetfilerequestedeventargs.md).

Calling this method will complete the request even if [getDeferral](targetfilerequest_getdeferral_254836512.md) has been called multiple times.

## -examples

## -see-also
[FileSavePickerUI.TargetFileRequested event](filesavepickerui_targetfilerequested.md), [TargetFileRequestDeferral class](targetfilerequestdeferral.md), [TargetFileRequestedEventArgs class](targetfilerequestedeventargs.md)