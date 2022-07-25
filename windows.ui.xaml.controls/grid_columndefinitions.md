---
-api-id: P:Windows.UI.Xaml.Controls.Grid.ColumnDefinitions
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.ColumnDefinitionCollection ColumnDefinitions { get; }
-->

# Windows.UI.Xaml.Controls.Grid.ColumnDefinitions

## -description
Gets a list of [ColumnDefinition](columndefinition.md) objects defined on this instance of [Grid](grid.md).



## -xaml-syntax
```xaml
<Grid>
  <Grid.ColumnDefinitions>
    oneOrMoreColumnDefinitions
  </Grid.ColumnDefinitions>
</Grid>
```


## -xaml-values
<dl><dt>oneOrMoreColumnDefinitions</dt><dd>oneOrMoreColumnDefinitionsOne or more ColumnDefinition elements. Each such ColumnDefinition becomes a placeholder representing a column in the final grid layout.</dd>
</dl>
## -property-value
A list of [ColumnDefinition](columndefinition.md) objects defined on this instance of [Grid](grid.md).

## -remarks

## -examples
The following example creates a [Grid](grid.md) with two columns by using [ColumnDefinition](columndefinition.md) s.



[!code-xaml[ColumnDefinitions](../windows.ui.xaml/code/GridReferenceSample/csharp/Page.xaml#SnippetColumnDefinitions)]

## -see-also
[RowDefinitions](grid_rowdefinitions.md), [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml)
