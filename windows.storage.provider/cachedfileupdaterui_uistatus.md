---
-api-id: P:Windows.Storage.Provider.CachedFileUpdaterUI.UIStatus
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Storage.Provider.UIStatus UIStatus { get; }
-->

# Windows.Storage.Provider.CachedFileUpdaterUI.UIStatus

## -description
Gets an enum value that indicates the status of the file picker UI.

## -property-value
The [UIStatus](uistatus.md) value that indicates the status of the file picker UI.

## -remarks
When an app providing updates has responded to all [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) events, this property indicates [UIStatus.Complete](uistatus.md).

Check for the [UIStatus.Complete](uistatus.md) value to determine if your providing app has responded all [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) events. If the [UIStatus](uistatus.md) is [Complete](uistatus.md) your app should display page (which will be hosted in the file picker) to tell the user that the updates are complete.

## -examples

## -see-also
