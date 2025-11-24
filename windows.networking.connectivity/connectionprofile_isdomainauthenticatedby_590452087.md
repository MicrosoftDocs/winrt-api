---
-api-id: M:Windows.Networking.Connectivity.ConnectionProfile.IsDomainAuthenticatedBy(Windows.Networking.Connectivity.DomainAuthenticationKind)
-api-type: winrt method
---

# Windows.Networking.Connectivity.ConnectionProfile.IsDomainAuthenticatedBy(Windows.Networking.Connectivity.DomainAuthenticationKind)

<!--
public bool IsDomainAuthenticatedBy (Windows.Networking.Connectivity.DomainAuthenticationKind kind);
-->

## -description
Determines whether the specified domain authentication mechanism succeeded for this connection profile.

## -parameters

### -param kind

The specific domain authentication method to query about.

## -returns
`true` if the connection profile is authenticated by the specified domain authentication kind; otherwise, `false`.

## -remarks
### Behavior
Only one domain authentication mechanism reports true at a time (precedence applies). If both LDAP (Active Directory) and
TLS-based validation could succeed, LDAP takes precedence and TLS returns false.

### Common queries
* Any authenticated: `!profile.IsDomainAuthenticatedBy(DomainAuthenticationKind.None)`
* LDAP specifically: `profile.IsDomainAuthenticatedBy(DomainAuthenticationKind.Ldap)`
* TLS-based: `profile.IsDomainAuthenticatedBy(DomainAuthenticationKind.Tls)`

### Guidance
- Use event-driven re-query (network status / domain change events). Do not poll aggressively.
- Treat `None` as unauthenticated; transient `None` values can occur during transitions (roam, captive portal).
- Prefer enabling enterprise features for either LDAP or TLS unless LDAP-specific semantics are required.
- Log both the queried kind and the boolean result for telemetry.

### TLS considerations
TLS-based determination depends on device policy specifying trusted authentication endpoints. Missing or misconfigured
policy yields `false` even on otherwise trusted networks.

### Edge cases
- VPN: Reported kind can reflect the tunneled corporate network rather than the local physical link.
- Resume from low-power: Allow time for revalidation before gating critical enterprise actions.

### Performance
Lightweight call; suitable inside status handlers. Avoid tight polling loops. Subscribe to change events instead.

### Fallback logic
If neither LDAP nor TLS returns true, treat the profile as not domain authenticated and apply default (non-enterprise)
behavior.

> [!NOTE]
> A future platform update could introduce additional domain authentication kinds. Code defensively by handling
> unknown enum values gracefully.


## -see-also
[DomainAuthenticationKind](domainauthenticationkind.md)  
[ConnectionProfile](connectionprofile.md)

[ConnectionProfile](connectionprofile.md),
[DomainAuthenticationKind](domainauthenticationkind.md)
## -examples

The scenario for this code example is that a networking diagnostic tool for IT admins wants to ensure that connections to a corporate network have the correct authentication properties.

```csharp
using Windows.Networking.Connectivity;

...

public class Diagnostics
{
    private async void LogToConsole(string output, string connectionProfileName)
    {
        // Implementation omitted for brevity.
    }

    public async void RunDiagnostics()
    {
        // Retrieve the ConnectionProfile.
        ConnectionProfile internetConnectionProfile =
            NetworkInformation.GetInternetConnectionProfile();
        if (internetConnectionProfile == null)
        {
            LogToConsole("Device isn't connected to a network", "");
            return;
        }

        string connectionProfileName =
            internetConnectionProfile.ProfileName;
        bool isDomainAuthenticated =
            !internetConnectionProfile.IsDomainAuthenticatedBy(DomainAuthenticationKind.None);
        bool isLdapAuthenticated =
            internetConnectionProfile.IsDomainAuthenticatedBy(DomainAuthenticationKind.Ldap);
        bool isTlsAuthenticated =
            internetConnectionProfile.IsDomainAuthenticatedBy(DomainAuthenticationKind.Tls);

        if (isDomainAuthenticated)
        {
            if (isLdapAuthenticated)
            {
                LogToConsole("Connection profile is domain-authenticated via LDAP",
                    connectionProfileName);
            }
            if (isTlsAuthenticated)
            {
                LogToConsole("Connection profile is domain-authenticated via TLS",
                    connectionProfileName);
            }

            if (!isLdapAuthenticated && !isTlsAuthenticated)
            {
                LogToConsole("Connection profile wasn't expected to be domain authenticated for any other kinds",
                    connectionProfileName);
            }
        }
        else
        {
            LogToConsole("Connection profile isn't domain-authenticated",
                connectionProfileName);
        }
    }
}
```
