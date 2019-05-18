---
-api-id: P:Windows.ApplicationModel.DataTransfer.DataPackagePropertySet.ContentSourceWebLink
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri ContentSourceWebLink { get;  set; }
-->

# Windows.ApplicationModel.DataTransfer.DataPackagePropertySet.ContentSourceWebLink

## -description
Provides a web link to shared content that's currently displayed in the app.

## -property-value
The Uniform Resource Identifier (URI) of the web link to shared content.

## -remarks
ContentSourceWebLink is a companion property that you use to attribute shared content. It's shared when the app provides a web link to the content being shared. When the user makes an explicit selection, the [WebLink](standarddataformats_weblink.md) format isn't populated, because the value for the [WebLink](standarddataformats_weblink.md) format isn't the same as the user's selection. Populating this info doesn't mean that the web page is the user's selection, only that the content comes from there.

## -examples

## -see-also
