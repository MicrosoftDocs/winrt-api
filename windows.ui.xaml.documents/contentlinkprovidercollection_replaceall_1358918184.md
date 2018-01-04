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

For implementations that track a "changed" event, the initial reset fires an event, but the items added do not fire discrete events.

## -see-also

## -examples

