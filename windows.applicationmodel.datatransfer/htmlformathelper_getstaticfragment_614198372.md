---
-api-id: M:Windows.ApplicationModel.DataTransfer.HtmlFormatHelper.GetStaticFragment(System.String)
-api-type: winrt method
---

<!-- Method syntax
public string GetStaticFragment(System.String htmlFormat)
-->

# Windows.ApplicationModel.DataTransfer.HtmlFormatHelper.GetStaticFragment

## -description
Gets a string that represents an HTML fragment.

## -parameters
### -param htmlFormat
The formatted HTML.

## -returns
An HTML fragment based on the formatted HTML.

## -remarks
As a security precaution, you shouldn't display HTML unless you're sure it doesn't have any dynamic content. You can use the `GetStaticFragment` method to get shared HTML content without any dynamic elements such as script tags.

## -examples


[!code-js[HowToReceiveSharedHtml](../windows.applicationmodel.datatransfer.sharetarget/code/ShareTargetBeta/javascript/js/ReceiveSharedHtml.js#SnippetHowToReceiveSharedHtml)]

## -see-also
