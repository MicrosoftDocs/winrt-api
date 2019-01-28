---
-api-id: P:Windows.UI.Xaml.Controls.IScrollAnchorProvider.CurrentAnchor
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public UIElement CurrentAnchor { get; }
-->

# Windows.UI.Xaml.Controls.IScrollAnchorProvider.CurrentAnchor

## -description

The currently chosen anchor element to use for scroll anchoring.

## -property-value

The most recently chosen [UIElement](../windows.ui.xaml/uielement.md) for scroll anchoring after a layout pass, or **null**.

## -remarks

If there are no anchor candidates registered with the [IScrollAnchorProvider](iscrollanchorprovider.md) or none have been chosen, then [CurrentAnchor](iscrollanchorprovider_currentanchor.md) is **null**.

## -see-also

[IScrollAnchorProvider](iscrollanchorprovider.md)

## -examples

