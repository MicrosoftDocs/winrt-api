---
-api-id: P:Windows.UI.Xaml.Controls.NavigationView.Header
-api-type: winrt property
---

<!-- Property syntax.
public object Header { get;  set; }
-->

# Windows.UI.Xaml.Controls.NavigationView.Header

## -description

Gets or sets the header content.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.NavigationView.Header](/windows/winui/api/microsoft.ui.xaml.controls.navigationview.header) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<NavigationView Header="headerString"/>
- or -
<NavigationView>
  <NavigationView.Header>
    headerObject
  </NavigationView.Header>
</NavigationView>
```

## -xaml-values

<dl><dt>headerString</dt><dd>headerStringA text string that serves as header content.</dd>
<dt>headerObject</dt><dd>headerObjectAn single object element that serves as header content. Use discretion when using objects as header content; not all objects are suitable for use within the limited presentation surface that appears for headers.</dd>
</dl>

## -property-value

The header content for the NavigationView.

## -remarks

## -see-also

## -examples

