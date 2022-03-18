---
-api-id: T:Windows.UI.Xaml.Controls.Pivot
-api-type: winrt class
---

<!-- Class syntax.
public class Pivot : Windows.UI.Xaml.Controls.ItemsControl, Windows.UI.Xaml.Controls.IPivot, Windows.UI.Xaml.Controls.IPivot2, Windows.UI.Xaml.Controls.IPivot3
-->

# Windows.UI.Xaml.Controls.Pivot

## -description

Represents a control that provides quick navigation of views within an app.

Equivalent WinUI class: [Microsoft.UI.Xaml.Controls.Pivot](/windows/winui/api/microsoft.ui.xaml.controls.pivot).

## -xaml-syntax

```xaml

<Pivot .../>
-or-
<Pivot ...>
  oneOrMorePivotItems
</Pivot>

```

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Pivot](/windows/uwp/design/controls-and-patterns/pivot).

Use a Pivot to present groups of content that a user can swipe through. You typically use a Pivot as the top level control on a page.

Pivot is an [ItemsControl](itemscontrol.md), so it can contain a collection of items of any type. Any item you add to the Pivot that is not explicitly a [PivotItem](pivotitem.md) is implicitly wrapped in a [PivotItem](pivotitem.md). Because a Pivot is often used to navigate between pages of content, it's common to populate the [Items](itemscontrol_items.md) collection directly with XAML UI elements. Or, you can set the [ItemsSource](itemscontrol_itemssource.md) property to a data source. Items bound in the [ItemsSource](itemscontrol_itemssource.md) can be of any type, but if they aren't explicitly [PivotItem](pivotitem.md) s, you must define an [ItemTemplate](itemscontrol_itemtemplate.md) and [HeaderTemplate](pivot_headertemplate.md) to specify how the items are displayed.

<!--<note>You can define an <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.itemscontrol_itemtemplate">ItemTemplate</xref> whether <xref targtype="class_winrt" rid="w_ui_xaml_ctrl.pivot">Pivot</xref> is populated through the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.itemscontrol_items">Items</xref> or <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.itemscontrol_itemssource">ItemsSource</xref> property. If you populate the <xref targtype="class_winrt" rid="w_ui_xaml_ctrl.pivot">Pivot</xref> by setting the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.itemscontrol_itemssource">ItemsSource</xref> property, the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.itemscontrol_itemtemplate">ItemTemplate</xref> is applied to every item. If you populate the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.itemscontrol_items">Items</xref> collection directly, the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.itemscontrol_itemtemplate">ItemTemplate</xref> is applied only if the item is not a <xref targtype="class_winrt" rid="w_ui_xaml_ctrl.pivotitem">PivotItem</xref>.</note>-->

You can use the [SelectedItem](pivot_selecteditem.md) property to get or set the Pivot's active item. Use the [SelectedIndex](pivot_selectedindex.md) property to get or set the index of the active item.

You can use the [LeftHeader](pivot_leftheader.md) and [RightHeader](pivot_rightheader.md) properties to add other controls to the Pivot header.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (SDK 14393), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the Pivot control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>PivotBackground</td><td>Control background color</td></tr>
   <tr><td>PivotHeaderBackground</td><td>Header background color</td></tr>
   <tr><td>PivotNextButtonForeground</td><td>Button icon color at rest</td></tr>
   <tr><td>PivotNextButtonForegroundPointerOver</td><td>Button icon color on hover</td></tr>
   <tr><td>PivotNextButtonForegroundPressed</td><td>Button icon color when pressed</td></tr>
   <tr><td>PivotNextButtonBackground</td><td>Button background color at rest</td></tr>
   <tr><td>PivotNextButtonBackgroundPointerOver</td><td>Button background color on hover</td></tr>
   <tr><td>PivotNextButtonBackgroundPressed</td><td>Button background color when pressed</td></tr>
   <tr><td>PivotNextButtonBorderBrush</td><td>Button border color at rest</td></tr>
   <tr><td>PivotNextButtonBorderBrushPointerOver</td><td>Button border color on hover</td></tr>
   <tr><td>PivotNextButtonBorderBrushPressed</td><td>Button border color when pressed</td></tr>
   <tr><td>PivotPreviousButtonForeground</td><td>Button icon color at rest</td></tr>
   <tr><td>PivotPreviousButtonForegroundPointerOver</td><td>Button icon color on hover</td></tr>
   <tr><td>PivotPreviousButtonForegroundPressed</td><td>Button icon color when pressed</td></tr>
   <tr><td>PivotPreviousButtonBackground</td><td>Button background color at rest</td></tr>
   <tr><td>PivotPreviousButtonBackgroundPointerOver</td><td>Button background color on hover</td></tr>
   <tr><td>PivotPreviousButtonBackgroundPressed</td><td>Button background color when pressed</td></tr>
   <tr><td>PivotPreviousButtonBorderBrush</td><td>Button border color at rest</td></tr>
   <tr><td>PivotPreviousButtonBorderBrushPointerOver</td><td>Button border color on hover</td></tr>
   <tr><td>PivotPreviousButtonBorderBrushPressed</td><td>Button border color when pressed</td></tr>
