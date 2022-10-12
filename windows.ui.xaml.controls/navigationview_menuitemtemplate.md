---
-api-id: P:Windows.UI.Xaml.Controls.NavigationView.MenuItemTemplate
-api-type: winrt property
---

<!-- Property syntax.
public DataTemplate MenuItemTemplate { get;  set; }
-->

# Windows.UI.Xaml.Controls.NavigationView.MenuItemTemplate

## -description

Gets or sets the [DataTemplate](../windows.ui.xaml/datatemplate.md) used to display each menu item.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.NavigationView.MenuItemTemplate](/windows/winui/api/microsoft.ui.xaml.controls.navigationview.menuitemtemplate) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<NavigationMenu>
  <NavigationMenu.MenuItemTemplate>
    singleDataTemplate
  </NavigationMenu.MenuItemTemplate>
</NavigationMenu>
- or -
<NavigationMenu MenuItemTemplate="resourceReferenceToDataTemplate"/>
```


## -xaml-values

<dl><dt>singleDataTemplate</dt><dd>singleDataTemplateA single DataTemplate object element. That DataTemplate would typically have multiple child elements that define the visual appearance of the data representation.</dd>
<dt>resourceReferenceToDataTemplate</dt><dd>resourceReferenceToDataTemplateA resource reference to an existing DataTemplate from a resources collection. The resource reference must specify the desired DataTemplate by key through a {StaticResource} markup extension usage.</dd>
</dl>

## -property-value

The template that specifies the visualization of the menu data objects. The default is **null**.

## -remarks

## -see-also

## -examples

