---
-api-id: M:Windows.Web.AtomPub.AtomPubClient.CreateMediaResourceAsync(Windows.Foundation.Uri,System.String,System.String,Windows.Storage.Streams.IInputStream)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Web.Syndication.SyndicationItem, Windows.Web.Syndication.TransferProgress> CreateMediaResourceAsync(Windows.Foundation.Uri uri, System.String mediaType, System.String description, Windows.Storage.Streams.IInputStream mediaStream)
-->

# Windows.Web.AtomPub.AtomPubClient.CreateMediaResourceAsync

## -description
Creates a new media resource in the specified collection.

## -parameters
### -param uri
The Uniform Resource Identifier (URI) of the specified collection in which the new resource should be created.

### -param mediaType
The type for the media resource.

### -param description
The description of the new resource that is turned into the Slug: header of the POST request.

### -param mediaStream
Specifies the [IInputStream](../windows.storage.streams/iinputstream.md) to use as the media resource.

## -returns
The object that is used to create the resource asynchronously and to report the progress and completion status of the operation.

## -remarks

## -examples

## -see-also
