---
-api-id: M:Windows.Media.Audio.AudioFileOutputNode.FinalizeAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Transcoding.TranscodeFailureReason> FinalizeAsync()
-->

# Windows.Media.Audio.AudioFileOutputNode.FinalizeAsync

## -description
Finalizes the asynchronous operation of the audio file output node.

## -returns
When this operation completes, a [TranscodeFailureReason](../windows.media.transcoding/transcodefailurereason.md) value is returned.

## -remarks
You must call the [AudioFileOutputNode.Stop](audiofileoutputnode_stop.md) method to stop the node before calling **FinalizeAsync** or an exception will be thrown.

Upon completion of **FinalizeAsync**, this node transitions itself into the closed state. Further calls into this node will result in a RO_E_CLOSED exception.

## -examples

## -see-also
