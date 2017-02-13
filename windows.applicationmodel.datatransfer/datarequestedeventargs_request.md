---
-api-id: P:Windows.ApplicationModel.DataTransfer.DataRequestedEventArgs.Request
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.DataTransfer.DataRequest Request { get; }
-->

# Windows.ApplicationModel.DataTransfer.DataRequestedEventArgs.Request

## -description
Enables you to get the [DataRequest](datarequest.md) object and either give it data or a failure message.

## -property-value
The object used to manage content as part of a share operation.

## -remarks
When a user invokes the Share UI to share content, the system fires a [datarequested](datatransfermanager_datarequested.md) event. The **request** property of the event contains a [DataRequest](datarequest.md) object, which lets your app supply the information the user wants to share.

## -examples

## -see-also
