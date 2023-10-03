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

The launch URI used by the shell to launch the remote desktop client app, with information about the remote desktop session.

### -param windowId

The [WindowId](/windows/windows-app-sdk/api/winrt/microsoft.ui.windowid) of the window that will represent the remote desktop.

## -returns

A **RemoteDesktopConnectionInfo** associated with the remote desktop connection.

## -remarks

This call is made by the remote desktop client app running on the local desktop. 

The provider app completes the launch handshake by passing the launch protocol string to **GetForLaunchUri**.


### Launch URIs

The *launchUri* is used to launch the remote desktop client app. Example URI format:

`ms-remotedesktop:switch?remoteDesktopId={remote desktop Id}&correlationId={correlation Id}&supportBluetoothSettings=false`

Remote desktop client apps must register to handle the `ms-remotedesktop-launch` URI scheme to enable launching Windows 365 Cloud PCs using Windows 365 Switch. Example URI format:

`ms-remotedesktop-launch:?supportBluetoothSettings={true if local PC supports Bluetooth settings page}&correlationId={correlation Id}`

Remote desktop client apps must register to handle the `ms-remotedesktop-launch` Uri scheme if they want to launch Windows 365 Cloud PCs using Windows 365 Boot.

## -see-also

## -examples


