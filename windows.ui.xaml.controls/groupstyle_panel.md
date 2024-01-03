---
-api-id: P:Windows.UI.Xaml.Controls.GroupStyle.Panel
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.ItemsPanelTemplate Panel { get;  set; }
-->

# Windows.UI.Xaml.Controls.GroupStyle.Panel

## -description
Gets or sets a template that creates the panel used to lay out the items.



## -xaml-syntax
```xaml
<GroupStyle Panel="itemsPanelTemplateReference" />
- or -
<GroupStyle>
  <GroupStyle.Panel>
    singleItemsPanelTemplate
  </GroupStyle.Panel>
</GroupStyle>  
```


## -xaml-values
<dl><dt>itemsPanelTemplateReference</dt><dd>itemsPanelTemplateReferenceA reference to an existing ItemsPanelTemplate. Typically this is a keyed resource, which you reference through {StaticResource} markup extension.</dd>
<dt>singleItemsPanelTemplate</dt><dd>singleItemsPanelTemplateA single ItemsPanelTemplate object element defined inline, which declares the items template for the view.</dd>
</dl>
## -property-value
An [ItemsPanelTemplate](itemspaneltemplate.md) object that creates the panel used to layout the items.

## -remarks
An [ItemsPanelTemplate](itemspaneltemplate.md) object element should contain exactly one [FrameworkElement](../windows.ui.xaml/frameworkelement.md)-derived class that serves as the root element for items. In most cases this is a [Panel](panel.md)-derived class. The expanded template serves as the parent for the realized items and there generally is more than one item. Therefore the XAML content property of the intended root element of an [ItemsPanelTemplate](itemspaneltemplate.md) should support a collection, as [Panel.Children](panel_children.md) does.

> [!IMPORTANT]
> The root element of the template declared for the [ItemsPanelTemplate](itemspaneltemplate.md) in the GroupStyle.Panel property cannot be a virtualizing panel. Virtualizing panels are defined as any type that derives from [VirtualizingPanel](virtualizingpanel.md), for example the [VirtualizingStackPanel](virtualizingstackpanel.md) class.

## -examples

## -see-also
