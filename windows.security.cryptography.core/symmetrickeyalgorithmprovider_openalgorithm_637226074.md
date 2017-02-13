---
-api-id: M:Windows.Security.Cryptography.Core.SymmetricKeyAlgorithmProvider.OpenAlgorithm(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Security.Cryptography.Core.SymmetricKeyAlgorithmProvider OpenAlgorithm(System.String algorithm)
-->

# Windows.Security.Cryptography.Core.SymmetricKeyAlgorithmProvider.OpenAlgorithm

## -description
Creates an instance of the [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md) class and opens the specified algorithm for use.

## -parameters
### -param algorithm
Algorithm name.

## -returns
Represents a symmetric key algorithm provider.

## -remarks
The following algorithm names are supported for use in this method:


+ No padding:   + [SymmetricAlgorithmNames.AesCbc](symmetricalgorithmnames_aescbc.md)
   + [SymmetricAlgorithmNames.AesEcb](symmetricalgorithmnames_aesecb.md)
   + [SymmetricAlgorithmNames.DesCbc](symmetricalgorithmnames_descbc.md)
   + [SymmetricAlgorithmNames.DesEcb](symmetricalgorithmnames_desecb.md)
   + [SymmetricAlgorithmNames.Rc2Cbc](symmetricalgorithmnames_rc2cbc.md)
   + [SymmetricAlgorithmNames.Rc2Ecb](symmetricalgorithmnames_rc2ecb.md)
   + [SymmetricAlgorithmNames.TripleDesCbc](symmetricalgorithmnames_tripledescbc.md)
   + [SymmetricAlgorithmNames.TripleDesEcb](symmetricalgorithmnames_tripledesecb.md)

+ PKCS#7 block padding modes:   + [SymmetricAlgorithmNames.AesCbcPkcs7](symmetricalgorithmnames_aescbcpkcs7.md)
   + [SymmetricAlgorithmNames.AesEcbPkcs7](symmetricalgorithmnames_aesecbpkcs7.md)
   + [SymmetricAlgorithmNames.DesCbcPkcs7](symmetricalgorithmnames_descbcpkcs7.md)
   + [SymmetricAlgorithmNames.DesEcbPkcs7](symmetricalgorithmnames_desecbpkcs7.md)
   + [SymmetricAlgorithmNames.Rc2CbcPkcs7](symmetricalgorithmnames_rc2cbcpkcs7.md)
   + [SymmetricAlgorithmNames.Rc2EcbPkcs7](symmetricalgorithmnames_rc2ecbpkcs7.md)
   + [SymmetricAlgorithmNames.TripleDesCbcPkcs7](symmetricalgorithmnames_tripledescbcpkcs7.md)
   + [SymmetricAlgorithmNames.TripleDesEcbPkcs7](symmetricalgorithmnames_tripledesecbpkcs7.md)

+ Authenticated modes (see the [EncryptedAndAuthenticatedData](encryptedandauthenticateddata.md) class):   + [SymmetricAlgorithmNames.AesCcm](symmetricalgorithmnames_aesccm.md)
   + [SymmetricAlgorithmNames.AesGcm](symmetricalgorithmnames_aesgcm.md)

+ Stream Cipher:   + [SymmetricAlgorithmNames.Rc4](symmetricalgorithmnames_rc4.md)



## -examples

## -see-also
