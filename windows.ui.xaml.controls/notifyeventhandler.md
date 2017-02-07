---
-api-id: T:Windows.UI.Xaml.Controls.NotifyEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void NotifyEventHandler(System.Object sender, Windows.UI.Xaml.Controls.NotifyEventArgs e)
-->
# Windows.UI.Xaml.Controls.NotifyEventHandler

## -description
Represents the method that will handle the [ScriptNotify](webview_scriptnotify.md) event.

## -parameters
### -param sender
The object where the handler is attached.

### -param e
Event data for the event.


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