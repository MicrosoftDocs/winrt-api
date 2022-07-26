---
-api-id: P:Windows.UI.Xaml.Controls.NavigationView.PaneHeader
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public UIElement PaneHeader { get;  set; }
-->

# Windows.UI.Xaml.Controls.NavigationView.PaneHeader

## -description

Gets or sets the content for the pane header.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.NavigationView.PaneHeader](/windows/winui/api/microsoft.ui.xaml.controls.navigationview.paneheader) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<NavigationView>
  <NavigationView.PaneHeader>
    headerElement
  </NavigationView.PaneHeader>
</NavigationView>
```

## -xaml-values

<dt>headerElement</dt><dd>headerElementA single UI element that serves as header content. This can be a panel that contains other UI elements.</dd>
</dl>

## -property-value

The content of the pane header. The default is **null**.

## -remarks

The PaneHeader property takes a single UIElement, which can be a layout panel that contains additional elements.

## -see-also

## -examples
