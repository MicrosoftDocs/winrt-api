---
-api-id: M:Windows.Security.Credentials.KeyCredentialManager.RenewAttestationAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction RenewAttestationAsync()
-->

# Windows.Security.Credentials.KeyCredentialManager.RenewAttestationAsync

## -description

Renews an attestation for a key credential.

## -returns

This method does not return a value.

## -remarks

The `RenewAttestationAsync` method renews the attestation for an existing key credential. This ensures that the attestation remains valid and up-to-date.

#### Attestation Renewal

The renewed attestation includes updated metadata and a refreshed certificate chain. This can be used to verify the key's authenticity and properties.

## -examples

## -see-also
