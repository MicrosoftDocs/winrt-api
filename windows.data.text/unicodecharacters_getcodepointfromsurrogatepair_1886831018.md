---
-api-id: M:Windows.Data.Text.UnicodeCharacters.GetCodepointFromSurrogatePair(System.UInt32,System.UInt32)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public uint GetCodepointFromSurrogatePair(System.UInt32 highSurrogate, System.UInt32 lowSurrogate)
-->

# Windows.Data.Text.UnicodeCharacters.GetCodepointFromSurrogatePair

## -description
Returns the supplementary Unicode character for the specified high and low surrogate pair.

## -parameters
### -param highSurrogate
The high surrogate value. This must be in the proper range: 0xD800 &lt;= *highSurrogate* &lt;= 0xDBFF.

### -param lowSurrogate
The low surrogate value. This must be in the proper range: 0xDC00 &lt;= *lowSurrogate* &lt;= 0xDFFF.

## -returns
The supplementary Unicode character.

## -remarks


## -examples

## -see-also
[GetSurrogatePairFromCodepoint](unicodecharacters_getsurrogatepairfromcodepoint_381440991.md), [IsHighSurrogate](unicodecharacters_ishighsurrogate_1444937275.md), [IsLowSurrogate](unicodecharacters_islowsurrogate_645121110.md), [Surrogates and Supplementary Characters](http://msdn.microsoft.com/library/0dea39e2-a2b4-47fc-b44a-56af8ba1e346)