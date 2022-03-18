---
-api-id: M:Windows.Security.Cryptography.Core.CryptographicEngine.Encrypt(Windows.Security.Cryptography.Core.CryptographicKey,Windows.Storage.Streams.IBuffer,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Streams.IBuffer Encrypt(Windows.Security.Cryptography.Core.CryptographicKey key, Windows.Storage.Streams.IBuffer data, Windows.Storage.Streams.IBuffer iv)
-->

# Windows.Security.Cryptography.Core.CryptographicEngine.Encrypt

## -description
Encrypts data by using a symmetric or asymmetric algorithm.

## -parameters
### -param key
Cryptographic key to use for encryption. This can be an asymmetric or a symmetric key. For more information, see [AsymmetricKeyAlgorithmProvider](asymmetrickeyalgorithmprovider.md) and [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md).

### -param data
Data to encrypt.

### -param iv
Buffer that contains the initialization vector. This can be **null** for a symmetric algorithm and should always be **null** for an asymmetric algorithm. If an initialization vector (IV) was used to encrypt the data, you must use the same IV to decrypt the data. You can use the [GenerateRandom](../windows.security.cryptography/cryptographicbuffer_generaterandom_1645545930.md) method to create an IV that contains random data. Other IVs, such as nonce-generated vectors, require custom implementation. For more information, see [Cryptographic keys](/windows/uwp/security/cryptographic-keys).

Cipher block chaining (CBC) block cipher mode algorithms require an initialization vector. For more information, see Remarks.

## -returns
Encrypted data.

## -remarks
Of the symmetric algorithms supported by Microsoft, the following require an initialization vector:


+ [SymmetricAlgorithmNames.DesCbc](symmetricalgorithmnames_descbc.md)
+ [SymmetricAlgorithmNames.TripleDesCbc](symmetricalgorithmnames_tripledescbc.md)
+ [SymmetricAlgorithmNames.Rc2Cbc](symmetricalgorithmnames_rc2cbc.md)
+ [SymmetricAlgorithmNames.AesCbc](symmetricalgorithmnames_aescbc.md)
+ [SymmetricAlgorithmNames.AesCbcPkcs7](symmetricalgorithmnames_aescbcpkcs7.md)
+ [SymmetricAlgorithmNames.DesCbcPkcs7](symmetricalgorithmnames_descbcpkcs7.md)
+ [SymmetricAlgorithmNames.TripleDesCbcPkcs7](symmetricalgorithmnames_tripledescbcpkcs7.md)
+ [SymmetricAlgorithmNames.Rc2CbcPkcs7](symmetricalgorithmnames_rc2cbcpkcs7.md)
+ [SymmetricAlgorithmNames.Rc2EcbPkcs7](symmetricalgorithmnames_rc2ecbpkcs7.md)


## -examples


[!code-csharp[ShowSymmDecryption](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#SnippetShowSymmEncryption)]

## -see-also
[AsymmetricKeyAlgorithmProvider](asymmetrickeyalgorithmprovider.md), [Cryptographic keys](/windows/uwp/security/cryptographic-keys), [Decrypt](cryptographicengine_decrypt_258898008.md), [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md)
