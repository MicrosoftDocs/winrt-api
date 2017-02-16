---
-api-id: M:Windows.Security.Cryptography.Certificates.Certificate.BuildChainAsync(Windows.Foundation.Collections.IIterable{Windows.Security.Cryptography.Certificates.Certificate})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Cryptography.Certificates.CertificateChain> BuildChainAsync(Windows.Foundation.Collections.IIterable<Windows.Security.Cryptography.Certificates.Certificate> certificates)
-->

# Windows.Security.Cryptography.Certificates.Certificate.BuildChainAsync

## -description
Build a certificate chain for the specified certificates starting from the end entity certificate to the root.

## -parameters
### -param certificates
The intermediate certificates to use when building the certificate chain.

## -returns
An asynchronous operation to retrieve the [CertificateChain](certificatechain.md) object that contains the entire certificate chain.

## -remarks

## -examples

## -see-also
[BuildChainAsync(IIterable(Certificate), ChainBuildingParameters)](certificate_buildchainasync_1634621379.md)