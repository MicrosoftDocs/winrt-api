---
-api-id: M:Windows.ApplicationModel.Resources.ResourceLoader.GetStringForReference(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public string GetStringForReference(Windows.Foundation.Uri uri)
-->

# Windows.ApplicationModel.Resources.ResourceLoader.GetStringForReference

## -description
> [!NOTE]
> GetStringForReference may be altered or unavailable for releases after Windows 8.1. Instead, use [GetStringForUri](resourceloader_getstringforuri.md).

Returns the most appropriate string value of a resource, specified as a [Uri](../windows.foundation/uri.md) for a resource identifier, for the default [ResourceContext](../windows.applicationmodel.resources.core/resourcecontext.md) of the currently running app.

## -parameters
### -param uri
A [Uri](../windows.foundation/uri.md) that represents the resource to be retrieved.

## -returns
The most appropriate string value of the specified resource for the default [ResourceContext](../windows.applicationmodel.resources.core/resourcecontext.md).

## -remarks
[Uri](../windows.foundation/uri.md) objects require a scheme to be identified. In this context, the ms-resource scheme must be specified in the [Uri](../windows.foundation/uri.md) passed to the method. See [How to load string resources](http://msdn.microsoft.com/library/849f5bbf-6d85-4760-8832-75d3eff9bd96).

## -examples

## -see-also
[ResourceContext](../windows.applicationmodel.resources.core/resourcecontext.md), [How to load string resources](http://msdn.microsoft.com/library/849f5bbf-6d85-4760-8832-75d3eff9bd96)