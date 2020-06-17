---
-api-id: M:Windows.UI.Xaml.Controls.WebView.CapturePreviewToStreamAsync(Windows.Storage.Streams.IRandomAccessStream)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction CapturePreviewToStreamAsync(Windows.Storage.Streams.IRandomAccessStream stream)
-->

# Windows.UI.Xaml.Controls.WebView.CapturePreviewToStreamAsync

## -description
Creates an image of the current [WebView](webview.md) contents and writes it to the specified stream.

## -parameters
### -param stream
The stream to write the image to.

## -returns
An asynchronous action to await the capture operation.

## -remarks

## -examples
This example shows how to use this method to create a thumbnail image of the current content. For the complete example, see the [WebView control sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/XamlWebView).

```csharp
private async void bookmarkBtn_Click(object sender, RoutedEventArgs e)
{
    InMemoryRandomAccessStream ms = new InMemoryRandomAccessStream();
    await webView8.CapturePreviewToStreamAsync(ms);
            
    // Create a small thumbnail.
    int longlength = 180, width = 0, height = 0;
    double srcwidth = webView8.ActualWidth, srcheight = webView8.ActualHeight;
    double factor = srcwidth / srcheight;
    if (factor < 1)
    {
        height = longlength;
        width = (int)(longlength * factor);
    }
    else
    {
        width = longlength;
        height = (int)(longlength / factor);
    }
    BitmapSource small = await resize(width, height, ms);
            
    BookmarkItem item = new BookmarkItem();
    item.Title = webView8.DocumentTitle;
    item.PageUrl = webView8.Source;
    item.Preview = small;

    bookmarks.Add(item);
}

```



## -see-also
[XAML WebView control sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/XamlWebView)
