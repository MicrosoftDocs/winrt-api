---
-api-id: T:Windows.Networking.Connectivity.WwanNetworkIPKind
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum WwanNetworkIPKind : int 
-->

# Windows.Networking.Connectivity.WwanNetworkIPKind

## -description
Defines constants that describe a level of supported IP. The values reflect the [WWAN_IP_TYPE](/windows-hardware/drivers/ddi/content/wwan/ne-wwan-_wwan_ip_type) enumeration. You can use these values to determine which cellular profile to use (for example, to choose between IMS and SUPL).

## -enum-fields
### -field None:0
Default support; indicates no specific level of support.

### -field Ipv4:1
Indicates support for IPv4.

### -field Ipv6:2
Indicates support for IPv6.

### -field Ipv4v6:3
Indicates support for IPv4 with IPv6.

### -field Ipv4v6v4Xlat:4
Indicates support for 464XLAT (which allows clients on IPv6-only networks to access IPv4-only Internet services).

## -remarks

## -see-also
[WwanConnectionProfileDetails.IPKind](wwanconnectionprofiledetails_ipkind.md)

## -examples
