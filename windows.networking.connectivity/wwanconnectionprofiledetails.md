---
-api-id: T:Windows.Networking.Connectivity.WwanConnectionProfileDetails
-api-type: winrt class
---

<!-- Class syntax.
public class WwanConnectionProfileDetails : Windows.Networking.Connectivity.IWwanConnectionProfileDetails
-->

# Windows.Networking.Connectivity.WwanConnectionProfileDetails

## -description
Provides access to detailed information specific to WWAN (Wireless Wide Area Network) cellular connections, including carrier 
details, registration state, and data class capabilities.

## -remarks
[WwanConnectionProfileDetails](wwanconnectionprofiledetails.md) is obtained from the 
[WwanConnectionProfileDetails](connectionprofile_wwanconnectionprofiledetails.md) property of a 
[ConnectionProfile](connectionprofile.md) when [IsWwanConnectionProfile](connectionprofile_iswwanconnectionprofile.md) 
returns `true`. This class provides cellular-specific information that is not available for other connection types.

### Cellular connection information

The [WwanConnectionProfileDetails](wwanconnectionprofiledetails.md) class provides several key properties:

**Carrier identification:**
- [HomeProviderId](wwanconnectionprofiledetails_homeproviderid.md): Mobile Country Code (MCC) and Mobile Network Code (MNC) 
  combination that identifies the home carrier
- [AccessPointName](wwanconnectionprofiledetails_accesspointname.md): The APN used for the current connection

**Connection status and capabilities:**
- [GetNetworkRegistrationState](wwanconnectionprofiledetails_getnetworkregistrationstate_117061146.md): Current registration 
  state with the cellular network
- [GetCurrentDataClass](wwanconnectionprofiledetails_getcurrentdataclass_1355956130.md): Current cellular data technology 
  (3G, LTE, 5G, etc.)

**Advanced features (Windows 10 version 1803 and later):**
- [IPKind](wwanconnectionprofiledetails_ipkind.md): IP protocol version configuration (IPv4, IPv6, dual-stack)
- [PurposeGuids](wwanconnectionprofiledetails_purposeguids.md): Collection of GUIDs indicating the intended purpose of 
  the connection profile

### Registration states

The [GetNetworkRegistrationState](wwanconnectionprofiledetails_getnetworkregistrationstate_117061146.md) method returns 
values that indicate the cellular network registration status:

- **Home**: Registered on the home network
- **Roaming**: Registered on a roaming network  
- **Partner**: Registered on a preferred roaming partner network
- **Searching**: Actively searching for available networks
- **Denied**: Registration denied by the network
- **None**: Not registered or no cellular capability

### Data class capabilities

The [GetCurrentDataClass](wwanconnectionprofiledetails_getcurrentdataclass_1355956130.md) method returns flags indicating 
the current cellular technology:

- **5G**: NewRadioNonStandalone, NewRadioStandalone (Windows 10 version 1903 and later)
- **4G/LTE**: LteAdvanced
- **3G**: Umts, Hsdpa, Hsupa
- **2G**: Gprs, Edge
- **CDMA**: Various CDMA technologies

[!NOTE]
The data class returned represents the currently active technology, which may differ from the maximum capability of the 
cellular radio or network coverage area.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | IPKind |
| 1803 | 17134 | PurposeGuids |

## -examples

## -see-also
[ConnectionProfile.WwanConnectionProfileDetails](connectionprofile_wwanconnectionprofiledetails.md),
[ConnectionProfile.IsWwanConnectionProfile](connectionprofile_iswwanconnectionprofile.md),
[WwanNetworkRegistrationState](wwannetworkregistrationstate.md),
[WwanDataClass](wwandataclass.md),
[WwanNetworkIPKind](wwannetworkipkind.md),
[NetworkInformation](networkinformation.md)