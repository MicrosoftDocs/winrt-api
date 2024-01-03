---
-api-id: P:Windows.Devices.AllJoyn.AllJoynCredentials.PasswordCredential
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Security.Credentials.PasswordCredential PasswordCredential { get;  set; }
-->

# Windows.Devices.AllJoyn.AllJoynCredentials.PasswordCredential

## -description

> [!IMPORTANT]
> The types in the **Windows.Devices.AllJoyn** namespace are deprecated, and might not be available in future versions of Windows. [AllJoyn](https://openconnectivity.org/technology/reference-implementation/alljoyn/)&mdash;sponsored by AllSeen Alliance&mdash;was an open-source discovery and communication protocol for Internet of Things (IoT) scenarios such as turning lights on and off, and reading temperatures. For alternatives, such as [IoTivity Lite](https://github.com/iotivity/iotivity-lite) and [IoTivity](https://github.com/iotivity/iotivity), refer to the [iotivity.org](https://iotivity.org/) website.

The user name, if any, and password used for authentication.

## -property-value
A user name/password combination.

## -remarks
The password value contained in a [PasswordCredential](../windows.security.credentials/passwordcredential.md) object is used by the following authentication mechanisms: It’s also optionally used by Rsa if the private key associated with the certificate is encrypted with a password. The user name is used only by SrpLogon, and is ignored for the other ones.


+ SrpAnonymous
+ SrpLogon
+ Pin
+ EcdhePsk
> [!NOTE]
> Used for Rsa if the private key associated with the certificate is encrypted with a password.

The username value contained in a [PasswordCredential](../windows.security.credentials/passwordcredential.md) object is used only by SrpLogon, and is ignored by other authentication mechanisms.

## -examples

## -see-also


## -capabilities
allJoyn
