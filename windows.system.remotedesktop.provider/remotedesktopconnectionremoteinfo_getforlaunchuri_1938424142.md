---
-api-id: M:Windows.System.RemoteDesktop.Provider.RemoteDesktopConnectionRemoteInfo.GetForLaunchUri(Windows.Foundation.Uri)
-api-type: winrt method
---

# Windows.System.RemoteDesktop.Provider.RemoteDesktopConnectionRemoteInfo.GetForLaunchUri(Windows.Foundation.Uri)

<!--
public static Windows.System.RemoteDesktop.Provider.RemoteDesktopConnectionRemoteInfo GetForLaunchUri (System.Uri launchUri);
-->


## -description

Retrieves a [RemoteDesktopConnectionRemoteInfo](xref:Windows.System.RemoteDesktop.Provider.RemoteDesktopConnectionRemoteInfo) associated with a remote desktop connection

## -parameters

### -param launchUri

The launch URI containing information about the remote desktop session. This URI is passed over a network connection from the remote desktop client running on the local machine to the host service running on the remote machine.

## -returns

A **RemoteDesktopConnectionRemoteInfo** associated with the remote desktop connection.

## -remarks

This call is made by the remote desktop host service running on the remote desktop.

## -see-also

## -examples


