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
For more information about the **Deferral** class, see the section about deferrals in [App lifecycle](/windows/uwp/launch-resume/app-lifecycle#reentering-the-background-state) and the [ExtendedExecution sample](https://github.com/Microsoft/Windows-universal-samples/blob/master/Samples/ExtendedExecution/cs/Scenario4_MultipleTasks.xaml.cs).

Javascript apps should not allow navigation before completing a [DeferralCompletedHandler](deferralcompletedhandler.md). Doing so could cause an app to crash and should be considered a programming error.

## -examples

## -see-also
[App lifecycle](/windows/uwp/launch-resume/app-lifecycle#reentering-the-background-state),[ExtendedExecution sample](https://github.com/Microsoft/Windows-universal-samples/blob/master/Samples/ExtendedExecution/cs/Scenario4_MultipleTasks.xaml.cs),[IClosable](iclosable.md), [DeferralCompletedHandler](deferralcompletedhandler.md)