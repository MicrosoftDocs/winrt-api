---
-api-id: M:Windows.System.RemoteDesktop.Provider.RemoteDesktopConnectionInfo.GetForLaunchUri(Windows.Foundation.Uri,Windows.UI.WindowId)
-api-type: winrt method
---

# Windows.System.RemoteDesktop.Provider.RemoteDesktopConnectionInfo.GetForLaunchUri(Windows.Foundation.Uri,Windows.UI.WindowId)

<!--
public static Windows.System.RemoteDesktop.Provider.RemoteDesktopConnectionInfo GetForLaunchUri (System.Uri launchUri, Windows.UI.WindowId windowId);
-->


## -description

Retrieves a [RemoteDesktopConnectionInfo](xref:Windows.System.RemoteDesktop.Provider.RemoteDesktopConnectionInfo) associated with a remote desktop connection and registers a window with the OS to represent the remote desktop.

## -parameters

### -param launchUri

The launch URI containing the remote desktop ID and session ID for the remote desktop.

### -param windowId

The [WindowId](/windows/windows-app-sdk/api/winrt/microsoft.ui.windowid) of the window that will represent the remote desktop.

## -returns

A **RemoteDesktopConnectionInfo** associated with the remote desktop connection.

## -remarks

This call is made by the remote desktop host app running on the local desktop.

Remote desktop provider apps are launched by the OS using a URI scheme with the following syntax.

`ms-remotedesktop:switch?remoteDesktopId={ID}&sessionId={sessionID}`

The provider app completes the launch handshake by passing the launch protocol string to **GetForLaunchUri**.

## -see-also

## -examples


