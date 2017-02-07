---
-api-id: T:Windows.System.VirtualKey
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.System.VirtualKey : int
-->

# VirtualKey

## -description
Specifies the values for each virtual key.

The keys listed below are *virtual*, which means that they are not the physical keys or buttons on an attached keyboard or device, but an abstract mapping of those keys that may be connected to hardware that provides either those keys and buttons or an interface that simulates their physical behavior (such as an onscreen touch keyboard).

## -enum-fields
### -field None:0
No virtual key value.

### -field LeftButton:1
The left mouse button.

### -field RightButton:2
The right mouse button.

### -field Cancel:3
The cancel key or button
<!--It's not clear why you sometimes say "key", sometimes "button", and sometimes "key or button". Is there a consistent rationale for these distinctions?-->
.

### -field MiddleButton:4
The middle mouse button.

### -field XButton1:5
An additional "extended" device key or button (for example, an additional mouse button).

### -field XButton2:6
An additional "extended" device key or button (for example, an additional mouse button).

### -field Back:8
The virtual back key or button.

### -field Tab:9
The Tab key.

### -field Clear:12
The Clear key or button.

### -field Enter:13
The Enter key.

### -field Shift:16
The Shift key. This is the general Shift case, applicable to key layouts with only one Shift key or that do not need to differentiate between left Shift and right Shift keystrokes.

### -field Control:17
The Ctrl key. This is the general Ctrl case, applicable to key layouts with only one Ctrl key or that do not need to differentiate between left Ctrl and right Ctrl keystrokes.

### -field Menu:18
The menu key or button.

### -field Pause:19
The Pause key or button.

### -field CapitalLock:20
The Caps Lock key or button.

### -field Kana:21
The Kana symbol key-shift button
<!--I am not familiar with the term "key shift button" and I don't find it used anywhere else. Is there a more commonly used term for this?-->
.

### -field Hangul:21
The Hangul symbol key-shift button.

### -field Junja:23
The Junja symbol key-shift button.

### -field Final:24
The Final symbol key-shift button.

### -field Hanja:25
The Hanja symbol key shift button.

### -field Kanji:25
The Kanji symbol key-shift button.

### -field Escape:27
The Esc key.

### -field Convert:28
The convert button or key.

### -field NonConvert:29
The nonconvert button or key.

### -field Accept:30
The accept button or key.

### -field ModeChange:31
The mode change key.

### -field Space:32
The Spacebar key or button.

### -field PageUp:33
The Page Up key.

### -field PageDown:34
The Page Down key.

### -field End:35
The End key.

### -field Home:36
The Home key.

### -field Left:37
The Left Arrow key.

### -field Up:38
The Up Arrow key.

### -field Right:39
The Right Arrow key.

### -field Down:40
The Down Arrow key.

### -field Select:41
The Select key or button.

### -field Print:42
The Print key or button.

### -field Execute:43
The execute key or button.

### -field Snapshot:44
The snapshot key or button.

### -field Insert:45
The Insert key.

### -field Delete:46
The Delete key.

### -field Help:47
The Help key or button.

### -field Number0:48
The number "0" key.

### -field Number1:49
The number "1" key.

### -field Number2:50
The number "2" key.

### -field Number3:51
The number "3" key.

### -field Number4:52
The number "4" key.

### -field Number5:53
The number "5" key.

### -field Number6:54
The number "6" key.

### -field Number7:55
The number "7" key.

### -field Number8:56
The number "8" key.

### -field Number9:57
The number "9" key.

### -field A:65
The letter "A" key.

### -field B:66
The letter "B" key.

### -field C:67
The letter "C" key.

### -field D:68
The letter "D" key.

### -field E:69
The letter "E" key.

### -field F:70
The letter "F" key.

### -field G:71
The letter "G" key.

### -field H:72
The letter "H" key.

### -field I:73
The letter "I" key.

### -field J:74
The letter "J" key.

### -field K:75
The letter "K" key.

### -field L:76
The letter "L" key.

### -field M:77
The letter "M" key.

### -field N:78
The letter "N" key.

### -field O:79
The letter "O" key.

### -field P:80
The letter "P" key.

### -field Q:81
The letter "Q" key.

### -field R:82
The letter "R" key.

### -field S:83
The letter "S" key.

### -field T:84
The letter "T" key.

### -field U:85
The letter "U" key.

### -field V:86
The letter "V" key.

### -field W:87
The letter "W" key.

### -field X:88
The letter "X" key.

### -field Y:89
The letter "Y" key.

### -field Z:90
The letter "Z" key.

### -field LeftWindows:91
The left Windows key.

### -field RightWindows:92
The right Windows key.

### -field Application:93
The application key or button.

### -field Sleep:95
The sleep key or button.

### -field NumberPad0:96
The number "0" key as located on a numeric pad.

### -field NumberPad1:97
The number "1" key as located on a numeric pad.

