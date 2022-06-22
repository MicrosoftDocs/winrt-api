---
-api-id: P:Windows.UI.Xaml.Controls.RichEditBox.TextReadingOrder
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.TextReadingOrder TextReadingOrder { get;  set; }
-->

# Windows.UI.Xaml.Controls.RichEditBox.TextReadingOrder

## -description
Gets or sets a value that indicates how the reading order is determined for the [RichEditBox](richeditbox.md).



## -xaml-syntax
```xaml
<RichEditBox TextReadingOrder="textReadingOrderValue"/>
```


## -xaml-values
<dl><dt>textReadingOrderValue</dt><dd>textReadingOrderValue A named constant of the TextReadingOrder enumeration, such as DetectFromContent.</dd>
</dl>
## -property-value
A value that indicates how the reading order is determined for the [RichEditBox](richeditbox.md). The default is **DetectFromContent**.

## -remarks
This property can be useful when the base direction of the text is unknown, and may not match the user's language or direction. For more info, see the Remarks section of the [TextReadingOrder](../windows.ui.xaml/textreadingorder.md) enumeration or [How to support bidirectional UI](/previous-versions/windows/apps/jj712703(v=win.10)).

## -examples

## -see-also
[TextReadingOrder](../windows.ui.xaml/textreadingorder.md), [How to support bidirectional UI](/previous-versions/windows/apps/jj712703(v=win.10))
