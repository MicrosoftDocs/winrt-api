---
-api-id: T:Windows.Networking.Sockets.SocketProtectionLevel
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.Sockets.SocketProtectionLevel : int
-->

# SocketProtectionLevel

## -description
Specifies the level of encryption to use on a [StreamSocket](streamsocket.md) object.

## -enum-fields
### -field PlainSocket:0
A plain socket with no encryption.

### -field Ssl:1
> [!NOTE]
> This value is deprecated on Windows 8.1, Windows Server 2012 R2, and later.

A TCP socket that must use the Secure Sockets Layer (SSL) for encryption. This value requires encryption and never allows a NULL cipher (no encryption).

This value supports the SSL 3.0 and TLS 1.0 protocols and all encryption ciphers installed on the system except the NULL cipher. For domain-joined machines, an administrator can configure additional restrictions on which ciphers are allowed.

This value is marked as deprecated because it is considered insecure since RC4 and other weak ciphers are allowed. Sockets should use **Tls10**, **Tls11**, or **Tls12** instead unless the target server only supports RC4 or another weak cipher.

### -field SslAllowNullEncryption:2
A TCP socket that prefers to use SSL for encryption. This value prefers that full encryption be used, but allows a NULL cipher (no encryption) based on the server configuration.

This value supports the SSL 3.0 and TLS 1.0 protocols and all encryption ciphers installed on the system including the NULL cipher. For domain-joined machines, an administrator can configure additional restrictions on which ciphers are allowed.

The NULL cipher does no encryption, so this value does not provide confidentiality, but is integrity protected.

### -field BluetoothEncryptionAllowNullAuthentication:3
A Bluetooth socket that prefers that encryption be used, but allows a NULL cipher (no encryption) based on the configuration of the target server.

This value is supported on Windows 8.1, Windows Server 2012 R2, and later.

### -field BluetoothEncryptionWithAuthentication:4
A Bluetooth socket that must use encryption. This value requires encryption and never allows a NULL cipher.

This value is supported on Windows 8.1, Windows Server 2012 R2, and later.

### -field Ssl3AllowWeakEncryption:5
A TCP socket that must use SSL for encryption. This value supports the SSL 3.0 protocol and all encryption ciphers installed on the system except the NULL cipher. This value allows RC4 and other weak ciphers which are considered insecure. For domain-joined machines, an administrator can configure additional restrictions on which ciphers are allowed.

This value is supported on Windows 8.1, Windows Server 2012 R2, and later.

### -field Tls10:6
A TCP socket that must use SSL for encryption. This value supports the TLS 1.0 protocol and all encryption ciphers installed on the system except RC4, other weak ciphers, and the NULL cipher. For domain-joined machines, an administrator can configure additional restrictions on which ciphers are allowed.

This value is supported on Windows 8.1, Windows Server 2012 R2, and later.

### -field Tls11:7
A TCP socket that must use SSL for encryption. This value supports the TLS 1.1 and TLS 1.0 protocols and all encryption ciphers installed on the system except RC4, other weak ciphers, and the NULL cipher. For domain-joined machines, an administrator can configure additional restrictions on which ciphers are allowed.

This value is supported on Windows 8.1, Windows Server 2012 R2, and later.

### -field Tls12:8
A TCP socket that must use SSL for encryption. This value supports the TLS 1.2, TLS 1.1 and TLS 1.0 protocols and all encryption ciphers installed on the system except RC4, other weak ciphers, and the NULL cipher. For domain-joined machines, an administrator can configure additional restrictions on which ciphers are allowed.

This value is supported on Windows 8.1, Windows Server 2012 R2, and later.


### -field Unspecified:9
The protection level is unspecified.

## -remarks
The [SocketProtectionLevel](socketprotectionlevel.md) enumeration allow clients to control protocol negotiation for security options with servers when using the [StreamSocket](streamsocket.md) object.

For TCP sockets, the various enum values allow app developers to control the use of the TLS 1.2, TLS 1.1, TLS 1.0, and SSL 3.0 protocols and restrict the use of the RC4 and other weak ciphers which are considered insecure. This allows developers to configure apps that are compatible across a very wide set of servers.

For Bluetooth RFCOMM sockets, the various enum values allow app developers to control the use of Bluetooth encryption.

The users of non-domain joined machines can also disable ciphers and protocols by using registry settings. For more information, see [How to Restrict the Use of Certain Cryptographic Algorithms and Protocols in Schannel.dll](http://support.microsoft.com/kb/245030).

The [SocketProtectionLevel](socketprotectionlevel.md) enumeration also allow servers to control protocol negotiation for security with clients when using the [StreamSocketListener](streamsocketlistener.md) object to listen and bind to sockets over Bluetooth. When the [StreamSocketListener](streamsocketlistener.md) object is used over Bluetooth, the supported [SocketProtectionLevel](socketprotectionlevel.md) values are **PlainSocket**, **BluetoothEncryptionAllowNullAuthentication**, or **BluetoothEncryptionWithAuthentication**. When the [StreamSocketListener](streamsocketlistener.md) object is used to listen and bind to TCP sockets, the only supported [SocketProtectionLevel](socketprotectionlevel.md) value is **PlainSocket**.

### Version history

| Version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | Unspecified |

## -examples

## -see-also
[StreamSocket](streamsocket.md), [StreamSocketInformation.ProtectionLevel](streamsocketinformation_protectionlevel.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone], bluetooth.rfcomm
