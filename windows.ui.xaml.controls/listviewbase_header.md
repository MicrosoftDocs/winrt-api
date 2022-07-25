---
-api-id: P:Windows.UI.Xaml.Controls.ListViewBase.Header
-api-type: winrt property
---

<!-- Property syntax
public object Header { get;  set; }
-->

# Windows.UI.Xaml.Controls.ListViewBase.Header

## -description
Gets or sets the content for the list header.



## -xaml-syntax
```xaml
<listViewBase Header="headerString"/>
- or -
<listViewBase>
  <listViewBase.Header>
    headerObject
  </listViewBase.Header>
</listViewBase>

```


## -xaml-values
<dl><dt>headerString</dt><dd>headerStringA text string that serves as header content.</dd>
<dt>headerObject</dt><dd>headerObjectAn single object element that serves as header content. Use discretion when using objects as header content; not all objects are suitable for use within the limited presentation surface that appears for headers.</dd>
</dl>
## -property-value
The content of the list header. The default value is **null**.

## -remarks
By default, the header is shown at the top for a [ListView](listview.md), and on the left for a [GridView](gridview.md). If the [FlowDirection](../windows.ui.xaml/frameworkelement_flowdirection.md) property is set to [RightToLeft](../windows.ui.xaml/flowdirection.md), the header is shown on the right for a [GridView](gridview.md).

You can use a data template for the Header by setting the [HeaderTemplate](listviewbase_headertemplate.md) property.

## -examples
Here's a [GridView](gridview.md) header that contains a [StackPanel](stackpanel.md) with text and an image. This Extensible Application Markup Language (XAML) is a simplified version of the [GridView](gridview.md) used in `GroupDetail` page of the Microsoft Visual Studio  **Grid App** template.



[!code-xaml[GridViewHeader](../windows.ui.xaml.controls/code/ListAndGridViewSnippets/csharp/SplitPage.xaml#SnippetGridViewHeader)]

## -see-also
[HeaderTemplate](listviewbase_headertemplate.md), [HeaderTransitions](listviewbase_headertransitions.md), [FlowDirection](../windows.ui.xaml/frameworkelement_flowdirection.md)