### -field NumberPad2:98
The number "2" key as located on a numeric pad.

### -field NumberPad3:99
The number "3" key as located on a numeric pad.

### -field NumberPad4:100
The number "4" key as located on a numeric pad.

### -field NumberPad5:101
The number "5" key as located on a numeric pad.

### -field NumberPad6:102
The number "6" key as located on a numeric pad.

### -field NumberPad7:103
The number "7" key as located on a numeric pad.

### -field NumberPad8:104
The number "8" key as located on a numeric pad.

### -field NumberPad9:105
The number "9" key as located on a numeric pad.

### -field Multiply:106
The multiply (*) operation key as located on a numeric pad.

### -field Add:107
The add (+) operation key as located on a numeric pad.

### -field Separator:108
The separator key as located on a numeric pad.

### -field Subtract:109
The subtract (-) operation key as located on a numeric pad.

### -field Decimal:110
The decimal (.) key as located on a numeric pad.

### -field Divide:111
The divide (/) operation key as located on a numeric pad.

### -field F1:112
The F1 function key.

### -field F2:113
The F2 function key.

### -field F3:114
The F3 function key.

### -field F4:115
The F4 function key.

### -field F5:116
The F5 function key.

### -field F6:117
The F6 function key.

### -field F7:118
The F7 function key.

### -field F8:119
The F8 function key.

### -field F9:120
The F9 function key.

### -field F10:121
The F10 function key.

### -field F11:122
The F11 function key.

### -field F12:123
The F12 function key.

### -field F13:124
The F13 function key.

### -field F14:125
The F14 function key.

### -field F15:126
The F15 function key.

### -field F16:127
The F16 function key.

### -field F17:128
The F17 function key.

### -field F18:129
The F18 function key.

### -field F19:130
The F19 function key.

### -field F20:131
The F20 function key.

### -field F21:132
The F21 function key.

### -field F22:133
The F22 function key.

### -field F23:134
The F23 function key.

### -field F24:135
The F24 function key.

### -field NavigationView:136
The navigation up button.

### -field NavigationMenu:137
The navigation menu button.

### -field NavigationUp:138
The navigation up button.

### -field NavigationDown:139
The navigation down button.

### -field NavigationLeft:140
The navigation left button.

### -field NavigationRight:141
The navigation right button.

### -field NavigationAccept:142
The navigation accept button.

### -field NavigationCancel:143
The navigation cancel button.

### -field NumberKeyLock:144
The Num Lock key.

### -field Scroll:145
The Scroll Lock (ScrLk) key.

### -field LeftShift:160
The left Shift key.

### -field RightShift:161
The right Shift key.

### -field LeftControl:162
The left Ctrl key.

### -field RightControl:163
The right Ctrl key.

### -field LeftMenu:164
The left menu key.

### -field RightMenu:165
The right menu key.

### -field GoBack:166
The go back key.

### -field GoForward:167
The go forward key.

### -field Refresh:168
The refresh key.

### -field Stop:169
The stop key.

### -field Search:170
The search key.

### -field Favorites:171
The favorites key.

### -field GoHome:172
The go home key.

### -field GamepadA:195
The gamepad A button.

### -field GamepadB:196
The gamepad B button.

### -field GamepadX:197
The gamepad X button.

### -field GamepadY:198
The gamepad Y button.

### -field GamepadRightShoulder:199
The gamepad right shoulder.

### -field GamepadLeftShoulder:200
The gamepad left shoulder.

### -field GamepadLeftTrigger:201
The gamepad left trigger.

### -field GamepadRightTrigger:202
The gamepad right trigger.

### -field GamepadDPadUp:203
The gamepad d-pad up.

### -field GamepadDPadDown:204
The gamepad d-pad down.

### -field GamepadDPadLeft:205
The gamepad d-pad left.

### -field GamepadDPadRight:206
The gamepad d-pad right.

### -field GamepadMenu:207
The gamepad menu button.

### -field GamepadView:208
The gamepad view button.

### -field GamepadLeftThumbstickButton:209
The gamepad left thumbstick button.

### -field GamepadRightThumbstickButton:210
The gamepad right thumbstick button.

### -field GamepadLeftThumbstickUp:211
The gamepad left thumbstick up.

### -field GamepadLeftThumbstickDown:212
The gamepad left thumbstick down.

### -field GamepadLeftThumbstickRight:213
The gamepad left thumbstick right.

### -field GamepadLeftThumbstickLeft:214
The gamepad left thumbstick left.

### -field GamepadRightThumbstickUp:215
The gamepad right thumbstick up.

### -field GamepadRightThumbstickDown:216
The gamepad right thumbstick down.

### -field GamepadRightThumbstickRight:217
The gamepad right thumbstick right.

### -field GamepadRightThumbstickLeft:218
The gamepad right thumbstick left.


## -remarks

## -examples

## -see-also