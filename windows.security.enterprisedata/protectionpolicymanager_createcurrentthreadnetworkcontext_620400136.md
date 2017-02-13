---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.CreateCurrentThreadNetworkContext(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Security.EnterpriseData.ThreadNetworkContext CreateCurrentThreadNetworkContext(System.String identity)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.CreateCurrentThreadNetworkContext

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Creates a [ThreadNetworkContext](threadnetworkcontext.md) protected to an enterprise identity. The creation of the context tags all network connections made thereafter on the current thread with the identity, and allows access to enterprise resources that are access controlled by the enterprise's policy.

## -parameters
### -param identity
The enterprise identity. This is an email address or domain that is managed. This may be returned from [GetPrimaryManagedIdentityForNetworkEndpoint](protectionpolicymanager_getprimarymanagedidentityfornetworkendpointasync.md); otherwise your app should use [IsIdentityManaged](protectionpolicymanager_isidentitymanaged.md) to confirm that an email address or domain is managed.

## -returns
The protected network context. The app must call [ThreadNetworkContext.Close](threadnetworkcontext_close.md) after access to the resource is completed.

## -remarks

## -examples

## -see-also
[GetPrimaryManagedIdentityForNetworkEndpoint](protectionpolicymanager_getprimarymanagedidentityfornetworkendpointasync.md), [IsIdentityManaged](protectionpolicymanager_isidentitymanaged.md), [ThreadNetworkContext.Close](threadnetworkcontext_close.md)

## -capabilities
enterpriseDataPolicy