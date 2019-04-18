---
-api-id: M:Windows.Media.Miracast.MiracastReceiver.GetStatus
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public MiracastReceiverStatus MiracastReceiver.GetStatus()
-->

# Windows.Media.Miracast.MiracastReceiver.GetStatus

## -description

Retrieves the current status of the [MiracastReceiver](miracastreceiver.md).

## -returns

A [MiracastReceiverStatus](miracastreceiverstatus.md) object containing information about the the current status of the **MiracastReceiver**.

## -remarks

Because this method may block for a noticeable period of time, you should not call it from the UI thread or from a single-threaded apartment. Instead, use the asyncronous method [GetStatusAsync](miracastreceiver_getstatusasync_240032933.md).

## -see-also

[GetStatusAsync](miracastreceiver_getstatusasync_240032933.md)

## -examples

