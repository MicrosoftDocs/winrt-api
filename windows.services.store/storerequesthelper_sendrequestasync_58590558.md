---
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
This method is intended to be used to send requests to the Windows Store for operations that do not yet have a corresponding API available in the Windows SDK. This method currently supports the following requests.

### Monetization and engagement requests

>**Note**&nbsp;&nbsp;The requests described in this section can only be used by developer accounts that are specially provisioned to use them. These requests are not currently available to most developer accounts.

This method supports a set of requests for monetization and engagement scenarios. To submit these requests, pass the value 7 or 8 to the *requestKind* parameter along with a JSON-formatted string to the *parametersAsJson* parameter that indicates the request you want to submit along with any related arguments. These *requestKind* values differ in the following ways:

  * When you pass the value 7, the requests are performed in the context of the current device. This value can only be used on Windows 10 Creators Update or later.

  * When you pass the value 8, the requests are performed in the context of the user who is currently signed in to the device. This value can be used on Windows 10, version 1607, or later.

The following monetization and engagement requests are currently supported.

#### Retrieve the flight group for the device or user and related remote variables

This request retrieves the highest-ranked flight group to which the device or user belongs, along with any remote variables that you have configured for the flight group in the [Experimentation page of the Dev Center dashboard](https://docs.microsoft.com/windows/uwp/monetize/create-a-project-and-define-remote-variables-in-the-dev-center-dashboard). To send this request, pass the following information to the *requestKind* and *parametersAsJson* parameters.

  * *requestKind*: Specify 7 to return the highest-ranked flight group for the user who is currently signed in to the device, or specify 8 to return the highest-ranked flight group for the device. We recommend using the value 8 for the *requestKind* parameter, because this value will return the highest-ranked flight group across the membership for both the device and the current user.

  * *parametersAsJson*: Pass a JSON-formatted string that contains the following data. The *type* field must be assigned to the string *GetRemoteVariables*. Replace the value of the *projectId* field with the appropriate project ID from the [Experimentation page of the Dev Center dashboard](https://docs.microsoft.com/windows/uwp/monetize/create-a-project-and-define-remote-variables-in-the-dev-center-dashboard).
  ```json
  { 
      "type": "GetRemoteVariables", 
      "parameters": "{ \"projectId\": \"f065d3f2-bd92-4a96-ada8-b4e13828788f\" }" 
  }
  ```

After you submit this request, the [Response](storesendrequestresult_response.md) property of the [StoreSendRequestResult](storesendrequestresult.md) return value contains a JSON-formatted string with the following fields:

  * *anonymous*: A Boolean value, where **true** indicates that the user or device identity was not present in the request, and **false** indicates that user or device identity was present in the request.

  * *name*: A string that contains the name of the highest-ranked flight group to which the device or user belongs.

  * *settings*: A dictionary of key/value pairs that contain the name and value of the remote variables that the developer has configured for the flight group.  

The following example demonstrates a return value for this request.

```json
{ 
  "anonymous": false, 
  "name": "Insider Slow",
  "settings":
  {
      "Audience": "Slow"
      ...
  }
}
```

#### Add the current device or signed-in user to a flight group

To send this request, pass the following information to the *requestKind* and *parametersAsJson* parameters.

  * *requestKind*: Specify 7 to add the user who is currently signed in to the device to a flight group, or specify 8 to add the device to a flight group.

  * *parametersAsJson*: Pass a JSON string that contains the following data. The *type* field must be assigned to the string *AddToFlightGroup*. Replace the value of the *flightGroupId* field with the ID of the flight group to which you want to add the device or user.

  ```json
  { 
      "type": "AddToFlightGroup", 
      "parameters": "{ \"flightGroupId\": \"1152921504606962205\" }" 
  }
  ```

If there is an error with the request, the [HttpStatusCode](storesendrequestresult_httpstatuscode.md) property of the [StoreSendRequestResult](storesendrequestresult.md) return value contains one of the following error codes:

* 400: Invalid request.
* 401: User or device token was not populated correctly.
* 500: Internal server error.

#### Remove the current device or signed-in user from a flight group

To send this request, pass the following information to the *requestKind* and *parametersAsJson* parameters.

  * *requestKind*: Specify 7 to remove the user who is currently signed in to the device from a flight group, or specify 8 to remove the device from a flight group.

  * *parametersAsJson*: Pass a JSON string that contains the following data. The *type* field must be assigned to the string *RemoveFromFlightGroup*. Replace the value of the *flightGroupId* field with the ID of the flight group from which you want to remove the device or user.

  ```json
  { 
      "type": "RemoveFromFlightGroup", 
      "parameters": "{ \"flightGroupId\": \"1152921504606962205\" }" 
  }
  ```

If there is an error with the request, the [HttpStatusCode](storesendrequestresult_httpstatuscode.md) property of the [StoreSendRequestResult](storesendrequestresult.md) return value contains one of the following error codes:

* 400: Invalid request.
* 401: User or device token was not populated correctly.
* 500: Internal server error.

## -examples

## -see-also
