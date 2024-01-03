---
-api-id: P:Windows.UI.Xaml.Controls.Primitives.Popup.ShouldConstrainToRootBounds
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public bool ShouldConstrainToRootBounds { get;  set; }
-->

# Windows.UI.Xaml.Controls.Primitives.Popup.ShouldConstrainToRootBounds

## -description

Gets or sets a value that indicates whether the popup should be shown within the bounds of the XAML root.

## -property-value

**true** if the popup should be shown within the bounds of the XAML root; otherwise, **false**. The default is **true**.

## -remarks

This property is applicable only to apps running on the desktop. To check if the popup is actually constrained to the root bounds, check the [IsConstrainedToRootBounds](popup_isconstrainedtorootbounds.md) property.

In an app running on the desktop, when this property is **true**, the popup is shown within the main XAML window handle (HWND). When this property is **false**, the popup is shown in its own top level HWND. In this case, the popup might be positioned to extend beyond the main app window.

When a popup with `ShouldConstrainToRootBounds = false` is first shown, it’s placed in its own window and shown in that context. After it has been shown, `ShouldConstrainToRootBounds` cannot be set back to **true**.

The _XAML root_ might be a [CoreWindow](../windows.ui.core/corewindow.md), a [XAML island](/windows/uwp/xaml-platform/xaml-host-controls), or an [AppWindow](../windows.ui.windowmanagement/appwindow.md).

## -see-also

[IsConstrainedToRootBounds](popup_isconstrainedtorootbounds.md), [FlyoutBase ShouldConstrainToRootBounds](flyoutbase_shouldconstraintorootbounds.md)

## -examples

