---
-api-id: M:Windows.UI.Shell.Tasks.AppTaskResultAsset.#ctor(System.String,System.String,Windows.Foundation.Uri,Windows.Foundation.Uri)
-api-type: winrt constructor
---

# Windows.UI.Shell.Tasks.AppTaskResultAsset.#ctor(System.String,System.String,Windows.Foundation.Uri,Windows.Foundation.Uri)

<!--
public AppTaskResultAsset (string name, string context, System.Uri iconUri, System.Uri assetUri);
-->


## -description

Creates a new instance of `AppTaskResultAsset` with the specified parameters.

## -parameters

### -param name

The display name of the asset shown to the user (for example, "ResultStudy.txt").

### -param context

Additional context displayed next to the asset name (for example, "Generated content").

### -param iconUri

The URI of an icon that represents the asset. Supports `ms-appx:///`, `ms-appdata:///`, and absolute file paths.

### -param assetUri

The URI of the generated asset (for example, a file path).

## -remarks

> [!IMPORTANT]
> **App task support will start gradually rolling out to Windows 11 starting May, 2026.** The experiences enabled by `Windows.UI.Shell.Tasks` APIs require that the corresponding app task feature be present in the version of Windows where the app runs. Otherwise, these APIs will not have any effect.

## -see-also

## -examples


