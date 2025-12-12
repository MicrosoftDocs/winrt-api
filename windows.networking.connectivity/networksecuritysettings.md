---
-api-id: T:Windows.Networking.Connectivity.NetworkSecuritySettings
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class NetworkSecuritySettings : Windows.Networking.Connectivity.INetworkSecuritySettings
-->

# Windows.Networking.Connectivity.NetworkSecuritySettings

## -description
Exposes the authentication and encryption types applied to a connection (primarily meaningful for Wi-Fi and other wireless links).

## -remarks
### Retrieval
Access via [ConnectionProfile.NetworkSecuritySettings](connectionprofile_networksecuritysettings.md).

### Properties
- [NetworkAuthenticationType](networksecuritysettings_networkauthenticationtype.md): Link-layer / Wi-Fi authentication (Open, WPA2, WPA3, enterprise, etc.).
- [NetworkEncryptionType](networksecuritysettings_networkencryptiontype.md): Data encryption algorithm (None, WEP, TKIP, CCMP, GCMP variants, etc.).

### Interpretation
| Aspect | Guidance |
| -- | -- |
| Authentication = Open / None | Treat as unsecured; restrict sensitive traffic or elevate user warnings |
| WPA/WPA2-PSK vs WPA3-SAE | Prefer WPA3-SAE where available (stronger protections against offline attacks) |
| Enterprise (802.1X) modes | Indicates credential / certificate based access (typically stronger identity assurance) |
| Encryption = TKIP or WEP | Legacy / weak; recommend upgrade (surface advisory) |
| Encryption = CCMP / GCMP | Modern strong encryption (AES) |

### Wireless vs wired
> [!IMPORTANT]
> Ethernet profiles commonly report `None` for authentication and encryption. Do not interpret this as unsafe; link-layer
> security may not apply (security enforced at higher layers: TLS, IPsec, VPN).

### Policy & compliance usage
- Enforce minimum bar (e.g., block WEP/TKIP for sensitive operations).
- Offer degraded feature set or require user consent when encountering legacy or open networks.
- Log anonymous metrics on encountered auth/encryption types to guide enterprise policy improvements.

### Best practices
- Cache briefly; re-query after network status changes (roam, reconnect).
- Combine with cost and domain authentication (for example, [ConnectionProfile.GetConnectionCost](connectionprofile_getconnectioncost_2051899034.md),
  [IsDomainAuthenticatedBy](connectionprofile_isdomainauthenticatedby_590452087.md)) for holistic trust decisions.
- Avoid hard-coding specific enum values for future extensibility. Handle unknown types conservatively.

### Common pitfalls
| Pitfall | Impact | Mitigation |
| -- | -- | -- |
| Assuming WPA2 == always strong | Miss WPA2/TKIP downgrade | Check both auth and encryption |
| Treating Open Wi-Fi as equivalent to authenticated network | Data exposure | Force TLS / limit sensitive ops |
| Long-lived cached security snapshot | Stale decisions after roam | Re-evaluate on status change events |

> [!NOTE]
> Application-layer encryption (TLS, QUIC) remains critical even on "secure" Wi-Fi; do not remove transport security requirements.





## -examples

### Implementing security-based application policies

```csharp
using Windows.Networking.Connectivity;

private bool _listeningForChanges;

private void EvaluateNetworkSecurityPolicy()
{
    var internetProfile = NetworkInformation.GetInternetConnectionProfile();
    var securitySettings = internetProfile?.NetworkSecuritySettings;
    
    if (securitySettings == null)
    {
        // App-specific: no security data available. Disable sensitive operations or defer network activity.
        return;
    }
    
    // Evaluate security strength for application policy decisions
    bool isSecureConnection = IsConnectionSecure(securitySettings);
    bool allowSensitiveData = ShouldAllowSensitiveData(securitySettings);
    
    if (isSecureConnection && allowSensitiveData)
    {
        // App-specific: enable full feature set, including background sync and sensitive workflows.
    }
    else if (isSecureConnection)
    {
        // App-specific: allow core connectivity features but gate sensitive data behind explicit consent.
    }
    else
    {
        // App-specific: switch to a minimal offline-capable experience and prompt the user to find a secure network.
    }
    
    // Monitor for security changes
    if (!_listeningForChanges)
    {
        NetworkInformation.NetworkStatusChanged += OnNetworkSecurityChanged;
        _listeningForChanges = true;
    }
}

private bool IsConnectionSecure(NetworkSecuritySettings security)
{
    // Check for strong authentication methods
    var authType = security.NetworkAuthenticationType;
    return authType == NetworkAuthenticationType.Wpa3Sae ||
           authType == NetworkAuthenticationType.RsnaPsk ||
           authType == NetworkAuthenticationType.Rsna;
}

private bool ShouldAllowSensitiveData(NetworkSecuritySettings security)
{
    // Require strong encryption for sensitive operations
    var encryptionType = security.NetworkEncryptionType;
    return encryptionType == NetworkEncryptionType.Gcmp256 ||
           encryptionType == NetworkEncryptionType.Gcmp ||
           encryptionType == NetworkEncryptionType.Ccmp;
}

private void OnNetworkSecurityChanged(object sender)
{
    // Re-evaluate security policy when network changes
    EvaluateNetworkSecurityPolicy();
}
```

## -see-also

[ConnectionProfile](connectionprofile.md),
[NetworkAuthenticationType](networkauthenticationtype.md),
[NetworkEncryptionType](networkencryptiontype.md)
