---
-api-id: P:Windows.System.LauncherOptions.DisplayApplicationPicker
-api-type: winrt property
---

<!-- Property syntax
public bool DisplayApplicationPicker { get;  set; }
-->

# Windows.System.LauncherOptions.DisplayApplicationPicker

## -description
Gets or sets a value that indicates whether to display the **Open With** dialog whenever the association launching API is called.

## -property-value
True if the **Open With** dialog should always be displayed; otherwise false.

## -remarks
You should use the **Open With** dialog box when the user may want to select an app other than the default for a particular file. For example if your app allows the user to launch an image file, the default handler will likely be a viewer app. In some cases the user may want to edit the image instead of viewing it. Use the **Open With** option along with an alternative command in the AppBar or in a context menu to let the user bring up the **Open With** dialog and select the editor app in these types of scenarios.

> [!IMPORTANT]
> This property is only implemented on Desktop devices.

## -examples

See the code example in the [LaunchUriAsync(Uri, LauncherOptions)](launcher_launchfileasync_1480137410.md) topic.

## -see-also
[Association launching sample](https://go.microsoft.com/fwlink/p/?linkid=231484), [How to launch the default app for a file (JavaScript)](https://msdn.microsoft.com/library/876edae5-f1a8-45f9-a1a6-50efb1025f96), [Launch the default app for a file](https://msdn.microsoft.com/library/bb45fcaf-df93-4c99-a8b5-59b799c7bd98), [How to launch the default app for a URI (JavaScript)](https://msdn.microsoft.com/library/0f9fa8db-3e51-4cf8-879d-2b79a8ddbb7d), [Launch the default app for a URI](https://msdn.microsoft.com/library/7b0d0af5-d89e-4db0-9b79-90201d79974f), [Guidelines for file types and URIs](https://msdn.microsoft.com/library/a6653b8f-763f-4d67-9d12-6af73a673bc5), [Launcher.LaunchFileAsync(IStorageFile, LauncherOptions)](launcher_launchfileasync_1480137410.md), [Launcher.LaunchUriAsync(Uri, LauncherOptions)](launcher_launchuriasync_68890748.md)
