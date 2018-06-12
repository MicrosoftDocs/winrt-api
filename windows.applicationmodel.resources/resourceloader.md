---
-api-id: T:Windows.ApplicationModel.Resources.ResourceLoader
-api-type: winrt class
---

<!-- Class syntax.
public class ResourceLoader : Windows.ApplicationModel.Resources.IResourceLoader, Windows.ApplicationModel.Resources.IResourceLoader2
-->

# Windows.ApplicationModel.Resources.ResourceLoader

## -description
Provides simplified access to app resources such as app UI strings.

## -remarks
A [ResourceLoader](resourceloader.md) object encapsulates a particular [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md) and a [ResourceContext](../windows.applicationmodel.resources.core/resourcecontext.md), combined in a simple API.

A specific resource map can be specified when the [ResourceLoader](resourceloader.md) is obtained; if no resource map is specified, the [ResourceLoader](resourceloader.md) will provide access to the "Resources" subtree of the app's main resource map.

In general, resources can be sensitive to scale or other display characteristics. For that reason, resource contexts are generally associated with a specific view. Since a [ResourceLoader](resourceloader.md) encapsulates a resource context, this also applies to a [ResourceLoader](resourceloader.md). A [ResourceLoader](resourceloader.md) obtained using [GetForCurrentView](resourceloader_getforcurrentview.md) has a resource context associated with a view in which it was obtained. A view-independent [ResourceLoader](resourceloader.md) can also be obtained using [GetForViewIndependentUse.](resourceloader_getforviewindependentuse.md)

+  **In :**  UWP apps could show their UI on only a single monitor at a time. Frameworks and apps therefore used only a single scale factor at a time, which would change if the app was displayed on a different monitor.
+ **Beginning in :** Multiple monitors can display multiple UWP apps at a time, and one app can appear on multiple monitors simultaneously. Frameworks and apps therefore have to deal with multiple scale factors at a time. For Windows 8.1 apps:
+ Obtain the scale factor for the current view by using the [DisplayInformation](../windows.graphics.display/displayinformation.md) class instead of the deprecated [DisplayProperties](../windows.graphics.display/displayproperties.md) class.
+ Apps that set explicit width and height of elements should still work fine, other than possibly displaying blurry images.
+ Obtain resources that are not associated with any view by getting a [ResourceLoader](resourceloader.md) via [GetForViewIndependentUse](resourceloader_getforviewindependentuse.md).

See [Guidelines for window sizes and scaling to screens](http://msdn.microsoft.com/library/19732e24-add8-479e-809a-274f7c47ef68) and [UX guidelines for layout and scaling](http://msdn.microsoft.com/library/c388f639-6f35-4d52-bffe-53ff3f537d4b).

## -examples
Use the [ResourceLoader.GetString | getString](resourceloader_getstring.md) method to get the string resource identified by "Farewell".

```csharp
var resourceLoader = Windows.ApplicationModel.Resources.ResourceLoader.GetForCurrentView();
var text = resourceLoader.GetString("Farewell");
```

```cppwinrt
auto resourceLoader{ Windows::ApplicationModel::Resources::ResourceLoader::GetForCurrentView() };
winrt::hstring text{ resourceLoader.GetString(L"Farewell") };
```

```cpp
auto resourceLoader = Windows::ApplicationModel::Resources::ResourceLoader::GetForCurrentView();
String^ text = resourceLoader->GetString("Farewell");
```

```javascript
var resourceLoader = Windows.ApplicationModel.Resources.ResourceLoader.getForCurrentView();
var text = resourceLoader.getString('Farewell');
```

## -see-also

[GetForCurrentView](resourceloader_getforcurrentview_1363600702.md), [GetForCurrentView(String)](resourceloader_getforcurrentview_147266590.md), [GetForViewIndependentUse](resourceloader_getforviewindependentuse_386169056.md), [GetForViewIndependentUse(String)](resourceloader_getforviewindependentuse_1317372352.md), [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md), [ResourceContext](../windows.applicationmodel.resources.core/resourcecontext.md), [Creating and retrieving resources in ](http://go.microsoft.com/fwlink/p/?linkid=251463), [Guidelines for window sizes and scaling to screens](http://msdn.microsoft.com/library/19732e24-add8-479e-809a-274f7c47ef68), [UX guidelines for layout and scaling](http://msdn.microsoft.com/library/c388f639-6f35-4d52-bffe-53ff3f537d4b), [Application resources and localization sample](http://go.microsoft.com/fwlink/p/?linkid=227301), [Application resources and localization sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620487)
