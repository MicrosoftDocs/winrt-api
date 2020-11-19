---
-api-id: M:Windows.ApplicationModel.DataTransfer.DataPackage.SetText(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void SetText(System.String value)
-->

# Windows.ApplicationModel.DataTransfer.DataPackage.SetText

## -description
Sets the text that a [DataPackage](datapackage.md) contains.

## -parameters
### -param value
The text.

## -remarks
This method sets the text value for [StandardDataFormats.Text](standarddataformats_text.md). It's the equivalent of calling `dataPackage.setText(StandardDataFormats.Text)`.

Text is one of the data types that the [DataPackage](datapackage.md) object supports directly. See the [StandardDataFormats](standarddataformats.md) class for information on other supported data types.

## -examples


[!code-csharp[HowToShareTextBasic](../windows.applicationmodel.datatransfer/code/ShareMainBeta/cs/ShareText.xaml.cs#SnippetHowToShareTextBasic)]

## -see-also
