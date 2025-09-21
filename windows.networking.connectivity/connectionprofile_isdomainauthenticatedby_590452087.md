---
-api-id: M:Windows.Networking.Connectivity.ConnectionProfile.IsDomainAuthenticatedBy(Windows.Networking.Connectivity.DomainAuthenticationKind)
-api-type: winrt method
---

# Windows.Networking.Connectivity.ConnectionProfile.IsDomainAuthenticatedBy(Windows.Networking.Connectivity.DomainAuthenticationKind)

<!--
public bool IsDomainAuthenticatedBy (Windows.Networking.Connectivity.DomainAuthenticationKind kind);
-->

## -description

Queries whether the specified domain authentication method succeeded for this connection profile.

## -parameters

### -param kind

The specific domain authentication method to query about.

## -returns

`true` if this connection profile has the same domain authentication kind as that specified in the *kind* parameter; `false` if this connection profile has a different domain authentication kind from that specified in *kind*.

## -remarks
Use this method to differentiate which enterprise domain authentication mechanism (if any) validated the current network for the associated `ConnectionProfile`.

Behavior and guidance:

* Precedence: Only one mechanism reports true. If both LDAP (Active Directory) and a TLS-based endpoint would succeed,
  LDAP takes precedence and `IsDomainAuthenticatedBy(DomainAuthenticationKind.Ldap)` returns true while TLS returns false.
* Negative check: `IsDomainAuthenticatedBy(DomainAuthenticationKind.None)` is logically equivalent to saying the profile is not domain authenticated.
* Scope: This method is meaningful primarily when overall domain connectivity is established (for example when related connectivity level APIs indicate an authenticated enterprise domain context). It may transiently return `None` during network transitions or captive portal resolution.
* Re-query strategy: Do not cache earlier results indefinitely. Re-query inside network status / domain change events to reflect changes when a device roams between corporate and public networks.
* Policy dependency (TLS path): The TLS mode depends on device management policy defining allowed authentication endpoints. Absence or misconfiguration of policy causes the TLS value to remain false even if the network is otherwise trusted.
* Telemetry / diagnostics: For logging, record both the boolean result and which kind you queried so you can measure adoption of newer TLS-based trust vs legacy LDAP.
* Fallback logic: Prefer feature enabling based on any authenticated mechanism (LDAP or TLS) unless your scenario strictly requires the additional LDAP semantics.

Edge cases:

* Network transitions may temporarily surface `None` while wireless association precedes enterprise trust confirmation.
* VPN scenarios: Domain authentication kind may reflect the tunneled corporate trust rather than the local physical network.
* Offline resume: After resume from sleep, revalidation may take time; defer critical enterprise-only actions until a positive result is observed.

Performance:

This call is lightweight (property-based) and can be invoked in response handlers; avoid polling in tight loops. Prefer event-driven updates.

## -see-also
[DomainAuthenticationKind](domainauthenticationkind.md)
[ConnectionProfile](connectionprofile.md)

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
