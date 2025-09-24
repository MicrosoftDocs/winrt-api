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
Provides information about the authentication and encryption settings for a network connection, particularly relevant for 
wireless networks where security configuration varies.

## -remarks
[NetworkSecuritySettings](networksecuritysettings.md) objects are obtained from the 
[NetworkSecuritySettings](connectionprofile_networksecuritysettings.md) property of a [ConnectionProfile](connectionprofile.md). 
This class provides detailed information about the security protocols used for the network connection.

### Security properties

The [NetworkSecuritySettings](networksecuritysettings.md) class provides two key properties:

- [NetworkAuthenticationType](networksecuritysettings_networkauthenticationtype.md): The authentication method used 
  (None, Open 802.11, WPA, WPA2, WPA3, etc.)
- [NetworkEncryptionType](networksecuritysettings_networkencryptiontype.md): The encryption protocol used 
  (None, WEP, TKIP, CCMP, etc.)

### Wireless security considerations

[!IMPORTANT]
Security settings are most relevant for wireless connections where authentication and encryption are configurable. 
Wired Ethernet connections typically report "None" for both authentication and encryption types, as security is handled 
at different network layers.

### Authentication and encryption types

Wireless networks use various authentication and encryption combinations:
- Authentication types include Open, WPA-PSK, WPA2-PSK (RSNA-PSK), WPA3-SAE, and enterprise variants
- Encryption types include None, WEP, TKIP, CCMP, and GCMP variants
- The combination determines the overall security configuration of the network

## -examples

### Implementing security-based application policies

```csharp
using Windows.Networking.Connectivity;

private void EvaluateNetworkSecurityPolicy()
{
    var internetProfile = NetworkInformation.GetInternetConnectionProfile();
    var securitySettings = internetProfile?.NetworkSecuritySettings;
    
    if (securitySettings == null)
    {
        // No network security information available
        DisableSensitiveOperations();
        return;
    }
    
    // Evaluate security strength for application policy decisions
    bool isSecureConnection = IsConnectionSecure(securitySettings);
    bool allowSensitiveData = ShouldAllowSensitiveData(securitySettings);
    
    if (isSecureConnection && allowSensitiveData)
    {
        EnableFullFunctionality();
    }
    else if (isSecureConnection)
    {
        EnableBasicFunctionality();
        WarnAboutLimitedSecurity();
    }
    else
    {
        EnableMinimalFunctionality();
        RequireAdditionalAuthentication();
    }
    
    // Monitor for security changes
    NetworkInformation.NetworkStatusChanged += OnNetworkSecurityChanged;
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

// App-specific policy implementations
private void EnableFullFunctionality() { /* App-specific: enable all features */ }
private void EnableBasicFunctionality() { /* App-specific: enable core features only */ }
private void EnableMinimalFunctionality() { /* App-specific: minimal offline-capable features */ }
private void DisableSensitiveOperations() { /* App-specific: disable data transmission */ }
private void WarnAboutLimitedSecurity() { /* App-specific: show security warning */ }
private void RequireAdditionalAuthentication() { /* App-specific: prompt for additional auth */ }
```
```

## -see-also
[ConnectionProfile.NetworkSecuritySettings](connectionprofile_networksecuritysettings.md),
[NetworkAuthenticationType](networkauthenticationtype.md),
[NetworkEncryptionType](networkencryptiontype.md),
[ConnectionProfile](connectionprofile.md)
