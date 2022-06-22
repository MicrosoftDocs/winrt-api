---
-api-id: T:Windows.UI.Text.TextRangeUnit
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Text.TextRangeUnit : int
-->

# TextRangeUnit

## -description
Specifies the units to use when navigating a text range.



## -enum-fields
### -field Character:0
A single character.

### -field Word:1
A span of alphanumeric characters, an end of paragraph, or punctuation that includes any blanks that follow.

### -field Sentence:2
A string of text that meets the following criteria:
+ Ends with a period, question mark, or exclamation mark.
+ Is followed by one or more ASCII white space characters (9 through 0xd and 0x20), or the Unicode paragraph separator (0x2029). The trailing white space is part of the sentence.
+ The last sentence in a story does not need to have a period, question mark, or exclamation mark.
+ Other sentences must follow a sentence end and cannot begin with a period, question mark, or exclamation mark.
+ The start of a story qualifies as the start of a **Sentence**, even if the string there doesn't qualify as a sentence grammatically.


### -field Paragraph:3
A string of text terminated by an end-of-paragraph mark, such as carriage return/line feed (CR/LF), carriage return (CR), vertical tab(VT), line feed (LF), form feed (FF), or the Unicode paragraph separator (0x2029).

### -field Line:4
A single line of text on a display, provided that the display is associated with the range. If no display is associated with a range, **Line** is treated as **Paragraph**. A selection automatically has a display.

### -field Story:5
A story, which is a contiguous range of text in a document. For example, a story can contain one of the various parts of a document, such as the main text of a document, headers and footers, footnotes, or annotations. In a rich edit control, there is only one story per document, although a client can use multiple documents to represent multiple stories.

### -field Screen:6
The contents of a screen. Typically, a screen is the amount of content associated with the Page Up or Page Down key.

### -field Section:7
A section.

### -field Window:8
The characters between the upper-left and lower-right corners of the window.

### -field CharacterFormat:9
A text run of characters that all have identical character formatting properties.

### -field ParagraphFormat:10
A text run of characters that all have identical paragraph formatting properties.

### -field Object:11
An embedded object.

### -field HardParagraph:12
A paragraph that is ended by a carriage return (CR) or carriage return/line feed (CR/LF).

### -field Cluster:13
A complex-script cluster (occurs, for example, in Indic scripts).

### -field Bold:14
Bold text.

### -field Italic:15
Italic text.

### -field Underline:16
Underlined text.

### -field Strikethrough:17
Strikethrough text.

### -field ProtectedText:18
Protected text.

### -field Link:19
Hyperlink text.

### -field SmallCaps:20
Text in small caps.

### -field AllCaps:21
Text in all uppercase.

### -field Hidden:22
Hidden text.

### -field Outline:23
Outline text.

### -field Shadow:24
Shadow text.

### -field Imprint:25
Imprinted (engraved) text.

### -field Disabled:26
Disabled text.

### -field Revised:27
Revised text.

### -field Subscript:28
Text in the subscript character format.

### -field Superscript:29
Text in the superscript character format.

### -field FontBound:30
Text is in a font-bound font. That is, characters that can't be displayed with the current font were assigned a different font that could display the characters.

### -field LinkProtected:31
Characters in one or more contiguous, friendly-name hyperlinks. To work with single links that might be adjacent, use the **Link** unit.

### -field ContentLink:32
ContentLink text.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | ContentLink |

## -examples

## -see-also
[ITextSelection.HomeKey](itextselection_homekey_234543261.md), [ITextSelection.EndKey](itextselection_endkey_141627204.md), [ITextSelection.MoveLeft](itextselection_moveleft_1979591935.md), [ITextSelection.MoveUp](itextselection_moveup_1557792442.md), [ITextSelection.MoveDown](itextselection_movedown_1876359068.md), [ITextSelection.MoveRight](itextselection_moveright_1427894299.md), [ITextRange.Delete](itextrange_delete_876436284.md), [ITextRange.Expand](itextrange_expand_1312677017.md), [ITextRange.StartOf](itextrange_startof_1690436680.md), [ITextRange.EndOf](itextrange_endof_428994747.md), [ITextRange.Move](itextrange_move_1126378751.md), [ITextRange.MoveStart](itextrange_movestart_65838126.md), [ITextRange.MoveEnd](itextrange_moveend_1212634036.md), [ITextRange.SetIndex](itextrange_setindex_1017096528.md), [ITextRange.GetIndex](itextrange_getindex_825085340.md)
