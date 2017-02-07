---
-api-id: T:Windows.Networking.Connectivity.NetworkAuthenticationType
-api-type: winrt enum
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


## -remarks

## -examples

## -see-also
[NetworkAuthenticationType (Property)](networksecuritysettings_networkauthenticationtype.md)