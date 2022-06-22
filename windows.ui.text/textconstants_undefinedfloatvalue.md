---
-api-id: P:Windows.UI.Text.TextConstants.UndefinedFloatValue
-api-type: winrt property
---

<!-- Property syntax
public float UndefinedFloatValue { get; }
-->

# Windows.UI.Text.TextConstants.UndefinedFloatValue

## -description
Gets the undefined floating-point value.



## -property-value
The undefined floating-point value.

## -remarks
When retrieving a floating-point format property, this value indicates that a range has at least two text runs with different values of that property. When setting such a property, this value indicates that the property is undefined; that is, it will not be applied if the [ITextCharacterFormat](itextcharacterformat.md) or [ITextParagraphFormat](itextparagraphformat.md) is applied to a range. This value is used with properties such as [ITextCharacterFormat.Size](itextcharacterformat_size.md).

## -examples

## -see-also
