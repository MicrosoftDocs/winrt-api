---
-api-id: P:Windows.UI.Xaml.Controls.SplitView.IsPaneOpen
-api-type: winrt property
---

<!-- Property syntax
public bool IsPaneOpen { get;  set; }
-->

# Windows.UI.Xaml.Controls.SplitView.IsPaneOpen

## -description
Gets or sets a value that specifies whether the [SplitView](splitview.md) pane is expanded to its full width.

Equivalent WinUI property: [Microsoft.UI.Xaml.Controls.SplitView.IsPaneOpen](/windows/winui/api/microsoft.ui.xaml.controls.splitview.ispaneopen).

## -xaml-syntax
```xaml

      <SplitView IsPaneOpen="bool" .../>
    
```


## -property-value
**true** if the pane is expanded to its full width; otherwise, **false**. The default is **true**.

## -remarks
The effects of this property are influenced by the value of the [DisplayMode](splitview_displaymode.md) property. <table>
   <tr><th>DisplayMode</th><th>Effect</th></tr>
   <tr><td>**Inline**</td><td>IsPaneOpen is **true**.</td></tr>
   <tr><td>**Overlay**</td><td>When IsPaneOpen is **false**, the pane is hidden.</td></tr>
   <tr><td>**Compact**</td><td>When IsPaneOpen is **false**, the pane is shown in its compact size (see [CompactPaneLength](splitview_compactpanelength.md)).</td></tr>
</table>

## -examples

## -see-also
