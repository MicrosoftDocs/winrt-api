---
-api-id: M:Windows.Data.Text.UnicodeCharacters.GetSurrogatePairFromCodepoint(System.UInt32,System.Char@,System.Char@)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void GetSurrogatePairFromCodepoint(System.UInt32 codepoint, System.Char highSurrogate, System.Char lowSurrogate)
-->

# Windows.Data.Text.UnicodeCharacters.GetSurrogatePairFromCodepoint

## -description
Returns the high and low surrogate pair values for the specified supplementary Unicode character.

## -parameters
### -param codepoint
A Unicode character. This must be in the proper range: 0 &lt;= *codepoint* &lt;= 0x10FFFF.

### -param highSurrogate
The high surrogate value returned.

### -param lowSurrogate
The low surrogate value returned.

## -remarks
See [Surrogates and Supplementary Characters](http://msdn.microsoft.com/library/0dea39e2-a2b4-47fc-b44a-56af8ba1e346) for a discussion of supplementary Unicode characters.

## -examples

## -see-also
[GetCodepointFromSurrogatePair](unicodecharacters_getcodepointfromsurrogatepair.md), [Surrogates and Supplementary Characters](http://msdn.microsoft.com/library/0dea39e2-a2b4-47fc-b44a-56af8ba1e346)