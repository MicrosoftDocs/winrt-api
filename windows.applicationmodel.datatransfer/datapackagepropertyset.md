---
-api-id: T:Windows.ApplicationModel.DataTransfer.DataPackagePropertySet
-api-type: winrt class
---

<!-- Class syntax.
public class DataPackagePropertySet : Windows.ApplicationModel.DataTransfer.IDataPackagePropertySet, Windows.ApplicationModel.DataTransfer.IDataPackagePropertySet2, Windows.ApplicationModel.DataTransfer.IDataPackagePropertySet3, Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, System.Object>>, Windows.Foundation.Collections.IMap<System.String, System.Object>
-->

# Windows.ApplicationModel.DataTransfer.DataPackagePropertySet

## -description
Defines a set of properties to use with a [DataPackage](datapackage.md) object.

## -remarks
In addition to the content being shared, each instance of a [DataPackage](datapackage.md) object supports a set of properties. Target apps can use these properties to learn more about the content of the [DataPackage](datapackage.md).

This class directly supports several default properties, such as a [thumbnail](datapackagepropertyset_thumbnail.md), a [title](datapackagepropertyset_title.md), and a [description](datapackagepropertyset_description.md). You can also create your own custom properties by using the [Insert](datapackagepropertyset_insert_2123640444.md) method or one of the **Add** methods. Target apps can access specific properties through the [Lookup](datapackagepropertyset_lookup_711408188.md) method.

### Collection member lists

For JavaScript, DataPackagePropertySet supports using an index to access items.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | ContentSourceUserActivityJson |

## -examples

## -see-also
