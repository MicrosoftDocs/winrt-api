---
-api-id: M:Windows.ApplicationModel.DataTransfer.DataPackage.SetWebLink(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public void SetWebLink(Windows.Foundation.Uri value)
-->

# Windows.ApplicationModel.DataTransfer.DataPackage.SetWebLink

## -description
Sets the web link that a [DataPackage](datapackage.md) contains.

## -parameters
### -param value
A Uniform Resource Identifier (URI) with an **http** or **https** scheme that corresponds to the content being displayed to the user.

## -remarks
Whenever possible, you should set this property. A source app provides a value for this property, and a target app reads the value. Use this property to indicate the source of the shared content.

## -examples

## -see-also
[WebLink](standarddataformats_weblink.md), [GetWebLink](datapackageview_getweblinkasync_1792258175.md)