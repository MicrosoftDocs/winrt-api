---
-api-id: T:Windows.Security.Cryptography.BinaryStringEncoding
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Cryptography.BinaryStringEncoding : int
-->

# BinaryStringEncoding

## -description
Contains encoding formats that can be used in the [ConvertStringToBinary](cryptographicbuffer_convertstringtobinary.md) and [ConvertBinaryToString](cryptographicbuffer_convertbinarytostring.md) methods.

## -enum-fields
### -field Utf8:0
Eight bit Unicode Transformation Format. The process encodes each Unicode code point into one to four 8-bit bytes. Code points represented by lower numerical values are encoded using fewer bytes. In particular, the first 128 characters correspond exactly to the ASCII character set and are encoded by using a single octet.

### -field Utf16LE:1
Sixteen bit Unicode Transformation Format in little-endian byte order. The encoding process creates a variable length result of one or two 8-bit bytes per Unicode code point.

### -field Utf16BE:2
Sixteen bit Unicode Transformation Format in big-endian byte order.


## -remarks

## -examples

## -see-also