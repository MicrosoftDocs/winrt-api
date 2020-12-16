---
-api-id: M:Windows.Data.Html.HtmlUtilities.ConvertToText(System.String)
-api-type: winrt method
---

<!-- Method syntax
public string ConvertToText(System.String html)
-->

# Windows.Data.Html.HtmlUtilities.ConvertToText

## -description
Converts HTML-formatted data to a string that contains the text content extracted from the HTML.

## -parameters
### -param html
A [String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) containing HTML-formatted data.

## -returns
A [String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) of text content.

## -remarks
The ConvertToText method is used to convert HTML-formatted data to a text string. The HTML-formatted data could represent an HTML document or an HTML fragment. When the ConvertToText method parses the HTML-formatted data, no scripts are run and no secondary downloads occur (scripts, images, and stylesheets, for example).

The ConvertToText method will only parse HTML-formatted data to extract the text. If the *html* parameter contains a non-HTML string (XML or SVG, for example), then the return value will contain an empty string. If the *html* parameter contains a string that represents an HTML Frameset document, then the return value will contain an empty string.

## -examples

## -see-also
