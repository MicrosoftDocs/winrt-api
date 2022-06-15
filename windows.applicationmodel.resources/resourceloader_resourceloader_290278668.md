---
-api-id: M:Windows.ApplicationModel.Resources.ResourceLoader.#ctor(System.String)
-api-type: winrt method
---

<!-- Method syntax
public ResourceLoader(System.String name)
-->

# Windows.ApplicationModel.Resources.ResourceLoader.ResourceLoader

## -description
> [!NOTE]
> ResourceLoader(String) may be altered or unavailable for releases after Windows 8.1. Instead, use [GetForCurrentView(String)](resourceloader_getforcurrentview_147266590.md).

Constructs a new [ResourceLoader](resourceloader.md) object for the specified [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md).

Equivalent **WinUI 2 API for UWP**: [ResourceLoader(String)](/windows/windows-app-sdk/api/winrt/microsoft.windows.applicationmodel.resources.resourceloader.-ctor#microsoft-windows-applicationmodel-resources-resourceloader-ctor(system-string)) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).


## -parameters
### -param name
The resource identifier of the [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md) that the new resource loader uses for unqualified resource references. It can then retrieve resources relative to those references.

> [!NOTE]
> The resource identifier is treated as a Uniform Resource Identifier (URI) fragment, subject to Uniform Resource Identifier (URI) semantics. For example, "Caption%20" is treated as "Caption ". Do not use "?" or "#" in resource identifiers, as they terminate the named resource path. For example, "Foo?3" is treated as "Foo".

## -remarks
This constructor is typically used to access resources relative to a resource file with the specified resource identifier. For example, `new ResourceLoader('Errors');` is relative to errors.resjson or errors.resw.

## -examples

## -see-also
[ResourceLoader class](resourceloader.md), [ResourceLoader()](resourceloader_resourceloader_1221375020.md), [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md)
