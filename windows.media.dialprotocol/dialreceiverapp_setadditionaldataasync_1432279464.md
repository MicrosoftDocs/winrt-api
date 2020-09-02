---
-api-id: M:Windows.Media.DialProtocol.DialReceiverApp.SetAdditionalDataAsync(Windows.Foundation.Collections.IIterable{Windows.Foundation.Collections.IKeyValuePair{System.String,System.String}})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction DialReceiverApp.SetAdditionalDataAsync(IIterable<String>> additionalData)
-->

# Windows.Media.DialProtocol.DialReceiverApp.SetAdditionalDataAsync

## -description
Used by the server app to send a set of data in key/value pairs to the DIAL REST service so that it can be queried from a client app. 

## -parameters
### -param additionalData
The set of key/value pairs to send to the DIAL REST service.

## -returns
Clients retrieve the additional data by making an HTTP GET request to the DIAL REST service application URL.  UWP client apps can perform this task by calling [DialDevice.GetDialApp](/uwp/api/windows.media.dialprotocol.dialdevice#Windows_Media_DialProtocol_DialDevice_GetDialApp_System_String_) followed by [DialApp.GetAppStateAsync](/uwp/api/windows.media.dialprotocol.dialapp.GetAppStateAsync), and then accessing the [DialAppStateDetails.FullXml](/uwp/api/windows.media.dialprotocol.dialappstatedetails.FullXml) property to retrieve the additional data.  The additional data is added to the DIAL app XML in accordance with the DIAL specification.

## -remarks

## -see-also

## -examples

