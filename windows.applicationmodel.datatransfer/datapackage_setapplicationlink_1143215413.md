---
-api-id: M:Windows.ApplicationModel.DataTransfer.DataPackage.SetApplicationLink(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public void SetApplicationLink(Windows.Foundation.Uri value)
-->

# Windows.ApplicationModel.DataTransfer.DataPackage.SetApplicationLink

## -description
Sets the application link that a [DataPackage](datapackage.md) contains.

## -parameters
### -param value
A Uniform Resource Identifier (URI) with a scheme that isn't **http** or **https** that's handled by the source app.

## -remarks
Whenever possible, you should set this property. This Uniform Resource Identifier (URI) represents a deep link that takes the user back to the currently displayed content. A source app provides a value for this property, and a target app reads the value. Use this property to indicate the source of the shared content.

The scheme of this Uniform Resource Identifier (URI) must not be **http** or **https**. The app sharing this Uniform Resource Identifier (URI) must be capable of being the default handler, although it may not be set as the default handler.

## -examples

## -see-also
[GetApplicationLinkAsync](datapackageview_getapplicationlinkasync_832271692.md)