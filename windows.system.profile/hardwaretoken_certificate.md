---
-api-id: P:Windows.System.Profile.HardwareToken.Certificate
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.Streams.IBuffer Certificate { get; }
-->

# Windows.System.Profile.HardwareToken.Certificate

## -description
Gets the certificate that is used to sign the [Id](hardwaretoken_id.md) and is used to help verify the authenticity of the [Id](hardwaretoken_id.md).

## -property-value
The certificate used to sign the [Id](hardwaretoken_id.md).

## -remarks
The buffer contains a **PKCS#7 formatted certificate chain**, not a single certificate. The chain is rooted at the *Microsoft Assurance Designation Root 2011* certificate. The leaf certificate carries the extended key usage (EKU) OID `1.3.6.1.4.1.311.10.5.40`.

When validating this chain in a cloud service, enable revocation checking for all certificates in the chain. The *Microsoft Assurance Designation Root 2011* root certificate must be present in the trusted root store on the server.

For the full cloud-side verification workflow, see [Guidance on using the App Specific Hardware ID (ASHWID) to implement per-device app logic](/previous-versions/windows/apps/jj553431(v=win.10)).

## -examples

## -see-also
[HardwareToken.Signature](hardwaretoken_signature.md), [HardwareToken.Id](hardwaretoken_id.md), [Guidance on using the App Specific Hardware ID (ASHWID) to implement per-device app logic](/previous-versions/windows/apps/jj553431(v=win.10))
