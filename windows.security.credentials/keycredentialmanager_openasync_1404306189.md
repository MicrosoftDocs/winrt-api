---
-api-id: M:Windows.Security.Credentials.KeyCredentialManager.OpenAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Credentials.KeyCredentialRetrievalResult> OpenAsync(System.String name)
-->

# Windows.Security.Credentials.KeyCredentialManager.OpenAsync

## -description

Retrieves a key credential for the current user and application.

## -parameters

### -param name

The name of the key credential to open.

## -returns

When this method completes, it returns the results of the key credential retrieval.

## -remarks

The `OpenAsync` method retrieves an existing key credential. The retrieved key can be used for cryptographic operations such as signing and encryption.

#### Key Usage

The key is an RSA 2048-bit key. It supports operations like:

- Generating signatures in PKCS #1 RSA PSS format with SHA256.
- Encrypting data using appropriate padding schemes such as PKCS #1 OAEP.

## -examples

## -see-also
