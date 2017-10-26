---
-api-id: P:Windows.Networking.NetworkOperators.NetworkOperatorNotificationEventDetails.Message
-api-type: winrt property
---

<!-- Property syntax
public string Message { get; }
-->

# Windows.Networking.NetworkOperators.NetworkOperatorNotificationEventDetails.Message

## -description
Gets the message for the network operator notification.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.



> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/en-us/windows/uwp/packaging/app-capability-declarations). 

## -property-value
The message for the network operator notification.

## -remarks
If the data-coding scheme is Unicode, the message is a plaintext string that has already been decoded. If it is an operator-defined scheme, the message is a hex-encoded string representing an array of bytes.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
