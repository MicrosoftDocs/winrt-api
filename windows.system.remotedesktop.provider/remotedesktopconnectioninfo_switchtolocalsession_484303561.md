---
-api-id: M:Windows.System.RemoteDesktop.Provider.RemoteDesktopConnectionInfo.SwitchToLocalSession
-api-type: winrt method
---

# Windows.System.RemoteDesktop.Provider.RemoteDesktopConnectionInfo.SwitchToLocalSession

<!--
public void SwitchToLocalSession ();
-->


## -description

Notifies the OS that the user has requested to switch to the local session.

## -remarks

The remote desktop provider's remote desktop host service informs the remote desktop client app that the user has requested to switch to the local session over a network channel. When that request is received, the remote desktop client app calls **SwitchToLocalSession** to notify the OS of the request.

## -see-also

## -examples


