---
-api-id: M:Windows.ApplicationModel.Resources.Core.ResourceContext.GetForViewIndependentUse
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Resources.Core.ResourceContext GetForViewIndependentUse()
-->

# Windows.ApplicationModel.Resources.Core.ResourceContext.GetForViewIndependentUse

## -description
Gets a default [ResourceContext](resourcecontext.md) not associated with any view.

## -returns
A default [ResourceContext](resourcecontext.md) not associated with any view.

## -remarks
By default, no scale qualifier value is set in the [ResourceContext](resourcecontext.md) returned by this method. Unless and until a scale qualifier value is set programmatically, the returned [ResourceContext](resourcecontext.md) does not support any operations that involve the scale qualifier, including reading the scale qualifier value or resolving resource candidates that are qualified for scale.

This method fails if it is called in a windowless thread.

## -examples

## -see-also
