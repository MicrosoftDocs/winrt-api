---
-api-id: T:Windows.UI.Xaml.Controls.WebView
-api-type: winrt class
---

<!-- Class syntax.
public class WebView : Windows.UI.Xaml.FrameworkElement, Windows.UI.Xaml.Controls.IWebView, Windows.UI.Xaml.Controls.IWebView2, Windows.UI.Xaml.Controls.IWebView3, Windows.UI.Xaml.Controls.IWebView4, Windows.UI.Xaml.Controls.IWebView5
-->

# Windows.UI.Xaml.Controls.WebView

## -description

Provides a control that hosts HTML content in an app.

## -xaml-syntax

```xaml
<WebView .../>
```

## -remarks

Use the WebView control to host web content in your app. Apps for Surface Hub or Xbox must use this WebView.

> [!IMPORTANT]
> For desktop apps, we recommend that you use the [WebView2](/windows/winui/api/microsoft.ui.xaml.controls.webview2) control, which is available as part of the Windows UI Library 2 for UWP (WinUI 2). WebView2 uses Microsoft Edge (Chromium) as the rendering engine to display web content in apps. For more info, see [Introduction to Microsoft Edge WebView2](/microsoft-edge/webview2/), [Get started with WebView2 in WinUI 2 (UWP) apps](/microsoft-edge/webview2/get-started/winui2), and [WebView2](/windows/winui/api/microsoft.ui.xaml.controls.webview2) in the WinUI API reference.

