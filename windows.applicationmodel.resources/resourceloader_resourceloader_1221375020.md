---
-api-id: M:Windows.ApplicationModel.Resources.ResourceLoader.#ctor
-api-type: winrt method
---

<!-- Method syntax
public ResourceLoader()
-->

# Windows.ApplicationModel.Resources.ResourceLoader.ResourceLoader

## -description

> [!NOTE]
> ResourceLoader() may be altered or unavailable for releases after Windows 8.1. Instead, use [GetForCurrentView()](resourceloader_getforcurrentview_1363600702.md).

Constructs a new [ResourceLoader](resourceloader.md) object for the "Resources" subtree of the currently running app's main [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md).

Equivalent **WinUI 2 API for UWP**: [ResourceLoader()](/windows/windows-app-sdk/api/winrt/microsoft.windows.applicationmodel.resources.resourceloader.-ctor#microsoft-windows-applicationmodel-resources-resourceloader-ctor) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

The empty constructor typically allows access relative to a resource file's named resources (resources.resjson or resources.resw).

This constructor fails with an exception if the main [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md) does not have a "Resources" subtree.

## -examples

## -see-also

[ResourceLoader class](resourceloader.md), [ResourceLoader(String)](resourceloader_resourceloader_290278668.md), [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md)
