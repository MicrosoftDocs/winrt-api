---
-api-id: M:Windows.UI.Xaml.Media.Animation.Storyboard.GetCurrentState
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Media.Animation.ClockState GetCurrentState()
-->

# Windows.UI.Xaml.Media.Animation.Storyboard.GetCurrentState

## -description
Gets the clock state of the [Storyboard](storyboard.md).



## -returns
One of the enumeration values. Can be: **Active**, **Filling**, or **Stopped**.

## -remarks
This method is useful if you want to modify an animation's properties at runtime, before the animation is started. An animation that is stopped (GetCurrentState returns **ClockState.Stopped**) can still be modified. An animation that is running (GetCurrentState returns either **ClockState.Active** or **ClockState.Filling**) cannot be modified, and you'll get an error if you try.

### Notes for previous versions

<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 462632-->
> **Windows 8**

An animation can have an optional [BeginTime](timeline_begintime.md) value, which modifies when the animation actually starts to affect values compared to when the controlling storyboard is started. Even if the running time has not reached the [BeginTime](timeline_begintime.md) yet, it's illegal to modify the properties of the animation once the storyboard starts it. For Windows 8, calling GetCurrentState for a running animation where the running time has not reached the [BeginTime](timeline_begintime.md) always returns **ClockState.Stopped**. Normally, it's legal to modify a **Stopped** animation's properties, but in this particular case it's not, so using GetCurrentState to determine whether it's legal to modify the animation is not always accurate. Starting with Windows 8.1, calling GetCurrentState for an animation that's been started by its storyboard always returns **ClockState.Active**, even if the [BeginTime](timeline_begintime.md) value exists and hasn't been reached. The circumstances in which GetCurrentState returns **ClockState.Filling** remain the same.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

## -examples

## -see-also
[GetCurrentTime](storyboard_getcurrenttime_1338472985.md), [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations)
