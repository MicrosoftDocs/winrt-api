---
-api-id: M:Windows.ApplicationModel.Resources.ResourceLoader.GetForViewIndependentUse
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Resources.ResourceLoader GetForViewIndependentUse()
-->

# Windows.ApplicationModel.Resources.ResourceLoader.GetForViewIndependentUse

## -description
Gets a [ResourceLoader](resourceloader.md) object for the [Resources subtree](../windows.applicationmodel.resources.core/resourcemap_getsubtree.md) of the currently running app's main [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md). This [ResourceLoader](resourceloader.md) uses a default context that's not associated with any view.

## -returns
A resource loader for the [Resources subtree](../windows.applicationmodel.resources.core/resourcemap_getsubtree.md) of the currently running app's main [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md). This [ResourceLoader](resourceloader.md) uses a default context that's not associated with any view. You can't use this [ResourceLoader](resourceloader.md) to retrieve any resource that has resource candidates qualified for scale.

## -remarks

## -examples

## -see-also
[GetForViewIndependentUse(String)](resourceloader_getforviewindependentuse_1317372352.md)