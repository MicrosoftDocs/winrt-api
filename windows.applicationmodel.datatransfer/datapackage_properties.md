---
-api-id: P:Windows.ApplicationModel.DataTransfer.DataPackage.Properties
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.DataTransfer.DataPackagePropertySet Properties { get; }
-->

# Windows.ApplicationModel.DataTransfer.DataPackage.Properties

## -description
Allows you to get and set properties like the title of the content being shared.

## -property-value
A collection of properties that describe the data contained in a [DataPackage.](datapackage.md)

## -remarks
In addition to the content being shared, each instance of a [DataPackage](datapackage.md) object supports a set of properties. Target apps can use these properties to learn more about the content of the [DataPackage](datapackage.md). Examples of common properties include [thumbnail](datapackagepropertyset_thumbnail.md) images, [title](datapackagepropertyset_title.md), and [file types](datapackagepropertyset_filetypes.md).

This property contains an instance of the [DataPackagePropertySet](datapackagepropertyset.md) class. This class supports several properties by default. This class also supports custom properties through its [Insert](datapackagepropertyset_insert.md) and [Lookup](datapackagepropertyset_lookup.md) methods.

## -examples

## -see-also
