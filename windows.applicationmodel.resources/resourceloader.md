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
A **ResourceLoader** object encapsulates a particular [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md) and a [ResourceContext](../windows.applicationmodel.resources.core/resourcecontext.md), combined in a simple API.

A specific resource map can be specified when the **ResourceLoader** is obtained; if no resource map is specified, the **ResourceLoader** will provide access to the "Resources" subtree of the app's main resource map.

In general, resources can be sensitive to scale or other display characteristics. For that reason, resource contexts are generally associated with a specific view. Since a **ResourceLoader** encapsulates a resource context, this also applies to a **ResourceLoader**. A **ResourceLoader** obtained using [GetForCurrentView](resourceloader_getforcurrentview_1363600702.md) has a resource context associated with a view in which it was obtained. A view-independent **ResourceLoader** can also be obtained using [GetForViewIndependentUse.](resourceloader_getforviewindependentuse_1317372352.md)

+ Obtain the scale factor for the current view by using the [DisplayInformation](../windows.graphics.display/displayinformation.md) class instead of the deprecated [DisplayProperties](../windows.graphics.display/displayproperties.md) class.
+ Apps that set explicit width and height of elements should still work fine, other than possibly displaying blurry images.
+ Obtain resources that are not associated with any view by getting a **ResourceLoader** via [GetForViewIndependentUse](resourceloader_getforviewindependentuse_1317372352.md).

Also see [Screen sizes and breakpoints](/windows/uwp/design/layout/screen-sizes-and-breakpoints-for-responsive-design).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | GetForUIContext |

## -examples
Use the [ResourceLoader.GetString](resourceloader_getstring_1647290392.md) method to get the string resource identified by "Farewell".

```csharp
var resourceLoader = Windows.ApplicationModel.Resources.ResourceLoader.GetForCurrentView();
var text = resourceLoader.GetString("Farewell");
```

```cppwinrt
auto resourceLoader{ Windows::ApplicationModel::Resources::ResourceLoader::GetForCurrentView() };
winrt::hstring text{ resourceLoader.GetString(L"Farewell") };
```

```cppcx
auto resourceLoader = Windows::ApplicationModel::Resources::ResourceLoader::GetForCurrentView();
String^ text = resourceLoader->GetString("Farewell");
```

```javascript
var resourceLoader = Windows.ApplicationModel.Resources.ResourceLoader.getForCurrentView();
var text = resourceLoader.getString('Farewell');
```

## -see-also

[GetForCurrentView](resourceloader_getforcurrentview_1363600702.md), [GetForCurrentView(String)](resourceloader_getforcurrentview_147266590.md), [GetForViewIndependentUse](resourceloader_getforviewindependentuse_386169056.md), [GetForViewIndependentUse(String)](resourceloader_getforviewindependentuse_1317372352.md), [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md), [ResourceContext](../windows.applicationmodel.resources.core/resourcecontext.md), [Creating and retrieving resources in ](http://msdn.microsoft.com/en-us/library/windows/apps/hh694557.aspx), [Guidelines for window sizes and scaling to screens](https://msdn.microsoft.com/library/19732e24-add8-479e-809a-274f7c47ef68), [UX guidelines for layout and scaling](https://developer.microsoft.com/windows/apps/design), [Application resources and localization sample](https://go.microsoft.com/fwlink/p/?linkid=227301), [Application resources and localization sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620487)
