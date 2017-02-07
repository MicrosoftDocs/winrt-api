---
-api-id: T:Windows.UI.Xaml.TextReadingOrder
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.TextReadingOrder : int
-->

# TextReadingOrder

## -description
Provides a value for **TextReadingOrder** properties.

## -xaml-syntax
```xaml
<object property="textReadingOrderMemberName"/>
```


## -enum-fields
### -field Default:0
Do not detect flow direction from content. Use [FlowDirection](flowdirection.md) value (if any) for reading order decisions. (Windows 8.1)

### -field UseFlowDirection:0
Do not detect flow direction from content. Use [FlowDirection](flowdirection.md) value (if any) for reading order decisions. (Starting with Windows 10)

### -field DetectFromContent:1
Detect flow direction from text content. For bidirectional text, text containers will infer the reading order for text based on the content. See Remarks.


## -remarks
> [!IMPORTANT]
> Starting with Windows 10, the enumeration value **0** has the constant name **UseFlowDirection**.

The **TextReadingOrder** properties influences the reading order (left-to-right or right-to-left) of individual UI elements that contain bidirectional text. These properties can be set to `TextReadingOrder ="DetectFromContent"` so that content can be detected dynamically, rather than using a **FlowDirection** property on a content parent. The **DetectFromContent** logic uses the first strong character in each paragraph to determine the reading direction for the paragraph, based on the [Unicode Bidirectional Algorithm, P2](http://go.microsoft.com/fwlink/p/?LinkId=306404).

This property can be useful when the base direction of the text is unknown, and may not match the user's language or direction. For more info see [How to support bidirectional UI](http://msdn.microsoft.com/library/66f92aff-6f1c-428f-b06f-b2892a8015b7).

If content is coming from data binding, this avoids the need for binding to **FlowDirection** with a converter that interprets right-to-left locale info that comes from the data.

Unlike **FlowDirection** and its logic, the reading order logic for **DetectFromContent** will not affect the alignment of the text within the text control, it just adjusts the order in which blocks of bidirectional text are laid out.

## -examples

## -see-also
[FlowDirection](flowdirection.md), [PasswordBox.TextReadingOrder](../windows.ui.xaml.controls/passwordbox_textreadingorder.md), [RichEditBox.TextReadingOrder](../windows.ui.xaml.controls/richeditbox_textreadingorder.md), [RichTextBlock.TextReadingOrder](../windows.ui.xaml.controls/richtextblock_textreadingorder.md), [TextBlock.TextReadingOrder](../windows.ui.xaml.controls/textblock_textreadingorder.md), [TextBox.TextReadingOrder](../windows.ui.xaml.controls/textbox_textreadingorder.md), [How to support bidirectional UI](http://msdn.microsoft.com/library/66f92aff-6f1c-428f-b06f-b2892a8015b7)