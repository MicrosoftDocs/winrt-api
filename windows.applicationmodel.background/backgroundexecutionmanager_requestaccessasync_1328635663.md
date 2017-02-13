---
-api-id: M:Windows.ApplicationModel.Background.BackgroundExecutionManager.RequestAccessAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Background.BackgroundAccessStatus> RequestAccessAsync(System.String applicationId)
-->

# Windows.ApplicationModel.Background.BackgroundExecutionManager.RequestAccessAsync

## -description
Requests that the app be permitted to run background tasks.

## -parameters
### -param applicationId
The Package Relative Application ID (PRAID) of the app to be permitted to run background tasks. The specified app must be in the same package as the calling app.

## -returns
When the operation completes, it returns a member of the [BackgroundAccessStatus](backgroundaccessstatus.md) enumeration that specifies the outcome.

## -remarks
<table>
   <tr><td>Version</td><td>Behavior</td></tr>
   <tr><td>Windows 8/Windows 8.1</td><td>Prompts the user with a dialog box that requests that an app be added to the lock screen. Must be called before registering any background tasks.</td></tr>
   <tr><td>Windows Phone 8.1</td><td>Does not prompt the user, but must be called before registering any background tasks.</td></tr>
   <tr><td>Windows 10</td><td>Does not prompt the user, but must be called before registering any background tasks. You do not need to add the app to the lock screen in order to use background tasks in Windows 10, but you still need to call [RequestAccessAsync](backgroundexecutionmanager_requestaccessasync.md) to request background access.</td></tr>
</table>



> [!TIP]
> Starting with Windows 10, it is no longer necessary to call this method from the UI thread.

## -examples

## -see-also
[RequestAccessAsync](backgroundexecutionmanager_requestaccessasync_380675631.md)