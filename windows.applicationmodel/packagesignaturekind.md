---
-api-id: T:Windows.ApplicationModel.PackageSignatureKind
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.PackageSignatureKind : int
-->

# PackageSignatureKind

## -description
Specifies the ways that an app package may be signed.

## -enum-fields
### -field None:0
Not signed.

### -field Developer:1
Deployed in your development environment. The package is signed with a private certificate.

### -field Enterprise:2
Signed using a certificate used in enterprises.

### -field Store:3
Signed by the Windows Store.

### -field System:4
Built-in system app.


## -remarks

## -examples

## -see-also
[Package.SignatureKind](package_signaturekind.md)