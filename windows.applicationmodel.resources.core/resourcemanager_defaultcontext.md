---
-api-id: P:Windows.ApplicationModel.Resources.Core.ResourceManager.DefaultContext
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Resources.Core.ResourceContext DefaultContext { get; }
-->

# Windows.ApplicationModel.Resources.Core.ResourceManager.DefaultContext

## -description

Gets the default [ResourceContext](resourcecontext.md) for the currently running application. Unless explicitly overridden, the default [ResourceContext](resourcecontext.md) is used to determine the most appropriate representation of any given named resource.

> [!NOTE]
> DefaultContext may be altered or unavailable for releases after Windows 8.1. Instead, use [ResourceContext.GetForCurrentView](resourcecontext_getforcurrentview_1363600702.md).

## -property-value
The resource context.

## -remarks

## -examples

## -see-also
[ResourceContext.GetForCurrentView](resourcecontext_getforcurrentview_1363600702.md)