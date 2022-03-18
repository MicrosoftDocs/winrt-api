---
-api-id: M:Windows.Security.Cryptography.Core.KeyDerivationParameters.BuildForSP80056a(Windows.Storage.Streams.IBuffer,Windows.Storage.Streams.IBuffer,Windows.Storage.Streams.IBuffer,Windows.Storage.Streams.IBuffer,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Security.Cryptography.Core.KeyDerivationParameters BuildForSP80056a(Windows.Storage.Streams.IBuffer algorithmId, Windows.Storage.Streams.IBuffer partyUInfo, Windows.Storage.Streams.IBuffer partyVInfo, Windows.Storage.Streams.IBuffer suppPubInfo, Windows.Storage.Streams.IBuffer suppPrivInfo)
-->

# Windows.Security.Cryptography.Core.KeyDerivationParameters.BuildForSP80056a

## -description
Creates a [KeyDerivationParameters](keyderivationparameters.md) object for use in the SP800-56A key derivation function.

## -parameters
### -param algorithmId
Specifies the intended purpose of the derived key.

### -param partyUInfo
Contains public information contributed by the initiator.

### -param partyVInfo
Contains public information contributed by the responder.

### -param suppPubInfo
Contains public information known to both initiator and responder.

### -param suppPrivInfo
Contains private information known to both initiator and responder, such as a shared secret.

## -returns
Refers to the parameters used during key derivation.

## -remarks
You can use the following algorithm names with the [OpenAlgorithm](keyderivationalgorithmprovider_openalgorithm_637226074.md) function to open a SP80056a KDF algorithm provider:


+ [KeyDerivationAlgorithmNames.Sp80056aConcatMd5](keyderivationalgorithmnames_sp80056aconcatmd5.md)
+ [KeyDerivationAlgorithmNames.Sp80056aConcatSha1](keyderivationalgorithmnames_sp80056aconcatsha1.md)
+ [KeyDerivationAlgorithmNames.Sp80056aConcatSha256](keyderivationalgorithmnames_sp80056aconcatsha256.md)
+ [KeyDerivationAlgorithmNames.Sp80056aConcatSha384](keyderivationalgorithmnames_sp80056aconcatsha384.md)
+ [KeyDerivationAlgorithmNames.Sp80056aConcatSha512](keyderivationalgorithmnames_sp80056aconcatsha512.md)


## -examples


[!code-csharp[ShowDerivationFromSP80056a](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowDerivationFromSP80056a)]

## -see-also
