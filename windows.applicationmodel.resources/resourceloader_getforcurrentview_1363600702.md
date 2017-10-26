---
-api-id: M:Windows.ApplicationModel.Resources.ResourceLoader.GetForCurrentView
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Resources.ResourceLoader GetForCurrentView()
-->

# Windows.ApplicationModel.Resources.ResourceLoader.GetForCurrentView

## -description
Gets a [ResourceLoader](resourceloader.md) object for the [Resources subtree](../windows.applicationmodel.resources.core/resourcemap_getsubtree.md) of the currently running app's main [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md). This [ResourceLoader](resourceloader.md) uses a default context associated with the current view.

## -returns
A resource loader for the [Resources subtree](../windows.applicationmodel.resources.core/resourcemap_getsubtree.md) of the currently running app's main [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md).

## -remarks
This method allows access relative to a resource file named "resources" (resources.resjson or resources.resw). The [ResourceLoader](resourceloader.md) that is returned uses a default context associated with the current view.

The resource management system for UWP apps supports the tailoring of resources for scale. Starting in Windows 8.1, different views owned by an app are able to display simultaneously on different display devices that may use different scales. In this way, scale is a per-view characteristic.

A [ResourceLoader](resourceloader.md) has an implicit context that is used when [ResourceLoader](resourceloader.md) methods are used to retrieve a resource. Since a [ResourceLoader](resourceloader.md) has an implicit context, and since the scale qualifier of contexts is dependent on an associated view, a [ResourceLoader](resourceloader.md) must be associated with a particular view.

### Errors

This method fails with an exception if it is called in a windowless thread, or if the main [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md) does not have a "resources" subtree.

## -examples

## -see-also
[GetForCurrentView(String)](resourceloader_getforcurrentview_147266590.md)