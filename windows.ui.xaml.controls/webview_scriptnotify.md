---
-api-id: E:Windows.UI.Xaml.Controls.WebView.ScriptNotify
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Controls.NotifyEventHandler ScriptNotify
-->

# Windows.UI.Xaml.Controls.WebView.ScriptNotify

## -description
Occurs when the content contained in the [WebView](webview.md) control passes a string to the application by using JavaScript.

## -xaml-syntax
```xaml
<WebView ScriptNotify="eventhandler"/>

```


## -remarks
A hosted HTML page can fire the ScriptNotify event in your UWP app when the page calls **window.external.notify** and passes a string parameter.

> [!NOTE]
> Because this event is initiated by external code, you should be careful about what you put in the event handler. To prevent malicious scripts from exploiting this event, be sure to enable it only for trusted URIs, as described below.

### Windows 8.1

To enable an external web page to fire the ScriptNotify event when calling **window.external.notify**, you must include the page's URI in the **ApplicationContentUriRules** section of the app manifest. (You can do this in Visual Studio on the Content URIs tab of the **Package.appxmanifest** designer.) The URIs in this list must use HTTPS and may contain subdomain wildcards (for example, "https://*.microsoft.com"), but they can't contain domain wildcards (for example, "https://*.com" and "https://*.*"). The manifest requirement does not apply to content that originates from the app package, uses an ms-local-stream:// URI, or is loaded using [NavigateToString](webview_navigatetostring_1924125949.md).

> [!NOTE]
> If you have more then one subdomain, you must use one wildcard for each subdomain. For example, "https://*.microsoft.com" matches with "https://*any*.microsoft.com" but not with "https://*this*.*any*.microsoft.com."

These changes do not affect apps compiled for Windows 8, even when running on Windows 8.1.

[AllowedScriptNotifyUris](webview_allowedscriptnotifyuris.md), [AnyScriptNotifyUri](webview_anyscriptnotifyuri.md), and [AllowedScriptNotifyUrisProperty](webview_allowedscriptnotifyurisproperty.md) are not supported in apps compiled for Windows 8.1.

### Windows 8

These remarks apply only to apps compiled for Windows 8, even when running on Windows 8.1.

If content is loaded into the [WebView](webview.md) control using the [Navigate](webview_navigate_1098085581.md) method, the app must opt-in to receiving ScriptNotify events by using the [AllowedScriptNotifyUris](webview_allowedscriptnotifyuris.md) property, which has the list of URIs that can fire ScriptNotify. If the content is loaded using [NavigateToString](webview_navigatetostring_1924125949.md), the application will receive ScriptNotify events without the opt-in. Set the [AllowedScriptNotifyUris](webview_allowedscriptnotifyuris.md) property to the value returned by the [AnyScriptNotifyUri](webview_anyscriptnotifyuri.md) property to indicate that any page can fire ScriptNotify events to this [WebView](webview.md) control.

## -examples
The following code example demonstrates the use of the ScriptNotify event in apps compiled for Windows 8. Starting with Windows 8.1, omit the lines related to [AllowedScriptNotifyUris](webview_allowedscriptnotifyuris.md).

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
[AllowedScriptNotifyUris](webview_allowedscriptnotifyuris.md), [WebView control (XAML) sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlWebView)
