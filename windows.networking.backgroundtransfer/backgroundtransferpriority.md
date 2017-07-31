---
-api-id: T:Windows.Networking.BackgroundTransfer.BackgroundTransferPriority
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.BackgroundTransfer.BackgroundTransferPriority : int
-->

# BackgroundTransferPriority

## -description
Indicates the priority that a BackgroundTransfer operation(download or upload) has in terms of scheduling within an app.

## -enum-fields
### -field Default:0
Default priority setting for an operation. By default when a new operation is created, it is placed at the end of the current transfer queue.

### -field High:1
High priority setting for an operation. Ensures that the operation doesn't get placed at the very end of the queue, and is instead placed near the front.


## -remarks

## -examples

## -see-also
[DownloadOperation](downloadoperation.md), [UploadOperation](uploadoperation.md), [BackgroundTransferGroup](backgroundtransfergroup.md)