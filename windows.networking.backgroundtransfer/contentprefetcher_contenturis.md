---
-api-id: P:Windows.Networking.BackgroundTransfer.ContentPrefetcher.ContentUris
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.Foundation.Uri> ContentUris { get; }
-->

# Windows.Networking.BackgroundTransfer.ContentPrefetcher.ContentUris

## -description
Array of URIs to download when prefetch is performed for the app.

## -property-value
A list of [Uri](../windows.foundation/uri.md) objects.

## -remarks
The following example demonstrates the creation and assignment of URIs for prefetching:



```css
//First, create content URIs
var uris = [new Windows.Foundation.Uri("http://www.microsoft.com/logo.jpg"),
            new Windows.Foundation.Uri("http://www.microsoft.com/heroimage.jpg")];

//clear the old list
Windows.Networking.BackgroundTransfer.ContentPrefetcher.ContentUris.Clear();
Windows.Networking.BackgroundTransfer.ContentPrefetcher.IndirectContentUri = null; // Remove this if your app never uses IndirectContentUri

//next set these as the content URIs:
for(vari=0;i<uris.length;i++){
Windows.Networking.BackgroundTransfer.ContentPrefetcher.ContentUris.Append(uris[i]);
}
```



## -examples

## -see-also
[Uri](../windows.foundation/uri.md)