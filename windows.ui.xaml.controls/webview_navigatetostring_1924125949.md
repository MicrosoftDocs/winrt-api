---
-api-id: M:Windows.UI.Xaml.Controls.WebView.NavigateToString(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void NavigateToString(System.String text)
-->

# Windows.UI.Xaml.Controls.WebView.NavigateToString

## -description
Loads the specified HTML content as a new document.

## -parameters
### -param text
The HTML content to display in the [WebView](webview.md) control.

## -remarks
NavigateToString is asynchronous. Use the [NavigationCompleted](webview_navigationcompleted.md) event to detect when navigation has completed. 

> [!NOTE]
> [NavigationCompleted](webview_navigationcompleted.md) replaces [LoadCompleted](webview_loadcompleted.md) starting with Windows 8.1. In apps compiled for Windows 8, use [LoadCompleted](webview_loadcompleted.md) instead.

NavigateToString supports content with references to external files such as CSS, scripts, images, and fonts. However, it does not provide a way to generate or provide these resources programmatically. Windows 8.1 introduces [NavigateToLocalStreamUri](webview_navigatetolocalstreamuri_1538250901.md) to provide this support.

If the app possesses the `enterpriseCloudSSO` capability,
then web pages hosted inside the WebView control
can use single sign on with Azure Active Directory (AAD) resources.

## -examples

## -see-also
[LoadCompleted](webview_loadcompleted.md), [NavigationCompleted](webview_navigationcompleted.md), [NavigateToLocalStreamUri](webview_navigatetolocalstreamuri_1538250901.md), [WebView control (XAML) sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlWebView)
## -capabilities
enterpriseCloudSSO