> [!IMPORTANT]
> **XAML Islands**: This control is not supported in XAML Islands apps. For alternatives, see [XAML Islands - Web view controls](/windows/apps/desktop/modernize/xaml-islands#web-view-controls).

WebView is not a [Control](control.md) subclass and thus does not have a control template. You can set various properties to control some visual aspects of the WebView. The display area is constrained by the [Width](../windows.ui.xaml/frameworkelement_width.md) and [Height](../windows.ui.xaml/frameworkelement_height.md) properties. To translate, scale, skew, and rotate a WebView, use the [RenderTransform](../windows.ui.xaml/uielement_rendertransform.md) property. To control the opacity of the WebView, set the [Opacity](../windows.ui.xaml/uielement_opacity.md) property. To specify a color to use as the web page background when the HTML content does not specify a color, set the [DefaultBackgroundColor](webview_defaultbackgroundcolor.md) property.

You can get the title of the HTML document currently displayed in the WebView by using the [DocumentTitle](webview_documenttitle.md) property.

Although WebView is not a [Control](control.md) subclass, it will receive keyboard input focus and participate in the tab sequence. It provides a [Focus](webview_focus_195503898.md) method, and [GotFocus](../windows.ui.xaml/uielement_gotfocus.md) and [LostFocus](../windows.ui.xaml/uielement_lostfocus.md) events, but it has no tab-related properties. Its position in the tab sequence is the same as its position in the XAML document order. The tab sequence includes all elements in the WebView content that can receive input focus.

As indicated in the Events table, WebView doesn't support most of the user input events inherited from [UIElement](../windows.ui.xaml/uielement.md), such as [KeyDown](../windows.ui.xaml/uielement_keydown.md), [KeyUp](../windows.ui.xaml/uielement_keyup.md), and [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md). A common workaround is to use [InvokeScriptAsync](webview_invokescriptasync_1912773610.md) with the JavaScript  **eval** function to use the HTML event handlers, and to use **window.external.notify** from the HTML event handler to notify the application using [WebView.ScriptNotify](webview_scriptnotify.md).

In apps compiled for Windows 10, WebView uses the Microsoft Edge rendering engine to display HTML content. In apps compiled for Windows 8 or Windows 8.1, WebView uses Internet Explorer 11 in document mode. It does not support any Microsoft ActiveX controls or plugins like Microsoft Silverlight or Portable Document Format (PDF) files.

### Navigating to content

WebView provides several API for basic navigation: [GoBack](webview_goback_1030386674.md), [GoForward](webview_goforward_1537152893.md), [Stop](webview_stop_1201535524.md), [Refresh](webview_refresh_839939657.md), [CanGoBack](webview_cangoback.md), and [CanGoForward](webview_cangoforward.md). You can use these to add typical web browsing capabilities to your app.

To set the initial content of the WebView, set the [Source](webview_source.md) property in XAML. The XAML parser automatically converts the string to a [Uri](../windows.foundation/uri.md).

```xaml

<!-- Source file is on the web. -->
<WebView x:Name="webViewA" Source="http://www.contoso.com"/>

<!-- Source file is in local storage. -->
<WebView x:Name="webViewB" Source="ms-appdata:///local/intro/welcome.html"/>

<!-- Source file is in the app package. -->
<WebView x:Name="webViewC" Source="ms-appx-web:///help/about.html"/>

```

The [Source](webview_source.md) property can be set in code, but rather than doing so, you typically use one of the **Navigate** methods to load content in code.

To load web content, use the [Navigate](webview_navigate_1098085581.md) method with a [Uri](../windows.foundation/uri.md) that uses the **http** or **https** scheme.

```csharp
webViewA.Navigate(new Uri("http://www.contoso.com"));
```

To navigate to a Uniform Resource Identifier (URI) with a POST request and HTTP headers, use the [NavigateWithHttpRequestMessage](webview_navigatewithhttprequestmessage_896558468.md) method. This method supports only [HttpMethod.Post](../windows.web.http/httpmethod_post.md) and [HttpMethod.Get](../windows.web.http/httpmethod_get.md) for the [HttpRequestMessage.Method](../windows.web.http/httprequestmessage_method.md) property value.

To load uncompressed and unencrypted content from your app's [LocalFolder](../windows.storage/applicationdata_localfolder.md) or [TemporaryFolder](../windows.storage/applicationdata_temporaryfolder.md) data stores, use the [Navigate](webview_navigate_1098085581.md) method with a [Uri](../windows.foundation/uri.md) that uses the [ms-appdata scheme](/previous-versions/windows/apps/jj655406(v=win.10)). The WebView support for this scheme requires you to place your content in a subfolder under the local or temporary folder. This enables navigation to Uniform Resource Identifier (URI) such as ms-appdata:///local/*folder*/*file*.html and ms-appdata:///temp/*folder*/*file*.html. (To load compressed or encrypted files, see [NavigateToLocalStreamUri](webview_navigatetolocalstreamuri_1538250901.md).)

Each of these first-level subfolders is isolated from the content in other first-level subfolders. For example, you can navigate to ms-appdata:///temp/folder1/file.html, but you can't have a link in this file to ms-appdata:///temp/folder2/file.html. However, you can still link to HTML content in the app package using the **ms-appx-web** scheme, and to web content using the **http** and **https**  Uniform Resource Identifier (URI) schemes.

```csharp
webViewA.Navigate(new Uri("ms-appdata:///local/intro/welcome.html"));
```

To load content from the your app package, use the [Navigate](webview_navigate_1098085581.md) method with a [Uri](../windows.foundation/uri.md) that uses the [ms-appx-web scheme](/previous-versions/windows/apps/jj655406(v=win.10)).

```csharp
webViewA.Navigate(new Uri("ms-appx-web:///help/about.html"));
```

You can load local content through a custom resolver using the [NavigateToLocalStreamUri](webview_navigatetolocalstreamuri_1538250901.md) method. This enables advanced scenarios such as downloading and caching web-based content for offline use, or extracting content from a compressed file.

### Responding to navigation events

WebView provides several events that you can use to respond to navigation and content loading states. The events occur in the following order for the root WebView content:

+ [NavigationStarting](webview_navigationstarting.md)- Occurs before the WebView navigates to new content. You can cancel navigation in a handler for this event by setting the [WebViewNavigationStartingEventArgs.Cancel](webviewnavigationstartingeventargs_cancel.md) property to **true**.

```csharp
webViewA.NavigationStarting += webViewA_NavigationStarting;

private void webViewA_NavigationStarting(object sender, WebViewNavigationStartingEventArgs args)
{
    // Cancel navigation if URL is not allowed. (Implemetation of IsAllowedUri not shown.)
    if (!IsAllowedUri(args.Uri))
        args.Cancel = true;
}

```

+ [ContentLoading](webview_contentloading.md) - Occurs when the WebView has started loading new content.

```csharp
webViewA.ContentLoading += webViewA_ContentLoading;

private void webViewA_ContentLoading(WebView sender, WebViewContentLoadingEventArgs args)
{
    // Show status.
    if (args.Uri != null)
    {
        statusTextBlock.Text = "Loading content for " + args.Uri.ToString();
    }
}

```

+ [DOMContentLoaded](webview_domcontentloaded.md) - Occurs when the WebView has finished parsing the current HTML content.

```csharp
webViewA.DOMContentLoaded += webViewA_DOMContentLoaded;

private void webViewA_DOMContentLoaded(WebView sender, WebViewDOMContentLoadedEventArgs args)
{
    // Show status.
    if (args.Uri != null)
    {
        statusTextBlock.Text = "Content for " + args.Uri.ToString() + " has finished loading";
    }
}

```

+ [NavigationCompleted](webview_navigationcompleted.md) - Occurs when the WebView has finished loading the current content or if navigation has failed. To determine whether navigation has failed, check the [IsSuccess](webviewnavigationcompletedeventargs_issuccess.md) and [WebErrorStatus](webviewnavigationcompletedeventargs_weberrorstatus.md) properties of the [WebViewNavigationCompletedEventArgs](webviewnavigationcompletedeventargs.md) class.

```csharp
webViewA.NavigationCompleted += webViewA_NavigationCompleted;

private void webViewA_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
{
    if (args.IsSuccess == true)
    {
        statusTextBlock.Text = "Navigation to " + args.Uri.ToString() + " completed successfully.";
    }
    else
    {
        statusTextBlock.Text = "Navigation to: " + args.Uri.ToString() +
                               " failed with error " + args.WebErrorStatus.ToString();
    }
}

```

Similar events occur in the same order for each **iframe** in the WebView content:

+ [FrameNavigationStarting](webview_framenavigationstarting.md) - Occurs before a frame in the WebView navigates to new content.
+ [FrameContentLoading](webview_framecontentloading.md) - Occurs when a frame in the WebView has started loading new content.
+ [FrameDOMContentLoaded](webview_framedomcontentloaded.md) - Occurs when a frame in the WebView has finished parsing its current HTML content.
+ [FrameNavigationCompleted](webview_framenavigationcompleted.md) - Occurs when a frame in the WebView has finished loading its content.

### Responding to potential problems

You can respond to potential problems with the content such as long running scripts, content that WebView can't load, and warnings of unsafe content.

Your app might appear unresponsive while scripts are running. The [LongRunningScriptDetected](webview_longrunningscriptdetected.md) event occurs periodically while the WebView executes JavaScript and provides an opportunity to interrupt the script. To determine how long the script has been running, check the [ExecutionTime](webviewlongrunningscriptdetectedeventargs_executiontime.md) property of the [WebViewLongRunningScriptDetectedEventArgs](webviewlongrunningscriptdetectedeventargs.md). To halt the script, set the event args [StopPageScriptExecution](webviewlongrunningscriptdetectedeventargs_stoppagescriptexecution.md) property to **true**. The halted script will not execute again unless it is reloaded during a subsequent WebView navigation.

The WebView control cannot host arbitrary file types. When an attempt is made to load content that the WebView can't host, the [UnviewableContentIdentified](webview_unviewablecontentidentified.md) event occurs. You can handle this event and notify the user, or use the [Launcher](../windows.system/launcher.md) class to redirect the file to an external browser or another app.

Similarly, the [UnsupportedUriSchemeIdentified](webview_unsupportedurischemeidentified.md) event occurs when a Uniform Resource Identifier (URI) scheme that's not supported is invoked in the web content, such as fbconnect:// or mailto://. You can handle this event to provide custom behavior instead of allowing the default system launcher to launch the Uniform Resource Identifier (URI).

The [UnsafeContentWarningDisplaying](webview_unsafecontentwarningdisplaying.md) event occurs when the WebView shows a warning page for content that was reported as unsafe by the SmartScreen Filter. If the user chooses to continue the navigation, subsequent navigation to the page will not display the warning nor fire the event.

### Handling special cases for WebView content

You can use the [ContainsFullScreenElement](webview_containsfullscreenelement.md) property and [ContainsFullScreenElementChanged](webview_containsfullscreenelementchanged.md) event to detect, respond to, and enable full-screen experiences in web content, such as full-screen video playback. For example, you may use the [ContainsFullScreenElementChanged](webview_containsfullscreenelementchanged.md) event to resize the WebView to occupy the entirety of your app view, or, as the following example illustrates, put a windowed app in full screen mode when a full screen web experience is desired.

```csharp

// Assume webView is defined in XAML
webView.ContainsFullScreenElementChanged += webView_ContainsFullScreenElementChanged;

private void webView_ContainsFullScreenElementChanged(WebView sender, object args)
{
    var applicationView = ApplicationView.GetForCurrentView();

    if (sender.ContainsFullScreenElement)
    {
        applicationView.TryEnterFullScreenMode();
    }
    else if (applicationView.IsFullScreenMode)
    {
        applicationView.ExitFullScreenMode();
    }
}

```

You can use the [NewWindowRequested](webview_newwindowrequested.md) event to handle cases where hosted web content requests a new window to be displayed, such as a popup window. You can use another WebView control to display the contents of the requested window.

Use [PermissionRequested](webview_permissionrequested.md) event to enable web features that require special capabilities. These currently include geolocation, IndexedDB storage, and user audio and video (for example, from a microphone or webcam). If your app accesses user location or user media, you still are required to declare this capability in the app manifest. For example, an app that uses geolocation needs the following capability declarations at minimum in Package.appxmanifest:

```xml
  <Capabilities>
    <Capability Name="internetClient"/>
    <DeviceCapability Name="location"/>
  </Capabilities>

```

In addition to the app handling the [PermissionRequested](webview_permissionrequested.md) event, the user will have to approve standard system dialogs for apps requesting location or media capabilities in order for these features to be enabled.

Here is an example of how an app would enable geolocation in a map from Bing:

```csharp

// Assume webView is defined in XAML
webView.PermissionRequested += webView_PermissionRequested;

private void webView_PermissionRequested(WebView sender, WebViewPermissionRequestedEventArgs args)
{
    if (args.PermissionRequest.PermissionType == WebViewPermissionType.Geolocation &&
        args.PermissionRequest.Uri.Host == "www.bing.com")
    {
        args.PermissionRequest.Allow();
    }
}

```

If your app requires user input or other asynchronous operations to respond to a permission request, use the [Defer](webviewpermissionrequest_defer_1945301616.md) method of [WebViewPermissionRequest](webviewpermissionrequest.md) to create a [WebViewDeferredPermissionRequest](webviewdeferredpermissionrequest.md) that can be acted upon at a later time. See [WebViewPermissionRequest.Defer](webviewpermissionrequest_defer_1945301616.md).

If users must securely log out of a website hosted in WebView, or in other cases when security is important, call the static method [ClearTemporaryWebDataAsync](webview_cleartemporarywebdataasync_1779958528.md) to clear out all locally cached content from a WebView session. This prevents malicious users from accessing sensitive data.

### Interacting with WebView content

You can interact with the content of the WebView by using the [InvokeScriptAsync](webview_invokescriptasync_1912773610.md) method to invoke or inject script into the WebView content, and the [ScriptNotify](webview_scriptnotify.md) event to get information back from the WebView content.

To invoke JavaScript inside the WebView content, use the [InvokeScriptAsync](webview_invokescriptasync_1912773610.md) method. The invoked script can return only string values.

For example, if the content of a WebView named `webViewA` contains a function named `setDate` that takes 3 parameters, you can invoke it like this.

```csharp

string[] args = {"January", "1", "2000"};
string returnValue = await webViewA.InvokeScriptAsync("setDate", args);
```

You can use [InvokeScriptAsync](webview_invokescriptasync_1912773610.md) with the JavaScript  **eval** function to inject content into the web page.

Here, the text of a XAML [TextBox](textbox.md) (`nameTextBox.Text`) is written to a div in an HTML page hosted in `webViewA`.

```csharp

private async void Button_Click(object sender, RoutedEventArgs e)
{
    string functionString = String.Format("document.getElementById('nameDiv').innerText = 'Hello, {0}';", nameTextBox.Text);
    await webViewA.InvokeScriptAsync("eval", new string[] { functionString });
}
```

Scripts in the WebView content can use **window.external.notify** with a string parameter to send information back to your app. To receive these messages, handle the [ScriptNotify](webview_scriptnotify.md) event.

To enable an external web page to fire the [ScriptNotify](webview_scriptnotify.md) event when calling **window.external.notify**, you must include the page's Uniform Resource Identifier (URI) in the **ApplicationContentUriRules** section of the app manifest. (You can do this in Microsoft Visual Studio on the Content URIs tab of the Package.appxmanifest designer.) The URIs in this list must use HTTPS, and may contain subdomain wildcards (for example, https://*.microsoft.com) but they cannot contain domain wildcards (for example, https://*.com and https://*.*). The manifest requirement does not apply to content that originates from the app package, uses an ms-local-stream:// URI, or is loaded using [NavigateToString](webview_navigatetostring_1924125949.md).

### Accessing the Windows Runtime in WebView

Starting in Windows 10, you can use the [AddWebAllowedObject](webview_addweballowedobject_1295901427.md) method to inject an instance of a native class from a Windows Runtime component into the JavaScript context of the WebView. This allows full access to the native methods, properties, and events of that object in the JavaScript content of that WebView. The class must be decorated with the [AllowForWeb](../windows.foundation.metadata/allowforwebattribute.md) attribute.

For example, this code injects an instance of `MyClass` imported from a Windows Runtime component into WebView.

```csharp

private void webView_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
{
    if (args.Uri.Host == "www.contoso.com")
    {
        webView.AddWebAllowedObject("nativeObject", new MyClass());
    }
}

```

For more info, see [WebView.AddWebAllowedObject](webview_addweballowedobject_1295901427.md).

In addition, trusted JavaScript content in WebView can be allowed to directly access Windows RuntimeAPI. This provides powerful native capabilities for web apps hosted in WebView. To enable this feature, the Uniform Resource Identifier (URI) for trusted content must be added to the allowlist in the ApplicationContentUriRules of the app in Package.appxmanifest, with WindowsRuntimeAccess specifically set to "all".

This example shows a section of the app manifest. Here, a local Uniform Resource Identifier (URI) is given access to the Windows Runtime.

```xml
  <Applications>
    <Application Id="App"
      ...

      <uap:ApplicationContentUriRules>
        <uap:Rule Match="ms-appx-web:///Web/App.html" WindowsRuntimeAccess="all" Type="include"/>
      </uap:ApplicationContentUriRules>
    </Application>
  </Applications>

```

### Options for web content hosting

Starting in Windows 10, you can use the [WebView.Settings](webview_settings.md) property (of type [WebViewSettings](webviewsettings.md)) to control whether JavaScript and IndexedDB are enabled. For example, if you use WebView to display strictly static content, you might want to disable JavaScript for best performance.

### Capturing WebView content

To enable sharing WebView content with other apps, use the [CaptureSelectedContentToDataPackageAsync](webview_captureselectedcontenttodatapackageasync_1187796026.md) method, which returns the selected content as a [DataPackage](../windows.applicationmodel.datatransfer/datapackage.md). This method is asynchronous, so you must use a deferral to prevent your [DataRequested](../windows.applicationmodel.datatransfer/datatransfermanager_datarequested.md) event handler from returning before the asynchronous call is complete.

To get a preview image of the WebView's current content, use the [CapturePreviewToStreamAsync](webview_capturepreviewtostreamasync_1169189879.md) method. This method creates an image of the current content and writes it to the specified stream.

### Execution modes

By default, WebView content is hosted on the UI thread on devices in the desktop device family, and off the UI thread on all other devices. You can use the [WebView.DefaultExecutionMode](webview_defaultexecutionmode.md) static property to query the default threading behavior for the current client. If necessary, you can use the [WebView(WebViewExecutionMode)](webview_webview_499271973.md) constructor to override this behavior.

The supported [WebViewExecutionMode](webview_executionmode.md) values are:

- **SameThread** - The WebView content is hosted on the UI Thread.
- **SeparateThread** - The WebView content is hosted on a separate thread off the UI thread.
- **SeparateProcess** - (Windows 10, version 1803 or later) The WebView content is hosted on a separate process off the app process. All of an app's WebView instances share the same separate process, there is not a separate process per WebView instance.

When running in a separate process, WebView exibits two behavior differences:

- The WebView process could terminate. You can be notified of this by listening to the [SeparateProcessLost](webview_separateprocesslost.md) event.
- The WebView process could asynchronously reject keyboard focus. In this case, the WebView.Focus method returns **true**, and then immediately (but asynchronously), focus moves away from the WebView. (Other ways of moving focus behave similarly, such as FocusManager.TryMoveFocus.) You can track this more explicitly by using the [FocusManager.TryFocusAsync](../windows.ui.xaml.input/focusmanager_tryfocusasync_1779533284.md) or [FocusManager.TryMoveFocusAsync](../windows.ui.xaml.input/focusmanager_trymovefocus_582274934.md) APIs.

This example demonstrates how to create a WebView control that runs in a separate process from the host app, and will be re-created if the separate process is lost.

```xaml
<Grid>
    <Border x:Name="WebViewBorder" Loaded="WebViewBorder_Loaded" />
</Grid>
```

```csharp
    ...

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();

        var webView = new WebView(WebViewExecutionMode.SeparateProcess);
        WebViewBorder.Child = webView;;

        InitializeWebView(webView);
    }

    void InitializeWebView(WebView webView)
    {
        webView.Source = this.WebViewSourceUri;

        webView.SeparateProcessLost += (sender, e) =>
        {
            var newWebView = new WebView(WebViewExecutionMode.SeparateProcess);
            InitializeWebView(newWebView);
            WebViewBorder.Child = newWebView;
        };
    }
}
```

> [!NOTE]
> There might be performance issues when hosting content on the UI thread on mobile devices, so be sure to test on all target devices when you change [DefaultExecutionMode](webview_defaultexecutionmode.md).

A WebView that hosts content off the UI thread is not compatible with parent controls that require gestures to propagate up from the WebView control to the parent, such as [FlipView](flipview.md), [ScrollViewer](scrollviewer.md), and other related controls. These controls will not be able to receive gestures initiated in the off-thread WebView. In addition, printing off-thread web content is not directly supported – you should print an element with [WebViewBrush](webviewbrush.md) fill instead.

#### Focus behavior for WebView in a separate process

Whether running in the app process or a separate process, you can set focus on a WebView by calling the WebView.Focus method. This is equivalent to the Control.Focus and Hyperlink.Focus methods (note that WebView does not derive from Control).

Similarly, several methods on the [FocusManager](../windows.ui.xaml.input/focusmanager.md) class can affect a WebView (or Control or Hyperlink): **TryMoveFocus**, **FindNextFocusableElement**, **FindLastFocusableElement**, and **GetFocusedElement**. For example, TryMoveFocus moves focus to a WebView, and GetFocusedElement returns a WebView that has focus.

Finally, moving focus to or from a WebView raises focus events, both on the WebView itself and on the element that loses or receives focus. The events are **LosingFocus**, **LostFocus**, **GettingFocus**, and **GotFocus**. For example, when focus moves from a Control to a WebView, the Control will raise LosingFocus and LostFocus events, and the WebView will raise GettingFocus and GotFocus events.

When a WebView is running in a separate process, the behavior of these APIs changes slightly. Assuming the WebView is focusable, the WebView.Focus method will return true (success), but focus has not actually moved yet. The same is true if rather than the WebView.Focus method, FocusManager.TryMoveFocus is called and it identifies a WebView as the next focusable element.

The differences in behavior are:

- FocusManager.GetFocusedElement does not return the WebView unless/until the asynchronous operation completes.
- The control that is losing focus will receive its LosingFocus event synchronously; however, it will not receive LostFocus unless/until the asynchronous operation completes.
- Similarly, the GettingFocus event will occur on the WebView synchronously; however, the GotFocus event won't be raised unless/until the asynchronous operation completes.

None of this changes if you call FocusManager.TryFocusAsync instead. However, the async method gives you an opportunity to determine if the focus change succeeded.

Calling FocusManager.TryMoveFocusAsync on an element other than a WebView in a separate process will complete synchronously.

This example demonstrates how to move focus to the next logical element, but if that fails, restore focus to its initial location.

```csharp
async void MoveFocus(WebView webView))
{
    FocusMovementResult result;
    result = await FocusManager.TryFocusAsync(webView, FocusState.Programmatic);
    if (!result.Succeeded)
    {
        // Reset focus to the starting position
        this.Focus(FocusState.Programmatic);
    }
}
```

### Use of Alert

If a web page hosted in a WebView uses the JavaScript **Alert** function, it will not be displayed. This is by design for all versions of WebView.

You might be able to intercept the information displayed by an **Alert** and do what you want with it in the host application. Whether this is possible depends on how the page is written and whether you have control of it. A sample is available that demonstrates one possible technique to do this. The sample is written for Windows 8.1 and Windows Phone 8.1, but will also work for apps using the Universal Windows Platform (UWP). However, this might not work for every scenario.

[How to intercept JavaScript alert in WebView in Universal Windows apps sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/OneCodeTeam/How%20to%20intercept%20JavaScript%20alert%20in%20WebView%20in%20universal%20Windows%20apps)

### Notes for previous versions

### Windows 8.1

The following WebView APIs are deprecated in Windows 8.1:

+ [LoadCompleted](webview_loadcompleted.md) and [NavigationFailed](webview_navigationfailed.md). Use [NavigationCompleted](webview_navigationcompleted.md) instead.
+ [InvokeScript](webview_invokescript_1786819783.md). Use [InvokeScriptAsync](webview_invokescriptasync_1912773610.md) instead.
+ [DataTransferPackage](webview_datatransferpackage.md) and [DataTransferPackageProperty](webview_datatransferpackageproperty.md). Use [CaptureSelectedContentToDataPackageAsync](webview_captureselectedcontenttodatapackageasync_1187796026.md) instead.
+ [AllowedScriptNotifyUris](webview_allowedscriptnotifyuris.md), [AnyScriptNotifyUri](webview_anyscriptnotifyuri.md), and [AllowedScriptNotifyUrisProperty](webview_allowedscriptnotifyurisproperty.md). Include the page's URI in the **ApplicationContentUriRules** section of the app manifest instead.

On Windows only, you can handle the [UnsafeContentWarningDisplaying](webview_unsafecontentwarningdisplaying.md) event. This event occurs when the WebView shows a warning page for content that was reported as unsafe by the SmartScreen Filter. If the user chooses to continue the navigation, subsequent navigation to the page will not display the warning nor fire the event. This event is not implemented for Windows Phone.

When you invoke JavaScript inside the WebView by calling the [InvokeScriptAsync](webview_invokescriptasync_1912773610.md) method, functions that require a secondary window, like **Alert**, are not supported.

### Windows Phone 8

+ WebView on Windows Phone 8.1 is not compatible with parent controls that require gestures to propagate up from the WebView control to the parent, such as [FlipView](flipview.md), [ScrollViewer class](scrollviewer.md), and other related controls.
+ WebView on Windows Phone 8.1 includes the [ContainsFullScreenElement](webview_containsfullscreenelement.md) property and [ContainsFullScreenElementChanged](webview_containsfullscreenelementchanged.md) event. These members are not available on Windows.

The [UnsafeContentWarningDisplaying](webview_unsafecontentwarningdisplaying.md) event is not implemented for Windows Phone prior to Windows 10.

### Windows 8

These remarks apply only to apps compiled for Windows 8, even when running on Windows 8.1 or later.

In Windows 8,WebView has the characteristic that other UI regions such as controls cannot be rendered on top of the WebView. This "airspace problem" is because of how window regions are handled internally, particularly how input events are processed and how the screen draws. If you want to render HTML content and also place other UI elements on top of that HTML content, you should use [WebViewBrush](webviewbrush.md) as the render area. The WebView still provides the HTML source information, and you reference that WebView through the [SourceName](webviewbrush_sourcename.md) property. [WebViewBrush](webviewbrush.md) does not have this overlay limitation.

If you want to display an interactive WebView that only occasionally has overlapping content (such as a drop-down list or app bar), you can temporarily hide the WebView control when necessary, replacing it with an element using a [WebViewBrush](webviewbrush.md) fill. Then, when the overlapping content is no longer present, you can display the original WebView again.

> [!NOTE]
> The "airspace problem" has been fixed starting with Windows 8.1 and does not apply for apps targeting Windows 8.1 or Windows 10.

WebView always uses Internet Explorer 10 in document mode.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | XYFocusDown |
| 1607 | 14393 | XYFocusLeft |
| 1607 | 14393 | XYFocusRight |
| 1607 | 14393 | XYFocusUp |
| 1803 | 17134 | SeparateProcessLost |
| 1809 | 17763 | WebResourceRequested |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Web view](/windows/uwp/design/controls-and-patterns/web-view).
>
> If you have the **WinUI 2 Gallery** app installed, click here to [open the app and see the WebView in action](winui2gallery:/item/WebView).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)

The following code example demonstrates how to navigate a WebView to a URI contained in a [TextBox](textbox.md) named `Address`.

```csharp
try
{
    Uri targetUri = new Uri(Address.Text);
    webViewA.Navigate(targetUri);
}
catch (FormatException ex)
{
    // Bad address.
}

```

The following code example demonstrates how to load local HTML into a WebView control.

```csharp
webViewB.NavigateToString(
    "<html><body><h2>This is an HTML fragment</h2></body></html>");
```

## -see-also

[FrameworkElement](../windows.ui.xaml/frameworkelement.md), [WebView guidelines](/windows/uwp/design/controls-and-patterns/web-view), [XAML WebView control sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/XamlWebView)
