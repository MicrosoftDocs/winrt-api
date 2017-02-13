---
-api-id: P:Windows.ApplicationModel.DataTransfer.DataPackagePropertySet.FileTypes
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<string> FileTypes { get; }
-->

# Windows.ApplicationModel.DataTransfer.DataPackagePropertySet.FileTypes

## -description
Specifies a vector object that contains the types of files stored in the [DataPackage](datapackage.md) object.

## -property-value
Contains the types of files stored in the [DataPackage](datapackage.md) object.

## -remarks
Many target apps accept a number of different file formats. Even so, they might prefer one format over another. By adding the file types supported in a [DataPackage](datapackage.md) to the **FileTypes** property, you can help those target apps select the most appropriate file format for a given operation.

If your app shares content using one of the formats that the [DataPackage](datapackage.md) object supports directly, such as [text](standarddataformats_text.md) or [Html](standarddataformats_html.md), you should use the [StandardDataFormats](standarddataformats.md) class when adding file types to this property. If your app supports a custom data format, you can add that format using a string. In cases where your app uses a delegate to add content to the [DataPackage](datapackage.md), you must ensure that the string you use in the **FileTypes** property matches the value of the *formatId* parameter of the [SetDataProvider](datapackage_setdataprovider.md) method.

## -examples

## -see-also
