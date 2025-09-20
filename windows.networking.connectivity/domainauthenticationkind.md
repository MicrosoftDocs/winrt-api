---
-api-id: T:Windows.Networking.Connectivity.DomainAuthenticationKind
-api-type: winrt enum
---

# Windows.Networking.Connectivity.DomainAuthenticationKind

<!--
public enum DomainAuthenticationKind
-->

## -description

Defines constants that specify a domain authentication method.

Only one of the listed constants is set for any instance of **DomainAuthenticationKind**. In some scenarios, the constant set will represent the most preferred protocol used to determine whether the domain was authenticated.

## -enum-fields

### -field None: 0

Specifies no domain authentication method; and/or that the network couldn't be domain-authenticated.

### -field Ldap: 1

Specifies the domain authentication method for an Active Directory network; and/or that the machine was successful in a Lightweight Directory Access Protocol (LDAP) authentication request against the configured Active Directory servers on the current network.

### -field Tls: 2

Specifies the Transport Layer Security (TLS) domain authentication method; and/or that the network connection was able to successfully complete a HTTPS connection with verified TLS authentication to an endpoint configured by the `AllowedTlsAuthenticationEndpoints` Mobile Device Management (MDM) policy.

## -remarks
Use this enumeration to identify the mechanism (if any) that established enterprise domain authentication for a `ConnectionProfile`.

Key points:

* Exclusivity: Only one non-`None` value is active at a time. If both LDAP (Active Directory) and TLS trust conditions are satisfied, LDAP takes precedence.
* Evolution: TLS-based domain authentication enables Azure AD–joined or MDM-managed devices to recognize corporate networks without requiring traditional LDAP reachability.
* Policy dependency: The `Tls` value depends on an MDM policy that defines allowed TLS authentication endpoints. If that policy is absent or misconfigured, `Tls` will remain unused.
* Diagnostic flow: Query `IsDomainAuthenticatedBy(Ldap)` and, if false, optionally query `IsDomainAuthenticatedBy(Tls)` before concluding the device is not domain authenticated.
* Negative form: Treat `IsDomainAuthenticatedBy(None)` as a precise statement that no recognized enterprise domain authentication mechanism has succeeded for the profile.

Scenarios:

* Conditional enterprise features (enable when LDAP or TLS is present).
* UI indicators distinguishing classic (LDAP) vs modern (TLS) trust.
* Telemetry to monitor rollout of TLS-based trust in mixed environments.

Best practices:

* Always re-query on network status change events; do not assume stability across roam / resume.
* Implement timeouts or retries after resume since authentication may lag physical connectivity.
* Log both the enum value and network identifier (e.g., ProfileName) for support diagnostics.

## -see-also
[ConnectionProfile.IsDomainAuthenticatedBy method](connectionprofile_isdomainauthenticatedby_590452087.md)
[ConnectionProfile](connectionprofile.md)

## -examples
