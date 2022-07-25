---
-api-id: M:Windows.UI.Text.ITextRange.InRange(Windows.UI.Text.ITextRange)
-api-type: winrt method
---

<!-- Method syntax
public bool InRange(Windows.UI.Text.ITextRange range)
-->

# Windows.UI.Text.ITextRange.InRange

## -description
Determines whether this range is in or at the same text as a specified range.



## -parameters
### -param range
Text that is compared to the current range.

## -returns
The comparison result. The result can be null. The method returns **True** if the range is in or at the same text as [ITextRange](itextrange.md); otherwise it returns **False**.

## -remarks
For one range (range2) to be contained in another (range1), both ranges must be in the same story, and:


+ Both ranges must be degenerate and have identical insertion points, or
+ Range2 must be a nondegenerate range with start and end positions at or within those of the range1.


When the [ITextRange.FindText](itextrange_findtext_105657918.md) method is used, you can use one range to walk another by specifying the appropriate limit count of characters.

## -examples

## -see-also
[ITextRange.IsEqual](itextrange_isequal_565025630.md)
