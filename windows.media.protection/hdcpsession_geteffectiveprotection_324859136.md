---
-api-id: M:Windows.Media.Protection.HdcpSession.GetEffectiveProtection
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IReference<Windows.Media.Protection.HdcpProtection> GetEffectiveProtection()
-->

# Windows.Media.Protection.HdcpSession.GetEffectiveProtection

## -description
Returns the effective protection of the [HdcpSession](hdcpsession.md) instance.

## -returns
The level of protection that the [HdcpSession](hdcpsession.md) instance currently has.

## -remarks
To get the output of this method, assign it to a variable of type **HdcpProtection?**:

```csharp
HdcpProtection? protection = hdcpSession.GetEffectiveProtection();
```

Then, to get the actual value of the enumeration, use `protection.Value`.

## -examples

## -see-also
