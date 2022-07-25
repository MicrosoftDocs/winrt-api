---
-api-id: T:Windows.UI.Xaml.Controls.RowDefinition
-api-type: winrt class
---

<!-- Class syntax.
public class RowDefinition : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Controls.IRowDefinition
-->

# Windows.UI.Xaml.Controls.RowDefinition

## -description
Defines row-specific properties that apply to [Grid](grid.md) elements.



## -xaml-syntax
```xaml
<RowDefinition .../>

```


## -remarks

## -examples
The following example uses three [ColumnDefinitions](grid_columndefinitions.md) and three [RowDefinitions](grid_rowdefinitions.md) to create a grid that has nine cells, such as in a worksheet. Each cell contains a [TextBlock](textblock.md) element that represents data, and the top row contains a [TextBlock](textblock.md) with the [ColumnSpan](/uwp/api/windows.ui.xaml.controls.grid.columnspan) property applied.



[!code-xaml[ColumnDefinitionClassXAML](../windows.ui.xaml.controls/code/ColumnDefinitionClassXAMLSample/csharp/Page.xaml#SnippetColumnDefinitionClassXAML)]
<!-- <auto_snippet sample_id="ColumnDefinitionClassCodeSample" snippet_id="ColumnDefinitionClassCode"/> -->

## -see-also
[DependencyObject](../windows.ui.xaml/dependencyobject.md)
