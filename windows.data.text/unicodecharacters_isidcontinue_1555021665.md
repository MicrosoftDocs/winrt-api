---
-api-id: M:Windows.Data.Text.UnicodeCharacters.IsIdContinue(System.UInt32)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public bool IsIdContinue(System.UInt32 codepoint)
-->

# Windows.Data.Text.UnicodeCharacters.IsIdContinue

## -description
Determines if a specified Unicode character can be considered a continuation character of an identifier in programming.

## -parameters
### -param codepoint
A Unicode character. This must be in the proper range: 0 &lt;= *codepoint* &lt;= 0x10FFFF.

## -returns
**TRUE** if *codepoint* is a continuation character of an identifier in programming; otherwise **FALSE**.

## -remarks


## -examples

## -see-also
[GetCodepointFromSurrogatePair](unicodecharacters_getcodepointfromsurrogatepair_1886831018.md)