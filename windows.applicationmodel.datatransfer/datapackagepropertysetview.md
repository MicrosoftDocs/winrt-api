---
-api-id: T:Windows.ApplicationModel.DataTransfer.DataPackagePropertySetView
-api-type: winrt class
---

<!-- Class syntax.
public class DataPackagePropertySetView : Windows.ApplicationModel.DataTransfer.IDataPackagePropertySetView, Windows.ApplicationModel.DataTransfer.IDataPackagePropertySetView2, Windows.ApplicationModel.DataTransfer.IDataPackagePropertySetView3, Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, System.Object>>, Windows.Foundation.Collections.IMapView<System.String, System.Object>
-->

# Windows.ApplicationModel.DataTransfer.DataPackagePropertySetView

## -description
Gets the set of properties of a [DataPackageView](datapackageview.md) object.

## -remarks
In addition to the content being shared, each instance of a [DataPackageView](datapackageview.md) object supports a set of properties. Target apps can use these properties to learn more about the content of the [DataPackageView](datapackageview.md).

This class directly supports several default properties, such as a [thumbnail](datapackagepropertysetview_thumbnail.md), a [title](datapackagepropertysetview_title.md), and a [description](datapackagepropertysetview_description.md). Target apps can access specific properties through the [Lookup](datapackagepropertysetview_lookup_711408188.md) method.

> When a share target receives shared content, it also receives certain properties associated with the source app as a part of the [DataPackageView](datapackageview.md). In Windows Runtime app, several of these properties, such as [ApplicationListingUri](datapackagepropertysetview_applicationlistinguri.md), [ApplicationName](datapackagepropertysetview_applicationname.md), and [PackageFamilyName](datapackagepropertysetview_packagefamilyname.md), will be set by the operating system. In Windows Phone Silverlight apps, however, these properties will not be automatically filled and must be set manually.

### Collection member lists

For JavaScript, DataPackagePropertySetView supports using an index to access items.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | ContentSourceUserActivityJson |
| 1809 | 17763 | IsFromRoamingClipboard |

## -examples


```javascript
if (shareOperation.data.contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.text)) {
    var title = shareOperation.data.properties.title;
    var description = shareOperation.data.properties.description;
}

```



## -see-also
