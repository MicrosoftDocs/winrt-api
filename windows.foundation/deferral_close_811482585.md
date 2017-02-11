---
-api-id: M:Windows.Foundation.Deferral.Close
-api-type: winrt method
---

<!-- Method syntax
public void Close()
-->

# Windows.Foundation.Deferral.Close

## -description
If the [DeferralCompletedHandler](deferralcompletedhandler.md) has not yet been invoked, this will call it and drop the reference to the delegate.

## -remarks
If the [DeferralCompletedHandler](deferralcompletedhandler.md) has not yet been invoked, this will call it and drop the reference to the delegate. Otherwise, since [Close](deferral_close.md) must be safe to call multiple times, this will simply succeed without doing anything.

## -examples

## -see-also
[DeferralCompletedHandler](deferralcompletedhandler.md)