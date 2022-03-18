---
-api-id: M:Windows.UI.Xaml.Controls.WebView.BuildLocalStreamUri(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Uri BuildLocalStreamUri(System.String contentIdentifier, System.String relativePath)
-->

# Windows.UI.Xaml.Controls.WebView.BuildLocalStreamUri

## -description
Creates a URI that you can pass to [NavigateToLocalStreamUri](webview_navigatetolocalstreamuri_1538250901.md).

## -parameters
### -param contentIdentifier
A unique identifier for the content the URI is referencing. This defines the root of the URI.

### -param relativePath
The path to the resource, relative to the root.

## -returns
The URI created by combining and normalizing the *contentIdentifier* and *relativePath*.

## -remarks

## -examples
The following code example shows how to use this method with a resolver that will serve a file from the app package. For a complete example, see the [XAML WebView control sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/XamlWebView).

```csharp

public sealed partial class TestPage : Page
{
    // ... other code ...

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        // The 'Host' part of the URI for the ms-local-stream protocol needs to be a combination of the package name
        // and an application-defined key, which identifies the specific resolver, in this case 'MyTag'.
            
        Uri url = webView4.BuildLocalStreamUri("MyTag","/Minesweeper/default.html");
        StreamUriWinRTResolver myResolver = new StreamUriWinRTResolver();

        // Pass the resolver object to the navigate call.
        webView4.NavigateToLocalStreamUri(url, myResolver);
    }
}

public sealed class StreamUriWinRTResolver : IUriToStreamResolver
{
    public IAsyncOperation<IInputStream> UriToStreamAsync(Uri uri)
    {
        if (uri == null)
        {
            throw new Exception();
        }
        string path = uri.AbsolutePath;

        // Because of the signature of the this method, it can't use await, so we 
        // call into a separate helper method that can use the C# await pattern.
        return GetContent(path).AsAsyncOperation();
    }

    private async Task<IInputStream> GetContent(string path)
    {
        // We use a package folder as the source, but the same principle should apply
        // when supplying content from other locations
        try
        {
            Uri localUri= new Uri("ms-appx:///html" + path);
            StorageFile f = await StorageFile.GetFileFromApplicationUriAsync(localUri);
            IRandomAccessStream stream = await f.OpenAsync(FileAccessMode.Read);
            return stream.GetInputStreamAt(0);
        }
        catch (Exception) { throw new Exception("Invalid path"); }
    }
}

```



## -see-also
[NavigateToLocalStreamUri](webview_navigatetolocalstreamuri_1538250901.md), [XAML WebView control sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/XamlWebView)
