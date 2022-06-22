---
-api-id: P:Windows.UI.Text.TextConstants.UndefinedInt32Value
-api-type: winrt property
---

<!-- Property syntax
public int UndefinedInt32Value { get; }
-->

# Windows.UI.Text.TextConstants.UndefinedInt32Value

## -description
Gets the undefined 32-bit integer value.



## -property-value
The undefined 32-bit integer value.

## -remarks
When retrieving an integer format property, this value indicates that a range has at least two text runs with different values of that property. When setting such a property, this value indicates that the property is undefined; that is, it will not be applied if the [ITextCharacterFormat](itextcharacterformat.md) or [ITextParagraphFormat](itextparagraphformat.md) is applied to a range. This value is used with properties such as [ITextCharacterFormat.ListStart](itextparagraphformat_liststart.md).

## -examples

## -see-also
