---
-api-id: M:Windows.ApplicationModel.Resources.Core.NamedResource.Resolve(Windows.ApplicationModel.Resources.Core.ResourceContext)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Resources.Core.ResourceCandidate Resolve(Windows.ApplicationModel.Resources.Core.ResourceContext resourceContext)
-->

# Windows.ApplicationModel.Resources.Core.NamedResource.Resolve

## -description
Resolves this [NamedResource](namedresource.md) object against a supplied context and returns the most appropriate candidate.

## -parameters
### -param resourceContext
The context against which the [NamedResource](namedresource.md) should be resolved.

## -returns
The most appropriate candidate for the specified context.

## -remarks
The resource management system for UWP apps supports the tailoring of resources for scale. Starting in Windows 8.1, different views owned by an app are able to display simultaneously on different display devices that may use different scales. In this way, scale is a per-view characteristic.

Since the [Resolve](namedresource_resolve_302177783.md) method selects the best candidate for a [NamedResource](namedresource.md) in relation to a runtime context, and since the scale qualifier of a [ResourceContext](resourcecontext.md) depends on the associated view, the [Resolve](namedresource_resolve_302177783.md) should always be called passing a [ResourceContext](resourcecontext.md) object obtained from the view in which the resource will be used.

See the [ResourceContext.GetForCurrentView](resourcecontext_getforcurrentview.md) method.

## -examples

## -see-also
[ResourceContext](resourcecontext.md), [ResourceContext.GetForCurrentView](resourcecontext_getforcurrentview.md)