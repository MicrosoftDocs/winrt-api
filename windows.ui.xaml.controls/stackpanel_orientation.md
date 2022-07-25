---
-api-id: P:Windows.UI.Xaml.Controls.StackPanel.Orientation
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.Orientation Orientation { get;  set; }
-->

# Windows.UI.Xaml.Controls.StackPanel.Orientation

## -description
Gets or sets the dimension by which child elements are stacked.



## -xaml-syntax
```xaml
<StackPanel Orientation="Horizontal"/>
-or-
<StackPanel Orientation="Vertical"/>
```


## -property-value
One of the enumeration values that specifies the orientation of child elements. The default is **Vertical**.
## -remarks

## -examples
The following example creates a horizontal list of items by setting the Orientation property to **Horizontal**.

[!code-xaml[LayoutOvwStackPanel_2](../windows.ui.xaml/code/layout_ovw_all/CSharp/MainPage.xaml#SnippetLayoutOvwStackPanel_2)]

## -see-also
