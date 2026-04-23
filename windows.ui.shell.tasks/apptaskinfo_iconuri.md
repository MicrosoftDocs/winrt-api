---
-api-id: P:Windows.UI.Shell.Tasks.AppTaskInfo.IconUri
-api-type: winrt property
---

# Windows.UI.Shell.Tasks.AppTaskInfo.IconUri

<!--
public System.Uri IconUri { get; }
-->


## -description

Gets the path to an icon that represents the task.

## -property-value

The path to an icon that represents the task.

## -remarks

> [!IMPORTANT]
> **App task support will start gradually rolling out to Windows 11 starting May, 2026.** The experiences enabled by `Windows.UI.Shell.Tasks` APIs require that the corresponding app task feature be present in the version of Windows where the app runs. Otherwise, these APIs will not have any effect.

These path formats are supported:

- `ms-appx:///` - Package-relative URI to the app's package folder (recommended)
- `ms-appdata:///` - Package-relative URI to the app's data folders
- Absolute paths - For example, `C:\Program Files\MyApp\icon.png` or `file://c:/temp/icon.png`

## -see-also

## -examples


