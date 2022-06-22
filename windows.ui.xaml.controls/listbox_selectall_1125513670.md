---
-api-id: M:Windows.UI.Xaml.Controls.ListBox.SelectAll
-api-type: winrt method
---

<!-- Method syntax
public void SelectAll()
-->

# Windows.UI.Xaml.Controls.ListBox.SelectAll

## -description
Selects all the items in the [ListBox](listbox.md) control.



## -remarks
> [!WARNING]
> The SelectAll method should only be called when the [SelectionMode](listbox_selectionmode.md) property is set to [Multiple](selectionmode.md) or [Extended](selectionmode.md). If SelectAll is called when the [SelectionMode](listbox_selectionmode.md) is **Single**, an exception is thrown.

## -examples
```csharp
if (listBox.SelectionMode != SelectionMode.Single)
{
    listBox.SelectAll();
}
```

```cppwinrt
if (listBox().SelectionMode() != Windows::UI::Xaml::Controls::SelectionMode::Single)
{
    listBox().SelectAll();
}
```

```cppcx
if (listBox->SelectionMode != SelectionMode::Single)
{
    listBox->SelectAll();
}
```

```vb
If listBox.SelectionMode <> SelectionMode.Single Then
    listBox.SelectAll()
End If
```



## -see-also
