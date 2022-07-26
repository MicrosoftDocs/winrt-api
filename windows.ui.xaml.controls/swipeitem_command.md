---
-api-id: P:Windows.UI.Xaml.Controls.SwipeItem.Command
-api-type: winrt property
---

<!-- Property syntax.
public ICommand Command { get;  set; }
-->

# Windows.UI.Xaml.Controls.SwipeItem.Command

## -description

Gets or sets the command to execute when this item is invoked.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.SwipeItem.Command](/windows/winui/api/microsoft.ui.xaml.controls.swipeitem.command) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<SwipeItem Command="commandReference"/>
```

## -xaml-values

<dl><dt>commandReference</dt><dd>commandReferenceA reference to an ICommand implementation that describes the command logic. Typically this is done through a {Binding} markup extension reference to a data source, when using view-view model designs.</dd>
</dl>

## -property-value

The command to execute when this item is invoked. The default is **null**.

## -remarks

## -see-also

## -examples

