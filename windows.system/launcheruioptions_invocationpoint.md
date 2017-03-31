---
-api-id: P:Windows.System.LauncherUIOptions.InvocationPoint
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.Point> InvocationPoint { get;  set; }
-->

# Windows.System.LauncherUIOptions.InvocationPoint

## -description
Gets or sets the point on the screen where the user opened a file or URI.

## -property-value
The invocation point.

## -remarks
To get or set the selection rectangle, use the [SelectionRect](launcheruioptions_selectionrect.md) method.



> [!IMPORTANT]
> This property is only implemented on Desktop devices.

## -examples

## -see-also
[Association launching sample](http://go.microsoft.com/fwlink/p/?linkid=231484), [How to launch the default app for a file (JavaScript)](http://msdn.microsoft.com/library/876edae5-f1a8-45f9-a1a6-50efb1025f96), [Launch the default app for a file](http://msdn.microsoft.com/library/bb45fcaf-df93-4c99-a8b5-59b799c7bd98), [How to launch the default app for a URI (JavaScript)](http://msdn.microsoft.com/library/0f9fa8db-3e51-4cf8-879d-2b79a8ddbb7d), [Launch the default app for a URI](http://msdn.microsoft.com/library/7b0d0af5-d89e-4db0-9b79-90201d79974f), [Guidelines for file types and URIs](http://msdn.microsoft.com/library/a6653b8f-763f-4d67-9d12-6af73a673bc5), [Launcher.LaunchFileAsync(IStorageFile, LauncherOptions)](launcher_launchfileasync_1480137410.md), [Launcher.LaunchUriAsync(Uri, LauncherOptions)](launcher_launchuriasync_68890748.md)