---
-api-id: M:Windows.Media.Core.MediaStreamSource.NotifyError(Windows.Media.Core.MediaStreamSourceErrorStatus)
-api-type: winrt method
---

<!-- Method syntax
public void NotifyError(Windows.Media.Core.MediaStreamSourceErrorStatus errorStatus)
-->

# Windows.Media.Core.MediaStreamSource.NotifyError

## -description
Notifies the [MediaStreamSource](mediastreamsource.md) that an error has occurred which is preventing the application from continuing to deliver data to the [MediaStreamSource](mediastreamsource.md).

## -parameters
### -param errorStatus
The cause of the error.

## -remarks
The application should invoke this method when it has encountered an unrecoverable error, for example, loss of the network connection to a media server or an out-of-memory condition.

The [MediaStreamSource](mediastreamsource.md) will raise the [Closed](mediastreamsource_closed.md) event when this method is invoked.

## -examples

## -see-also
