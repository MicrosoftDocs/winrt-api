---
-api-id: E:Windows.UI.Core.Preview.SystemNavigationManagerPreview.CloseRequested
-api-type: winrt event
---

<!-- Event syntax.
public event EventHandler CloseRequested<SystemNavigationCloseRequestedPreviewEventArgs>
-->

# Windows.UI.Core.Preview.SystemNavigationManagerPreview.CloseRequested

## -description

Occurs when the user invokes the system button for close (the 'x' button in the corner of the app's title bar).

## -remarks
ClosedRequested events will not be raised for windows that are non-visible. For example an application window that is minimised but not suspended (multi-window, or with an active extended execution request) will not be closed or receive this event until the window is made visible by the user. Also in [Tablet mode (Windows 10 only)](/windows-hardware/design/device-experiences/continuum) the event will not be raised and the window will be closed when the user drags the window to the bottom of the screen. In all cases apps are expected to save user data when the app receives a suspend notification in case it never is woken again to save data.

The app must possess the  `confirmAppClose` capability in order to receive this event. An app without the capability can register for the event, but the handler will not be called.

## -see-also

## -capabilities
confirmAppClose

## -examples

