---
-api-id: M:Windows.Web.AtomPub.AtomPubClient.UpdateResourceAsync(Windows.Foundation.Uri,Windows.Web.Syndication.SyndicationItem)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncActionWithProgress<Windows.Web.Syndication.TransferProgress> UpdateResourceAsync(Windows.Foundation.Uri uri, Windows.Web.Syndication.SyndicationItem item)
-->

# Windows.Web.AtomPub.AtomPubClient.UpdateResourceAsync

## -description
Updates an existing Entry or Media Link resource. If an ETag: header has previously been seen while retrieving this resource (in a response to [RetrieveResourceAsync](atompubclient_retrieveresourceasync_1946100714.md), [CreateResourceAsync](atompubclient_createresourceasync_823380555.md) or a previous call to [UpdateResourceAsync](atompubclient_updateresourceasync_241802746.md)), this method automatically sends an If-Match: header with the remembered value.

## -parameters
### -param uri
The Uniform Resource Identifier (URI) of the resource to be updated.

### -param item
The resource to be updated.

## -returns
The object that is used to update the resource asynchronously and to report the progress and completion status of the operation.

## -remarks
For an example of how this method is implemented to update syndicated content see [Quickstart: Managing Feed Entries](https://msdn.microsoft.com/library/239d42bc-5812-4ead-a91c-b3696fc3ef75).

## -examples

## -see-also
[Quickstart: Managing Feed Entries](https://msdn.microsoft.com/library/239d42bc-5812-4ead-a91c-b3696fc3ef75), [AtomPub sample](https://go.microsoft.com/fwlink/p/?linkid=245061)
