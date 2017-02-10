---
-api-id: E:Windows.UI.Xaml.Controls.WebView.NewWindowRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler NewWindowRequested<Windows.UI.Xaml.Controls.WebView,  Windows.UI.Xaml.Controls.WebViewNewWindowRequestedEventArgs>
-->

# Windows.UI.Xaml.Controls.WebView.NewWindowRequested

## -description
Occurs when a user performs an action in a [WebView](webview.md) that causes content to be opened in a new window.

## -xaml-syntax
```xaml
<WebView NewWindowRequested="eventhandler"/>
```


## -remarks
See [WebViewNewWindowRequestedEventArgs](webviewnewwindowrequestedeventargs.md).

This event occurs only for user initiated actions. By default, when a user clicks a link in a [WebView](webview.md) that requests to open in a new window, the link launches the default browser. A new window can be caused by the user clicking on an **href**, or a button which calls **window.open**.

Handle this event to provide custom handling of the new window request. You might navigate the [WebView](webview.md) to the desired page, or create a new [WebView](webview.md) in your app to display the requested content. If you provide custom handling of the new window request, set the [Handled](webviewnewwindowrequestedeventargs_handled.md) property to true to prevent the default browser from being launched.

## -examples
```xaml
<WebView x:Name="myWebView" NewWindowRequested="OnNewWindowRequested" /> 

```

```csharp
private void OnNewWindowRequested (WebView sender, WebViewNewWindowRequestedEventArgs e) 
{ 
    if (e.Referrer.Host == "www.contoso.com") 
    { 
         var newWebView = new WebView(); 
         newWebView.Navigate(e.Uri); 
         myGrid.Children.Add(newWebView); 
         e.Handled = true; 
    } 
} 

```



## -see-also
[WebViewNewWindowRequestedEventArgs](webviewnewwindowrequestedeventargs.md)