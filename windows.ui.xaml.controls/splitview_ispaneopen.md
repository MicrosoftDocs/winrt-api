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



## -xaml-syntax
```xaml

      <SplitView IsPaneOpen="bool" .../>
    
```


## -property-value
**true** if the pane is expanded to its full width; otherwise, **false**. The default is **true**.

## -remarks
The effects of this property are influenced by the value of the [DisplayMode](splitview_displaymode.md) property. 

| DisplayMode | Effect |
|---|---|
| **Inline** | IsPaneOpen is **true**. |
| **Overlay** | When IsPaneOpen is **false**, the pane is hidden. |
| **Compact** | When IsPaneOpen is **false**, the pane is shown in its compact size (see [CompactPaneLength](splitview_compactpanelength.md)). |

## -examples

## -see-also
