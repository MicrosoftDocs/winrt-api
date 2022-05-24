---
-api-id: M:Windows.System.RemoteDesktop.Input.RemoteTextConnection.#ctor(System.Guid,Windows.System.RemoteDesktop.Input.RemoteTextConnectionDataHandler)
-api-type: winrt constructor
---

# Windows.System.RemoteDesktop.Input.RemoteTextConnection.#ctor(System.Guid,Windows.System.RemoteDesktop.Input.RemoteTextConnectionDataHandler)

<!--
public RemoteTextConnection (Guid connectionId, Windows.System.RemoteDesktop.Input.RemoteTextConnectionDataHandler pduForwarder);
-->


## -description

Creates a new instance of the [RemoteTextConnection](remotetextconnection.md) class specific to one remote session.

## -parameters

### -param connectionId

Uniquely identifies a single remote session that the client application has connected to. The value only needs to be unique on the local system. The client will typically create this identifier using [CoCreateGuid](/windows/win32/api/combaseapi/nf-combaseapi-cocreateguid).

### -param pduForwarder

Specifies a delegate that will be called back when the client machine text input system needs to send a message to a target on the remote machine.

## -remarks

## -see-also

## -examples


