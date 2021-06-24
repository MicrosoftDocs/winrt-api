---
-api-id: M:Windows.System.RemoteDesktop.Input.RemoteTextConnection.ReportDataReceived(System.Byte[])
-api-type: winrt method
---

# Windows.System.RemoteDesktop.Input.RemoteTextConnection.ReportDataReceived(System.Byte[])

<!--
public void ReportDataReceived (byte[] pduData);
-->


## -description

Forwards a data packet received over the `TextInput_ServerToClientDVC` [Dynamic Virtual Channel (DVC)](/windows/win32/termserv/dynamic-virtual-channels) to the local machine’s text input service.

## -parameters

### -param pduData

A memory buffer containing a data packet received over the `TextInput_ServerToClientDVC` DVC. The data packet conforms to the RDP text input virtualization protocol.

## -remarks

## -see-also

## -examples


