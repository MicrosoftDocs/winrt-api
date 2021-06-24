---
-api-id: T:Windows.UI.UIAutomation.Core.RemoteAutomationClientSession
-api-type: winrt class
---

# Windows.UI.UIAutomation.Core.RemoteAutomationClientSession

<!--
public sealed class RemoteAutomationClientSession
-->

## -description

Represents a UI Automation client session for a remote application.

## -remarks

This class is used by a host application (such as the remote desktop app running on the local machine) to plug in and implement named pipe sharing with a remote session (container or network). The host application would implement [ConnectionRequested](remoteautomationclientsession_connectionrequested.md)/[Disconnected](remoteautomationclientsession_disconnected.md) callbacks to share the named pipe, then start/stop the client session to enable/disable those callbacks.

## -see-also

[RemoteAutomationServer](remoteautomationserver.md)

## -examples
