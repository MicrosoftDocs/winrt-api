---
-api-id: M:Windows.ApplicationModel.Resources.ResourceLoader.GetString(System.String)
-api-type: winrt method
---

<!-- Method syntax
public string GetString(System.String resource)
-->

# Windows.ApplicationModel.Resources.ResourceLoader.GetString

## -description

Returns the most appropriate string value of a resource, specified by resource identifier, for the default [ResourceContext](../windows.applicationmodel.resources.core/resourcecontext.md) of the view in which the [ResourceLoader](resourceloader.md) was obtained using [ResourceLoader.GetForCurrentView](resourceloader_getforcurrentview_1363600702.md).


<!--Writer todo: Link to how to create and identify resources.-->

Equivalent **WinUI 2 API for UWP**: [Microsoft.Windows.ApplicationModel.Resources.ResourceLoader.GetString](/windows/windows-app-sdk/api/winrt/microsoft.windows.applicationmodel.resources.resourceloader.getstring) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param resource
The resource identifier of the resource to be resolved.

> [!NOTE]
> The resource identifier is treated as a Uniform Resource Identifier (URI) fragment, subject to Uniform Resource Identifier (URI) semantics. For example, **getString** ("Caption%20") is treated as **getString** ("Caption "). Do not use "?" or "#" in resource identifiers, as they terminate the named resource path. For example, "Foo?3" is treated as "Foo".

## -returns
The most appropriate string value of the specified resource for the default [ResourceContext](../windows.applicationmodel.resources.core/resourcecontext.md).

## -remarks
<!--Writer todo: remarks: discuss when to use GetString vs. GetStringByReference.-->

## -examples
See the example in [ResourceLoader](resourceloader.md).

## -see-also
[ResourceContext](../windows.applicationmodel.resources.core/resourcecontext.md)
