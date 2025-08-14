---
-api-id: M:Windows.Security.Authentication.Web.Core.WebAuthenticationCoreManager.AddAccountWithTransferTokenAsync(Windows.Security.Authentication.Web.Core.WebAuthenticationTransferTokenRequest)
-api-type: winrt method
---

# Windows.Security.Authentication.Web.Core.WebAuthenticationCoreManager.AddAccountWithTransferTokenAsync(Windows.Security.Authentication.Web.Core.WebAuthenticationTransferTokenRequest)

<!--
public static Windows.Foundation.IAsyncOperation<Windows.Security.Authentication.Web.Core.WebAuthenticationAddAccountResult> AddAccountWithTransferTokenAsync (Windows.Security.Authentication.Web.Core.WebAuthenticationTransferTokenRequest request);
-->

## -description

A method that adds a user's account to a cloud device using a transfer token.

## -parameters

### -param request

The [WebAuthenticationTransferTokenRequest](webauthenticationtransfertokenrequest.md) object that contains the transfer token blob and the account provider ID.

## -returns

Returns an **IAsyncOperation** that, on completion, returns a [WebAuthenticationAddAccountResult](webauthenticationaddaccountresult.md) object.

## -remarks

This API can be used to redeem a transfer token blob to provision a Web Account on Windows for seamless single sign-on resulting in the provisioning of the desired Web Account.

## -see-also

[WebAuthenticationAddAccountResult](webauthenticationaddaccountresult.md)

## -examples

The following example demonstrates how to use the **AddAccountWithTransferTokenAsync** method to add a user's account to a cloud device using a transfer token.

The user has purchased a game from the Microsoft Store and would like to stream the game via game streaming service A, which leverages a pre-provisioned Windows VM for the game to run from. Upon user consent to share credentials with the game streaming provider A, game streaming provider A’s application requests the transfer token blob for the intended Windows VM and redeems it on the device to provision the user web account with the **AddAccountWithTransferTokenAsync** method.

```cpp
class AddAccountCloudDevice
{ 
public:
  winrt::Windows::Security::Credentials::WebAccount AddAndRetrieveAccount(
  winrt::hstring transferToken,
  winrt::hstring accountProviderId,
  winrt::hstring correlationId);
 
  HRESULT LogError([[maybe_unused]] winrt::Windows::Security::Authentication::Web::Core::WebProviderError 
error)
  { 
     return E_NOTIMPL;
  };
  HRESULT LogStatus([[maybe_unused]] winrt::Windows::Security::Authentication::Web::Core::
WebAuthenticationAddAccountStatus status)
  { 
    return E_NOTIMPL;
  };
};
winrt::WebAccount AddAccountCloudDevice::AddAndRetrieveAccount(
  winrt::hstring transferToken,
  winrt::hstring accountProviderId,
  winrt::hstring correlationId)
{ 
  /* Prior to this function/execution of this program: Outside of this cloud device, we had a user sign in with
  * their MSA account into our game. We need their account on this cloud device as well, to make the gaming
  * experience seamless for the end user.
  * To facilitate this, outside this device we used the existing GetTokenSilentlyAsync API provided by WAM, with a special scope,
  * to receive a transfer token. (This scope is only used for transfer tokens.)
  * Now that we are within the cloud device, we can make use of the aforementioned transfer token, and the API
  * AddAccountWithTransferTokenAsync made available by WAM, to add the user's account on this device as well,
  * so that gaming within this cloud device is not halted by a repeated sign-in request.
  */
 
  // We need to create a transfer token request to facilitate adding the user's MSA account to this cloud device.
  // First, find the provider that owns the account that we want to add.
  winrt::WebAccountProvider provider = 
winrt::WebAuthenticationCoreManager::FindAccountProviderAsync(accountProviderId).get();
 
  if (!provider)
  throw winrt::hresult_error(NTE_BAD_PROVIDER);
 
  // Now we can create a transfer token request - if we have a correlation ID, incorporate this into the request
  winrt:: WebAuthenticationTransferTokenRequest request = correlationId.empty()
  ? winrt::WebAuthenticationTransferTokenRequest(provider, transferToken)
  : winrt::WebAuthenticationTransferTokenRequest(provider, transferToken, correlationId);
 
  winrt::IAsyncOperation<winrt:: WebAuthenticationAddAccountResult> response = winrt::WebAuthenticationCoreManager::AddAccountWithTransferTokenAsync(request);
 
  // Address other tasks in this space
  winrt:: WebAuthenticationAddAccountResult result = response.get();
 
  // Act on result object
  switch (result.ResponseStatus())
  { 
 
    case WebAuthenticationAddAccountStatus_Success:
      return result.ResponseData().WebAccount();
      break;
 
    case WebAuthenticationAddAccountStatus_Error:
      LogError(result.ResponseError());
      break;
 
    default:
      LogStatus(result.ResponseStatus());
      break;
  }
 
  return nullptr;
}
```
