---
-api-id: P:Windows.Networking.NetworkOperators.HotspotAuthenticationContext.AuthenticationUrl
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Uri AuthenticationUrl { get; }
-->

# Windows.Networking.NetworkOperators.HotspotAuthenticationContext.AuthenticationUrl

## -description
Gets the HTTPS URL specified in the Wireless Internet Service Provider roaming (WISPr) redirect message.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

Applications must determine whether to trust this URL for providing credentials.

## -property-value
A URI that contains the HTTPS authentication URL.

## -remarks
Applications should not assume they are only invoked for authentication attempts for profiles they created themselves. An application from another operator could have mistakenly created a profile that invokes the application of another operator for issuing credentials. The authentication context contains all relevant parameters of the authentication attempt.

## -examples

## -see-also
