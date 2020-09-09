---
-api-id: M:Windows.UI.Xaml.Controls.WebView.AddWebAllowedObject(System.String,System.Object)
-api-type: winrt method
---

<!-- Method syntax
public void AddWebAllowedObject(System.String name, System.Object pObject)
-->

# Windows.UI.Xaml.Controls.WebView.AddWebAllowedObject

## -description
Adds a native Windows Runtime object as a global parameter to the top level document inside of a [WebView](webview.md).

## -parameters
### -param name
The name of the object to expose to the document in the [WebView](webview.md).

### -param pObject
The object to expose to the document in the [WebView](webview.md).

## -remarks
Use this method to expose a native Windows Runtime object as a global parameter in the context of the top level document inside of a [WebView](webview.md). For a Windows Runtime object to be projected, it must agile and be decorated with the **AllowForWeb** attribute.

> [!NOTE]
> Runtime classes created using Microsoft Visual Basic, C# or Visual C++ component extensions (C++/CX) are agile by default. For more info, see [Threading and Marshaling](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment](/windows/uwp/threading-async/using-windows-runtime-objects-in-a-multithreaded-environment).




The object passed into AddWebAllowedObject must be imported from a [Windows Runtime component](/windows/uwp/winrt-components/index) that is separate from the app assembly. This is necessary for the **AllowForWeb** attribute to be property identified by the [WebView](webview.md) security subsystem. If you use a class from your app project, AddWebAllowedObject does not work.

You must call AddWebAllowedObject every time [WebView](webview.md) is navigated to a new page that accesses the native object. You can use the [WebView.NavigationStarting](webview_navigationstarting.md) event to inject the object when navigation begins.

## -examples
This example shows how to decorate a class with the **AllowForWeb** attribute.

```csharp
using Windows.Foundation.Metadata;

namespace MyRuntimeComponent
{
    [AllowForWeb]
    public sealed class MyNativeClass
    {
        public void NativeMethod()
        {
            ...
        }
 
        ...
    }
}

```

This example demonstrates using the [NavigationStarting](webview_navigationstarting.md) event to inject an object when navigation begins.

```xaml
<WebView x:Name="webView" Source="https://www.contoso.com/index.html"
         NavigationStarting="webView_NavigationStarting"/>

```

```csharp
private void webView_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args) 
{ 
    if (args.Uri.Host == "www.contoso.com")  
    { 
        webView.AddWebAllowedObject("nativeObject", new MyNativeClass()); 
    } 
} 

```

Here's how to access the native object in a script in the web page.

```javascript
<script type='text/javascript'>
    nativeObject.nativeMethod(); // Call the projected WinRT method.
</script>

```



## -see-also
