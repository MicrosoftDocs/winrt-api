---
-api-id: M:Windows.UI.Xaml.Markup.XamlMarkupHelper.UnloadObject(Windows.UI.Xaml.DependencyObject)
-api-type: winrt method
---

<!-- Method syntax.
public void XamlMarkupHelper.UnloadObject(DependencyObject element)
-->

# Windows.UI.Xaml.Markup.XamlMarkupHelper.UnloadObject

## -description

Unloads an element from the XAML visual tree that was loaded by [x:Load](/windows/uwp/xaml-platform/x-load-attribute).

## -parameters

### -param element

The element to unload.

## -remarks

This method supports functionality provided by the [x:Load attribute](/windows/uwp/xaml-platform/x-load-attribute). Calling this method with an element that is not marked with the `x:Load` attribute will cause an error.

For more information and examples, see [Unloading elements](/windows/uwp/xaml-platform/x-load-attribute#unloading-elements) in the [x:Load attribute](/windows/uwp/xaml-platform/x-load-attribute) page.

## -see-also

[x:Load attribute](/windows/uwp/xaml-platform/x-load-attribute)

## -examples
