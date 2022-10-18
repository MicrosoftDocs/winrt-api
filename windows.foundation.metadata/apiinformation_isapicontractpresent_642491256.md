---
-api-id: M:Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent(System.String,System.UInt16,System.UInt16)
-api-type: winrt method
---

<!-- Method syntax
public bool IsApiContractPresent(System.String contractName, System.UInt16 majorVersion, System.UInt16 minorVersion)
-->

# Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent

## -description
Returns true or false to indicate whether the API contract with the specified name and major and minor version number is present.

## -parameters
### -param contractName
The name of the API contract.

### -param majorVersion
The major version number of the API contract.

### -param minorVersion
The minor version number of the API contract.

## -returns
**True** if the specified API contract is present; otherwise, **false**.

## -remarks

For details on finding and using API contracts, see [Programming with extension SDKs](/uwp/extension-sdks/device-families-overview#api-contracts-and-how-to-look-them-up).

## -examples
```cs
if (Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.ApplicationModel.Calls.CallsVoipContract", 1, 1))
{
    Debug.WriteLine("Windows.ApplicationModel.Calls.CallsVoipContract v1.1 found");
}
else
{
    Debug.WriteLine("Windows.ApplicationModel.Calls.CallsVoipContract v1.1 NOT found");
}
```

## -see-also
[IsApiContractPresent(String, UInt16)](apiinformation_isapicontractpresent_1836214132.md)