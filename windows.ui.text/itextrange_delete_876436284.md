---
-api-id: M:Windows.UI.Text.ITextRange.Delete(Windows.UI.Text.TextRangeUnit,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public int Delete(Windows.UI.Text.TextRangeUnit unit, System.Int32 count)
-->

# Windows.UI.Text.ITextRange.Delete

## -description
Deletes text from the text range.



## -parameters
### -param unit
The unit of text to delete.

### -param count
The number of *units* to delete. See Remarks.

## -returns
The number of *units* deleted. Deleting the text in a nondegenerate text range counts as one *unit*.

## -remarks
If *count* is zero, this method deletes all text in the text range. Nothing is deleted if the text range is only an insertion point (that is, a degenerate range).

If *count* is not zero, and the range is an insertion point, `| count |` (absolute value of *count*) units are deleted in the logical direction given by the sign of count, where a positive value is toward the end of the story, and a negative value is toward the start of the story.

If *count* is not zero, and the range is nondegenerate (contains text), the text in the range is deleted regardless of the values of *unit* and *count*, resulting in an insertion point. Then, `| count | - 1` units are deleted in the logical direction given by the sign of count.

The text in the range can also be deleted by assigning a null string to the range.

Deleting the CR results in the following behavior:
+ If you delete just the CR but the paragraph includes text, the CR is deleted, and the following paragraph gets the same paragraph formatting as the current one.
+ If you delete the CR as well as some, but not all, of the characters in the following paragraph, the characters left over from the current paragraph get the paragraph formatting of the following paragraph.
+ If you select to the end of a paragraph, but not the whole paragraph, the CR is not deleted.
+ If you delete the whole paragraph (from the beginning through the CR), you delete the CR as well (unless it is the final CR in the file).


## -examples

## -see-also
