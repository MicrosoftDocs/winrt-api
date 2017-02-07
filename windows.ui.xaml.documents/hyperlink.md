---
-api-id: T:Windows.UI.Xaml.Documents.Hyperlink
-api-type: winrt class
---

<!-- Class syntax.
public class Hyperlink : Windows.UI.Xaml.Documents.Span, Windows.UI.Xaml.Documents.IHyperlink, Windows.UI.Xaml.Documents.IHyperlink2, Windows.UI.Xaml.Documents.IHyperlink3, Windows.UI.Xaml.Documents.IHyperlink4
-->

# Windows.UI.Xaml.Documents.Hyperlink

## -description
Provides an inline-level content element that provides facilities for hosting hyperlinks.

## -xaml-syntax
```xaml
<Hyperlink .../>
```


## -remarks
### **Hyperlink** and **HyperlinkButton**

There are two ways that you can add a hyperlink to a XAML app. [Hyperlink](hyperlink.md) and [HyperlinkButton](../windows.ui.xaml.controls/hyperlinkbutton.md) have the similar purpose of enabling a user to launch a specific URI using a separate browser app.+ Use an inline [Hyperlink](hyperlink.md) text element inside of a text control. A [Hyperlink](hyperlink.md) element flows with other text elements and you can use it in any [InlineCollection](inlinecollection.md).
+ Use a [HyperlinkButton](../windows.ui.xaml.controls/hyperlinkbutton.md) control anywhere in the app. A [HyperlinkButton](../windows.ui.xaml.controls/hyperlinkbutton.md) is a specialized [Button](../windows.ui.xaml.controls/button.md) control that you can use anywhere that you would use a [Button](../windows.ui.xaml.controls/button.md). For more info, see [HyperlinkButton](../windows.ui.xaml.controls/hyperlinkbutton.md).


### Inline hyperlink

You use the [Hyperlink](hyperlink.md) element to add interactive text to the content of a [TextBlock](../windows.ui.xaml.controls/textblock.md) or [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md). [Hyperlink](hyperlink.md) is derived from the [Inline](inline.md) class, so you can place it inside of any container that has an [InlineCollection](inlinecollection.md) as its **Inlines** property, such as [TextBlock](../windows.ui.xaml.controls/textblock.md), [Paragraph](paragraph.md), or [Span](span.md).

> [!TIP]
> When you use a [Hyperlink](hyperlink.md) within a [Span](span.md) container with other text elements in XAML, apply the `xml:space="preserve"` attribute to the [Span](span.md) to keep the white space between the [Hyperlink](hyperlink.md) and other elements.

### Navigate to a URI

To use the hyperlink to navigate to a Uniform Resource Identifier (URI), set the [NavigateUri](hyperlink_navigateuri.md) property. When a user clicks or taps the [Hyperlink](hyperlink.md) element, the specified Uniform Resource Identifier (URI) opens in the default browser. The default browser runs in a separate process from your app.

> [!TIP]
> You don't have to use **http:** or **https:** schemes. You can use schemes such as **ms-appx:**, **ms-appdata:**, or **ms-resources:**, if there's resource content at these locations that's appropriate to load in a browser. However, the **file:** scheme is specifically blocked. For more info, see [URI schemes](http://msdn.microsoft.com/library/f3b3ae74-aaea-4f00-8f0a-4c231b8745af).

When a user clicks the [Hyperlink](hyperlink.md), the value of the [NavigateUri](hyperlink_navigateuri.md) property is passed to a system handler for Uniform Resource Identifier (URI) types and schemes. The system then launches the app that is registered for the scheme of the Uniform Resource Identifier (URI) provided for [NavigateUri](hyperlink_navigateuri.md).

If you don't want the [Hyperlink](hyperlink.md) to load content in a default Web browser (and don't want a browser to appear), then don't set a value for [NavigateUri](hyperlink_navigateuri.md). Instead, handle the [Click](hyperlink_click.md) event, and write code that does what you want.

### Handle the Click event

Use the [Click](hyperlink_click.md) event for actions other than launching a Uniform Resource Identifier (URI) in a browser, such as navigation within the app. For example, if you want to load a new app page rather than opening a browser, call a [Frame.Navigate](../windows.ui.xaml.controls/frame_navigate.md) method within your [Click](hyperlink_click.md) event handler to navigate to the new app page. If you want an external, absolute Uniform Resource Identifier (URI) to load within a [WebView](../windows.ui.xaml.controls/webview.md) control that also exists in your app, call [WebView.Navigate](../windows.ui.xaml.controls/webview_navigate.md) as part of your [Click](hyperlink_click.md) handler logic.

You don't typically handle the [Click](hyperlink_click.md) event as well as specifying a [NavigateUri](hyperlink_navigateuri.md) value, as these represent two different ways of using the [Hyperlink](hyperlink.md) element. If your intent is to open the URI in the default browser, and you have specified a value for [NavigateUri](hyperlink_navigateuri.md), don't handle the [Click](hyperlink_click.md) event. Conversely, if you handle the [Click](hyperlink_click.md) event, don't specify a [NavigateUri](hyperlink_navigateuri.md).

