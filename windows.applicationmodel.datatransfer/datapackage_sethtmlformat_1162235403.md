---
-api-id: M:Windows.ApplicationModel.DataTransfer.DataPackage.SetHtmlFormat(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void SetHtmlFormat(System.String value)
-->

# Windows.ApplicationModel.DataTransfer.DataPackage.SetHtmlFormat

## -description
Adds HTML content to the [DataPackage](datapackage.md).

## -parameters
### -param value
The HTML content.

## -remarks
To ensure that a target app can process the HTML content, use [HtmlFormatHelper.CreateHtmlFormat](htmlformathelper_createhtmlformat_180504809.md). It adds the required headers and other information the string containing the HTML.

If your app supports selection or copying/pasting of HTML content that contains [img](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/img) elements, be sure that the **src** attributes specify fully-qualified absolute paths to the images, not relative paths.

## -examples


[!code-csharp[HowToShareHtml](../windows.applicationmodel.datatransfer/code/ShareMainBeta/cs/ShareHTML.xaml.cs#SnippetHowToShareHtml_CS)]

## -see-also
