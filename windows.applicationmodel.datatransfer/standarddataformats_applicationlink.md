---
-api-id: P:Windows.ApplicationModel.DataTransfer.StandardDataFormats.ApplicationLink
-api-type: winrt property
---

<!-- Property syntax
public string ApplicationLink { get; }
-->

# Windows.ApplicationModel.DataTransfer.StandardDataFormats.ApplicationLink

## -description
A read-only property that returns the format ID string value corresponding to the activation link format.

## -property-value
The format ID string value corresponding to the application link format.

## -remarks
An application link represents a Uniform Resource Identifier (URI) with a scheme that isn't **http** or **https** that can be handled by a UWP app. The referenced app must be capable of being the default handler for the Uniform Resource Identifier (URI) scheme, although it may not be set as the default handler.

## -examples

## -see-also
[SetApplicationLink](datapackage_setapplicationlink.md), [GetApplicationLinkAsync](datapackageview_getapplicationlinkasync.md)