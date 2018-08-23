---
-api-id: M:Windows.ApplicationModel.Resources.Core.ResourceMap.GetValue(System.String,Windows.ApplicationModel.Resources.Core.ResourceContext)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Resources.Core.ResourceCandidate GetValue(System.String resource, Windows.ApplicationModel.Resources.Core.ResourceContext context)
-->

# Windows.ApplicationModel.Resources.Core.ResourceMap.GetValue

## -description
Returns the most appropriate candidate for a resource that is specified by a resource identifier for the supplied context.


<!--Writer todo: link to doc on how to form a resource identifier.-->

## -parameters
### -param resource
A resource specified as a name or reference. For details, see the remarks for [ResourceMap](resourcemap.md) class.

### -param context
The context for which to select the most appropriate candidate.

## -returns
A [ResourceCandidate](resourcecandidate.md) that describes the most appropriate candidate.

## -remarks
Some resources are loaded according to the scale of the view where they will be displayed, and different views within an app might be displayed on different devices with different scales. Scale is a per-view characteristic.

Since the [GetValue](resourcemap_getvalue_1450213417.md) method selects the best candidate for the specified resource in relation to a runtime context, and since the scale qualifier of a [ResourceContext](resourcecontext.md) depends on the associated view, [GetValue](resourcemap_getvalue_1450213417.md) should always be called with a [ResourceContext](resourcecontext.md) object obtained from the view in which the resource will be used. Call [ResourceContext.GetForCurrentView](resourcecontext_getforcurrentview_1363600702.md) to retrieve the appropriate [ResourceContext](resourcecontext.md).

## -examples

## -see-also
[ResourceContext](resourcecontext.md), [ResourceContext.GetForCurrentView](resourcecontext_getforcurrentview_1363600702.md)