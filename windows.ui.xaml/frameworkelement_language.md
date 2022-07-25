---
-api-id: P:Windows.UI.Xaml.FrameworkElement.Language
-api-type: winrt property
---

<!-- Property syntax
public string Language { get;  set; }
-->

# Windows.UI.Xaml.FrameworkElement.Language

## -description
Gets or sets localization/globalization language information that applies to a [FrameworkElement](frameworkelement.md), and also to all child elements of the current [FrameworkElement](frameworkelement.md) in the object representation and in UI.



## -xaml-syntax
```xaml
<frameworkElement Language="languageString" />
```


## -xaml-values
<dl><dt>languageString</dt><dd>languageStringA string specifying language and culture that follows the BCP 47 standards. For example, U.S. English is "en-US".</dd>
</dl>
## -property-value
A string specifying language and culture that follows the Internet Engineering Task Force (IETF)  [BCP 47](https://tools.ietf.org/html/bcp47) standards. For example, U.S. English is "en-US".

## -remarks
The Language property is intended for setting a per-element language setting on selected elements in a larger UI. The main reason for doing this is to influence text-related properties and settings, such as what the default or fallback [FontFamily](../windows.ui.xaml.media/fontfamily.md) should be for text presentation.

The default value for this property is the top language from the app language list, which is derived from the user's ranked list of preferred languages. We recommend that you leave the default for this property, as it will provide the best end user experience in terms of font fallback. For example, if the app is displaying East Asian content and the user has specified an East Asian language in their user profile, the content will most reliability show up in the desired East Asian font.

The Language property is mainly relevant for these [FrameworkElement](frameworkelement.md) subclasses: 
+ [TextBlock](../windows.ui.xaml.controls/textblock.md)
+ [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md)
+ [RichTextBlockOverflow](../windows.ui.xaml.controls/richtextblockoverflow.md)
+ [TextBox](../windows.ui.xaml.controls/textbox.md)
+ [RichEditBox](../windows.ui.xaml.controls/richeditbox.md)
+ [PasswordBox](../windows.ui.xaml.controls/passwordbox.md)


The [TextElement](../windows.ui.xaml.documents/textelement.md) class also has a [Language](../windows.ui.xaml.documents/textelement_language.md) property, and it has similar purpose and behavior for [TextElement](../windows.ui.xaml.documents/textelement.md) subclasses such as [Run](../windows.ui.xaml.documents/run.md).

If it's not specifically set as an attribute, the default value for Language is determined by other, larger factors that influence the globalization and localization settings for your app. This includes the user's system settings. For more info, see [Globalizing your app](/previous-versions/windows/apps/hh965328(v=win.10)).

Setting Language on UI elements is only a small part of what you might do to prepare an app for localization and globalization. For example, you typically need to name or load resources such as strings and images and include these resources in your app package. You also need to apply [x:Uid directive](/windows/uwp/xaml-platform/x-uid-directive) values to any elements that should use resource qualifiers to obtain the language-specific resource. For more info, see [Globalizing your app](/previous-versions/windows/apps/hh965328(v=win.10)).

When you set Language in markup, you should consider using a RESW resources file to specify the BCP 47 string, rather than hard-coding a string in the markup. Specify an [x:Uid directive](/windows/uwp/xaml-platform/x-uid-directive) value on that element where you want to specify Language so that the resource system can target the element. Then provide a string resource of the BCP 47 string that matches the resources folder name the resource comes from. You'll probably already have a RESW file in your project that is providing the conventional localized UI strings. For more info, see [Quickstart: Translating UI resources](/previous-versions/windows/apps/hh965329(v=win.10)).

### FrameworkElement.Language and xml:lang

XAML is a language that is based on XML and follows basic XML rules. This includes supporting XML constructs such as the **lang** attribute from the XML language XML namespace. You can specify xml:lang on an object element for a [FrameworkElement](frameworkelement.md) subclass, and it is treated the same as if it were a Language value, because it uses the same BCP 47 handling of the string attribute value. You can also specify xml:lang on an object element that is not a [FrameworkElement](frameworkelement.md) subclass, although that typically won't result in any behavior change on that element.

Language deliberately uses a property inheritance structure so that a value for Language set on the root element will propagate that value to all child objects in the visual tree that are also a [FrameworkElement](frameworkelement.md). This parallels the xml:lang behavior in XML and the XML DOM. Also, you can use Language at run time to read an xml:lang value that was set in the markup, so long as the element you're reading from is a [FrameworkElement](frameworkelement.md) subclass that has a Language property.

However, you can't specify both the Language and xml:lang attributes on the same object element, that will throw a XAML parse error.

### Migration notes

This API takes a string. In the equivalent Microsoft Silverlight and Windows Presentation Foundation (WPF)  API, the type of this property is a helper object that wraps the same string. You can import XAML from other projects without noticing this difference, because how XAML parses the string is identical.

## -examples

## -see-also
[Globalizing your app](/previous-versions/windows/apps/hh965328(v=win.10)), [FlowDirection](frameworkelement_flowdirection.md), [IANA list of languages](https://www.iana.org/assignments/language-subtag-registry), [x:Uid directive](/windows/uwp/xaml-platform/x-uid-directive)
