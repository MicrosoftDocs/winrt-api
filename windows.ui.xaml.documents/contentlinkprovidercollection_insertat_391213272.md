---
-api-id: M:Windows.UI.Xaml.Documents.ContentLinkProviderCollection.InsertAt(System.UInt32,Windows.UI.Xaml.Documents.ContentLinkProvider)
-api-type: winrt method
---

<!-- Method syntax.
public void ContentLinkProviderCollection.InsertAt(UInt32 index, ContentLinkProvider value)
-->

# Windows.UI.Xaml.Documents.ContentLinkProviderCollection.InsertAt

## -description

Inserts the specified item at the specified index.

## -parameters
### -param index

The index at which to set the value.

### -param value

The value to set.

## -remarks

> [!IMPORTANT]
> This API supports content links. The Windows features that enable content links are not available in versions of Windows after Windows 10 version 1903. Content links for XAML text controls will not function in versions of Windows later than version 1903.

InsertAt expands the collection and moves all subsequent index items by one.

In contrast, SetAt replaces the item at the index, and the collection count remains the same.

## -see-also

## -examples

