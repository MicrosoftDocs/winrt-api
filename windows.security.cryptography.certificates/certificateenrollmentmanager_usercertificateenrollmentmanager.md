---
-api-id: P:Windows.Security.Cryptography.Certificates.CertificateEnrollmentManager.UserCertificateEnrollmentManager
-api-type: winrt property
---

<!-- Property syntax
public Windows.Security.Cryptography.Certificates.UserCertificateEnrollmentManager UserCertificateEnrollmentManager { get; }
-->

# Windows.Security.Cryptography.Certificates.CertificateEnrollmentManager.UserCertificateEnrollmentManager

## -description
Gets the associated [UserCertificateEnrollmentManager](usercertificateenrollmentmanager.md).

## -property-value
The associated [UserCertificateEnrollmentManager](usercertificateenrollmentmanager.md).

## -remarks
This API installs certificates in the app's certificate store. Certificates in an app's certificate store are only discoverable and usable by that app. To install a certificate in the user's certificate store, enable the **sharedUserCertificates** capability and use the [UserCertificateEnrollmentManager](usercertificateenrollmentmanager.md) class.

## -examples

## -see-also


## -capabilities
sharedUserCertificates