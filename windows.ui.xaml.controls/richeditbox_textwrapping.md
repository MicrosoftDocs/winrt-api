---
-api-id: P:Windows.UI.Xaml.Controls.RichEditBox.TextWrapping
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.TextWrapping TextWrapping { get;  set; }
-->

# Windows.UI.Xaml.Controls.RichEditBox.TextWrapping

## -description
Gets or sets a value that indicates how text wrapping occurs if a line of text extends beyond the available width of the [RichEditBox](richeditbox.md).



## -xaml-syntax
```xaml
<RichEditBox TextWrapping="Wrap"/>
-or-
<RichEditBox TextWrapping="NoWrap"/>
```


## -property-value
One of the [TextWrapping](../windows.ui.xaml/textwrapping.md) enumeration values that specifies whether text is wrapped. The default is **Wrap**.

## -remarks
[TextBox](textbox.md) and [RichEditBox](richeditbox.md) don't support the **WrapWholeWords** value for their **TextWrapping** properties. If you try to use **WrapWholeWords** as a value for [TextBox.TextWrapping](textbox_textwrapping.md) or RichEditBox.TextWrapping an invalid argument exception is thrown.

## -examples

## -see-also
