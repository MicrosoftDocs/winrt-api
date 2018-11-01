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
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.



> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations). 

Applications must determine whether to trust this URL for providing credentials.

## -property-value
A URI that contains the HTTPS authentication URL.

## -remarks
Applications should not assume they are only invoked for authentication attempts for profiles they created themselves. An application from another operator could have mistakenly created a profile that invokes the application of another operator for issuing credentials. The authentication context contains all relevant parameters of the authentication attempt.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
