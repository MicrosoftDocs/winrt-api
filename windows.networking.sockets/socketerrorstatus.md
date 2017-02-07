---
-api-id: T:Windows.Networking.Sockets.SocketErrorStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.Sockets.SocketErrorStatus : int
-->

# SocketErrorStatus

## -description
Specifies status values for a socket operation.

## -enum-fields
### -field Unknown:0
The socket status is unknown.

### -field OperationAborted:1
The operation was aborted.

### -field HttpInvalidServerResponse:2
A bad response was received from the HTTP server.

### -field ConnectionTimedOut:3
A connection timeout was exceeded.

### -field AddressFamilyNotSupported:4
The address family is not supported.

### -field SocketTypeNotSupported:5
The socket type is not supported.

### -field HostNotFound:6
The host was not found.

### -field NoDataRecordOfRequestedType:7
The requested name is valid and was found in the database, but it does not have the correct associated data being resolved for.

### -field NonAuthoritativeHostNotFound:8
This is usually a temporary error during hostname resolution and means that the local server did not receive a response from an authoritative server.

### -field ClassTypeNotFound:9
The specified class was not found.

### -field AddressAlreadyInUse:10
The address is already in use.

### -field CannotAssignRequestedAddress:11
Cannot assign requested address.



### -field ConnectionRefused:12
The connection was refused.

### -field NetworkIsUnreachable:13
The network is unreachable.

### -field UnreachableHost:14
The host is unreachable.

### -field NetworkIsDown:15
The network is down.

### -field NetworkDroppedConnectionOnReset:16
The network dropped connection on reset.

### -field SoftwareCausedConnectionAbort:17
Software caused a connection abort.

### -field ConnectionResetByPeer:18
The connection was reset by the peer.

### -field HostIsDown:19
The host is down.

### -field NoAddressesFound:20
The pipe is being closed.

### -field TooManyOpenFiles:21
Too many open files.

### -field MessageTooLong:22
A message sent on a datagram socket was larger than the internal message buffer or some other network limit, or the buffer used to receive a datagram was smaller than the datagram itself.

### -field CertificateExpired:23
A required certificate is not within its validity period when verifying against the current system clock or the timestamp in the signed file. This error is also returned if the validity periods of the certification chain do not nest correctly.

### -field CertificateUntrustedRoot:24
A certificate chain processed, but terminated in a root certificate which is not trusted by the trust provider. This error is also returned if a certificate chain could not be built to a trusted root authority.

### -field CertificateCommonNameIsIncorrect:25
The certificate is not valid for the requested usage. This error is also returned if the certificate has an invalid name. The name is not included in the permitted list or is explicitly excluded.

### -field CertificateWrongUsage:26
The certificate is not valid for the requested usage.

### -field CertificateRevoked:27
A certificate was explicitly revoked by its issuer. This error is also returned if the certificate was explicitly marked as untrusted by the user.

### -field CertificateNoRevocationCheck:28
The revocation function was unable to check revocation for the certificate.

### -field CertificateRevocationServerOffline:29
The revocation function was unable to check revocation because the revocation server was offline.

### -field CertificateIsInvalid:30
The supplied certificate is invalid. This can be returned for a number of reasons:


+ A certificate that can only be used as an end-entity is being used as a CA or vice versa.
+ A path length constraint in the certification chain has been violated.
+ A certificate contains an unknown extension that is marked critical.
+ A certificate is being used for a purpose other than the ones specified by its CA.
+ A parent of a given certificate in fact did not issue that child certificate.
+ A certificate is missing or has an empty value for an important field, such as a subject or issuer name.
+ The signature of the certificate cannot be verified.
+ The certificate has an invalid policy.
+ A certificate's basic constraint extension has not been observed.



## -remarks
An error encountered on socket operation is returned as **HRESULT** value. The [SocketError.GetStatus](socketerror_getstatus.md) method is used to convert an error from a socket operation to a [SocketErrorStatus](socketerrorstatus.md) enumeration value. Most of the [SocketErrorStatus](socketerrorstatus.md) enumeration values correspond to an error returned by the native Windows sockets operation.

## -examples

## -see-also
[SocketError](socketerror.md), [SocketError.GetStatus](socketerror_getstatus.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]