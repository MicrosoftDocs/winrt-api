---
-api-id: M:Windows.Security.Isolation.IsolatedWindowsEnvironment.PostMessageToReceiverAsync(System.Guid,Windows.Foundation.Collections.IIterable{System.Object},Windows.Security.Isolation.IsolatedWindowsEnvironmentTelemetryParameters)
-api-type: winrt method
---

# Windows.Security.Isolation.IsolatedWindowsEnvironment.PostMessageToReceiverAsync(System.Guid,Windows.Foundation.Collections.IIterable{System.Object},Windows.Security.Isolation.IsolatedWindowsEnvironmentTelemetryParameters)

<!--
public Windows.Foundation.IAsyncOperation<Windows.Security.Isolation.IsolatedWindowsEnvironmentPostMessageResult> PostMessageToReceiverAsync (Guid receiverId, System.Collections.Generic.IEnumerable<object> message, Windows.Security.Isolation.IsolatedWindowsEnvironmentTelemetryParameters telemetryParameters);
-->

## -description

**Deprecated.** Post a message from the host to the receiver that is registered on the Isolated Windows Environment side and correlate with telemetry events.

## -parameters

### -param receiverId

GUID for message receiver.

### -param message

IIterable

### -param telemetryParameters

Telemetry parameters defined by [isolatedwindowsenvironmenttelemetryparameters](isolatedwindowsenvironmenttelemetryparameters.md)

## -returns

[IsolatedWindowsEnvironmentPostMessageResult](isolatedwindowsenvironmentpostmessageresult.md)

## -remarks

> [!WARNING]
> This is a deprecated API.

## -see-also

[PostMessageToReceiverAsync](isolatedwindowsenvironment_postmessagetoreceiverasync_1987579471.md)

## -examples
