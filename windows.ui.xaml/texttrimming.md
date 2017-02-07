---
-api-id: T:Windows.UI.Xaml.TextTrimming
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.TextTrimming : int
-->

# TextTrimming

## -description
Describes how text is trimmed when it overflows the edge of its containing box.

## -xaml-syntax
```xaml
<object property="enumMemberName"/>
```


## -enum-fields
### -field None:0
Text is not trimmed.

### -field CharacterEllipsis:1
**Introduced in .** Text is trimmed at a character boundary. An ellipsis (...) is drawn in place of remaining text.

### -field WordEllipsis:2
Text is trimmed at a word boundary. An ellipsis (...) is drawn in place of remaining text.

### -field Clip:3
**Introduced in .** Text is trimmed at a pixel level, visually clipping the excess glyphs.


## -remarks

## -examples

## -see-also
[RichTextBlock.TextTrimming property](../windows.ui.xaml.controls/richtextblock_texttrimming.md), [TextBlock.TextTrimming property](../windows.ui.xaml.controls/textblock_texttrimming.md)