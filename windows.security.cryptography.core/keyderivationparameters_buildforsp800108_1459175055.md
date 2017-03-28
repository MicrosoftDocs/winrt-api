---
-api-id: M:Windows.Security.Cryptography.Core.KeyDerivationParameters.BuildForSP800108(Windows.Storage.Streams.IBuffer,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Security.Cryptography.Core.KeyDerivationParameters BuildForSP800108(Windows.Storage.Streams.IBuffer label, Windows.Storage.Streams.IBuffer context)
-->

# Windows.Security.Cryptography.Core.KeyDerivationParameters.BuildForSP800108

## -description
Creates a [KeyDerivationParameters](keyderivationparameters.md) object for use in a counter mode, hash-based message authentication code (HMAC) key derivation function.

## -parameters
### -param label
Buffer that specifies the purpose for the derived keying material.

### -param context
Buffer that specifies information related to the derived keying material. For example, the context can identify the parties who are deriving the keying material and, optionally, a nonce known by the parties.

## -returns
Refers to the parameters used during key derivation.

## -remarks
You can use the following algorithm names with the [OpenAlgorithm](keyderivationalgorithmprovider_openalgorithm.md) function to open a SP800108 KDF algorithm provider:


+ [KeyDerivationAlgorithmNames.Sp800108CtrHmacMd5](keyderivationalgorithmnames_sp800108ctrhmacmd5.md)
+ [KeyDerivationAlgorithmNames.Sp800108CtrHmacSha1](keyderivationalgorithmnames_sp800108ctrhmacsha1.md)
+ [KeyDerivationAlgorithmNames.Sp800108CtrHmacSha256](keyderivationalgorithmnames_sp800108ctrhmacsha256.md)
+ [KeyDerivationAlgorithmNames.Sp800108CtrHmacSha384](keyderivationalgorithmnames_sp800108ctrhmacsha384.md)
+ [KeyDerivationAlgorithmNames.Sp800108CtrHmacSha512](keyderivationalgorithmnames_sp800108ctrhmacsha512.md)


## -examples


[!code-csharp[ShowDerivationFromSP800108](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowDerivationFromSP800108)]

## -see-also
