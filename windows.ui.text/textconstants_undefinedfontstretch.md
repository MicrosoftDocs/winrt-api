---
-api-id: P:Windows.UI.Text.TextConstants.UndefinedFontStretch
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Text.FontStretch UndefinedFontStretch { get; }
-->

# Windows.UI.Text.TextConstants.UndefinedFontStretch

## -description
Gets the undefined font stretch value.



## -property-value
The undefined font stretch value.

## -remarks
When retrieving the font-stretch property, this value indicates that a range has at least two text runs with different values of that property. When setting a font-stretch property, this value indicates that the property is undefined; that is, it will not be applied if the [ITextCharacterFormat](itextcharacterformat.md) is applied to a range. This value is used with the [ITextCharacterFormat.FontStretch](itextcharacterformat_fontstretch.md) property.

## -examples

## -see-also
