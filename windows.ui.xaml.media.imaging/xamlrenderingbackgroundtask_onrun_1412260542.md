---
-api-id: M:Windows.UI.Xaml.Media.Imaging.XamlRenderingBackgroundTask.OnRun(Windows.ApplicationModel.Background.IBackgroundTaskInstance)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnRun(Windows.ApplicationModel.Background.IBackgroundTaskInstance taskInstance)
-->

# Windows.UI.Xaml.Media.Imaging.XamlRenderingBackgroundTask.OnRun

## -description
Performs the work of the background task. The system calls this method when the associated background task has been triggered.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Media.Imaging.XamlRenderingBackgroundTask.OnRun](/windows/winui/api/microsoft.ui.xaml.media.imaging.xamlrenderingbackgroundtask.onrun) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param taskInstance
An interface to an instance of the background task. The system creates this instance when the task has been triggered to run.

## -remarks
> [!IMPORTANT]
> To keep the memory footprint of the background task as low as possible, this task should be implemented in a C++ Windows Runtime Component for Windows Phone. The memory footprint will be higher if written in C# and will cause out of memory exceptions on low-memory devices which will terminate the background task. For more information on memory constraints, see [Support your app with background tasks](/windows/uwp/launch-resume/support-your-app-with-background-tasks).

## -examples

## -see-also
