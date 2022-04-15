---
-api-id: M:Windows.ApplicationModel.Background.BackgroundExecutionManager.RequestAccessAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Background.BackgroundAccessStatus> RequestAccessAsync(System.String applicationId)
-->

# Windows.ApplicationModel.Background.BackgroundExecutionManager.RequestAccessAsync

## -description
Asynchronously requests that the app be permitted to run background tasks.

## -parameters
### -param applicationId
The package-relative application identifier (PRAID) of the app to be permitted to run background tasks. The specified app must be in the same package as the calling app. For more info on the PRAID, see the **Id** attribute of the [Application](/uwp/schemas/appxpackage/appxmanifestschema/element-application#attributes-and-elements) element.

If you are hosting background task(s) in an out-of-process COM server, separate from your main application, then pass as the argument for `applicationId` the PRAID of the application that defines the `windows.backgroundTask` extension in its own package manifest.

## -returns
An asynchronous request operation. On successful completion, contains a member of the [BackgroundAccessStatus](backgroundaccessstatus.md) enumeration that specifies the outcome.

## -remarks

| Version | Behavior |
|---|---|
| Windows 8/Windows 8.1 | Prompts the user with a dialog box that requests that an app be added to the lock screen. Must be called before registering any background tasks. |
| Windows Phone 8.1 | Does not prompt the user, but must be called before registering any background tasks. |
| Windows 10 | Does not prompt the user, but must be called before registering any background tasks. You do not need to add the app to the lock screen in order to use background tasks in Windows 10, but you still need to call this method, or  [RequestAccessAsync](/uwp/api/windows.applicationmodel.background.backgroundexecutionmanager.RequestAccessAsync), to request background access. |

> [!TIP]
> Starting with Windows 10, it is no longer necessary to call this method from the UI thread.

## -examples

## -see-also
[RequestAccessAsync](/uwp/api/windows.applicationmodel.background.backgroundexecutionmanager.RequestAccessAsync)
