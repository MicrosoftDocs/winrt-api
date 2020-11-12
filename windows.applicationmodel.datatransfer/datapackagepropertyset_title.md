---
-api-id: P:Windows.ApplicationModel.DataTransfer.DataPackagePropertySet.Title
-api-type: winrt property
---

<!-- Property syntax
public string Title { get;  set; }
-->

# Windows.ApplicationModel.DataTransfer.DataPackagePropertySet.Title

## -description
Gets or sets the text that displays as a title for the contents of the [DataPackage](datapackage.md) object.

## -property-value
The text that displays as a title for the contents of the [DataPackage](datapackage.md) object.

## -remarks
Setting this property is mandatory. Without it, any share operations involving the [DataPackage](datapackage.md) will fail.

## -examples
This example shows how you can set the title for the content in a [DataPackage.](datapackage.md)



[!code-csharp[HowToShareTextBasic](../windows.applicationmodel.datatransfer/code/ShareMainBeta/cs/ShareText.xaml.cs#SnippetHowToShareTextBasic)]

## -see-also
