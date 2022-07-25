---
-api-id: P:Windows.UI.Text.TextConstants.UndefinedColor
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Color UndefinedColor { get; }
-->

# Windows.UI.Text.TextConstants.UndefinedColor

## -description
Gets the undefined color value.



## -property-value
The undefined color.

## -remarks
When retrieving a character-format color property, this value indicates that a range has at least two text runs with different values of that character-format color property. When setting a character-format color property, this value indicates that the property is undefined; that is, it will not be applied if the [ITextCharacterFormat](itextcharacterformat.md) is applied to a range. This value is used with properties such as [ITextCharacterFormat.BackgroundColor](itextcharacterformat_backgroundcolor.md).

## -examples

## -see-also
