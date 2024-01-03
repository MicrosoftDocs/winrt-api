---
-api-id: E:Windows.UI.Shell.WindowTabManager.TabTearOutRequested
-api-type: winrt event
---

# Windows.UI.Shell.WindowTabManager.TabTearOutRequested

<!--
public event Windows.Foundation.TypedEventHandler<Windows.UI.Shell.WindowTabManager,Windows.UI.Shell.WindowTabTearOutRequestedEventArgs> TabTearOutRequested;
-->

## -description

Occurs when the system shell requests a separate window for a specific tab.

## -remarks

> [!IMPORTANT]
> This API is for Win32 desktop apps only. UWP and other app types are not supported.

A tab tear out request can happen when tabs show in the Snap Assist tool and the user chooses to have a specific tab snapped in a different window.

Not all versions of Windows support the scenarios that raise this event, so call [IsTabTearOutSupported](windowtabmanager_istabtearoutsupported_716001682.md) before subscribing to the `TabTearOutRequested` event and subscribe only if it returns `true`.

If your app does not support tab tear out, its tabs will not show in Snap Assist.

## -see-also

## -examples

```cppwinrt
if (WindowTabManager::IsTabTearOutSupported())
{
    m_tabTearOutRequestedRevoker = m_tabManager.TabTearOutRequested(winrt::auto_revoke, { this, &MainWindow::TabTearOutRequested });
}
```
