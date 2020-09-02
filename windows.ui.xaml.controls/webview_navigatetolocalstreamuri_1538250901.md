---
-api-id: M:Windows.UI.Xaml.Controls.WebView.NavigateToLocalStreamUri(Windows.Foundation.Uri,Windows.Web.IUriToStreamResolver)
-api-type: winrt method
---

<!-- Method syntax
public void NavigateToLocalStreamUri(Windows.Foundation.Uri source, Windows.Web.IUriToStreamResolver streamResolver)
-->

# Windows.UI.Xaml.Controls.WebView.NavigateToLocalStreamUri

## -description
Loads local web content at the specified URI using an [IUriToStreamResolver](../windows.web/iuritostreamresolver.md).

## -parameters
### -param source
A URI identifying the local HTML content to load.

### -param streamResolver
A resolver that converts the URI into a stream to load.

## -remarks
Use this method to load local content that the [NavigateToString](webview_navigatetostring_1924125949.md) method won't handle. [NavigateToString](webview_navigatetostring_1924125949.md) provides an easy way to navigate to static HTML content, including content with references to resources such as CSS, scripts, images, and fonts. However, [NavigateToString](webview_navigatetostring_1924125949.md) does not provide a way to generate these resources programmatically.

To use the NavigateToLocalStreamUri method, you must pass in an [IUriToStreamResolver](../windows.web/iuritostreamresolver.md) implementation that translates a URI pattern into a content stream. You can do this to supply the content for all the resources used by a web page, or series of pages. For example, you can use this method to display content saved on the local file system as encrypted files or in cab packages. When the content is requested, you can use an [IUriToStreamResolver](../windows.web/iuritostreamresolver.md) implementation to decrypt it on the fly.

The [IUriToStreamResolver](../windows.web/iuritostreamresolver.md) interface has one method, [UriToStreamAsync](../windows.web/iuritostreamresolver_uritostreamasync_1256896073.md) which takes the URI and returns the stream. The URI is in the form of “ms-local-stream://appname_KEY/folder/file” where KEY identifies the resolver. Use [BuildLocalStreamUri](webview_buildlocalstreamuri_803594427.md) to create a URI in the correct format that references the local content to load.

> [!NOTE]
> Your [IUriToStreamResolver](../windows.web/iuritostreamresolver.md) implementation must be agile to prevent deadlock that can occur when the UI thread waits for the [IUriToStreamResolver](../windows.web/iuritostreamresolver.md) to finish its work before continuing. For more info, see [Threading and Marshaling](/cpp/cppcx/threading-and-marshaling-c-cx)

If the app possesses the `enterpriseCloudSSO` capability,
then web pages hosted inside the WebView control
can use single sign on with Azure Active Directory (AAD) resources.

## -examples
The following code example shows how to create and use a resolver that will serve a file from the app package. For a complete example, see the [XAML WebView control sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/XamlWebView).

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
            return stream;
        }
        catch (Exception) { throw new Exception("Invalid path"); }
    }
}

```



## -see-also
[IUriToStreamResolver](../windows.web/iuritostreamresolver.md), [BuildLocalStreamUri](webview_buildlocalstreamuri_803594427.md), [XAML WebView control sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/XamlWebView), [WebView control (XAML) sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=722922)
## -capabilities
enterpriseCloudSSO
