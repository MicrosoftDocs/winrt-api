---
-api-id: P:Windows.UI.Xaml.Controls.Grid.RowDefinitions
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.RowDefinitionCollection RowDefinitions { get; }
-->

# Windows.UI.Xaml.Controls.Grid.RowDefinitions

## -description
Gets a list of [RowDefinition](rowdefinition.md) objects defined on this instance of [Grid](grid.md).



## -xaml-syntax
```xaml
<Grid>
  <Grid.RowDefinitions>
    oneOrMoreRowDefinitions
  </Grid.RowDefinitions>
</Grid>
```


## -xaml-values
<dl><dt>oneOrMoreRowDefinitions</dt><dd>oneOrMoreRowDefinitionsOne or more RowDefinition elements. Each such RowDefinition becomes a placeholder representing a row in the final grid layout.</dd>
</dl>
## -property-value
A list of [RowDefinition](rowdefinition.md) objects defined on this instance of [Grid](grid.md).

## -remarks

## -examples
The following example creates a [Grid](grid.md) with three rows. The [Height](rowdefinition_height.md) of the first row is set to the value **Auto**, which distributes height evenly based on the size of the content that is within that row. The height of the second row and third row are set to 2* and * respectively. The second row gets 2/3 of the remaining space and the third row gets 1/3.



[!code-xaml[RowDefinitions](../windows.ui.xaml/code/GridReferenceSample/csharp/Page.xaml#SnippetRowDefinitions)]

- **Star (*)** : It will take the remaining space when Auto and fixed sized are filled.

## -see-also
[ColumnDefinitions](grid_columndefinitions.md), [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml)
