---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.GetPrimaryManagedIdentityForIdentity(System.String)
-api-type: winrt method
---

<!-- Method syntax
public string GetPrimaryManagedIdentityForIdentity(System.String identity)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.GetPrimaryManagedIdentityForIdentity

## -description
Gets the parent or primary identity of a given child or secondary identity.

## -parameters
### -param identity
The child or secondary identity that you want to use to get the parent or primary identity.

## -returns
The parent or primary identity.

## -remarks
Most policies have a list of identities. The primary identity usually appears first in that list. The secondary identities usually appear after the primary identity. Those secondary identities are, in a sense "owned" by the primary identity.

## -examples

## -see-also