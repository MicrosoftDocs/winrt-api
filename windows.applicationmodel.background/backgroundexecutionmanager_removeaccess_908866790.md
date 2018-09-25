---
-api-id: M:Windows.ApplicationModel.Background.BackgroundExecutionManager.RemoveAccess(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void RemoveAccess(System.String applicationId)
-->

# Windows.ApplicationModel.Background.BackgroundExecutionManager.RemoveAccess

## -description
Removes a specific app from the list of apps that may run background tasks.

## -parameters
### -param applicationId
The package-relative application identifier (PRAID) of the app to be removed from the list of apps that may run background tasks. The specified app must be in the same package as the calling app. For more info on the PRAID, see the **Id** attribute of the [Application](/uwp/schemas/appxpackage/appxmanifestschema/element-application#attributes-and-elements) element.

If you are hosting background task(s) in an out-of-process COM server, separate from your main application, then pass as the argument for `applicationId` the PRAID of the application that defines the `windows.backgroundTask` extension in its own package manifest.

## -remarks

## -examples

## -see-also
[RemoveAccess](backgroundexecutionmanager_removeaccess_1873661382.md)