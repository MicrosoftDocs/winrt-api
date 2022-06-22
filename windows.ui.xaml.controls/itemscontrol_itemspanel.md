---
-api-id: P:Windows.UI.Xaml.Controls.ItemsControl.ItemsPanel
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.ItemsPanelTemplate ItemsPanel { get;  set; }
-->

# Windows.UI.Xaml.Controls.ItemsControl.ItemsPanel

## -description
Gets or sets the template that defines the panel that controls the layout of items.



## -xaml-syntax
```xaml
<itemsControl>
  <itemsControl.ItemsPanel>
    singlePanelTemplate
  </itemsControl.ItemsPanel>
</itemsControl>
- or -
<itemsControl ItemsPanel="resourceReferenceToPanelTemplate"/>
```


## -xaml-values
<dl><dt>singlePanelTemplate</dt><dd>singlePanelTemplateA single ItemsPanelTemplate object element. That ItemsPanelTemplate would typically have multiple child elements that define the panel layout.</dd>
<dt>resourceReferenceToPanelTemplate</dt><dd>resourceReferenceToPanelTemplateA resource reference to an existing ItemsPanelTemplate from a resources collection. The resource reference must specify the desired ItemsPanelTemplate by key.</dd>
</dl>
## -property-value
An [ItemsPanelTemplate](itemspaneltemplate.md) that defines the panel to use for the layout of the items. The default value for the [ItemsControl](itemscontrol.md) is an [ItemsPanelTemplate](itemspaneltemplate.md) that specifies a [StackPanel](stackpanel.md).

Subtypes of ItemsControl may use different default ItemsPanelTemplates. For example, [ListView](/uwp/api/windows.ui.xaml.controls.listview)s by default use an [ItemsStackPanel](/uwp/api/Windows.UI.Xaml.Controls.ItemsStackPanel). Using a different type may cause unexpected behavior; for example using a plain StackPanel as the ListView's ItemsPanel can regress Narrator behavior during drag and drop.

## -remarks
> [!NOTE]
> [ComboBox](combobox.md) uses a [CarouselPanel](../windows.ui.xaml.controls.primitives/carouselpanel.md) as its ItemsPanel. Using a different panel as the ItemsPanel of [ComboBox](combobox.md) is not supported and might result in undesired behavior.

## -examples

Replace the default panel used in a ListView with an [ItemsStackPanel](/uwp/api/Windows.UI.Xaml.Controls.ItemsStackPanel) that has its Orientation changed to Horizontal.

```xaml
<ListView>
    <x:String>Hello</x:String>
    <x:String>World</x:String>

    <ItemsControl.ItemsPanel>
        <ItemsPanelTemplate>
            <ItemsStackPanel Orientation="Horizontal" />
        </ItemsPanelTemplate>
    </ItemsControl.ItemsPanel>
</ListView>
```

## -see-also
