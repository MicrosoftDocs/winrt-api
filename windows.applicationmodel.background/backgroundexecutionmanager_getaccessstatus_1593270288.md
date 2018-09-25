---
-api-id: M:Windows.ApplicationModel.Background.BackgroundExecutionManager.GetAccessStatus(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Background.BackgroundAccessStatus GetAccessStatus(System.String applicationId)
-->

# Windows.ApplicationModel.Background.BackgroundExecutionManager.GetAccessStatus

## -description
Gets the specified app's background task execution capability.

## -parameters
### -param applicationId
The package-relative application identifier (PRAID) of the app whose capabilities are being retrieved. The specified app must be in the same package as the calling app. For more info on the PRAID, see the **Id** attribute of the [Application](/uwp/schemas/appxpackage/appxmanifestschema/element-application#attributes-and-elements) element.

If you are hosting background task(s) in an out-of-process COM server, separate from your main application, then pass as the argument for `applicationId` the PRAID of the application that defines the `windows.backgroundTask` extension in its own package manifest.

## -returns
An enumeration value that specifies the app's background capabilities.

## -remarks

## -examples

## -see-also
[GetAccessStatus](backgroundexecutionmanager_getaccessstatus_125212976.md)