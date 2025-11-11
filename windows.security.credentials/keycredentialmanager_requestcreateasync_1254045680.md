---
-api-id: M:Windows.Security.Credentials.KeyCredentialManager.RequestCreateAsync(System.String,Windows.Security.Credentials.KeyCredentialCreationOption)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Credentials.KeyCredentialRetrievalResult> RequestCreateAsync(System.String name, Windows.Security.Credentials.KeyCredentialCreationOption option)
-->

# Windows.Security.Credentials.KeyCredentialManager.RequestCreateAsync

## -description

Creates a new key credential for the current user and application.

## -parameters

### -param name

The name of the key credential to create.

### -param option

Options for the creation operation.

## -returns

When this method completes, it returns the results of the key credential creation.

## -remarks

The `RequestCreateAsync` method generates a new RSA 2048-bit key credential. The generated key is stored securely and can be used for cryptographic operations.

#### Key Export and Parsing

The public key can be exported in a binary format. To parse the parameters of the public key:

1. Use the `BCrypt` library to extract the key blob.
1. Parse the key blob to retrieve the modulus and exponent.

## -examples

Refer to the [KeyCredentialManager sample](https://github.com/Microsoft/Windows-universal-samples/tree/main/Samples/KeyCredentialManager) for an example of exporting and parsing the public key.

## -see-also
