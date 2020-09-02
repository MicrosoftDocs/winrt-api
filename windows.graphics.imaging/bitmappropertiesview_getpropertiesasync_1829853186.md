---
-api-id: M:Windows.Graphics.Imaging.BitmapPropertiesView.GetPropertiesAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Graphics.Imaging.BitmapPropertySet> GetPropertiesAsync(Windows.Foundation.Collections.IIterable<System.String> propertiesToRetrieve)
-->

# Windows.Graphics.Imaging.BitmapPropertiesView.GetPropertiesAsync

## -description
Asynchronously retrieves one or more bitmap properties.

## -parameters
### -param propertiesToRetrieve
A collection of strings representing the property keys or queries that are being requested. Valid strings include [Windows properties](/windows/desktop/wic/photo-metadata-policies) and [Windows Imaging Component metadata queries](/windows/desktop/wic/-wic-native-image-format-metadata-queries).

## -returns
Object that manages the asynchronous retrieval of the bitmap properties.

## -remarks
The asynchronous operation produces a collection representing the requested image property keys and their values. The values are stored as [BitmapTypedValue](bitmaptypedvalue.md), which contains both the actual data as well as the [PropertyType](/windows/desktop/api/windows.foundation/ne-windows-foundation-propertytype) of the data.

A particular image may only contain some (or none) of the requested properties. In this case the collection will only have key-value pairs for the properties which were found in the image. You need to check for the existence of the property before you attempt to get data from it: 

```javascript
bitmapPropertiesView.getPropertiesAsync(["System.Title"]).done(function (retrievedProperties) {
  if (retrievedProperties.hasKey("System.Title")) {
	  	var titleProperty = retrievedProperties.lookup("System.Title");
	  	var title = titleProperty.value;
	 }
});
```



### Querying for a metadata block

If you use the metadata query language to request a metadata block instead of a property, the returned value is a [BitmapPropertiesView](bitmappropertiesview.md) representing the metadata within that block. You can request any metadata contained within the block from the [BitmapPropertiesView](bitmappropertiesview.md):

```javascript
// this is equivalent to directly requesting "/app1/ifd/{ushort=274}" from bitmapPropertiesView
bitmapPropertiesView.getPropertiesAsync(["/app1/ifd"]).done(function (retrievedProperties) {
	  // var ifdBlock is a BitmapPropertiesView
	  var ifdBlock = retrievedProperties.lookup("/app1/ifd").value;
	  return ifdBlock.getPropertiesAsync(["/{ushort=274}");
}).then(function (retrievedProperties) {
	  var orientation = retrievedProperties.lookup("/{ushort=274}").value;
});
```



### Enumerating through all the metadata within a frame

You can request all of the contents of a metadata block, including sub-blocks and properties, by passing in an empty (zero length) collection of strings. This produces a collection containing every sub-block and property within the [BitmapPropertiesView](bitmappropertiesview.md) ’s scope. In this way, you are able to iteratively retrieve all of the metadata contained within an image frame.

```javascript
bitmapPropertiesView.getPropertiesAsync([]).done(function (retrievedProperties) {
	  var iterator = retrievedProps.first();
	  while (iterator.hasCurrent) {
		  // iterator.current gives a key-value pair of string, BitmapTypedValue
		  // nextMetadataBlock is a BitmapPropertiesView containing the sub-block
		  var nextMetadataBlock = iterator.current.value.value;
		  iterator.moveNext();
	}
});

```



If the image format does not support metadata, it will fail with HRESULT [WINCODEC_ERR_UNSUPPORTEDOPERATION](/windows/desktop/wic/-wic-codec-error-codes).

## -examples

## -see-also
[BitmapPropertySet](bitmappropertyset.md), [BitmapTypedValue](bitmaptypedvalue.md)