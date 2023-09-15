---
-api-id: E:Windows.System.RemoteDesktop.Provider.RemoteDesktopConnectionRemoteInfo.PerformLocalActionRequested
-api-type: winrt event
---

# Windows.System.RemoteDesktop.Provider.RemoteDesktopConnectionRemoteInfo.PerformLocalActionRequested

<!--
public event Windows.Foundation.TypedEventHandler<Windows.System.RemoteDesktop.Provider.RemoteDesktopConnectionRemoteInfo,Windows.System.RemoteDesktop.Provider.PerformLocalActionRequestedEventArgs> PerformLocalActionRequested;
-->


## -description

Raised when there is a request for the app to perform a local action on the remote desktop.

## -remarks

Remote Desktop client apps must invoke the Uri `ms-settings:devices?launchedFromRemoteSession=1` on the local PC to launch Local PC Bluetooth settings when the remote shell triggers a call to do so via the **PerformLocalActionRequested** event. This occurs when user clicks on **Bluetooth** button in **Quick Actions** or in the Settings app on the Windows 365 Cloud PC.

## -see-also

## -examples


