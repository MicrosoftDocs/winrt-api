---
-api-id: T:Windows.Security.Cryptography.Core.HashAlgorithmProvider
-api-type: winrt class
---

<!-- Class syntax.
public class HashAlgorithmProvider : Windows.Security.Cryptography.Core.IHashAlgorithmProvider
-->

# Windows.Security.Cryptography.Core.HashAlgorithmProvider

## -description
Represents a cryptographic hash provider. For more information about hashes, see [MACs, hashes, and signatures](http://msdn.microsoft.com/library/e674312f-6678-44c5-91d9-b489f49c4d3c).

## -remarks
You create a [HashAlgorithmProvider](hashalgorithmprovider.md) object by calling the static [OpenAlgorithm](hashalgorithmprovider_openalgorithm_637226074.md) method and specifying one of the following algorithm names:
+ MD5
+ SHA1
+ SHA256
+ SHA384
+ SHA512


## -examples


[!code-csharp[ShowHashAlgProviderClass](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowHashAlgProviderClass)]

## -see-also
[MACs, hashes, and signatures](http://msdn.microsoft.com/library/e674312f-6678-44c5-91d9-b489f49c4d3c)