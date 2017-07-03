---
-api-id: M:Windows.UI.Shell.TaskbarManager.RequestPinCurrentAppAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> TaskbarManager.RequestPinCurrentAppAsync()
-->

# Windows.UI.Shell.TaskbarManager.RequestPinCurrentAppAsync

## -description
Requests that the currently active application be pinned to the taskbar.

## -returns
A boolean representing whether the application was successfully pinned to the takbar. If the app was already pinned, this will immediately return true.

## -remarks
Calling this method will display a dialog asking the user to confirm that they want to pin the app. If the user selects "no", this method will return false.

## -see-also

## -examples

