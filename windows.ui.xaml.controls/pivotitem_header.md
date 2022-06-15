---
-api-id: P:Windows.UI.Xaml.Controls.PivotItem.Header
-api-type: winrt property
---

<!-- Property syntax
public object Header { get;  set; }
-->

# Windows.UI.Xaml.Controls.PivotItem.Header

## -description
Gets or sets the header for the [PivotItem](pivotitem.md).

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.PivotItem.Header](/windows/winui/api/microsoft.ui.xaml.controls.pivotitem.header) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<PivotItem Header="headerString"/>
- or -
<PivotItem>
  <PivotItem.Header>
    headerObject
  </PivotItem.Header>
</PivotItem>

```


## -xaml-values
<dl><dt>headerString</dt><dd>headerStringA text string that serves as header content.</dd>
<dt>headerObject</dt><dd>headerObjectAn single object element that serves as header content. Use discretion when using objects as header content; not all objects are suitable for use within the limited presentation surface that appears for headers.</dd>
</dl>
## -property-value
Returns [Object](/dotnet/api/system.object?view=dotnet-uwp-10.0&preserve-view=true).

## -remarks

## -examples

## -see-also
