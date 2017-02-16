---
-api-id: T:Windows.UI.Core.CoreWindowResizeManager
-api-type: winrt class
---

<!-- Class syntax.
public class CoreWindowResizeManager : Windows.UI.Core.ICoreWindowResizeManager, Windows.UI.Core.ICoreWindowResizeManagerLayoutCapability
-->

# Windows.UI.Core.CoreWindowResizeManager

## -description
Defines a type used to manage [CoreWindow.SizeChanged](corewindow_sizechanged.md) events.

## -remarks
When [CoreWindow-&gt;SizeChanged](corewindow_sizechanged.md) is fired, call the static [CoreWindowResizeManager::GetForCurrentView](corewindowresizemanager_getforcurrentview.md) method to obtain an instance of this type for the current [CoreWindow](corewindow.md).



```cpp

if (m_windowSizeChangeInProgress)
{
 // A window size change has been initiated and the app has just completed presenting
 // the first frame with the new size. Notify the resize manager so we can abbreviate
 // any resize animation and prevent unnecessary delays.
 CoreWindowResizeManager::GetForCurrentView()->NotifyLayoutCompleted();
 m_windowSizeChangeInProgress = false;
}
```



## -examples

## -see-also
