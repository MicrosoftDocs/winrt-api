---
-api-id: M:Windows.Web.UI.IWebViewControl.NavigateToLocalStreamUri(Windows.Foundation.Uri,Windows.Web.IUriToStreamResolver)
-api-type: winrt method
---

<!-- Method syntax.
public void IWebViewControl.NavigateToLocalStreamUri(Uri source, IUriToStreamResolver streamResolver)
-->

# Windows.Web.UI.IWebViewControl.NavigateToLocalStreamUri

## -description
Loads local web content at the specified URI using an [IUriToStreamResolver](../windows.web/iuritostreamresolver.md).

## -parameters
### -param source
A URI identifying the local HTML content to load.

### -param streamResolver
A resolver that converts the URI into a stream to load.

## -remarks
Use this method to load local content that the [NavigateToString](iwebviewcontrol_navigatetostring_1924125949.md) method won't handle. [NavigateToString](iwebviewcontrol_navigatetostring_1924125949.md) provides an easy way to navigate to static HTML content, including content with references to resources such as CSS, scripts, images, and fonts. However, [NavigateToString](iwebviewcontrol_navigatetostring_1924125949.md) does not provide a way to generate these resources programmatically.

To use the **NavigateToLocalStreamUri** method, you must pass in an [IUriToStreamResolver](../windows.web/iuritostreamresolver.md) implementation that translates a URI pattern into a content stream. You can do this to supply the content for all the resources used by a web page, or series of pages. For example, you can use this method to display content saved on the local file system as encrypted files or in cab packages. When the content is requested, you can use an [IUriToStreamResolver](../windows.web/iuritostreamresolver.md) implementation to decrypt it on the fly.

The [IUriToStreamResolver](../windows.web/iuritostreamresolver.md) interface has one method, [UriToStreamAsync](../windows.web/iuritostreamresolver_uritostreamasync_1256896073.md) which takes the URI and returns the stream. The URI is in the form of “ms-local-stream://appname_KEY/folder/file” where KEY identifies the resolver. Use [BuildLocalStreamUri](iwebviewcontrol_buildlocalstreamuri_803594427.md) to create a URI in the correct format that references the local content to load.

> [!NOTE]
> Your [IUriToStreamResolver](../windows.web/iuritostreamresolver.md) implementation must be agile to prevent deadlock that can occur when the UI thread waits for the [IUriToStreamResolver](../windows.web/iuritostreamresolver.md) to finish its work before continuing. For more info, see [Threading and Marshaling](/cpp/cppcx/threading-and-marshaling-c-cx)

## -see-also

## -examples

