---
-api-id: M:Windows.Foundation.GuidHelper.Equals(System.Guid@,System.Guid@)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public bool GuidHelper.Equals(Guid target, Guid value)
-->

# Windows.Foundation.GuidHelper.Equals

## -description
Compares two **Guid** values for equality.

## -parameters

### -param target
A **Guid** value to compare with the other argument.

### -param value
A **Guid** value to compare with the other argument.

## -returns
`true` if the two **Guid** values are equal, otherwise `false`.

## -remarks
In JavaScript, **Guid** is projected as a string.

## -see-also

## -examples
```javascript
function isMyProvider(mobileAccount) { /* type MobileBroadbandAccount */
    return Windows.Foundation.GuidHelper.equals(
        mobileAccount.serviceProviderGuid,
        "9e8e2757-5fa6-4e19-b2bf-8b1054c2d751");
}
```
