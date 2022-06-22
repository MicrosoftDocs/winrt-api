---
-api-id: P:Windows.UI.Xaml.Controls.RichEditBox.ClipboardCopyFormat
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.RichEditClipboardFormat ClipboardCopyFormat { get;  set; }
-->

# Windows.UI.Xaml.Controls.RichEditBox.ClipboardCopyFormat

## -description
Gets or sets a value that specifies whether text is copied with all formats, or as plain text only.



## -property-value
An enumeration value that specifies whether text is copied with all formats, or as plain text only. The default is **AllFormats**.

## -remarks
By default, text copied from a [RichEditBox](richeditbox.md) is copied as both plain text and rich text. When the text is pasted into another app, the receiving app determines whether the plain text or rich text is used. To ensure that only plain text is pasted into a receiving app, set this property to **PlainText** to copy only plain text from the [RichEditBox](richeditbox.md).

## -examples
```xaml
<RichEditBox ClipboardCopyFormat="PlainText"/>
```

```csharp
RichEditBox editBox1 = new RichEditBox();
editBox1.ClipboardCopyFormat = RichEditClipboardFormat.PlainText;

```



## -see-also
