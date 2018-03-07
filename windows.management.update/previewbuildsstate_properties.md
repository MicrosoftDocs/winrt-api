---
-api-id: P:Windows.Management.Update.PreviewBuildsState.Properties
-api-type: winrt property
---

<!-- Property syntax.
public ValueSet Properties { get; }
-->

# Windows.Management.Update.PreviewBuildsState.Properties

## -description
Contains properties associated with a [PreviewBuildsState](previewbuildsstate.md) for registering a device with the WindowsInsiderProgram. 

## -property-value
A ValueSet of properties.

## -remarks
Property values include:

| Name | Type | Description | 
|------|------|-------------|
| ActivationCode | String | The activation code that must be entered into the Windows Insider Program Device Portal to opt their device into the program. |
| ActivationCodeExpirationDateTime | DateTime | The expiration date of the activation code. A new activation code must be requested once this one has expired. |
| ErrorMessage | String | A message that should be displayed to the user to inform them of issues with their device configuration. | 
| PreviewBuildsEnabled | Integer | A value greater than `0` indicates that the device is currently opted into the Windows Insider Program and will receive preview builds. |
| StatusMessage | String | A message that should be displayed to the user to inform them of general information. |

## -see-also

## -examples

