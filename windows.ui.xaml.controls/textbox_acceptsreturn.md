---
-api-id: P:Windows.UI.Xaml.Controls.TextBox.AcceptsReturn
-api-type: winrt property
---

<!-- Property syntax
public bool AcceptsReturn { get;  set; }
-->

# Windows.UI.Xaml.Controls.TextBox.AcceptsReturn

## -description
Gets or sets the value that determines whether the text box allows and displays the newline or return characters.

## -xaml-syntax
```xaml
<TextBox AcceptsReturn="bool"/>
```


## -property-value
**true** if the text box allows newline characters; otherwise, **false**. The default is **false**.

## -remarks
If you change the [AcceptsReturn](textbox_acceptsreturn.md) property to **true**, text might be displayed differently due to text containing newline characters.

You can enable multi-line text in a [TextBox](textbox.md) control by using the [AcceptsReturn](textbox_acceptsreturn.md) property. Use the [ScrollViewer.HorizontalScrollBarVisibility](scrollviewer_horizontalscrollbarvisibility.md) or [ScrollViewer.VerticalScrollBarVisibility](scrollviewer_verticalscrollbarvisibilityproperty.md) attached properties to change scrollbar behavior. By default the scrollbars appear when the layout system calculates that the text exceeds the dimensions of the viewport for the [TextBox](textbox.md).

## -examples

## -see-also
[Display and edit text](https://msdn.microsoft.com/library/abb02e08-a40a-4973-8a7e-caeb3c694db3), [ScrollViewer](scrollviewer.md)
