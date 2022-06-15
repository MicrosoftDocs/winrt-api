---
-api-id: P:Windows.UI.Xaml.Controls.Hub.Sections
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.UI.Xaml.Controls.HubSection> Sections { get; }
-->

# Windows.UI.Xaml.Controls.Hub.Sections

## -description
Gets all the hub sections in the [Hub](hub.md).

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.Hub.Sections](/windows/winui/api/microsoft.ui.xaml.controls.hub.sections) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<Hub ...>
  oneOrMoreHubSections
</Hub>
```


## -xaml-values
<dl><dt>oneOrMoreHubSections</dt><dd>oneOrMoreHubSections One or more HubSection elements that declare the content that's being viewed. The HubSection elements can't be interspersed with other Hub property elements such as Hub.Header; the sections must be declared contiguously.</dd>
</dl>
## -property-value
All the hub sections in the [Hub](hub.md). The default is an empty collection.

## -remarks

## -examples

## -see-also
[HubSection](hubsection.md), [HubSectionCollection](hubsectioncollection.md)
