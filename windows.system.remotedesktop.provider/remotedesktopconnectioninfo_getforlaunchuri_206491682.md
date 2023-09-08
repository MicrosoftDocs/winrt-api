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

The *launchUri* is the URI used in the local PC’s shell to launch the client app. The client app should pass this URI to the remote desktop client app which will in turn call [GetForLaunchUri](xref:Windows.System.RemoteDesktop.Provider.RemoteDesktopConnectionRemoteInfo.GetForLaunchUri(Windows.Foundation.Uri) passing this launchUri as the parameter.

Remote desktop provider apps are launched by the OS through URI schemes with the following syntax.

`ms-remotedesktop:switch? remoteDesktopId={remote desktop Id}&correlationId={correlation Id}& supportBluetoothSettings=false`

Remote desktop client apps must subscribe to the `ms-remotedesktop` URI scheme to enable launching Cloud PCs using FastSwitch.

`ms-remotedesktop-launch:?supportBluetoothSettings ={true if local PC supports Bluetooth settings page} &correlationId={correlation Id}`

Remote desktop client apps must subscribe to the `ms-remotedesktop-launch` Uri scheme if they want to launch Cloud PCs using Boot to Cloud.

## -see-also

## -examples


