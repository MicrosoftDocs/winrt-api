---
-api-id: P:Windows.Security.Cryptography.Certificates.CertificateQuery.EnhancedKeyUsages
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<string> EnhancedKeyUsages { get; }
-->

# Windows.Security.Cryptography.Certificates.CertificateQuery.EnhancedKeyUsages

## -description
Gets a collection of object identifiers (OIDs) for the enhanced key usage extension to search for.

## -property-value
A collection of object identifiers (OIDs) for the enhanced key usage extension to search for.

## -remarks

## -examples
```javascript
var query = new Windows.Security.Cryptography.Certificates.CertificateQuery();
query.issuerName = "Consoto Bank Issuing CA";
var enhancedKeyUsages = query.enhancedKeyUsages;
enhancedKeyUsage[0] = "1.3.6.1.5.5.7.3.2"; // client auth
var certificates;
Windows.Security.Cryptography.Certificates.
    CertificateStores.findAllAsync(query).done(function(queriedCertificates)
{
    certificates = queriedCertificates;
}, 
function(e) 
{
    WinJS.log("FindAllAsync failed, error:" + e.number + e.message);
});
```



## -see-also
