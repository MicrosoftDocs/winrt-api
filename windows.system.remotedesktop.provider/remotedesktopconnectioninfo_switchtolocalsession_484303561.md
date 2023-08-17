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

The remote desktop provider's remote host app informs the local host app that the user has requested to switch to the local session over a network channel. When that request is received, the local host calls **SwitchToLocalSession** to notify the OS of the request.

## -see-also

## -examples


