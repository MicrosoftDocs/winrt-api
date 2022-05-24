---
-api-id: M:Windows.UI.UIAutomation.Core.RemoteAutomationServer.ReportSession(System.Guid)
-api-type: winrt method
---

# Windows.UI.UIAutomation.Core.RemoteAutomationServer.ReportSession(System.Guid)

<!--
public static void ReportSession (Guid sessionId);
-->

## -description

Initiates the server (remote) side of a connection between a local client and a remote provider.

## -parameters

### -param sessionId

The unique identifier for the session.

This should be the same identifer as the corresponding client session was initialized with.

## -remarks

The server session can be initialized 'lazily'—when the remote client app first detects an attempt to access its UI (for example, receives the WM_GETOBJECT window message or the [AutomationProviderRequested](../windows.ui.core/corewindow_automationproviderrequested.md) event), it can send a protocol-appropriate message to the server, which invokes this method.

It doesn't matter which side is ready to connect first. Each side of the connection will wait (with a timeout) for the other to complete the connection.

## -see-also

## -examples
