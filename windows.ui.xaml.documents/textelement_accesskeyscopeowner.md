---
-api-id: P:Windows.UI.Xaml.Documents.TextElement.AccessKeyScopeOwner
-api-type: winrt property
---

<!-- Property syntax.
public DependencyObject AccessKeyScopeOwner { get;  set; }
-->

# Windows.UI.Xaml.Documents.TextElement.AccessKeyScopeOwner

## -description
Gets or sets a source element that provides the access key scope for this element, even if it's not in the visual tree of the source element.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Documents.TextElement.AccessKeyScopeOwner](/windows/winui/api/microsoft.ui.xaml.documents.textelement.accesskeyscopeowner) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
The element that defines the access key scope.

## -remarks
The source element must have its **IsAccessKeyScope** property set to **true**.

## -see-also
[UIElement.AccessKeyScopeOwner](./../windows.ui.xaml/uielement_accesskeyscopeowner.md)

## -examples

