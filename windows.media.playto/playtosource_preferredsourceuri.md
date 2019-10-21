---
-api-id: P:Windows.Media.PlayTo.PlayToSource.PreferredSourceUri
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri PreferredSourceUri { get;  set; }
-->

# Windows.Media.PlayTo.PlayToSource.PreferredSourceUri

## -description
Specifies a preferred Uniform Resource Identifier (URI) for the media stream, such as a cloud based media server, used is used for Play To by reference.

## -property-value
The preferred URI to stream the media from.

## -remarks
Play To by reference enables web pages and UWP apps to play Digital Rights Management (DRM) protected content. The app specifies a preferred Uniform Resource Identifier (URI) that will be sent to the PlayTo target device. This Uniform Resource Identifier (URI) can point to a cloud based media server. If the preferredSourceUri is present, the PlayTo target device can stream content directly from the cloud, which can be Digital Rights Management (DRM) protected, instead of streaming content from the Windows 8.1 machine which must be unprotected content.

## -examples

## -see-also
