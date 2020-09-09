---
-api-id: M:Windows.ApplicationModel.DataTransfer.DataPackage.SetData(System.String,System.Object)
-api-type: winrt method
---

<!-- Method syntax
public void SetData(System.String formatId, System.Object value)
-->

# Windows.ApplicationModel.DataTransfer.DataPackage.SetData

## -description
Sets the data contained in the [DataPackage](datapackage.md) in a [RandomAccessStream](../windows.storage.streams/randomaccessstream.md) format.

## -parameters
### -param formatId
Specifies the format of the data. We recommend that you set this value by using the [StandardDataFormats](standarddataformats.md) class.

### -param value
Specifies the content that the [DataPackage](datapackage.md) contains.

## -remarks
To add data using this method, your app must convert the data into an object. You must also specify a *formatId* that target apps can use to request the data. Note that the target app can request this data only if it knows the *formatId*.

This method is often used when you use a delegate function to share data. For more information, see [How to support pull operations](/previous-versions/windows/apps/hh770848(v=win.10)).

## -examples


## -see-also
