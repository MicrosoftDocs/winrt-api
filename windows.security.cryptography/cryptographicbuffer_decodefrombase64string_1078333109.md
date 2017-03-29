---
-api-id: M:Windows.Security.Cryptography.CryptographicBuffer.DecodeFromBase64String(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Streams.IBuffer DecodeFromBase64String(System.String value)
-->

# Windows.Security.Cryptography.CryptographicBuffer.DecodeFromBase64String

## -description
Decodes a string that has been base64 encoded.

## -parameters
### -param value
Base64 encoded input string.

## -returns
Output buffer that contains the decoded string.

## -remarks
Base64 processes data as 24-bit groups, mapping each group to four encoded 8-bit characters. Base64 encoding is sometimes referred to as 3-to-4 encoding. Each 6 bits of the 24-bit group is used as an index into a mapping table (the base64 alphabet) to obtain a character for the encoded data.

## -examples


[!code-csharp[ShowBase64Encoding](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowBase64Encoding)]

## -see-also
