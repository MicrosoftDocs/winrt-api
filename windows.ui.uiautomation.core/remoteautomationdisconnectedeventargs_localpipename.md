---
-api-id: P:Windows.UI.UIAutomation.Core.RemoteAutomationDisconnectedEventArgs.LocalPipeName
-api-type: winrt property
---

# Windows.UI.UIAutomation.Core.RemoteAutomationDisconnectedEventArgs.LocalPipeName

<!--
public string LocalPipeName { get; }
-->

## -description

Gets the full pipe path to a remote provider that is to be closed.

## -property-value

The fully-named pipe path of the [RemoteAutomationClientSession](remoteautomationclientsession.md).

## -remarks

Multiple clients can exist on the local machine and each can establish a unique connection with the remote provider, with each having a different pipe name.

## -see-also

## -examples
