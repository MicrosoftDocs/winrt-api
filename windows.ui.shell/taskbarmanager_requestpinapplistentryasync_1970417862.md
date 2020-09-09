---
-api-id: M:Windows.UI.Shell.TaskbarManager.RequestPinAppListEntryAsync(Windows.ApplicationModel.Core.AppListEntry)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> TaskbarManager.RequestPinAppListEntryAsync(AppListEntry appListEntry)
-->

# Windows.UI.Shell.TaskbarManager.RequestPinAppListEntryAsync

## -description
Requests that the specified application be pinned to the taskbar.

## -parameters
### -param appListEntry
An [AppListEntry](/uwp/api/Windows.ApplicationModel.Core.AppListEntry) corresponding to the application to pin to the taskbar.

## -returns
A boolean representing whether the application was successfully pinned to the takbar. If the app was already pinned, this will immediately return true.

## -remarks
Calling this method will display a dialog asking the user to confirm that they want to pin the app. If the user selects "no", this method will return false.

## -see-also