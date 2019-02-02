---
-api-id: T:Windows.UI.Xaml.Controls.HyperlinkButton
-api-type: winrt class
---

<!-- Class syntax.
public class HyperlinkButton : Windows.UI.Xaml.Controls.Primitives.ButtonBase, Windows.UI.Xaml.Controls.IHyperlinkButton
-->

# Windows.UI.Xaml.Controls.HyperlinkButton

## -description
Represents a button control that functions as a hyperlink.

## -xaml-syntax
```xaml
<HyperlinkButton .../>
-or-
<HyperlinkButton>stringContent</HyperlinkButton>
-or-
<HyperlinkButton>
    singleObject
</HyperlinkButton>

```


## -remarks
[HyperlinkButton](hyperlinkbutton.md) is a button that appears as marked up text.

<img alt="Hyperlink button" src="images/controls/HyperlinkButton.png" />

> [!NOTE]
> By default, the [HyperlinkButton](hyperlinkbutton.md) appears as underlined text when you set a string as the value for the [Content](contentcontrol_content.md) property.

The text does not appear underlined in the following cases:

+ You set a [TextBlock](textblock.md) as the value for the [Content](contentcontrol_content.md) property, and set the [Text](textblock_text.md) property on the [TextBlock](textblock.md).
+ You re-template the [HyperlinkButton](hyperlinkbutton.md) and change the name of the [ContentPresenter](contentpresenter.md) template part.
 If you need a button that appears as non-underlined text, consider using a standard [Button](button.md) control and applying the built-in TextBlockButtonStyle system resource to its [Style](../windows.ui.xaml/frameworkelement_style.md) property.

### **Hyperlink** and **HyperlinkButton**

There are two ways that you can add a hyperlink to a XAML app. [Hyperlink](../windows.ui.xaml.documents/hyperlink.md) and [HyperlinkButton](hyperlinkbutton.md) have the similar purpose of enabling a user to launch a specific URI using a separate browser app.+ Use an inline [Hyperlink](../windows.ui.xaml.documents/hyperlink.md) text element inside of a text control. A [Hyperlink](../windows.ui.xaml.documents/hyperlink.md) element flows with other text elements and you can use it in any [InlineCollection](../windows.ui.xaml.documents/inlinecollection.md). For more info, see [Hyperlink](../windows.ui.xaml.documents/hyperlink.md).
+ Use a [HyperlinkButton](hyperlinkbutton.md) control anywhere in the app. A [HyperlinkButton](hyperlinkbutton.md) is a specialized [Button](button.md) control that you can use anywhere that you would use a [Button](button.md).


### Navigate to a URI

To use the hyperlink to navigate to a Uniform Resource Identifier (URI), set the [NavigateUri](hyperlinkbutton_navigateuri.md) property. When a user clicks or taps the [HyperlinkButton](hyperlinkbutton.md), the specified Uniform Resource Identifier (URI) opens in the default browser. The default browser runs in a separate process from your app.

> [!TIP]
> You don't have to use **http:** or **https:** schemes. You can use schemes such as **ms-appx:**, **ms-appdata:**, or **ms-resources:**, if there's resource content at these locations that's appropriate to load in a browser. However, the **file:** scheme is specifically blocked. For more info, see [URI schemes](https://msdn.microsoft.com/library/f3b3ae74-aaea-4f00-8f0a-4c231b8745af).

When a user clicks the [HyperlinkButton](hyperlinkbutton.md), the value of the [NavigateUri](hyperlinkbutton_navigateuri.md) property is passed to a system handler for Uniform Resource Identifier (URI) types and schemes. The system then launches the app that is registered for the scheme of the Uniform Resource Identifier (URI) provided for [NavigateUri](hyperlinkbutton_navigateuri.md).

If you don't want the [HyperlinkButton](hyperlinkbutton.md) to load content in a default Web browser (and don't want a browser to appear), then don't set a value for [NavigateUri](hyperlinkbutton_navigateuri.md). Instead, handle the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event, and write code that does what you want.

### Handle the Click event

Use the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event for actions other than launching a Uniform Resource Identifier (URI) in a browser, such as navigation within the app. For example, if you want to load a new app page rather than opening a browser, call a [Frame.Navigate](frame_navigate_1426351961.md) method within your [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event handler to navigate to the new app page. If you want an external, absolute Uniform Resource Identifier (URI) to load within a [WebView](webview.md) control that also exists in your app, call [WebView.Navigate](webview_navigate_1098085581.md) as part of your [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) handler logic.

You don't typically handle the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event as well as specifying a [NavigateUri](hyperlinkbutton_navigateuri.md) value, as these represent two different ways of using the [Hyperlink](../windows.ui.xaml.documents/hyperlink.md) element. If your intent is to open the URI in the default browser, and you have specified a value for [NavigateUri](hyperlinkbutton_navigateuri.md), don't handle the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event. Conversely, if you handle the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event, don't specify a [NavigateUri](hyperlinkbutton_navigateuri.md).

There's nothing you can do within the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event handler to prevent the default browser from loading any valid target specified for [NavigateUri](hyperlinkbutton_navigateuri.md); that action takes place automatically (asynchronously) when the hyperlink is activated and can't be canceled from within the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event handler.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Hyperlinks](/windows/uwp/design/controls-and-patterns/hyperlinks).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the HyperlinkButton in action](xamlcontrolsgallery:/item/HyperlinkButton).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

Here's a [HyperlinkButton](hyperlinkbutton.md) as declared in XAML. It declares a string value for [Content](contentcontrol_content.md) and also a [NavigateUri](hyperlinkbutton_navigateuri.md) value.

[!code-xml[BasicHyperlinkButtonXAML](../windows.ui.xaml.controls/code/BasicControlSnippets/CS/MainPage.xaml#SnippetBasicHyperlinkButtonXAML)]

## -see-also
[ButtonBase](../windows.ui.xaml.controls.primitives/buttonbase.md), [HyperlinkButton styles and templates](https://msdn.microsoft.com/library/7a121bf4-0a2f-4d49-b3e7-3c44fd4905c6), [Hyperlinks overview](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/hyperlinks)
