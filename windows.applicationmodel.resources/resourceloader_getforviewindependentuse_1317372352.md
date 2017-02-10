---
-api-id: M:Windows.ApplicationModel.Resources.ResourceLoader.GetForViewIndependentUse(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Resources.ResourceLoader GetForViewIndependentUse(System.String name)
-->

# Windows.ApplicationModel.Resources.ResourceLoader.GetForViewIndependentUse

## -description
Gets a [ResourceLoader](resourceloader.md) object for the specified [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md). This [ResourceLoader](resourceloader.md) uses a default context that's not associated with any view.

## -parameters
### -param name
The resource identifier of the [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md) that the new resource loader uses for unqualified resource references. The loader can then retrieve resources relative to those references.

> [!NOTE]
> The resource identifier is treated as a Uniform Resource Identifier (URI) fragment, subject to Uniform Resource Identifier (URI) semantics. For example, "Caption%20" is treated as "Caption ". Do not use "?" or "#" in resource identifiers, as they terminate the named resource path. For example, "Foo?3" is treated as "Foo".

## -returns
A resource loader for the [Resources subtree](../windows.applicationmodel.resources.core/resourcemap_getsubtree.md) of the currently running app's main [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md). This [ResourceLoader](resourceloader.md) uses a default context that's not associated with any view. You can't use this [ResourceLoader](resourceloader.md) to retrieve any resource that has resource candidates qualified for scale.

## -remarks

## -examples

## -see-also
[GetForViewIndependentUse](resourceloader_getforviewindependentuse_386169056.md)