---
-api-id: T:Windows.System.RemoteDesktop.Input.RemoteTextConnectionDataHandler
-api-type: winrt delegate
---

# Windows.System.RemoteDesktop.Input.RemoteTextConnectionDataHandler

<!--
public delegate bool RemoteTextConnectionDataHandler(byte[] pduData);
-->


## -description

Represents a method that receives a data packet from the text input system on the local (client) computer.

## -parameters

### -param pduData

A memory buffer containing a data packet that conforms to the RDP text input virtualization protocol.

## -returns

## -remarks

When this method is invoked, the Remote Desktop client application should forward the data packet to the appropriate remote computer over the `TextInput_ClientToServerDVC` [Dynamic Virtual Channel (DVC)](/windows/win32/termserv/dynamic-virtual-channels).

The Remote Desktop client application should create an instance of this delegate for each remote session it connects to. Each delegate instance should be passed to the [constructor](remotetextconnection_remotetextconnection_1474280690.md) of the [RemoteTextConnection](remotetextconnection.md) object that represents the corresponding remote connection.

## -see-also

## -examples