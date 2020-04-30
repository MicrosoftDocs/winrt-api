---
-api-id: T:Windows.UI.Core.CoreWindowResizeManager
-api-type: winrt class
---

<!-- Class syntax.
public class CoreWindowResizeManager : Windows.UI.Core.ICoreWindowResizeManager, Windows.UI.Core.ICoreWindowResizeManagerLayoutCapability
-->

# Windows.UI.Core.CoreWindowResizeManager

## -description
Defines a type used to manage [CoreWindow.SizeChanged](corewindow_sizechanged.md) events. This type is used by frameworks (such as XAML) or apps that implement their own IFrameWorkView to synchronize the handover between shell drawn placholder (such as a splash screen) and the apps first drawn frame, so that there is no gap in the transition from one to the other. If your app does not implement the IFrameWorkView itself you should not participate in this synchronization as the framework will do it for you.

## -remarks
When [CoreWindow.SizeChanged](corewindow_sizechanged.md) is fired, call the static [CoreWindowResizeManager.GetForCurrentView](corewindowresizemanager_getforcurrentview_1363600702.md) method to obtain an instance of this type for the current [CoreWindow](corewindow.md).

```cppwinrt
if (m_windowSizeChangeInProgress)
{
    // A window size change has been initiated and the app has just completed presenting
    // the first frame with the new size. Notify the resize manager so that we can abbreviate
    // any resize animation and prevent unnecessary delays.
    Windows::UI::Core::CoreWindowResizeManager::GetForCurrentView().NotifyLayoutCompleted();
    m_windowSizeChangeInProgress = false;
}
```

```cppcx
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
