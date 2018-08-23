---
-api-id: M:Windows.Data.Text.UnicodeCharacters.IsSupplementary(System.UInt32)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public bool IsSupplementary(System.UInt32 codepoint)
-->

# Windows.Data.Text.UnicodeCharacters.IsSupplementary

## -description
Determines if a specified Unicode character is a supplementary character.

## -parameters
### -param codepoint
A Unicode character. This must be in the proper range: 0 &lt;= *codepoint* &lt;= 0x10FFFF.

## -returns
**TRUE** if *codepoint* is a supplementary character; otherwise **FALSE**.

## -remarks
This method determines if *codepoint* is a supplementary character (greater than 0xFFFF).

## -examples

## -see-also
[GetCodepointFromSurrogatePair](unicodecharacters_getcodepointfromsurrogatepair_1886831018.md)