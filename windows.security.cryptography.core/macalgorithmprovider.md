---
-api-id: T:Windows.Security.Cryptography.Core.MacAlgorithmProvider
-api-type: winrt class
---

<!-- Class syntax.
public class MacAlgorithmProvider : Windows.Security.Cryptography.Core.IMacAlgorithmProvider, Windows.Security.Cryptography.Core.IMacAlgorithmProvider2
-->

# Windows.Security.Cryptography.Core.MacAlgorithmProvider

## -description
Represents a message authentication code (MAC). A MAC uses symmetric key cryptography to prevent message tampering. For more information, see [MACs, hashes, and signatures](/windows/uwp/security/macs-hashes-and-signatures).

## -remarks
You create a MacAlgorithmProvider object by calling the static [OpenAlgorithm](macalgorithmprovider_openalgorithm_637226074.md) method and specifying one of the following algorithm names:


+ HMAC_MD5
+ HMAC_SHA1
+ HMAC_SHA256
+ HMAC_SHA384
+ HMAC_SHA512
+ AES_CMAC


## -examples


[!code-csharp[ShowMacAlgProviderClass](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowMacAlgProviderClass)]

## -see-also
[HashAlgorithmProvider](hashalgorithmprovider.md)
