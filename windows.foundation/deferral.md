---
-api-id: T:Windows.Foundation.Deferral
-api-type: winrt class
---

<!-- Class syntax.
public class Deferral : Windows.Foundation.IClosable, Windows.Foundation.IDeferral
-->

# Windows.Foundation.Deferral

## -description
Stores a [DeferralCompletedHandler](deferralcompletedhandler.md) to be invoked upon completion of the deferral and manipulates the state of the deferral.

## -remarks
Javascript apps should not allow navigation before completing a [DeferralCompletedHandler](deferralcompletedhandler.md). Doing so could cause an app to crash and should be considered a programming error.

## -examples

## -see-also
[IClosable](iclosable.md), [DeferralCompletedHandler](deferralcompletedhandler.md)