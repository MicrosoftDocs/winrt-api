---
-api-id: M:Windows.Security.Cryptography.Certificates.CmsDetachedSignature.GenerateSignatureAsync(Windows.Storage.Streams.IInputStream,Windows.Foundation.Collections.IIterable{Windows.Security.Cryptography.Certificates.CmsSignerInfo},Windows.Foundation.Collections.IIterable{Windows.Security.Cryptography.Certificates.Certificate})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IBuffer> GenerateSignatureAsync(Windows.Storage.Streams.IInputStream data, Windows.Foundation.Collections.IIterable<Windows.Security.Cryptography.Certificates.CmsSignerInfo> signers, Windows.Foundation.Collections.IIterable<Windows.Security.Cryptography.Certificates.Certificate> certificates)
-->

# Windows.Security.Cryptography.Certificates.CmsDetachedSignature.GenerateSignatureAsync

## -description
Signs the specified input data using the specified signer information and creates a detached signed CMS message.

## -parameters
### -param data
The input data to be signed.

### -param signers
The signer information used to compute the signature.

### -param certificates
The list of certificates to build the chain for the signer certificates.

## -returns
An asynchronous operation to retrieve the detached signed CMS message.

## -remarks

## -examples

## -see-also
