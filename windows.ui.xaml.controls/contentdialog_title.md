---
-api-id: P:Windows.UI.Xaml.Controls.ContentDialog.Title
-api-type: winrt property
---

<!-- Property syntax
public object Title { get;  set; }
-->

# Windows.UI.Xaml.Controls.ContentDialog.Title

## -description
Gets or sets the title of the dialog.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.ContentDialog.Title](/windows/winui/api/microsoft.ui.xaml.controls.contentdialog.title) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<ContentDialog Title="string"/>
- or -
<ContentDialog>
  <ContentDialog.Title>
    singleObject
  </ContentDialog.Title>
</ContentDialog>

```


## -xaml-values
<dl><dt>string</dt><dd>stringA text string for the title.</dd>
<dt>singleObject</dt><dd>singleObjectAn single object element that serves as title content. Use discretion when using objects; not all objects are suitable for use within the limited presentation area.</dd>
</dl>
## -property-value
The title of the dialog.

## -remarks

## -examples

## -see-also
