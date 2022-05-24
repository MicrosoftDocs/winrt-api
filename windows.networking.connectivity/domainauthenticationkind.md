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

## -see-also
[ConnectionProfile.IsDomainAuthenticatedBy method](connectionprofile_isdomainauthenticatedby_590452087.md)

## -examples
