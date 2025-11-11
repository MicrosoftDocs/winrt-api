---
-api-id: T:Windows.Security.Credentials.KeyCredentialManager
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class KeyCredentialManager 
-->

# Windows.Security.Credentials.KeyCredentialManager

## -description

Contains methods for basic management of key credentials.

## -remarks

The `KeyCredentialManager` class provides methods to manage key credentials, which are RSA 2048-bit keys. These keys are used for secure authentication and cryptographic operations.

#### Key Information

- **Key Type**: RSA 2048-bit
- **Signature Format**: PKCS #1 RSA PSS with SHA256
- **Attestation Data**: The attestation data is a binary blob that includes metadata about the key, such as its origin and security properties.

#### Attestation Data Format

The attestation data is encoded in a binary format. It includes:

1. **Key Metadata**: Information about the key's origin and properties.
1. **Certificate Chain**: A chain of certificates that can be used to verify the authenticity of the attestation.

#### Verifying Attestation Data

To verify the attestation data:

1. Parse the binary blob to extract the metadata and certificate chain.
1. Use the certificate chain to validate the authenticity of the attestation.
1. Ensure the metadata matches the expected properties of the key.

For more details, refer to the [KeyCredentialManager sample](https://github.com/Microsoft/Windows-universal-samples/tree/main/Samples/KeyCredentialManager).

## -examples

## -see-also

[KeyCredentialManager sample](https://github.com/Microsoft/Windows-universal-samples/tree/main/Samples/KeyCredentialManager)