There's nothing you can do within the [Click](hyperlink_click.md) event handler to prevent the default browser from loading any valid target specified for [NavigateUri](hyperlink_navigateuri.md); that action takes place automatically (asynchronously) when the hyperlink is activated and can't be canceled from within the [Click](hyperlink_click.md) event handler.

### Hyperlink limitations

Because a [Hyperlink](hyperlink.md) is not a [UIElement](../windows.ui.xaml/uielement.md), it does not have the set of UI element input events such as [Tapped](../windows.ui.xaml/uielement_tapped.md), [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md) and so on. Instead, a [Hyperlink](hyperlink.md) has its own [Click](hyperlink_click.md) event, plus the implicit behavior of the system loading any Uniform Resource Identifier (URI) specified as the [NavigateUri](hyperlink_navigateuri.md). The system handles all input actions that should invoke the [Hyperlink](hyperlink.md) actions and raises the [Click](hyperlink_click.md) event in response.

[Hyperlink](hyperlink.md) has restrictions on the content that can exist in its [Inlines](span_inlines.md) collection. Specifically, a [Hyperlink](hyperlink.md) only permits [Run](run.md) and other [Span](span.md) types that aren't another [Hyperlink](hyperlink.md). [InlineUIContainer](inlineuicontainer.md) can't be in the [Inlines](span_inlines.md) collection of a [Hyperlink](hyperlink.md). Attempting to add restricted content throws an invalid argument exception or XAML parse exception.

### Hyperlink and theme/style behavior

[Hyperlink](hyperlink.md) doesn't inherit from [Control](../windows.ui.xaml.controls/control.md), so it doesn't have a [Style](../windows.ui.xaml/frameworkelement_style.md) property or a [Template](../windows.ui.xaml.controls/control_template.md). You can edit the properties that are inherited from [TextElement](textelement.md), such as [Foreground](textelement_foreground.md) or [FontFamily](textelement_fontfamily.md), to change the appearance of a [Hyperlink](hyperlink.md), but you can't use a common style or template to apply changes. Instead of using a template, consider using common resources for values of [Hyperlink](hyperlink.md) properties to provide consistency. Some properties of [Hyperlink](hyperlink.md) use defaults from a [{ThemeResource} markup extension](http://msdn.microsoft.com/library/8a1c79d2-9566-44aa-b8e1-cc7adad1bcc5) value provided by the system. This enables the [Hyperlink](hyperlink.md) appearance to switch in appropriate ways when the user changes the system theme at run-time.

The default color of the hyperlink is the accent color of the system. You can set the [Foreground](textelement_foreground.md) property to override this.

By default, [Hyperlink](hyperlink.md) is underlined. This underline is important because it helps meet accessibility requirements. Color-blind users use the underline to distinguish between hyperlinks and other text. You can set the [UnderlineStyle](hyperlink_underlinestyle.md) property to disable the underline. If you disable underlines, you should consider adding some other type of formatting difference to distinguish hyperlinks from other text, such as [FontWeight](textelement_fontweight.md) or [FontStyle](textelement_fontstyle.md).

## -examples
Here's an example of a simple [Hyperlink](hyperlink.md) element in a [TextBlock](../windows.ui.xaml.controls/textblock.md).

In XAML, the creation of content elements is implicit, so you can add the link text directly to the [Hyperlink](hyperlink.md), and the [Hyperlink](hyperlink.md) directly to the [TextBlock](../windows.ui.xaml.controls/textblock.md) element.

In code, you have to explicitly create each [Run](run.md) element, set its [Text](run_text.md) property, and add it to the appropriate **Inlines** collection (either the [Hyperlink](hyperlink.md) or the [TextBlock](../windows.ui.xaml.controls/textblock.md)).

```xaml
<TextBlock><Hyperlink NavigateUri="http://www.bing.com">Go to Bing</Hyperlink></TextBlock>
```

```csharp
// Create a TextBlock. The hyperlink is the TextBlock content. 
TextBlock tb = new TextBlock();

// Create a Hyperlink and a Run. 
// The Run provides the visible content of the hyperlink. 
Hyperlink hyperlink = new Hyperlink();
Run run = new Run();

// Set the Text property on the Run. This will be the visible text of the hyperlink.
run.Text = "Go to Bing";
// Set the URI for the Hyperlink. 
hyperlink.NavigateUri = new Uri("http://www.bing.com");

// Add the Run to Hyperlink.Inlines collection.
hyperlink.Inlines.Add(run);
// Add the text elements to the TextBlock.Inlines collection.
tb.Inlines.Add(hyperlink);
// Add the TextBlock to a StackPanel (defined in the XAML page).        
stackPanel.Children.Add(tb);
```

This example shows a [Hyperlink](hyperlink.md) element in a [TextBlock](../windows.ui.xaml.controls/textblock.md) with other text.

