---
-api-id: T:Windows.Data.Text.UnicodeCharacters
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class UnicodeCharacters 
-->

# Windows.Data.Text.UnicodeCharacters

## -description

Provides a way for apps to get information about Unicode characters, per the [Unicode Standard Annex #44](https://www.unicode.org/reports/tr44/#White_Space).

## -remarks

Use [GetCodepointFromSurrogatePair](unicodecharacters_getcodepointfromsurrogatepair_1886831018.md) to prepare Unicode characters before you pass them to any of the other methods of this class, in order to properly process supplementary characters. See [Surrogates and Supplementary Characters](/windows/desktop/Intl/surrogates-and-supplementary-characters) for a discussion of supplementary Unicode characters.

The normal procedure for processing the code points in a stream is to:

1. Use [IsHighSurrogate](unicodecharacters_ishighsurrogate_1444937275.md) to determine if a code point is a high surrogate.
1. If it is not, pass it to the desired method of UnicodeCharacters.
1. Else the code point is a high surrogate:1. Use [IsLowSurrogate](unicodecharacters_islowsurrogate_645121110.md) to check the next code point in the stream to determine if it is a low surrogate.
1. If it is not, you have an invalid sequence of code points.
1. Else the second code point is a low surrogate. Pass the high and low pair to [GetCodepointFromSurrogatePair](unicodecharacters_getcodepointfromsurrogatepair_1886831018.md) to obtain the supplementary Unicode character that can be passed on to the desired method.

The methods in this class throw an invalid argument exception if the input is not a valid codepoint.

## -examples

## -see-also

[Unicode string processing sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Unicode)
