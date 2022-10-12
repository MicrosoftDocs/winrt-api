---
-api-id: P:Windows.UI.Xaml.Controls.TreeView.ItemTemplate
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public DataTemplate ItemTemplate { get;  set; }
-->

# Windows.UI.Xaml.Controls.TreeView.ItemTemplate

## -description

Gets or sets the [DataTemplate](../windows.ui.xaml/datatemplate.md) used to display each item.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.TreeView.ItemTemplate](/windows/winui/api/microsoft.ui.xaml.controls.treeview.itemtemplate) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<TreeView>
  <TreeView.ItemTemplate>
    singleDataTemplate
  </TreeView.ItemTemplate>
</TreeView>
- or -
<TreeView ItemTemplate="resourceReferenceToDataTemplate"/>
```

## -xaml-values

<dl><dt>singleDataTemplate</dt><dd>singleDataTemplateA single DataTemplate object element. That DataTemplate would typically have multiple child elements that define the visual appearance of the data representation.</dd>
<dt>resourceReferenceToDataTemplate</dt><dd>resourceReferenceToDataTemplateA resource reference to an existing DataTemplate from a resources collection. The resource reference must specify the desired DataTemplate by key through a {StaticResource} markup extension usage.</dd>
</dl>

## -property-value

The template that specifies the visualization of the data objects. The default is **null**.

## -remarks


In Windows 10, version 1803, there is no **ItemTemplate** property. Instead, you have to re-template the **TreeView** control and specify a custom **ItemTemplate** if your content is not a string. This example shows how to apply a [DataTemplate](../windows.ui.xaml/datatemplate.md) to a tree view item in Windows 10, version 1803. For the code that defines `Item` and populates the **TreeView**, see the "[Tree view using data binding](/windows/uwp/design/controls-and-patterns/tree-view#tree-view-using-data-binding)" example in the _TreeView_ article.

```xaml
<Page.Resources>
    <DataTemplate x:Key="TreeViewItemDataTemplate" x:DataType="local:Item">
        <TreeViewItem ItemsSource="{x:Bind Children}"
                      Content="{x:Bind Name}"/>
    </DataTemplate>

    <Style TargetType="TreeView">
        <Setter Property="IsTabStop" Value="False" />
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="TreeView">
                    <TreeViewList x:Name="ListControl"
                                  ItemTemplate="{StaticResource TreeViewItemDataTemplate}"
                                  ItemContainerStyle="{StaticResource TreeViewItemStyle}"
                                  CanDragItems="True"
                                  AllowDrop="True"
                                  CanReorderItems="True">
                        <TreeViewList.ItemContainerTransitions>
                            <TransitionCollection>
                                <ContentThemeTransition />
                                <ReorderThemeTransition />
                                <EntranceThemeTransition IsStaggeringEnabled="False" />
                            </TransitionCollection>
                        </TreeViewList.ItemContainerTransitions>
                    </TreeViewList>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
    </Style>
</Page.Resources>
<Grid>
    <TreeView Name="DessertTree"
              ItemsSource="{x:Bind DataSource}"/>
</Grid>
```

## -see-also

## -examples

This example shows how to apply a [DataTemplate](../windows.ui.xaml/datatemplate.md) for a locally defined `Item` object. For the code that defines `Item` and populates the **TreeView**, see the "[Tree view using data binding](/windows/uwp/design/controls-and-patterns/tree-view#tree-view-using-data-binding)" example in the _TreeView_ article.

```xaml
<TreeView Name="DessertTree"
          SelectionMode="Multiple"
          ItemsSource="{x:Bind DataSource}">
    <TreeView.ItemTemplate>
        <DataTemplate x:DataType="local:Item">
            <TreeViewItem ItemsSource="{x:Bind Children}"
                          Content="{x:Bind Name}"/>
        </DataTemplate>
    </TreeView.ItemTemplate>
</TreeView>
```

