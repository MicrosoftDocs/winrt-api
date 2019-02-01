---
-api-id: P:Windows.UI.Xaml.FrameworkElement.RequestedTheme
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.ElementTheme RequestedTheme { get;  set; }
-->

# Windows.UI.Xaml.FrameworkElement.RequestedTheme

## -description
Gets or sets the UI theme that is used by the [UIElement](uielement.md) (and its child elements) for resource determination. The UI theme you specify with [RequestedTheme](frameworkelement_requestedtheme.md) can override the app-level [RequestedTheme](application_requestedtheme.md).

## -xaml-syntax
```xaml
<uiElement RequestedTheme="elementThemeMemberName" .../>
```


## -property-value
A value of the enumeration, for example **Light**.

## -remarks
Changing the [RequestedTheme](frameworkelement_requestedtheme.md) value is effectively changing the resource lookup behavior for the element's default template. If you change the value to **Light** then the template uses the values from the [ResourceDictionary](resourcedictionary.md) that is keyed as "Light" in the [ThemeDictionaries](resourcedictionary_themedictionaries.md) collection. Setting the UI theme differently from the app's theme is often appropriate for floating controls such as menus and flyouts.

You can change the value of the [RequestedTheme](frameworkelement_requestedtheme.md) property for any given element at run-time. That's in contrast to the [Application.RequestedTheme](application_requestedtheme.md) property, which throws an exception if you try to set it while the app's running.

The [RequestedTheme](frameworkelement_requestedtheme.md) value you set on a [FrameworkElement](frameworkelement.md) will inherit to any elements that are nested within the element where [RequestedTheme](frameworkelement_requestedtheme.md) is set, but that inheritance can be overridden by explicitly setting [RequestedTheme](frameworkelement_requestedtheme.md) again. For example, in this XAML example, the parent [StackPanel](../windows.ui.xaml.controls/stackpanel.md) sets the theme to **Light**, and that value inherits to the first [TextBlock](../windows.ui.xaml.controls/textblock.md) child element, but not to the second [TextBlock](../windows.ui.xaml.controls/textblock.md) because it's setting the value to **Dark** instead.
```xaml
<StackPanel RequestedTheme="Light">
  <TextBlock>Text using light theme.</TextBlock>
  <TextBlock RequestedTheme="Dark">Text using dark theme.</TextBlock>
</StackPanel>
```



The [RequestedTheme](frameworkelement_requestedtheme.md) property is ignored if the user is running in high contrast mode. See [High-contrast themes](https://msdn.microsoft.com/library/fd7ca6f6-a8f1-47d8-aa6c-3f2ec3168c45) and [XAML high contrast style sample](https://go.microsoft.com/fwlink/p/?LinkID=254993).



> [!NOTE]
> On Windows, setting [RequestedTheme](frameworkelement_requestedtheme.md) to [ElementTheme.Default](elementtheme.md) will always result in "Dark" being the theme. On Windows Phone, using the [ElementTheme.Default](elementtheme.md) value will result in a query for the system theme, as set by the user.

## -examples

## -see-also
[Application.RequestedTheme](application_requestedtheme.md), [XAML requested theme sample](https://go.microsoft.com/fwlink/p/?LinkId=306608), [{ThemeResource} markup extension](https://msdn.microsoft.com/library/8a1c79d2-9566-44aa-b8e1-cc7adad1bcc5)
