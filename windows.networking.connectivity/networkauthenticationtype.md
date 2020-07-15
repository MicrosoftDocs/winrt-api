---
-api-id: T:Windows.Networking.Connectivity.NetworkAuthenticationType
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax
public enum Windows.Networking.Connectivity.NetworkAuthenticationType : int
-->

# NetworkAuthenticationType

## -description
Defines values that indicate the type of authentication used by the network.

## -enum-fields
### -field None:0
No authentication enabled.

### -field Unknown:1
Authentication method unknown.

### -field Open80211:2
Open authentication over 802.11 wireless. Devices are authenticated and can connect to an access point, but communication with the network requires a matching Wired Equivalent Privacy (WEP) key.

### -field SharedKey80211:3
Specifies an IEEE 802.11 Shared Key authentication algorithm that requires the use of a pre-shared Wired Equivalent Privacy (WEP) key for the 802.11 authentication.

### -field Wpa:4
Specifies a Wi-Fi Protected Access (WPA) algorithm. IEEE 802.1X port authorization is performed by the supplicant, authenticator, and authentication server. Cipher keys are dynamically derived through the authentication process.

### -field WpaPsk:5
Specifies a Wi-Fi Protected Access (WPA) algorithm that uses pre-shared keys (PSK). IEEE 802.1X port authorization is performed by the supplicant and authenticator. Cipher keys are dynamically derived through a pre-shared key that is used on both the supplicant and authenticator.

### -field WpaNone:6
Wi-Fi Protected Access.

### -field Rsna:7
Specifies an IEEE 802.11i Robust Security Network Association (RSNA) algorithm. IEEE 802.1X port authorization is performed by the supplicant, authenticator, and authentication server. Cipher keys are dynamically derived through the authentication process.

### -field RsnaPsk:8
Specifies an IEEE 802.11i RSNA algorithm that uses PSK. IEEE 802.1X port authorization is performed by the supplicant and authenticator. Cipher keys are dynamically derived through a pre-shared key that is used on both the supplicant and authenticator.

### -field Ihv:9
Specifies an authentication type defined by an independent hardware vendor (IHV).

### -field Wpa3:10
Specifies a Wi-Fi Protected Access 3 (WPA3) algorithm. WPA3 is an encryption security standard for enterprise users. It offers the equivalent of 192-bit cryptographic strength, providing additional protections for networks transmitting sensitive data.

### -field Wpa3Sae:11
Specifies a Wi-Fi Protected Access 3 Simultaneous Authentication of Equals (WPA3 SAE) algorithm. WPA3 SAE is the consumer version of WPA3. Simultaneous Authentication of Equals (SAE) is a secure key establishment protocol between devices; it provides synchronous authentication, and stronger protections for users against password-guessing attempts by third parties.

### -field Owe:12
Specifies an opportunistic wireless encryption (OWE) algorithm. OWE provides opportunistic encryption over 802.11 wireless, where cipher keys are dynamically derived through a Diffie-Hellman key exchange; enabling data protection without authentication.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | Wpa3 |
| 1903 | 18362 | Wpa3Sae |
| 2004 | 19041 | Owe |

## -examples

## -see-also
[NetworkAuthenticationType (Property)](networksecuritysettings_networkauthenticationtype.md)
