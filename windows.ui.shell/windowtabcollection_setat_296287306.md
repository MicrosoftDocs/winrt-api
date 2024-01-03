---
-api-id: M:Windows.UI.Shell.WindowTabCollection.SetAt(System.UInt32,Windows.UI.Shell.WindowTab)
-api-type: winrt method
---

# Windows.UI.Shell.WindowTabCollection.SetAt(System.UInt32,Windows.UI.Shell.WindowTab)

<!--
public void SetAt (uint index, Windows.UI.Shell.WindowTab value);
-->

## -description

Sets the value at the specified index to the specified `WindowTab` value.

## -parameters

### -param index

The index at which to set the value.

### -param value

The value to set.

## -remarks

> [!IMPORTANT]
> This API is for Win32 desktop apps only. UWP and other app types are not supported.

[InsertAt](windowtabcollection_insertat_1626840122.md) expands the collection and moves all subsequent index items by one.

In contrast, `SetAt` replaces the item at the index, and the collection count remains the same.

## -see-also

## -examples
