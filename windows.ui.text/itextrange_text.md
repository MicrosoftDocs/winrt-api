---
-api-id: P:Windows.UI.Text.ITextRange.Text
-api-type: winrt property
---

<!-- Property syntax
public string Text { get;  set; }
-->

# Windows.UI.Text.ITextRange.Text

## -description
Gets or sets the plain text of the text range.



## -property-value
The plain text.

## -remarks
The Text property is the default property for [ITextRange](itextrange.md). As such, it is automatically invoked for the text range. For example: Some of the examples below use this fact. `print range`

The Text method substitutes a string for the range text. For processing a single character, the [ITextRange.Character](itextrange_character.md) property is more efficient than the Text property and doesn't require creating a single character range for storing a character.

If the range is degenerate, the Text property lets you insert text easily. You can also delete the text in a range:`range.delete
range = ""`

You can use the Text property to copy plain text from one place to another, simply by setting one range equal to another. The following statement sets the text of one range to that of another:`range1 = range2`

These ranges can be in different stories or even in different apps. However, they do imply copying the text first into a string and then from that string to the target location.

For large amounts of text, the [ITextRange.Copy](itextrange_copy_4862135.md) and [ITextRange.Paste](itextrange_paste_955889140.md) methods can be faster, because they can perform the copy directly from source to target and with any format supported by the source and target.

The text returned by the Text property is given in Unicode. The end-of-paragraph mark may be given by one of the following depending on the original file:
+ 0x2029 (the Unicode paragraph separator)
+ carriage return/line feed (CRLF) (0xd, 0xa)
+ CR alone (0xd)


The placeholder for an embedded object is given by the special character, WCH_EMBEDDING, which has the official Unicode value 0xFFFC.

## -examples

## -see-also
