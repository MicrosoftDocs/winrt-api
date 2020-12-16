---
-api-id: T:Windows.Data.Text.UnicodeGeneralCategory
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Data.Text.UnicodeGeneralCategory : int
-->

# UnicodeGeneralCategory

## -description
Defines the Unicode general category of a character.

## -enum-fields
### -field UppercaseLetter:0
Uppercase letter. Signified by the Unicode designation "Lu" (letter, uppercase).

### -field LowercaseLetter:1
Lowercase letter. Signified by the Unicode designation "Ll" (letter, lowercase).

### -field TitlecaseLetter:2
Titlecase letter. Signified by the Unicode designation "Lt" (letter, titlecase).

### -field ModifierLetter:3
Modifier letter character, which is a free-standing spacing character that indicates modifications of a preceding letter. Signified by the Unicode designation "Lm" (letter, modifier).

### -field OtherLetter:4
Letter that is not an uppercase letter, a lowercase letter, a titlecase letter, or a modifier letter. Signified by the Unicode designation "Lo" (letter, other).

### -field NonspacingMark:5
Nonspacing character that indicates modifications of a base character. Signified by the Unicode designation "Mn" (mark, nonspacing),

### -field SpacingCombiningMark:6
Spacing character that indicates modifications of a base character and affects the width of the glyph for that base character. Signified by the Unicode designation "Mc" (mark, spacing combining).

### -field EnclosingMark:7
Enclosing mark character, which is a nonspacing combining character that surrounds all previous characters up to and including a base character. Signified by the Unicode designation "Me" (mark, enclosing).

### -field DecimalDigitNumber:8
Decimal digit character, which is a character in the range 0 through 9. Signified by the Unicode designation "Nd" (number, decimal digit).

### -field LetterNumber:9
Number represented by a letter, instead of a decimal digit. For example, the Roman numeral for five, which is "V". The indicator is signified by the Unicode designation "Nl" (number, letter).

### -field OtherNumber:10
Number that is neither a decimal digit nor a letter number. For example, the fraction 1/2. The indicator is signified by the Unicode designation "No" (number, other).

### -field SpaceSeparator:11
Space character, which has no glyph but is not a control or format character. Signified by the Unicode designation "Zs" (separator, space).

### -field LineSeparator:12
Character that is used to separate lines of text. Signified by the Unicode designation "Zl" (separator, line).

### -field ParagraphSeparator:13
Character that is used to separate paragraphs. Signified by the Unicode designation "Zp" (separator, paragraph).

### -field Control:14
Control code character, with a Unicode value of U+007F or in the range U+0000 through U+001F or U+0080 through U+009F. Signified by the Unicode designation "Cc" (other, control).

### -field Format:15
Format character that affects the layout of text or the operation of text processes, but is not normally rendered. Signified by the Unicode designation "Cf" (other, format).

### -field Surrogate:16
High surrogate or low surrogate character. Surrogate code values are in the range U+D800 through U+DFFF. Signified by the Unicode designation "Cs" (other, surrogate).

### -field PrivateUse:17
Private-use character, with a Unicode value in the range U+E000 through U+F8FF. Signified by the Unicode designation "Co" (other, private use).

### -field ConnectorPunctuation:18
Connector punctuation character that connects two characters. Signified by the Unicode designation "Pc" (punctuation, connector).

### -field DashPunctuation:19
Dash or hyphen character. Signified by the Unicode designation "Pd" (punctuation, dash).

### -field OpenPunctuation:20
Opening character of one of the paired punctuation marks, such as parentheses, square brackets, and braces. Signified by the Unicode designation "Ps" (punctuation, open).

### -field ClosePunctuation:21
Closing character of one of the paired punctuation marks, such as parentheses, square brackets, and braces. Signified by the Unicode designation "Pe" (punctuation, close).

### -field InitialQuotePunctuation:22
Opening or initial quotation mark character. Signified by the Unicode designation "Pi" (punctuation, initial quote).

### -field FinalQuotePunctuation:23
Closing or final quotation mark character. Signified by the Unicode designation "Pf" (punctuation, final quote).

### -field OtherPunctuation:24
Punctuation character that is not a connector, a dash, open punctuation, close punctuation, an initial quote, or a final quote. Signified by the Unicode designation "Po" (punctuation, other).

### -field MathSymbol:25
Mathematical symbol character, such as "+" or "=". Signified by the Unicode designation "Sm" (symbol, math).

### -field CurrencySymbol:26
Currency symbol character. Signified by the Unicode designation "Sc" (symbol, currency).

### -field ModifierSymbol:27
Modifier symbol character, which indicates modifications of surrounding characters. For example, the fraction slash indicates that the number to the left is the numerator and the number to the right is the denominator. The indicator is signified by the Unicode designation "Sk" (symbol, modifier).

### -field OtherSymbol:28
Symbol character that is not a mathematical symbol, a currency symbol or a modifier symbol. Signified by the Unicode designation "So" (symbol, other).

### -field NotAssigned:29
Character that is not assigned to any Unicode category. Signified by the Unicode code designation "Cn" (other, not assigned).


## -remarks
A member of this enumeration is returned by [GetGeneralCategory](unicodecharacters_getgeneralcategory_1785789586.md). A Unicode general category defines the broad classification of a character— that is, designation as a type of letter, decimal digit, separator, mathematical symbol, punctuation, and so on. See the [Unicode Standard Annex #44](https://www.unicode.org/reports/tr44/#General_Category_Values).

The values of this enumeration are compatible with the Microsoft .NET  [System.Globalization.UnicodeGeneralCategory](/dotnet/api/system.globalization.unicodecategory?view=dotnet-uwp-10.0&preserve-view=true) enumeration.

## -examples

## -see-also
[GetGeneralCategory](unicodecharacters_getgeneralcategory_1785789586.md), [System.Globalization.UnicodeGeneralCategory](/dotnet/api/system.globalization.unicodecategory?view=dotnet-uwp-10.0&preserve-view=true), [Unicode Standard Annex #44](https://www.unicode.org/reports/tr44/#General_Category_Values)
