---
-api-id: P:Windows.Management.Deployment.RegisterPackageOptions.ExpectedDigests
-api-type: winrt property
---

# Windows.Management.Deployment.RegisterPackageOptions.ExpectedDigests

<!--
public System.Collections.Generic.IDictionary<System.Uri,string> ExpectedDigests { get; }
-->


## -description

Gets a dictionary that maps the URIs associated with a **RegisterPackageOptions** with the corresponding digest string.

## -property-value

A dictionary where the key is a URI and the value is a string representing the digest associated with the URI.

## -remarks

A digest string is a hashed representation of the contents of the package URI. Get the digest for a package URI by calling [IAppxDigestProvider::GetDigest](/windows/win32/api/appxpackaging/nf-appxpackaging-iappxdigestprovider-getdigest.md) and then add the value to the collection returned by **ExpectedDigests**. Digests may be specified for any or all URIs included in the **RegisterPackageOptions**.  If a digest is specified for a URI and the content at that URI doesn’t match its digest, the deployment operation will fail.  If a digest is not specified for a URI, then the package manager will proceed without validating its digest.  If a digest is specified for a URI which the package manager doesn’t need to read, the digest is ignored. 

## -see-also

## -examples


