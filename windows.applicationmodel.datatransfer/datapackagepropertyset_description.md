---
-api-id: P:Windows.ApplicationModel.DataTransfer.DataPackagePropertySet.Description
-api-type: winrt property
---

<!-- Property syntax
public string Description { get;  set; }
-->

# Windows.ApplicationModel.DataTransfer.DataPackagePropertySet.Description

## -description
Gets or sets text that describes the contents of the [DataPackage](datapackage.md).

## -property-value
Text that describes the contents of the [DataPackage](datapackage.md).

## -remarks
We recommend adding a description to a [DataPackage](datapackage.md) object if you can. Target apps can use this description to help users identify what content they're sharing.

## -examples
The following example shows how you can set the description for the content in a [DataPackage](datapackage.md).



[!code-csharp[HowToShareTextBasic](../windows.applicationmodel.datatransfer/code/ShareMainBeta/cs/ShareText.xaml.cs#SnippetHowToShareTextBasic)]

## -see-also
