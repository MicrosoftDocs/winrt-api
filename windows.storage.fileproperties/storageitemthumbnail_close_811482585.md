---
-api-id: M:Windows.Storage.FileProperties.StorageItemThumbnail.Close
-api-type: winrt method
---

<!-- Method syntax
public void Close()
-->

# Windows.Storage.FileProperties.StorageItemThumbnail.Close

## -description
Releases system resources that are exposed by a Windows Runtime object.

## -remarks
Use this method to release the exclusive system resources that are in use, such as file handles, streams, and network sockets. The method should also release other resources that are in use, including object references and memory, to prepare them for reuse.

This method must call the [Close](../windows.foundation/iclosable_close_811482585.md) method of any object it holds that implements [IClosable](../windows.foundation/iclosable.md).

The [Close](../windows.foundation/iclosable_close_811482585.md) method should release system resources as quickly as possible, without blocking for asynchronous operations to complete. To ensure that all resources are completely released, the caller must wait for all outstanding asynchronous operations to complete before calling [Close](../windows.foundation/iclosable_close_811482585.md).

After [Close](../windows.foundation/iclosable_close_811482585.md) returns, the object is still in memory but without the system resources it needs; therefore, most of its members are not usable. A member that depends on a released system resource can return **RO_E_CLOSED** to indicate that the object is closed and it cannot complete the requested operation.

If you call [Close](../windows.foundation/iclosable_close_811482585.md) multiple times, there is no effect; the method returns **S_OK**.

## -examples

## -see-also
