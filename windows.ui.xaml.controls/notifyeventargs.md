---
-api-id: T:Windows.UI.Xaml.Controls.NotifyEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class NotifyEventArgs : Windows.UI.Xaml.Controls.INotifyEventArgs, Windows.UI.Xaml.Controls.INotifyEventArgs2
-->

# Windows.UI.Xaml.Controls.NotifyEventArgs

## -description
Provides data for the [ScriptNotify](webview_scriptnotify.md) event.

## -remarks

## -examples
The following code example demonstrates the use of the [ScriptNotify](webview_scriptnotify.md) event in apps compiled for Windows 8. Starting with Windows 8.1, omit the lines related to [AllowedScriptNotifyUris](webview_allowedscriptnotifyuris.md). For more info, see the [WebView](webview.md) class overview.

```csharp
public MyPage()
{
    this.InitializeComponent();
    MyWebView.ScriptNotify += MyWebView_ScriptNotify;

    // Here we have to set the AllowedScriptNotifyUri property because we are 
    // navigating to some site where we don't own the content and we want to 
    // allow window.external.notify() to pass data back to the app.
    List<Uri> allowedUris = new List<Uri>();
    allowedUris.Add(new Uri("http://www.bing.com"));
    MyWebView.AllowedScriptNotifyUris = allowedUris;
}

void MyWebView_ScriptNotify(object sender, NotifyEventArgs e)
{
    // Respond to the script notification.
}

```



## -see-also
[WebView](webview.md), [ScriptNotify](webview_scriptnotify.md)