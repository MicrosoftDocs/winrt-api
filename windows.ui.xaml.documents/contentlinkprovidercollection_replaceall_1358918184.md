---
-api-id: M:Windows.UI.Xaml.Documents.ContentLinkProviderCollection.ReplaceAll(Windows.UI.Xaml.Documents.ContentLinkProvider[])
-api-type: winrt method
---

<!-- Method syntax.
public void ContentLinkProviderCollection.ReplaceAll(ContentLinkProvider[] items)
-->

# Windows.UI.Xaml.Documents.ContentLinkProviderCollection.ReplaceAll

## -description

Initially clears the collection, then inserts the provided array as new items.

## -parameters
### -param items

The new collection items.

## -remarks

> [!IMPORTANT]
> This API supports content links. The Windows features that enable content links are not available in versions of Windows after Windows 10 version 1903. Content links for XAML text controls will not function in versions of Windows later than version 1903.

For implementations that track a "changed" event, the initial reset fires an event, but the items added do not fire discrete events.

## -see-also

## -examples

