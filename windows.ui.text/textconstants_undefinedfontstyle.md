---
-api-id: P:Windows.UI.Text.TextConstants.UndefinedFontStyle
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Text.FontStyle UndefinedFontStyle { get; }
-->

# Windows.UI.Text.TextConstants.UndefinedFontStyle

## -description
Gets the undefined font style.



## -property-value
The undefined font style.

## -remarks
When retrieving the font-style property, this value indicates that a range has at least two text runs with different values of that property. When setting the font-style property, this value indicates that the property is undefined; that is, it will not be applied if the [ITextCharacterFormat](itextcharacterformat.md) is applied to a range. This value is used with the [ITextCharacterFormat.FontStyle](itextcharacterformat_fontstyle.md) property.

## -examples

## -see-also
