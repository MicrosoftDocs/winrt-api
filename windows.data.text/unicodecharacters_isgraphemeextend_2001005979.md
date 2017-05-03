---
-api-id: M:Windows.Data.Text.UnicodeCharacters.IsGraphemeExtend(System.UInt32)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public bool IsGraphemeExtend(System.UInt32 codepoint)
-->

# Windows.Data.Text.UnicodeCharacters.IsGraphemeExtend

## -description
Determines if a specified Unicode character can be considered to continue a previous grapheme.

## -parameters
### -param codepoint
A Unicode character. This must be in the proper range: 0 &lt;= *codepoint* &lt;= 0x10FFFF.

## -returns
**TRUE** if *codepoint* continues the previous grapheme; otherwise **FALSE**.

## -remarks


## -examples

## -see-also
[GetCodepointFromSurrogatePair](unicodecharacters_getcodepointfromsurrogatepair.md)