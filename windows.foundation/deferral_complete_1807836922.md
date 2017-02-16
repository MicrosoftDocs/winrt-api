---
-api-id: M:Windows.Foundation.Deferral.Complete
-api-type: winrt method
---

<!-- Method syntax
public void Complete()
-->

# Windows.Foundation.Deferral.Complete

## -description
If the [DeferralCompletedHandler](deferralcompletedhandler.md) has not yet been invoked, this will call it and drop the reference to the delegate.

## -remarks
If the [DeferralCompletedHandler](deferralcompletedhandler.md) has not yet been invoked, this will call it and drop the reference to the delegate. Otherwise, it will throw a programming error exception.

## -examples

## -see-also
[DeferralCompletedHandler](deferralcompletedhandler.md)