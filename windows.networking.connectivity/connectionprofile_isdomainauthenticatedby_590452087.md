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

## -see-also

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
