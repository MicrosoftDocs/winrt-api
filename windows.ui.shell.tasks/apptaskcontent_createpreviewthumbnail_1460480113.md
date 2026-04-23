---
-api-id: M:Windows.UI.Shell.Tasks.AppTaskContent.CreatePreviewThumbnail(Windows.Foundation.Uri,System.String)
-api-type: winrt method
---

# Windows.UI.Shell.Tasks.AppTaskContent.CreatePreviewThumbnail(Windows.Foundation.Uri,System.String)

<!--
public static Windows.UI.Shell.Tasks.AppTaskContent CreatePreviewThumbnail (System.Uri imageUri, string executingStep);
-->


## -description

Creates task content that displays a preview thumbnail of the task output.

## -parameters

### -param imageUri

The URI of the thumbnail image to display. Supports `ms-appx:///`, `ms-appdata:///`, and absolute file paths.

### -param executingStep

A string that represents the step that is currently executing.

## -returns

A new [AppTaskContent](apptaskcontent.md) object that displays an image preview.

## -remarks

> [!IMPORTANT]
> **App task support will start gradually rolling out to Windows 11 starting May, 2026.** The experiences enabled by `Windows.UI.Shell.Tasks` APIs require that the corresponding app task feature be present in the version of Windows where the app runs. Otherwise, these APIs will not have any effect.

## -see-also

## -examples


