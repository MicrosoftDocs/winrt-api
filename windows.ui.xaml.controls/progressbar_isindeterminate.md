---
-api-id: P:Windows.UI.Xaml.Controls.ProgressBar.IsIndeterminate
-api-type: winrt property
---

<!-- Property syntax
public bool IsIndeterminate { get;  set; }
-->

# Windows.UI.Xaml.Controls.ProgressBar.IsIndeterminate

## -description
Gets or sets a value that indicates whether the progress bar reports generic progress with a repeating pattern or reports progress based on the [Value](../windows.ui.xaml.controls.primitives/rangebase_value.md) property.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.ProgressBar.IsIndeterminate](/windows/winui/api/microsoft.ui.xaml.controls.progressbar.isindeterminate) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<ProgressBar IsIndeterminate="bool"/>
```


## -property-value
**True** if the progress bar reports generic progress with a repeating pattern; **false** if the progress bar reports progress based on the [Value](../windows.ui.xaml.controls.primitives/rangebase_value.md) property. The default is **false**.

## -remarks

### Notes for previous versions

> **Windows 8.x**
> In an app compiled for Windows 8, when the [ProgressBar](progressbar.md) is indeterminate, the progress animation continues even if it's not visible on the screen, such as when the [ProgressBar](progressbar.md)  [Visibility](../windows.ui.xaml/uielement_visibility.md) is collapsed. This can keep the UI thread awake, use resources, and impair app performance. When the [ProgressBar](progressbar.md) is not visible, you should disable the animation by setting IsIndeterminate to **false**.



## -examples

## -see-also