In XAML, the creation of content elements is implicit, so you can add the link text directly to the [Hyperlink](hyperlink.md). The [Span](span.md) element with the `xml:space="preserve"` attribute is used to preserve white space around the hyperlink.

In code, you have to explicitly create each [Run](run.md) element, set its [Text](run_text.md) property, and add it to the appropriate **Inlines** collection (either the [Hyperlink](hyperlink.md) or the [TextBlock](../windows.ui.xaml.controls/textblock.md)).

```xaml
<TextBlock>
    <Span xml:space="preserve"><Run>Open </Run><Hyperlink NavigateUri="http://www.bing.com">Bing</Hyperlink><Run> in your browser.</Run></Span>
</TextBlock>
```

```csharp
// Create a TextBlock. The hyperlink is part of the TextBlock content. 
// Set TextWrapping so that the text and the hyperlink wrap if the content is too wide.
TextBlock tb = new TextBlock();
tb.TextWrapping = TextWrapping.Wrap;

// Create a Hyperlink and a Run. 
// The Run provides the visible content of the hyperlink. 
Hyperlink hyperlink = new Hyperlink();
Run run = new Run();
// Set the Text property on the Run. This will be the visible text of the hyperlink.
run.Text = "Bing";
// Set the URI for the Hyperlink. 
hyperlink.NavigateUri = new Uri("http://www.bing.com");
//Add the Run to Hyperlink.Inlines collection.
hyperlink.Inlines.Add(run);

// Create Run elements for the text around the hyperlink.
Run run1 = new Run();
Run run2 = new Run();            
//Set the Text property on the Run elements.
run1.Text = "Open ";
run2.Text = " in your browser.";

// Add the text elements to the TextBlock.Inlines collection.
tb.Inlines.Add(run1);
tb.Inlines.Add(hyperlink);
tb.Inlines.Add(run2);

// Add the TextBlock to a StackPanel (defined in the XAML page).        
stackPanel.Children.Add(tb);
```

Here's an example of a simple [Hyperlink](hyperlink.md) element in a [TextBlock](../windows.ui.xaml.controls/textblock.md).

In XAML, the creation of content elements is implicit, so you can add the link text directly to the [Hyperlink](hyperlink.md), and the [Hyperlink](hyperlink.md) directly to the [TextBlock](../windows.ui.xaml.controls/textblock.md) element. The [Span](span.md) element with the `xml:space="preserve"` attribute is used to preserve white space around the hyperlink.

In code, you have to explicitly create each text element (for example, [Run](run.md), [Paragraph](paragraph.md), or [Italic](italic.md)) and add it to the appropriate **Inlines** collection.

```xaml
<RichTextBlock>
    <Paragraph>
        <Span xml:space="preserve">
            <Run>This shows a hyperlink in a paragraph of text. You can click it to open </Run><Hyperlink NavigateUri="http://www.bing.com" UnderlineStyle="None" FontWeight="SemiBold"><Italic>Bing</Italic></Hyperlink><Run> in your browser.</Run>
        </Span>
    </Paragraph>
</RichTextBlock>
```

```csharp
// Create a RichTextBlock. The hyperlink is part of the content. 
// Set TextWrapping so that the text and the hyperlink wrap if the content is too wide.
RichTextBlock rtb = new RichTextBlock();
rtb.TextWrapping = TextWrapping.Wrap;

// Create a Hyperlink and a Run. 
// The Run provides the visible content of the hyperlink. 
Hyperlink hyperlink = new Hyperlink();
Run run = new Run();
// Set the Text property on the Run. This will be the visible text of the hyperlink.
run.Text = "Bing";
// Set the URI  and other properties for the Hyperlink. 
hyperlink.NavigateUri = new Uri("http://www.bing.com");
hyperlink.UnderlineStyle = UnderlineStyle.None;
hyperlink.FontWeight = Windows.UI.Text.FontWeights.SemiBold;
//Add the Run to Hyperlink.Inlines collection.
hyperlink.Inlines.Add(run);


// Create an Italic element for the hyperlink.            
Italic italic = new Italic();
italic.Inlines.Add(hyperlink);

// Create Run elements for the text around the hyperlinks.
// Set the Text property on the Run elements.
Run run1 = new Run();
Run run2 = new Run();
run1.Text = "This shows a hyperlink in a paragraph of text. You can click it to open ";
run2.Text = " in your browser.";

// Create a Paragraph to hold the RichTextBlock content.
Paragraph paragraph = new Paragraph();

// Add the text elements to the Paragraph.Inlines collection.
paragraph.Inlines.Add(run1);
paragraph.Inlines.Add(italic);
paragraph.Inlines.Add(run2);
//Add the paragraph to the RichTextBlock.
rtb.Blocks.Add(paragraph);
// Add the RichTextBlock to a StackPanel (defined in the XAML page).        
stackPanel.Children.Add(rtb);
```



## -see-also
[Span](span.md), [HyperlinkButton](../windows.ui.xaml.controls/hyperlinkbutton.md), [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md), [TextBlock](../windows.ui.xaml.controls/textblock.md)