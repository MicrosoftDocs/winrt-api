---
-api-id: M:Windows.ApplicationModel.DataTransfer.DataPackagePropertySet.Insert(System.String,System.Object)
-api-type: winrt method
---

<!-- Method syntax
public bool Insert(System.String key, System.Object value)
-->

# Windows.ApplicationModel.DataTransfer.DataPackagePropertySet.Insert

## -description
Adds a property to the [DataPackagePropertySet](datapackagepropertyset.md) object.

## -parameters
### -param key
The key to insert.

### -param value
The value to insert.

## -returns
True if the method replaced a value that already existed for the key; false if this is a new key.

## -remarks
Use this method if your app needs to add a custom property to the [DataPackagePropertySet](datapackagepropertyset.md) object. A custom property is any property that you can't define by using an existing property of the object. For example, [title](datapackagepropertyset_title.md) is a property that the object supports directly, but if you wanted a subtitle property, you would need to use **Insert** to add it.

For more info, see [IMapView(String, Object)](../windows.foundation.collections/imapview_2.md).

## -examples

## -see-also
