---
-api-id: P:Windows.UI.Xaml.Documents.ContentLink.XYFocusRightNavigationStrategy
-api-type: winrt property
---

<!-- Property syntax.
public XYFocusNavigationStrategy XYFocusRightNavigationStrategy { get;  set; }
-->

# Windows.UI.Xaml.Documents.ContentLink.XYFocusRightNavigationStrategy

## -description

Gets or sets a value that specifies the strategy used to determine the target element of a right navigation.

## -property-value

A value of the enumeration. The default is **Auto**.

## -remarks

> [!IMPORTANT]
> This API supports content links. The Windows features that enable content links are not available in versions of Windows after Windows 10 version 1903. Content links for XAML text controls will not function in versions of Windows later than version 1903.

When this property is set to **Auto**, the strategy is inherited from the elements ancestors. If all ancestors have a value of **Auto**, the fallback strategy is **Projection**.

## -see-also

## -examples

