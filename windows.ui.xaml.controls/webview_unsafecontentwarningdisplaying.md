---
-api-id: E:Windows.UI.Xaml.Controls.WebView.UnsafeContentWarningDisplaying
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler UnsafeContentWarningDisplaying<Windows.UI.Xaml.Controls.WebView,  object>
-->

# Windows.UI.Xaml.Controls.WebView.UnsafeContentWarningDisplaying

## -description
Occurs when the [WebView](webview.md) shows a warning page for content that was reported as unsafe by SmartScreen Filter.

## -xaml-syntax
```xaml
<WebView UnsafeContentWarningDisplaying="eventhandler" />
```


## -remarks
> This event is not implemented on Windows Phone 8.1 and will never be raised.

This event occurs when the warning page appears. If the user chooses to continue the navigation, subsequent navigation to the page will not display the warning nor fire the event.

## -examples

## -see-also
