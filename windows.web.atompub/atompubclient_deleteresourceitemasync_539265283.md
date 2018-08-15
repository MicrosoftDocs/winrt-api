---
-api-id: M:Windows.Web.AtomPub.AtomPubClient.DeleteResourceItemAsync(Windows.Web.Syndication.SyndicationItem)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncActionWithProgress<Windows.Web.Syndication.TransferProgress> DeleteResourceItemAsync(Windows.Web.Syndication.SyndicationItem item)
-->

# Windows.Web.AtomPub.AtomPubClient.DeleteResourceItemAsync

## -description
Deletes an existing Entry or Media Link resource. This differs from the [DeleteResourceAsync](atompubclient_deleteresourceasync_1093618628.md) method in that the [SyndicationItem](../windows.web.syndication/syndicationitem.md) object that represents the resource to be deleted is specified instead of the Uri. The [DeleteResourceItemAsync](atompubclient_deleteresourceitemasync_539265283.md) method uses the  property of the specified [SyndicationItem](../windows.web.syndication/syndicationitem.md) as the Uri of the resource to be deleted.

## -parameters
### -param item
The resource to be deleted.

## -returns
The object that is used to delete the resource asynchronously and to report the progress and completion status of the operation.

## -remarks

## -examples

## -see-also
