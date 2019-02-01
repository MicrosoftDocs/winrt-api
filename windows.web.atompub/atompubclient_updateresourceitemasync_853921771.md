---
-api-id: M:Windows.Web.AtomPub.AtomPubClient.UpdateResourceItemAsync(Windows.Web.Syndication.SyndicationItem)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncActionWithProgress<Windows.Web.Syndication.TransferProgress> UpdateResourceItemAsync(Windows.Web.Syndication.SyndicationItem item)
-->

# Windows.Web.AtomPub.AtomPubClient.UpdateResourceItemAsync

## -description
Updates an existing Entry or Media Link resource. This differs from the [UpdateResourceAsync](atompubclient_updateresourceasync_241802746.md) method in that the [EditUri](../windows.web.syndication/syndicationitem_edituri.md) property of the specified [SyndicationItem](../windows.web.syndication/syndicationitem.md) object is used as the Uri of the resource to be updated.

## -parameters
### -param item
The resource to be updated.

## -returns
The object that is used to update the resource asynchronously and to report the progress and completion status of the operation.

## -remarks

## -examples

## -see-also
[Quickstart: Managing Feed Entries](https://msdn.microsoft.com/library/239d42bc-5812-4ead-a91c-b3696fc3ef75), [AtomPub sample](https://go.microsoft.com/fwlink/p/?linkid=245061)
