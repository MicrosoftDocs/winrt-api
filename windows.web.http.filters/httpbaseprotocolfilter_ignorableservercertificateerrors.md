---
-api-id: P:Windows.Web.Http.Filters.HttpBaseProtocolFilter.IgnorableServerCertificateErrors
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.Security.Cryptography.Certificates.ChainValidationResult> IgnorableServerCertificateErrors { get; }
-->

# Windows.Web.Http.Filters.HttpBaseProtocolFilter.IgnorableServerCertificateErrors

## -description
Get a vector of SSL server certificate errors that the app might subsequently choose to ignore.

## -property-value
A vector of SSL server certificate errors that the app might subsequently choose to ignore.

## -remarks
SSL server certificate errors should only be ignored in advanced scenarios. Disregarding server certificate errors classified as either **Ignorable** or **Fatal** may result in the loss of privacy or integrity of the content passed over the SSL session.

## -examples

## -see-also
