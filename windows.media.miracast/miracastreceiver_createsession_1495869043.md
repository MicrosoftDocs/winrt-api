---
-api-id: M:Windows.Media.Miracast.MiracastReceiver.CreateSession(Windows.ApplicationModel.Core.CoreApplicationView)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public MiracastReceiverSession MiracastReceiver.CreateSession(CoreApplicationView view)
-->

# Windows.Media.Miracast.MiracastReceiver.CreateSession

## -description

Creates a new [MiracastReceiverSession](miracastreceiversession.md) object, needed to receive Miracast connections.

## -parameters
### -param view

The [CoreApplicationView](../windows.applicationmodel.core/coreapplicationview.md) used by the app when displaying the Miracast video stream.

## -returns

The new **MiracastReceiverSession** object.

## -remarks
 
Because this method may block for a noticeable period of time, you should not call it from the UI thread or from a single-threaded apartment. Instead, use the asyncronous method [CreateSessionAsync](miracastreceiver_createsessionasync_1751251082.md).

## -see-also

[CoreApplicationView](/windows.applicationmodel.core/coreapplicationview.md),
[CreateSessionAsync](miracastreceiver_createsessionasync_1751251082.md),
[MiracastReceiverSession](miracastreceiversession.md)

## -examples