</table>

### XAML attached properties

Pivot is the host service class for a [XAML attached property](/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| SlideInAnimationGroup | Gets or sets the slide-in animation group of a child element in a Pivot container.<ul><li>Type: [PivotSlideInAnimationGroup](pivotslideinanimationgroup.md)</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.pivot.slideinanimationgroupproperty">SlideInAnimationGroupProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.pivot.getslideinanimationgroup">GetSlideInAnimationGroup</a>, <a href="/uwp/api/windows.ui.xaml.controls.pivot.setslideinanimationgroup">SetSlideInAnimationGroup</a></li></ul> |

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | HeaderFocusVisualPlacement |
| 1607 | 14393 | IsHeaderItemsCarouselEnabled |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Pivot](/windows/uwp/design/controls-and-patterns/pivot).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the Pivot in action](xamlcontrolsgallery:/item/Pivot).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

For more examples, see the [Pivot sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlPivot).

This example shows a Pivot with 3 items. It also has a [RightHeader](pivot_rightheader.md) with forward and back buttons that use [SelectedIndex](pivot_selectedindex.md) to let a user navigate through the items.

```xaml
<Pivot x:Name="rootPivot" Title="PIVOT TITLE">
    <Pivot.RightHeader>
        <CommandBar ClosedDisplayMode="Compact">
            <AppBarButton Icon="Back" Label="Previous" Click="BackButton_Click"/>
            <AppBarButton Icon="Forward" Label="Next" Click="NextButton_Click"/>
        </CommandBar>
    </Pivot.RightHeader>
    <PivotItem Header="Pivot Item 1">
        <!--Pivot content goes here-->
        <TextBlock Text="Content of pivot item 1."/>
    </PivotItem>
    <PivotItem Header="Pivot Item 2">
        <!--Pivot content goes here-->
        <TextBlock Text="Content of pivot item 2."/>
    </PivotItem>
    <PivotItem Header="Pivot Item 3">
        <!--Pivot content goes here-->
        <TextBlock Text="Content of pivot item 3."/>
    </PivotItem>
</Pivot>
```

```csharp
private void BackButton_Click(object sender, RoutedEventArgs e)
{
    if (rootPivot.SelectedIndex > 0)
    {
        // If not at the first item, go back to the previous one.
        rootPivot.SelectedIndex -= 1;
    }
    else
    {
        // The first PivotItem is selected, so loop around to the last item.
        rootPivot.SelectedIndex = rootPivot.Items.Count-1;
    }
}

private void NextButton_Click(object sender, RoutedEventArgs e)
{
    if (rootPivot.SelectedIndex < rootPivot.Items.Count-1)
    {
        // If not at the last item, go to the next one.
        rootPivot.SelectedIndex += 1;
    }
    else
    {
        // The last PivotItem is selected, so loop around to the first item.
        rootPivot.SelectedIndex = 0;
    }
}
```

## -see-also

[Pivot overview](/windows/uwp/design/controls-and-patterns/pivot)
