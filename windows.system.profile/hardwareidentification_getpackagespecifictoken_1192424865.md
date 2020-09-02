---
-api-id: M:Windows.System.Profile.HardwareIdentification.GetPackageSpecificToken(Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.System.Profile.HardwareToken GetPackageSpecificToken(Windows.Storage.Streams.IBuffer nonce)
-->

# Windows.System.Profile.HardwareIdentification.GetPackageSpecificToken

## -description
Gets a hardware identifier (**ASHWID**) that represents the current hardware. The returned **ASHWID** will be different for each application package. In other words, this API will return different identifiers when called by two apps from different packages. It will return the same identifier when called by two apps that are part of the same package.

## -parameters
### -param nonce
The cryptographic *nonce* is optional. The *nonce* is recommended when **ASHWID** needs to be verified on the cloud against replay attacks. In the scenarios where nonce is desired, the remote server should generate a random nonce and pass it to the client app, and then verify that the signature has the expected nonce once the **ASHWID** is received from the client system.

## -returns
The hardware Id information.

## -remarks
The GetPackageSpecificToken is designed for use by professional developers who have experience with licensing content and with sufficient expertise in cryptography

## -examples

## -see-also
[Guidance on using the App Specific Hardware ID (ASHWID) to implement per-device app logic](/previous-versions/windows/apps/jj553431(v=win.10))
