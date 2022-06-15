---
-api-id: P:Windows.UI.Xaml.UIElement.AccessKeyScopeOwner
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyObject AccessKeyScopeOwner { get;  set; }
-->

# Windows.UI.Xaml.UIElement.AccessKeyScopeOwner

## -description
Gets or sets a source element that provides the access key scope for this element, even if it's not in the visual tree of the source element.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.UIElement.AccessKeyScopeOwner](/windows/winui/api/microsoft.ui.xaml.uielement.accesskeyscopeowner) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
The element that defines the access key scope.

## -remarks
The source element must have its [IsAccessKeyScope](uielement_isaccesskeyscope.md) property set to **true**.

## -examples

## -see-also
[Access keys](/windows/uwp/design/input/access-keys)
