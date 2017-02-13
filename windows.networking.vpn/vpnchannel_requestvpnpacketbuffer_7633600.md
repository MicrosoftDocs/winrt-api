---
-api-id: M:Windows.Networking.Vpn.VpnChannel.RequestVpnPacketBuffer(Windows.Networking.Vpn.VpnDataPathType,Windows.Networking.Vpn.VpnPacketBuffer@)
-api-type: winrt method
---

<!-- Method syntax
public void RequestVpnPacketBuffer(Windows.Networking.Vpn.VpnDataPathType type, Windows.Networking.Vpn.VpnPacketBuffer vpnPacketBuffer)
-->

# Windows.Networking.Vpn.VpnChannel.RequestVpnPacketBuffer

## -description
Not supported. Requests a **IVpnPacketBuffer** from the specified pool. There is one **IVpnPacketBuffer** for the send path and another **IVpnPacketBuffer** for the receive path

## -parameters
### -param type
An enum value indicating which buffer pool to pick a buffer from. If the buffer requested for the packet to be sent to the VPN server, pick the Send enum type. If the buffer requested is for a received L3 decapsulated packet ready to be injected into the client network stack, pick the Receive enum type.

### -param vpnPacketBuffer
A **IVpnPacketBuffer** object returned from the specified buffer pool.

## -remarks
If the function succeeds, the return value is **S_OK**, otherwise the function will return an error hresult value describing the specific failure. If the plug-in is not connected, the error will be **E_ACCESSDENIED**.If there is no more memory available the method will return **E_OUTOFMEMORY**.

> [!NOTE]
> Any call to this API outside of a connected VPN plug-in will fail, as activity and interactions between the VPN plug-in and the system are controlled by the VPN profile. There can only be one VPN profile per process because the VPN plug-in only has one VPN profile mapped to it, and if a caller were to create more than one profile object, they would all refer to the same settings.

## -examples

## -see-also


## -capabilities
networkingVpnProvider