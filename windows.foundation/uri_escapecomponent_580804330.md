---
-api-id: M:Windows.Foundation.Uri.EscapeComponent(System.String)
-api-type: winrt method
---

<!-- Method syntax
public string EscapeComponent(System.String toEscape)
-->

# Windows.Foundation.Uri.EscapeComponent

## -description
Converts a Uniform Resource Identifier (URI) string to its escaped representation.

## -parameters
### -param toEscape
The string to convert.

## -returns
The escaped representation of *toEscape*.

## -remarks
Use [EscapeComponent](uri_escapecomponent_580804330.md) as a utility to escape any Uniform Resource Identifier (URI) component that requires escaping in order to construct a valid [Uri](uri.md) object. For example, if your app is using a user-provided string and adding it to a query that is sent to a service, you may need to escape that string in the Uniform Resource Identifier (URI) because the string might contain characters that are invalid in a Uniform Resource Identifier (URI). This includes characters as simple as spaces; even input that seems to be pure ASCII may still need encoding to be valid as a component of a Uniform Resource Identifier (URI).

You can append the string you get from [EscapeComponent](uri_escapecomponent_580804330.md) onto other strings before calling the [Uri(String) constructor](uri_uri_290278668.md). You'll want to encode each component separately, because you do not want to escape the characters that are significant to how the [Uri(String) constructor](uri_uri_290278668.md) parses the string into components, such as the "/" between host and path or the "?" between path and query.

[EscapeComponent](uri_escapecomponent_580804330.md) might also be useful for other scenarios where a Uniform Resource Identifier (URI)-escaped string is needed for an HTTP request scenario, such as using APIs in the [Windows.Web.Http](../windows.web.http/windows_web_http.md) namespace.

## -examples

## -see-also
[Uri(String) constructor](uri_uri_290278668.md)