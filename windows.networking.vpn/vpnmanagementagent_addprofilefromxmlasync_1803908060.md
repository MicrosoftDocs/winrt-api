---
-api-id: M:Windows.Networking.Vpn.VpnManagementAgent.AddProfileFromXmlAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.Vpn.VpnManagementErrorStatus> AddProfileFromXmlAsync(System.String xml)
-->

# Windows.Networking.Vpn.VpnManagementAgent.AddProfileFromXmlAsync

## -description
Creates a new VPN connection based on a ProfileXML-encoded string (see [ProfileXML XSD](/windows/client-management/mdm/vpnv2-profile-xsd)).

## -parameters

### -param xml
A **VpnProfile** object.

## -returns
An enum value indicating the error status.

## -remarks
This method should only be used with versions of Windows as of the July 27 2019 update to the Windows 10 May 2019 Update. In prior versions of Windows, this method would simply return an error code and not add a profile.

## -examples

## -see-also

## -capabilities
networkingVpnProvider
