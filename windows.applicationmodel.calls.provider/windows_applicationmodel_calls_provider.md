---
-api-id: N:Windows.ApplicationModel.Calls.Provider
-api-type: winrt namespace
---

# Windows.ApplicationModel.Calls.Provider

## -description

Enables an application to record and provide information about the origin of a phone call.

## -remarks

This namespace is used to set information such as the call location and the category of the call. You can also use this API to select which app should handle determine the call's origin. This gives the user the ability to determine whether or not to accept a call based on some information about who is calling. For example, a user can choose to ignore a call if an app informs them that a certain call has been identified as an advertising agency.

In order to use this API, you will need to define a new category in your application manifest file.

```xml
<Extension Category="windows.phoneCallOriginProvider" />
```

## -examples

## -see-also

## -capabilities

phoneCallHistory, phoneCallHistorySystem
