---
-api-id: M:Windows.Web.UI.Interop.WebViewControl.AddInitializeScript(System.String)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void WebViewControl.AddInitializeScript(String script)
-->

# Windows.Web.UI.Interop.WebViewControl.AddInitializeScript

## -description
Injects a script into a [WebViewControl](/uwp/api/windows.web.ui.interop.webviewcontrol) just after [ContentLoading](/uwp/api/windows.ui.xaml.controls.webview.contentloading) but before any other script is run on the page.

## -parameters
### -param script

## -remarks

## -see-also

## -examples

The following code is a C# sample of script injection on page load:

```csharp
WebViewControl webViewControl; 
 
// Replace the window.external with a custom object that does postMessage. The app 
// script uses ScriptNotify and InvokeScriptAsync to implement PostMessage and invoke 
// a messageReceived handler. 
String script = @"var realExternal = window.external;  
var customExternal = { 
    postMessage: (message) => { realExternal.notify('PostMessage: ' + message); }, 
    messageReceived: null, 
}; 
window.external = customExternal;"; 
 
void ScriptNotifyCallback(WebViewControl sender, WebViewControlScriptNotifyEventArgs args) 
{ 
    String response = GetResponseForPostFromWebView(args.value); 
    sender.InvokeScriptAsync("eval", $"window.external.messageReceived({response});");
} 
 
webViewControl.ScriptNotify += ScriptNotifyCallback; 
webViewControl.AddInitializeScript(script); 
webViewControl.Navigate(new Uri("http://mydomain.com")); 
```

Using [InvokeScriptAsync](/uwp/api/windows.web.ui.iwebviewcontrol.invokescriptasync), an app can inject scripts into a WebViewControl to provide additional functionality or alter the page. However, InvokeScriptAsync has no guarantees about when the script is executed, and if the app calls it before [DOMContentLoaded](/uwp/api/windows.web.ui.iwebviewcontrol.domcontentloaded) is raised, there is a risk that the script gets injected into the previous page. This example offers a way for the app to provide a script before navigation (or during [NavigationStarting](/uwp/api/windows.web.ui.iwebviewcontrol.navigationstarting)) that will run before any script in the page is executed. 
