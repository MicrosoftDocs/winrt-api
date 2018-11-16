---
-api-id: M:Windows.Services.Store.StoreQueueItem.ResumeInstallAsync
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncAction StoreQueueItem.ResumeInstallAsync()
-->

# Windows.Services.Store.StoreQueueItem.ResumeInstallAsync

## -description
Resumes the install for the current package in the queue.

## -returns
The object that is used to control the asynchronous operation.

## -remarks
If you pause or cancel the install for the current package in the queue by using the [PauseInstallAsync](storequeueitem_pauseinstallasync_1526538422.md) or [CancelInstallAsync](storequeueitem_cancelinstallasync_474034196.md) methods, you can use this method to resume the install.

## -see-also
[CancelInstallAsync](storequeueitem_cancelinstallasync_474034196.md),[PauseInstallAsync](storequeueitem_pauseinstallasync_1526538422.md)

## -examples
