---
-api-id: M:Windows.ApplicationModel.Resources.ResourceLoader.GetForCurrentView(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Resources.ResourceLoader GetForCurrentView(System.String name)
-->

# Windows.ApplicationModel.Resources.ResourceLoader.GetForCurrentView

## -description
Gets a [ResourceLoader](resourceloader.md) object for the specified [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md). This [ResourceLoader](resourceloader.md) uses a default context associated with the current view.

## -parameters
### -param name
The resource identifier of the [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md) that the new resource loader uses for unqualified resource references. The loader can then retrieve resources relative to those references.

> [!NOTE]
> The resource identifier is treated as a Uniform Resource Identifier (URI) fragment, subject to Uniform Resource Identifier (URI) semantics. For example, "Caption%20" is treated as "Caption ". Do not use "?" or "#" in resource identifiers, as they terminate the named resource path. For example, "Foo?3" is treated as "Foo".

## -returns
A resource loader for the specified [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md).

## -remarks
This method is typically used to access resources relative to a resource file with the specified resource identifier. For example, `GetForCurrentView('Errors');` is relative to errors.resjson or errors.resw.

To construct a resource loader for resources from a library package, a resource reference Uniform Resource Identifier (URI) is used.

The [ResourceLoader](resourceloader.md) that is returned uses a default context associated with the current view.

The resource management system for UWP apps supports the tailoring of resources for scale. Starting in Windows 8.1, different views owned by an app are able to display simultaneously on different display devices that may use different scales. In this way, scale is a per-view characteristic.

A [ResourceLoader](resourceloader.md) has an implicit context that is used when [ResourceLoader](resourceloader.md) methods are used to retrieve a resource. Since a [ResourceLoader](resourceloader.md) has an implicit context, and since the scale qualifier of contexts is dependent on an associated view, a [ResourceLoader](resourceloader.md) must be associated with a particular view.

### Errors

This method fails with an exception if it is called in a windowless thread, or if the specified [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md) cannot be found.

## -examples

## -see-also
[GetForCurrentView](resourceloader_getforcurrentview_1363600702.md)