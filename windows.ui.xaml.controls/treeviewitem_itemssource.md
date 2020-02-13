---
-api-id: P:Windows.UI.Xaml.Controls.TreeViewItem.ItemsSource
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public object ItemsSource { get;  set; }
-->

# Windows.UI.Xaml.Controls.TreeViewItem.ItemsSource

## -description

Gets or sets an object source used to generate the content of the TreeView.

## -xaml-syntax

```xaml
<TreeViewItem ItemsSource="bindingDeclaration"/>
-or-
<TreeViewItem ItemsSource="resourceReferenceToSource"/>
```

## -xaml-values

<dl><dt>bindingDeclaration</dt><dd>bindingDeclarationA Binding declaration using a {Binding ....} markup extension. For more information, see {Binding} markup extension.</dd>
<dt>resourceReferenceToSource</dt><dd>resourceReferenceToSourceA resource reference to an existing iterable/enumerable items source from a resources collection. The resource reference must specify the desired items source by key.</dd>
</dl>

## -property-value

The object that is used to generate the content of the TreeViewItem. The default is **null**.

## -remarks

TThe type of the object that you set the **ItemsSource** property to must implement particular interface(s). For more details, see the [Remarks](/uwp/api/windows.ui.xaml.controls.itemscontrol.itemssource#remarks) section of **ItemsControl.ItemsSource**.

## -see-also

## -examples

