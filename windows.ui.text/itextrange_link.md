---
-api-id: P:Windows.UI.Text.ITextRange.Link
-api-type: winrt property
---

<!-- Property syntax
public string Link { get;  set; }
-->

# Windows.UI.Text.ITextRange.Link

## -description
Gets or sets the URL text associated with a text range.



## -property-value
The URL as text.

## -remarks
This method sets the start and end of the text range to include the entire hyperlink, including the friendly name, if any.

The URL string isn't validated. The text it contains must be enclosed in quotes, optionally preceded by the sentinel character 0xFDDF. For example: "http://www.msn.com" or 0xFDDF"http://www.msn.com".

The text range must be nondegenerate. The following actions are possible: 
+ If part of a link's friendly name is selected, the URL part is replaced with the Link property value.
+ If part of a regular URL is selected, it becomes the link's friendly name, with the Link property value as the URL.
+ If nonlink text is selected:    + If the text immediately follows a link's friendly name and the Link property value matches the URL, the text is appended to the friendly name.
   + Otherwise, the text becomes the friendly name of a link with the Link property value as the URL.

 The text range can be adjusted to different character positions after this method is called.

## -examples

## -see-also
