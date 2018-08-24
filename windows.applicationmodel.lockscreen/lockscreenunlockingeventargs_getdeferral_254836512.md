---
-api-id: M:Windows.ApplicationModel.LockScreen.LockScreenUnlockingEventArgs.GetDeferral
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.ApplicationModel.LockScreen.LockScreenUnlockingDeferral GetDeferral()
-->

# Windows.ApplicationModel.LockScreen.LockScreenUnlockingEventArgs.GetDeferral

## -description
Gets a [LockScreenUnlockingDeferral](lockscreenunlockingdeferral.md), which defers the unlocking of the device.
To show an unlock animation, your lock screen app must:

+ Register to be notified of unlocking via the [Unlocking](lockapplicationhost_unlocking.md) event.
+ In the Unlocking event handler, call [GetDeferral](lockscreenunlockingeventargs_getdeferral_254836512.md).
+ Kick off an animation.   + When that animation completes, call [Complete](lockscreenunlockingdeferral_complete_1807836922.md) on the deferral to end the deferral.
   + Note: If the animation takes too long, your lock screen app will be terminated by the system and potentially removed as the user’s default lock app.



## -returns
An unlock deferral.

## -remarks

## -examples

## -see-also
