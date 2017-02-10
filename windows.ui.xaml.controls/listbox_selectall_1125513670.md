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
> The [SelectAll](listbox_selectall.md) method should only be called when the [SelectionMode](listbox_selectionmode.md) property is set to [Multiple](selectionmode.md) or [Extended](selectionmode.md). If [SelectAll](listbox_selectall.md) is called when the [SelectionMode](listbox_selectionmode.md) is **Single**, an exception is thrown.

## -examples
```cpp
if (listBox->SelectionMode != SelectionMode::Single)
{
    listBox->SelectAll();
}
```

```csharp
if (listBox.SelectionMode != SelectionMode.Single)
{
    listBox.SelectAll();
}
```

```vbnet
If listBox.SelectionMode <> SelectionMode.Single Then
    listBox.SelectAll()
End If
```



## -see-also
