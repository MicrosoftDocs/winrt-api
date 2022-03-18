---
-api-id: M:Windows.ApplicationModel.Resources.Core.ResourceContext.#ctor
-api-type: winrt method
---

<!-- Method syntax
public ResourceContext()
-->

# Windows.ApplicationModel.Resources.Core.ResourceContext.ResourceContext

## -description

Creates a cloned [ResourceContext](resourcecontext.md) object.

> [!NOTE]
> ResourceContext constructor may be altered or unavailable for releases after Windows 8.1. Instead, use [GetForCurrentView](resourcecontext_getforcurrentview_1363600702.md) and [Clone](resourcecontext_clone_766852569.md).

## -remarks
In general, resources can be sensitive to scale. For that reason, a [ResourceContext](resourcecontext.md) is generally associated with a specific view, and should be obtained using [GetForCurrentView](resourcecontext_getforcurrentview_1363600702.md). (A view-independent [ResourceContext](resourcecontext.md) can also be obtained using [GetForViewIndependentUse](resourcecontext_getforviewindependentuse_386169056.md).) If a [ResourceContext](resourcecontext.md) is obtained using this constructor, it will be have scale associated with an arbitrary view. Do not make any assumptions in your app regarding this behavior.

## -examples

## -see-also
