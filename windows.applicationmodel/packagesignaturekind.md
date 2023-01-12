---
-api-id: T:Windows.ApplicationModel.PackageSignatureKind
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.PackageSignatureKind : int
-->

# PackageSignatureKind

## -description
Provides information about the package's signature and the kind of certificate used to create it.

## -enum-fields
### -field None:0
The package is not signed. For example, a Visual Studio project that is running from layout (F5).

### -field Developer:1
The package is signed with a trusted certificate that is not categorized as `Enterprise`, `Store`, or `System`. For example, an application signed by an ISV for distrubution outside of the Microsoft Store.

### -field Enterprise:2
The package is signed using a certificate issued by a root authority that has higher verification requirements than general public authorities. 

### -field Store:3
The package is signed by the Windows Store.

### -field System:4
The package is signed by a certificate that's also used to sign the Windows Operating System. These packages can have additional capabilities not granted to normal apps. For example, the built-in Settings app.

## -remarks
Other than for reporting purposes, these values are not particularly useful to most applications. Any value other than `None` indicates that the package is signed with a trusted certificate, since it is not possible to install a package that is signed with an untrusted or otherwise invalid certificate. 

The `Developer` option does not imply that the app is only for developers or that it is a "development build"; it simply means that the developer chose not to publish in the Microsoft Store (and is not using a special `Enterprise` certificate). Similarly, the `Enterprise` option does not imply that the app is only for Enterprises or that it is delivered via a device  management solution such as InTune; it simply means that the developer chose to use a special "Enterprise" certificate.

## -examples

## -see-also
[Package.SignatureKind](package_signaturekind.md)
