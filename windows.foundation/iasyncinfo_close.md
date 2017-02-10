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
Calling this method indicates that you have finished with the results of the operation. After calling [Close](iasyncinfo_close.md), do not call the **GetResults** method again (each of the 4 [IAsyncInfo](iasyncinfo.md) derived interfaces have their own implementation of **GetResults**.)

<!--Is this a Notes to Callers? It's a weird note for implementation purposes.-->

## -examples

## -see-also
[Status](iasyncinfo_status.md)