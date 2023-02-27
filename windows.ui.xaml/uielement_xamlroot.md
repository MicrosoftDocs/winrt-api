---
-api-id: P:Windows.UI.Xaml.UIElement.XamlRoot
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public XamlRoot XamlRoot { get;  set; }
-->

# Windows.UI.Xaml.UIElement.XamlRoot

## -description

Gets or sets the `XamlRoot` in which this element is being viewed.

## -property-value

The `XamlRoot` in which this element is being viewed. The default is `null`.

## -remarks

When a `UIElement` is first created, `XamlRoot` returns `null`. After it's parented to a live XAML object, it will return the same `XamlRoot` object as its parent. A common scenario for `XamlRoot` to be `null` is if you access the property from the constructor of your app.

## -see-also

## -examples

