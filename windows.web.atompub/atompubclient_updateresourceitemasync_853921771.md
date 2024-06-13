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
[Quickstart: Managing Feed Entries](/previous-versions/windows/apps/hh700368(v=win.10)), [AtomPub sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/AtomPub%20sample)
