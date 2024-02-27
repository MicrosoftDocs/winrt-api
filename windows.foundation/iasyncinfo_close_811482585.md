---
-api-id: M:Windows.Foundation.IAsyncInfo.Close
-api-type: winrt method
---

<!-- Method syntax
public void Close()
-->

# Windows.Foundation.IAsyncInfo.Close

## -description
Closes the asynchronous operation.

## -remarks
Calling this method indicates that you have finished with the asynchronous action or operation,
and it is permitted to free any associated resources.
After calling **Close**, you may not call any methods or access any properties
of the object that implements the [IAsyncInfo](iasyncinfo.md) interface.

You may not call **Close** before the asynchronous action or operation has completed.

## -examples

## -see-also
[Status](iasyncinfo_status.md)
