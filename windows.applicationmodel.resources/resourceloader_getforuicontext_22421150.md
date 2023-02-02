---
-api-id: M:Windows.ApplicationModel.Resources.ResourceLoader.GetForUIContext(Windows.UI.UIContext)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public ResourceLoader ResourceLoader.GetForUIContext(UIContext context)
-->

# Windows.ApplicationModel.Resources.ResourceLoader.GetForUIContext

## -description

Gets a [ResourceLoader](resourceloader.md) object for the specified [UIContext](../windows.ui/uicontext.md).

## -parameters

### -param context

The UI context for which to get the [ResourceLoader](resourceloader.md).

## -returns

A resource loader for the specified [UIContext](../windows.ui/uicontext.md).

## -remarks

This method fails if it is called in a windowless thread.

## -see-also

[AppWindow.UIContext](../windows.ui.windowmanagement/appwindow_uicontext.md), [UIElement.UIContext](../windows.ui.xaml/uielement_uicontext.md)

## -examples
