---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.IsRoamableProtectionEnabled(System.String)
-api-type: winrt method
---

<!-- Method syntax
public bool IsRoamableProtectionEnabled(System.String identity)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.IsRoamableProtectionEnabled

## -description
Determines whether the policy is configured to protect files that are copied to removable drives by using [Azure Information Protection](https://www.microsoft.com/cloud-platform/azure-information-protection).

## -parameters
### -param identity
The enterprise identity.

## -returns
**true** if files will be protected by using RMS keys, otherwise **false**.

## -remarks
If this method returns **false**, files that users copy to removable drives will be protected by using local keys and those files won't be accessible on those drives to other users on the current device or, if the drive is connected to another device, to anyone on that newly connected device.  If this method returns **false**, you could (optionally) let users know about this limitation by presenting this information in a dialog box.

## -examples

## -see-also
