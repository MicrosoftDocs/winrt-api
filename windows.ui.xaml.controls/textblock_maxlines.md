---
-api-id: P:Windows.UI.Xaml.Controls.TextBlock.MaxLines
-api-type: winrt property
---

<!-- Property syntax
public int MaxLines { get;  set; }
-->

# Windows.UI.Xaml.Controls.TextBlock.MaxLines

## -description
Gets or sets the maximum number of lines of text shown in the [TextBlock](textblock.md).



## -xaml-syntax
```xaml
<TextBlock MaxLines="int"/>
```


## -property-value
The maximum number of lines of text shown in the [TextBlock](textblock.md). The default is 0, which is a special value that represents "Auto" behavior. The value cannot be negative.

## -remarks
Use the **MaxLines** property to specify the maximum number of lines of text shown in a text block. The text control will adjust its height to show no more than the specified number of lines, regardless of the font size, font style, or text length.

Negative integer values are invalid, and will cause a run-time exception.

## -examples

## -see-also
