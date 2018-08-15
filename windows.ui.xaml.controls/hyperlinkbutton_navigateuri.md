---
-api-id: P:Windows.UI.Xaml.Controls.HyperlinkButton.NavigateUri
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri NavigateUri { get;  set; }
-->

# Windows.UI.Xaml.Controls.HyperlinkButton.NavigateUri

## -description
Gets or sets the Uniform Resource Identifier (URI) to navigate to when the [HyperlinkButton](hyperlinkbutton.md) is clicked.

## -xaml-syntax
```xaml
<HyperlinkButton NavigateUri="uriString"/>
```


## -property-value
The Uniform Resource Identifier (URI) to navigate to when the [HyperlinkButton](hyperlinkbutton.md) is clicked.

## -remarks
When a user clicks or otherwise invokes a [HyperlinkButton](hyperlinkbutton.md), it opens the URI you specified for the [NavigateUri](hyperlinkbutton_navigateuri.md) property in the default browser.

You don't have to use **http:** or **https:** schemes for the URI. You can use schemes such as **ms-appx:**, **ms-appdata:**, or **ms-resources:**, if there's resource content at these locations that's appropriate to load in a browser. However, the **file:** scheme is specifically blocked. For more info, see [URI schemes](http://msdn.microsoft.com/library/f3b3ae74-aaea-4f00-8f0a-4c231b8745af).

[HyperlinkButton](hyperlinkbutton.md) is a control, so it has input events such as [Tapped](../windows.ui.xaml/uielement_tapped.md), and it's a [ButtonBase](../windows.ui.xaml.controls.primitives/buttonbase.md) subclass so it also has a [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event. You don't typically specify a value for [NavigateUri](hyperlinkbutton_navigateuri.md) and also handle input events that are interpreted as clicking the [HyperlinkButton](hyperlinkbutton.md). The action of opening the [NavigateUri](hyperlinkbutton_navigateuri.md) in a default browser is a system action that takes place without requiring any event handling. If your intent is that the [HyperlinkButton](hyperlinkbutton.md) should load a specified URI within a [WebView](webview.md) control that's also part of your app, then don't specify a value for [NavigateUri](hyperlinkbutton_navigateuri.md). Handle the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event instead, and call [WebView.Navigate](webview_navigate_1098085581.md), specifying the URI to load.

## -examples
Here's a [HyperlinkButton](hyperlinkbutton.md) as declared in XAML. It declares a string value for [Content](contentcontrol_content.md) and also a [NavigateUri](hyperlinkbutton_navigateuri.md) value.



[!code-xml[BasicHyperlinkButtonXAML](../windows.ui.xaml.controls/code/BasicControlSnippets/CS/MainPage.xaml#SnippetBasicHyperlinkButtonXAML)]

## -see-also
[Quickstart: Adding button controls](http://msdn.microsoft.com/library/362f7ba1-7d28-441f-b0b5-0e56ec8deafe)
