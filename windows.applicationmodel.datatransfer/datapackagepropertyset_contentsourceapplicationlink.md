---
-api-id: P:Windows.ApplicationModel.DataTransfer.DataPackagePropertySet.ContentSourceApplicationLink
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri ContentSourceApplicationLink { get;  set; }
-->

# Windows.ApplicationModel.DataTransfer.DataPackagePropertySet.ContentSourceApplicationLink

## -description
Gets or sets the application link to the content from the source app.

## -property-value
The Uniform Resource Identifier (URI) of the application link to shared content.

## -remarks
ContentSourceApplicationLink is a companion property that you use to attribute shared content. It's shared when the app finds it meaningful for the user to return to the content that's currently displayed in the app. When the user makes a selection, the [ApplicationLink](standarddataformats_applicationlink.md) format isn't populated, because the value for [ApplicationLink](standarddataformats_applicationlink.md) format isn't the same as the user's selection. Populating this info doesn't mean that the deep link into the app represents the user's selection, only that the content comes from there.

## -examples

## -see-also
