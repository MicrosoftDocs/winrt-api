---
-api-id: M:Windows.Data.Text.UnicodeCharacters.IsNoncharacter(System.UInt32)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public bool IsNoncharacter(System.UInt32 codepoint)
-->

# Windows.Data.Text.UnicodeCharacters.IsNoncharacter

## -description
Determines if a specified codepoint is a non-character.

## -parameters
### -param codepoint
A Unicode character. This must be in the proper range: 0 &lt;= *codepoint* &lt;= 0x10FFFF.

## -returns
**TRUE** if *codepoint* is a non-character; otherwise **FALSE**.

## -remarks
This method determines if *codepoint* is a one of the invalid Unicode code points (U+FFD0 through U+FFEF, U+xxFFFE, or U+xxFFFF).

## -examples

## -see-also
[GetCodepointFromSurrogatePair](unicodecharacters_getcodepointfromsurrogatepair.md)