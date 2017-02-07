---
-api-id: T:Windows.UI.Xaml.TextAlignment
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.TextAlignment : int
-->

# TextAlignment

## -description
Specifies whether text is centered, left-aligned, or right-aligned.

## -xaml-syntax
```xaml
<object property="textAlignmentMemberName"/>
```


## -enum-fields
### -field Center:0
Text is centered within the container.

### -field Left:1
Text is aligned to the left edge of the container.

### -field Right:2
Text is aligned to the right edge of the container.

### -field Justify:3
Text is justified within the container.

### -field DetectFromContent:4
Text alignment is inferred from the text content.


## -remarks
**DetectFromContent** is available starting with Windows 10. When the **TextAlignment** property is set to **DetectFromContent**, alignment is inferred from the text content of the control. For example, English text is left aligned, and Arabic text is right aligned.

## -examples

## -see-also
[RichEditBox.TextAlignment](../windows.ui.xaml.controls/richeditbox_textalignment.md), [RichTextBlock.TextAlignment](../windows.ui.xaml.controls/richtextblock_textalignment.md), [TextBlock.TextAlignment](../windows.ui.xaml.controls/textblock_textalignment.md), [TextBox.TextAlignment](../windows.ui.xaml.controls/textbox_textalignment.md), [FlowDirection](flowdirection.md), [How to support bidirectional UI](http://msdn.microsoft.com/library/66f92aff-6f1c-428f-b06f-b2892a8015b7)