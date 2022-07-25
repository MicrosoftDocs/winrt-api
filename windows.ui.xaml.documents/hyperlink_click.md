---
-api-id: E:Windows.UI.Xaml.Documents.Hyperlink.Click
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Click<Windows.UI.Xaml.Documents.Hyperlink,  Windows.UI.Xaml.Documents.HyperlinkClickEventArgs>
-->

# Windows.UI.Xaml.Documents.Hyperlink.Click

## -description
Occurs when the [Hyperlink](hyperlink.md) is clicked.



## -xaml-syntax
```xaml
<Hyperlink Click="eventhandler"/>
```


## -remarks
The Click event is intended for navigation within the app, or actions other than launching a URI in a browser. For example, if you want a new app page to load rather than opening a browser, or if you want to load the URI specifically within a [WebView](../windows.ui.xaml.controls/webview.md) control, you handle the Click event and write code to perform the actions you want. You don't typically handle Click as well as specifying a [NavigateUri](hyperlink_navigateuri.md) value, these represent two different ways of using the [Hyperlink](hyperlink.md) element. If your intent is to open the URI in the default browser, and you have specified a value for [NavigateUri](hyperlink_navigateuri.md), don't handle Click. Conversely, if you have code for the Click event, don't specify a [NavigateUri](hyperlink_navigateuri.md).

## -examples

## -see-also
[NavigateUri](hyperlink_navigateuri.md)
