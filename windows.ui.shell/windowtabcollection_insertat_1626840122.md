---
-api-id: M:Windows.UI.Shell.WindowTabCollection.InsertAt(System.UInt32,Windows.UI.Shell.WindowTab)
-api-type: winrt method
---

# Windows.UI.Shell.WindowTabCollection.InsertAt(System.UInt32,Windows.UI.Shell.WindowTab)

<!--
public void InsertAt (uint index, Windows.UI.Shell.WindowTab value);
-->

## -description

Inserts the specified item at the specified index.

## -parameters

### -param index

The index at which to set the value.

### -param value

The value to set.

## -remarks

> [!IMPORTANT]
> This API is for Win32 desktop apps only. UWP and other app types are not supported.

`InsertAt` expands the collection and moves all subsequent index items by one.

In contrast, [SetAt](windowtabcollection_setat_296287306.md) replaces the item at the index, and the collection count remains the same.

## -see-also

## -examples


