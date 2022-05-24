---
-api-id: M:Windows.System.User.CheckUserAgeConsentGroupAsync(Windows.System.UserAgeConsentGroup)
-api-type: winrt method
---

# Windows.System.User.CheckUserAgeConsentGroupAsync(Windows.System.UserAgeConsentGroup)

<!--
public Windows.Foundation.IAsyncOperation<Windows.System.UserAgeConsentResult> CheckUserAgeConsentGroupAsync (Windows.System.UserAgeConsentGroup consentGroup);
-->


## -description

Retrieves a value indicating whether the user belongs to the specified user age consent group.

## -parameters

### -param consentGroup

A value from the [UserAgeConsentGroup](userageconsentgroup.md) indicating the age consent group for which user membership is queried.

## -returns

An asynchronous operation that returns a [UserAgeConsentResult](userageconsentresult.md) on completion.

## -remarks

The information returned from this API allows you to design a more suitable experience for children and minors using your app.

This API requires the **UserAccountInformation** capability. For more information, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations).

## -see-also

## -examples


