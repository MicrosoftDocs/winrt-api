---
-api-id: M:Windows.ApplicationModel.Resources.Core.NamedResource.ResolveAll(Windows.ApplicationModel.Resources.Core.ResourceContext)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Resources.Core.ResourceCandidate> ResolveAll(Windows.ApplicationModel.Resources.Core.ResourceContext resourceContext)
-->

# Windows.ApplicationModel.Resources.Core.NamedResource.ResolveAll

## -description
Resolves this [NamedResource](namedresource.md) object against a supplied context and returns a list of all possible candidates in preference order.

## -parameters
### -param resourceContext
The context against which the [NamedResource](namedresource.md) should be resolved.

## -returns
A list of [ResourceCandidate](resourcecandidate.md) objects, in order of preference. The object in first position in the list is the most appropriate candidate for the corresponding context, and the object in last position is the least appropriate.

## -remarks
The resource management system for UWP apps supports the tailoring of resources for scale. Starting in Windows 8.1, different views owned by an app are able to display simultaneously on different display devices that may use different scales. In this way, scale is a per-view characteristic.

Since the ResolveAll method returns all candidates for a [NamedResource](namedresource.md) in relation to a runtime context, and since the scale qualifier of a [ResourceContext](resourcecontext.md) depends on the associated view, the ResolveAll should always be called passing a [ResourceContext](resourcecontext.md) object obtained from the view in which the resource will be used.

See the [ResourceContext.GetForCurrentView](resourcecontext_getforcurrentview_1363600702.md) method.

## -examples

## -see-also
[ResourceContext](resourcecontext.md), [ResourceContext.GetForCurrentView](resourcecontext_getforcurrentview_1363600702.md)
