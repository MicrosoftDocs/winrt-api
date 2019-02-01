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
[NavigateToString](webview_navigatetostring_1924125949.md) is asynchronous. Use the [NavigationCompleted](webview_navigationcompleted.md) event to detect when navigation has completed. 

> [!NOTE]
> [NavigationCompleted](webview_navigationcompleted.md) replaces [LoadCompleted](webview_loadcompleted.md) starting with Windows 8.1. In apps compiled for Windows 8, use [LoadCompleted](webview_loadcompleted.md) instead.

[NavigateToString](webview_navigatetostring_1924125949.md) supports content with references to external files such as CSS, scripts, images, and fonts. However, it does not provide a way to generate or provide these resources programmatically. Windows 8.1 introduces [NavigateToLocalStreamUri](webview_navigatetolocalstreamuri_1538250901.md) to provide this support.

## -examples

## -see-also
[LoadCompleted](webview_loadcompleted.md), [NavigationCompleted](webview_navigationcompleted.md), [NavigateToLocalStreamUri](webview_navigatetolocalstreamuri_1538250901.md), [WebView control (XAML) sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=722922)
## -capabilities
enterpriseCloudSS
