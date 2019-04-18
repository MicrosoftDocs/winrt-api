---
-api-id: M:Windows.Media.Miracast.MiracastReceiverSession.Start
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public MiracastReceiverSessionStartResult MiracastReceiverSession.Start()
-->

# Windows.Media.Miracast.MiracastReceiverSession.Start

## -description

Start listening for incoming Miracast connections.

## -returns

The result of the operation.

## -remarks

Because this method may block for a noticeable period of time, you should not call it from the UI thread or from a single-threaded apartment. Instead, use the asyncronous method [StartAsync](miracastreceiversession_startasync_1931900819.md).

## -see-also

[StartAsync](miracastreceiversession_startasync_1931900819.md),
[MiracastReceiverSessionStartResult](miracastreceiversessionstartresult.md)

## -examples

