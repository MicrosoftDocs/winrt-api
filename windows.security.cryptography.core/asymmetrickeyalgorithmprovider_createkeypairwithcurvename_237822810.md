---
-api-id: M:Windows.Security.Cryptography.Core.AsymmetricKeyAlgorithmProvider.CreateKeyPairWithCurveName(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Security.Cryptography.Core.CryptographicKey CreateKeyPairWithCurveName(System.String curveName)
-->

# Windows.Security.Cryptography.Core.AsymmetricKeyAlgorithmProvider.CreateKeyPairWithCurveName

## -description

Creates a public/private key pair using an algorithmic curve name.

## -parameters

### -param curveName

The name of the curve.

## -returns

Represents the generated Elliptic Curve Digital Signature Algorithm (ECDSA) asymmetric key pair.

## -remarks

## -examples

The following example creates a new ECDSA curve from CurveName.

```csharp
AsymmetricKeyAlgorithmProvider eccAlgorithmProvider =
                AsymmetricKeyAlgorithmProvider.OpenAlgorithm(AsymmetricAlgorithmNames.EcdsaSha256);
CryptographicKey keyPair = eccAlgorithmProvider.CreateKeyPairWithCurveName(EccCurveNames.Secp160k1);
```

```cpp
AsymmetricKeyAlgorithmProvider^ eccAlgorithmProvider = AsymmetricKeyAlgorithmProvider::OpenAlgorithm(
                                                                               AsymmetricAlgorithmNames::EcdsaSha256);
CryptographicKey^ keyPair = eccAlgorithmProvider->CreateKeyPairWithCurveName(EccCurveNames::Secp160k1);
```

## -see-also
