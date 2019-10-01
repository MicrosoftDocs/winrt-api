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
You should use this method only with a version of Windows with build number 18362.267, or later. The Windows 10 May 2019 Update (version 1903) has build number 18362; then, an update on July 27 2019 revised that build number to 18362.267. In build numbers prior to 18362.267, this method returns an error code, but does not add a profile.

## -examples

## -see-also

## -capabilities
networkingVpnProvider
