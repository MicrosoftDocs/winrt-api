---
-api-id: T:Windows.Networking.Connectivity.DomainAuthenticationKind
-api-type: winrt enum
---

# Windows.Networking.Connectivity.DomainAuthenticationKind

<!--
public enum DomainAuthenticationKind
-->

## -description
Specifies the enterprise domain authentication mechanism (if any) associated with a network connection profile. Only one non-**None** value is reported at a time (precedence applies).

## -enum-fields

### -field None: 0

Specifies no domain authentication method; and/or that the network couldn't be domain-authenticated.

### -field Ldap: 1

Specifies the domain authentication method for an Active Directory network; and/or that the machine was successful in a Lightweight Directory Access Protocol (LDAP) authentication request against the configured Active Directory servers on the current network.

### -field Tls: 2

Specifies the Transport Layer Security (TLS) domain authentication method; and/or that the network connection was able to successfully complete a HTTPS connection with verified TLS authentication to an endpoint configured by the **AllowedTlsAuthenticationEndpoints** Mobile Device Management (MDM) policy.

## -remarks
### Semantics
Use to determine which (if any) enterprise domain authentication mechanism validated a [ConnectionProfile](connectionprofile.md).

### Key points
- Mutually exclusive: Only one non-**None** value appears. If both LDAP and TLS criteria are satisfied, **Ldap** takes precedence.
- Modern trust: **Tls** enables cloud / MDM managed devices to recognize corporate networks without legacy LDAP reachability.
- Policy dependency: **Tls** requires an MDM policy defining allowed TLS authentication endpoints. Missing / misconfigured policy => **Tls** never reported.
- Negative check: **IsDomainAuthenticatedBy**(**DomainAuthenticationKind.None**) precisely indicates no recognized enterprise domain authentication.

### Diagnostic flow
1. Test **IsDomainAuthenticatedBy**(**Ldap**).
2. If false, test **IsDomainAuthenticatedBy**(**Tls**).
3. If both false, treat as unauthenticated (None).

### Scenarios
| Scenario | Action |
| -- | -- |
| Enabling enterprise-only features | Accept either **Ldap** or **Tls** |
| UI indicator | Show badge / label based on enum value |
| Telemetry rollout tracking | Count occurrences of **Tls** vs **Ldap** to measure adoption |
| Conditional policy | Relax constraints only when authenticated (not **None**) |

### Best practices
- Re-query on network status / domain change events (roam, resume, captive portal).
- Allow a short stabilization delay after resume before making gating decisions.
- Log both the enum value and profile identifier for support diagnostics.
- Code defensively for potential future enum members (default case handling).

> [!NOTE]  
> Do not infer authentication from DNS suffixes or SSID naming; rely on the explicit API result.

### Example (C#)
```csharp
var profile = Windows.Networking.Connectivity.NetworkInformation.GetInternetConnectionProfile();
if (profile != null)
{
    bool ldap = profile.IsDomainAuthenticatedBy(DomainAuthenticationKind.Ldap);
    bool tls  = profile.IsDomainAuthenticatedBy(DomainAuthenticationKind.Tls);
    bool any  = !profile.IsDomainAuthenticatedBy(DomainAuthenticationKind.None);

    string mode = ldap ? "LDAP" : tls ? "TLS" : "None";
    System.Diagnostics.Debug.WriteLine($"Domain authentication: {mode}");
}
```

## -see-also
[ConnectionProfile.IsDomainAuthenticatedBy method](connectionprofile_isdomainauthenticatedby_590452087.md)  
[ConnectionProfile](connectionprofile.md)

## -examples
