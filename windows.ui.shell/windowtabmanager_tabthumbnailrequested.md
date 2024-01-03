---
-api-id: E:Windows.UI.Shell.WindowTabManager.TabThumbnailRequested
-api-type: winrt event
---

# Windows.UI.Shell.WindowTabManager.TabThumbnailRequested

<!--
public event Windows.Foundation.TypedEventHandler<Windows.UI.Shell.WindowTabManager,Windows.UI.Shell.WindowTabThumbnailRequestedEventArgs> TabThumbnailRequested;
-->

## -description

Occurs when the system shows a tab in a shell surface that displays a thumbnail view, as a signal to the app to generate a current thumbnail.

## -remarks

> [!IMPORTANT]
> This API is for Win32 desktop apps only. UWP and other app types are not supported.

The thumbnail generated in response to this event should be set as the value of the [WindowTabThumbnailRequestedEventArgs.Image](windowtabthumbnailrequestedeventargs_image.md) property. Call [WindowTab.ReportThumbnailAvailable](windowtab_reportthumbnailavailable_1990248161.md) to notify the system that the new thumbnail image is ready.

## -see-also

## -examples
