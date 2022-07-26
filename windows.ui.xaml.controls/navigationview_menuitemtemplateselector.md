---
-api-id: P:Windows.UI.Xaml.Controls.NavigationView.MenuItemTemplateSelector
-api-type: winrt property
---

<!-- Property syntax.
public DataTemplateSelector MenuItemTemplateSelector { get;  set; }
-->

# Windows.UI.Xaml.Controls.NavigationView.MenuItemTemplateSelector

## -description

Gets or sets a reference to a custom [DataTemplateSelector](datatemplateselector.md) logic class. The [DataTemplateSelector](datatemplateselector.md) referenced by this property returns a template to apply to items.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.NavigationView.MenuItemTemplateSelector](/windows/winui/api/microsoft.ui.xaml.controls.navigationview.menuitemtemplateselector) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<NavigationView MenuItemTemplateSelector="dataTemplateSelectorReference" />
```

## -xaml-values

<dl><dt>dataTemplateSelectorReference</dt><dd>dataTemplateSelectorReferenceA reference to an existing DataTemplateSelector. Typically this is a keyed resource, which you reference through {StaticResource} markup extension.</dd>
</dl>

## -property-value

A reference to a custom [DataTemplateSelector](datatemplateselector.md) logic class.

## -remarks

## -see-also

## -examples

