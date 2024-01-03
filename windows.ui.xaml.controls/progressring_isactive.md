---
-api-id: P:Windows.UI.Xaml.Controls.ProgressRing.IsActive
-api-type: winrt property
---

<!-- Property syntax
public bool IsActive { get;  set; }
-->

# Windows.UI.Xaml.Controls.ProgressRing.IsActive

## -description
Gets or sets a value that indicates whether the [ProgressRing](progressring.md) is showing progress.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.ProgressRing.IsActive](/windows/winui/api/microsoft.ui.xaml.controls.progressring.isactive) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<ProgressRing IsActive="bool" />
```


## -property-value
**True** if the [ProgressRing](progressring.md) is showing progress; otherwise, **false**. The default is **false**.

## -remarks
Set the IsActive property to turn the [ProgressRing](progressring.md) on or off. If IsActive is false, the [ProgressRing](progressring.md) is not shown, but space is reserved for it in the UI layout. To not reserve space for the [ProgressRing](progressring.md), set its [Visibility](../windows.ui.xaml/uielement_visibility.md) property to [Collapsed](../windows.ui.xaml/visibility.md).

### Notes for previous versions

> **Windows 8.x**
> In an app compiled for Windows 8, when the [ProgressRing](progressring.md) is active, the progress animation continues even if its not visible on the screen, such as when its [Visibility](../windows.ui.xaml/uielement_visibility.md) is [Collapsed](../windows.ui.xaml/visibility.md). This can keep the UI thread awake, use resources, and impair app performance. When the [ProgressRing](progressring.md) is not visible, you should disable the animation by setting IsActive to **false**.

## -examples

## -see-also
