---
-api-id: M:Windows.ApplicationModel.Resources.Core.ResourceContext.GetForUIContext(Windows.UI.UIContext)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public ResourceContext ResourceContext.GetForUIContext(UIContext context)
-->

# Windows.ApplicationModel.Resources.Core.ResourceContext.GetForUIContext

## -description
Gets a default [ResourceContext](resourcecontext.md) associated with the specified [UIContext](../windows.ui/uicontext.md) for the currently running application.

## -parameters
### -param context
The UI context for which to get the [ResourceContext](resourcecontext.md).

## -returns
The default [ResourceContext](resourcecontext.md) associated with the specified UI context.

## -remarks
This method fails if it is called in a windowless thread.

## -see-also

## -examples

