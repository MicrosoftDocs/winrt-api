-api-id: M:Windows.Services.Store.StoreRequestHelper.SendRequestAsync(Windows.Services.Store.StoreContext,System.UInt32,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Services.Store.StoreSendRequestResult> SendRequestAsync(Windows.Services.Store.StoreContext context, System.UInt32 requestKind, System.String parametersAsJson)
-->

# Windows.Services.Store.StoreRequestHelper.SendRequestAsync

## -description
Sends the specified request to the Windows Store with the provided context and parameters.

## -parameters
### -param context
An object that specifies the user for which to perform the operation. If your app is a single-user app (that is, it runs only in the context of the user that launched the app), use the [StoreContext.GetDefault](storecontext_getdefault.md) method to get a [StoreContext](storecontext.md) object that you can use to send a request that operates in the context of the user. If your app is a multi-user app, use the [StoreContext.GetForUser](storecontext_getforuser.md) method to get a [StoreContext](storecontext.md) object that you can use to send a request that operates in the context of a specific user.

### -param requestKind
A value that identifies the request that you want to send to the Windows Store.

### -param parametersAsJson
A JSON-formatted string that contains the arguments to pass to the request.

## -returns
An asynchronous operation that, on successful completion, returns a [StoreSendRequestResult](storesendrequestresult.md) object that provides status and error info about the request.

## -remarks
This method is intended to be used to send requests to the Windows Store for operations that do not yet have a corresponding API available in the Windows SDK. This method does not currently support any requests. When new requests are added, we will update this article with details about the supported values for the *requestKind* and *parametersAsJson* parameters.

## -examples

## -see-also
