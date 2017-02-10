---
-api-id: E:Windows.Web.Http.Filters.HttpBaseProtocolFilter.ServerCustomValidationRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ServerCustomValidationRequested<Windows.Web.Http.Filters.HttpBaseProtocolFilter,  Windows.Web.Http.Filters.HttpServerCustomValidationRequestedEventArgs>
-->

# Windows.Web.Http.Filters.HttpBaseProtocolFilter.ServerCustomValidationRequested

## -description
This event is raised when the SSL/TLS connection is being established with the server. You should implement an event handler for this event if you need to perform extra validation (in addition to the OS default) of the server SSL certificate.

## -remarks
Default OS validation of the server certificate is performed before raising this event. If the certificate fails this validation, the connection is terminated and your event handler is not called.

In order to skip parts of the OS validation (not recommended for production scenarios), use the [IgnorableServerCertificateErrors](httpbaseprotocolfilter_ignorableservercertificateerrors.md) property to specify the errors that you want to ignore. Then as long as the certificate does not have any other errors, the OS validation will be considered successful and your event handler will be called.

The event handler code is executed as part of a synchronous callback in the OS during the SSL/TLS connection establishment. Avoid performing long-running tasks within the event handler code to prevent the server from timing out during the connection.

If you need to call async APIs within your event handler code, you must take a deferral (See [HttpServerCustomValidationArgs.GetDeferral](httpservercustomvalidationrequestedeventargs_getdeferral.md)) before calling the asynchronous APIs. Once you are done, call the [deferral.Complete](../windows.foundation/deferral_complete.md) method to return control from your handler code.

The following snippet shows how to subscribe to this event.

```csharp

HttpBaseProtocolFilter.ServerCustomValidationRequest += (sender, args) =>
{
	var cert = args.ServerCertificate
	// Your custom cert validation code here.
}
```



## -examples

## -see-also
