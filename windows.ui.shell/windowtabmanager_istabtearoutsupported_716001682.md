---
-api-id: M:Windows.UI.Shell.WindowTabManager.IsTabTearOutSupported
-api-type: winrt method
---

# Windows.UI.Shell.WindowTabManager.IsTabTearOutSupported

<!--
public static bool IsTabTearOutSupported ();
-->

## -description

Gets a value that indicates whether the current system shell supports tearing a tab out into a separate window.

## -returns

`true` if the current system shell supports tearing a tab out into a separate window; otherwise, `false`.

## -remarks

> [!IMPORTANT]
> This API is for Win32 desktop apps only. UWP and other app types are not supported.

Call `IsTabTearOutSupported` before subscribing to the [TabTearOutRequested](windowtabmanager_tabtearoutrequested.md) event and subscribe only if it returns `true`.

This method indicates only whether the system supports surfaces that can request tab tear out, such as Snap Assist. If your app does not support tab tear out, its tabs will not show in Snap Assist.

## -see-also

## -examples

```cppwinrt
if (WindowTabManager::IsTabTearOutSupported())
{
    m_tabTearOutRequestedRevoker = m_tabManager.TabTearOutRequested(winrt::auto_revoke, { this, &MainWindow::TabTearOutRequested });
}
```
