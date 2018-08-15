---
-api-id: M:Windows.UI.Xaml.Controls.WebView.Focus(Windows.UI.Xaml.FocusState)
-api-type: winrt method
---

<!-- Method syntax
public bool Focus(Windows.UI.Xaml.FocusState value)
-->

# Windows.UI.Xaml.Controls.WebView.Focus

## -description
Sets the input focus to the [WebView](webview.md).

## -parameters
### -param value
A value that indicates how the focus was set.

## -returns
**true** if focus was set; otherwise, **false**.

## -remarks
In apps compiled for Windows 8, the [WebView](webview.md) control automatically gets input focus whenever you use script to programmatically set the focus to some content in the [WebView](webview.md). In apps compiled for Windows 8.1, this does not occur automatically. Instead, you must call the [Focus](webview_focus_195503898.md) method to set the focus to the [WebView](webview.md) control and also use script to set the focus to some content in the control.

When you call this method, you will typically pass in a [FocusState](../windows.ui.xaml/focusstate.md) value of **Programmatic**. Use the **Pointer** and **Keyboard** values when you call this method in response to direct user input. You cannot use this method to remove input focus from the control. The **Unfocused** value will throw an exception.

## -examples

## -see-also
