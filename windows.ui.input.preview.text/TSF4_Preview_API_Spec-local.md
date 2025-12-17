TSF4 API
===

# Background

The Text Services Framework (TSF) enables providers of text input and/or text services, aka IMEs, to access focused textboxes(\*)
for their functions. The current public TSF API for IMEs was introduced in Windows XP and designed to load and run IMEs 
in-proc in the every UI app. That design no longer meets the privacy and security standards as it allows 3rd party components (IMEs)
enjoy elevation and integrity level of their host processes. We're going to address that by enabling (and eventually forcing) 
TSF IMEs to run as standalone processes, contained and restricted in some activities while also granted with particular 
privileges to support their purpose. This move implies a drastic change in the nature of communication between IMEs and textboxes 
from "same thread, synchronous" to "remote, asynchronous" and it calls for a brand new TSF API facing IMEs. 
This document describes the proposed API in its interim state as it's going to be introduced and subsequently evolve 
in the scope of Limited Access Feature (LAF) process. The ultimate goal for this API (further referred to as TSF4 API) 
is to replace and allow deprecation of the current public TSF IME API (internally known as TSF1 API).

(*) textbox - a UI element capable of accepting text input and/or services.

# Conceptual pages (How To)

An Input Method Editor (IME) is a software component that leverages the Text Services Framework to access textual content of focused UI. 
Most commonly, IMEs process input of particular modality, such as keyboard, handwriting and voice inputs, 
to convert that into text input to the focused control. Alternatively or in addition to text input, IMEs can also be used to 
analyze textual content and provide various text services such as prediction, autocorrection, translation, rewriting, etc.
To enable a great input experience for all users, Microsoft produces a variety of IMEs that ship in-box for a wide range of input languages.
In addition to the in-box IMEs, you can build your own custom IMEs that users can install and use just like an in-box IME.
The purpose of these guidelines and requirements is to assist you in developing such custom IME.

## Kinds Of IMEs. Rules of Engagement.

First, you need to decide on the kind of IME you want to implement. While there can be great diversity amongst IMEs 
by the input sources they use, interactivity methods they employ, and services they offer, the TSF recognizes these 
two kinds based on their involvement in processing keyboard input: Keyboard IMEs and Non-Keyboard IMEs.
All TSF4 IMEs are supposed to be registered as such upon installation. 
The exact mechanism and rules are TBD and out of the scope of this API spec.

### Keyboard IME
The most widely known and used kind, Keyboard IME, is one that produces text from keyboard input. 
Users enable Keyboard IMEs in Language Settings and then find and select them in the Input Switcher UI. 
When a Keyboard IME is active (selected in Input Switcher) and the input focus is in a UI control that accepts text input, 
TSF redirects keyboard input to the IME for processing. To ensure consistency of that UX, TSF also takes responsibity 
for managing Keyboard IME lifetime and ensuring its availability and readiness. With TSF4 IMEs being standalone apps, 
this means TSF starts enabled Keyboard IMEs for user session and tries to restart them after crashes.
When your Keyboard IME app starts, it would connect to the TSF system by creating an instance of TextInputService 
and use it to advertise its IME, or IMEs, by creating a KeyboardInputProcessor for each:

```cpp
constexpr PCWSTR inputProfileString = L"<langid>:{<clsid>}{<guid>}";
TextInputService textInputService = TextInputService::GetForCurrentThread();
KeyboardInputProcessor keyboardIme = textInputService.CreateKeyboardInputProcessor(inputProfileString);
```
where inputProfileString uniquely defines registered IME profile in the format described [here](https://learn.microsoft.com/en-us/windows/win32/tsf/querylayoutortipstring#:~:text=%3CLangID%201%3E%3A%7Bxxxxxxxx%2Dxxxx%2Dxxxx%2Dxxxx%2Dxxxxxxxxxxxx%7D%7Bxxxxxxxx%2Dxxxx%2Dxxxx%2Dxxxx%2Dxxxxxxxxxxxx%7D%3B).

Finally, to complete initialization, your IME would subscribe to KeyboardInputProcessor events and go idle 
until it receives an Activated event which is an indication of the IME activation by user:

```cpp
    keyboardIme.Activated(auto_revoke, [](const KeyboardInputProcessor& , auto&& ) {
        // Wake up and get ready to process keyboard input.
    });
    keyboardIme.Deactivated(auto_revoke, [](const KeyboardInputProcessor& , auto&& ) {
        // Hide and destroy UI, release other resources, hibernate with minimal footprint.
    });
    keyboardIme.KeyEventReceived(auto_revoke, [](const KeyboardInputProcessor& , const KeyEventReceivedEventArgs& args) {
        // Process the keyevent.
        bool consumed = false;

        // Use args.EditSession to insert text.

      
        // Call it handled if consuming the key, or unhandled otherwise to let the taregt app handle it.
        args.Handled(consumed);
    });
```

### Non-Keyboard IME
All IMEs that don't qualify as Keyboard IMEs subsequently called Non-Keyboard IMEs, or, more officially, Text Input Providers.
Examples of Non-Keyboard IMEs: handwriting (ink-to-text processor), dictation IME (voice-to-text processor), 
AI-powered Writing Assistant (text rewrite), Expressive Input IME (text input from user selection).
Contrary to Keyboard IMEs, instantiation and lifetime of Non-Keyboard IMEs is not managed by TSF and can be 
driven by various factor and settings defined by user. But, once a Non-Keyboard IME app starts in IME mode, 
it follows similar rules of engagement as with Keyboard IMEs. Just due to functional differences, instead of 
KeyboardInputProcessor, it creates a different communication object called TextInputProvider, and TSF considers 
the IME active from this point and until IME releases its TextInputProvider for good:

```cpp
TextInputService textInputService = TextInputService::GetForCurrentThread();
// The format of inputProfileString for TextInputProviders is TBD. Meanwhile, empty string is acceptable.
TextInputProvider textInputProvider = textInputService.CreateTextInputProvider(inputProfileString);
```
#### Subscription
IME's 'subscription' is the scope of  of input targets (apps and controls) the IME will see while active.
For Keyboard IMEs, it's implied universally to match user expectations for Keyboard IME availability.
On the contrary, non-keyboard IMEs can be rather diverse in their interests and capabilities, 
therefore they're offered this option to optimize that scope as they see fit.
Subscription is defined by a set of features that desired input target would explicitly or implicitly support or wouldn't support.
```cpp
// Get the current subscription. It starts with no limitations.
TextInputServiceSubscription subscription;
textInputProvider.GetSubscription(&subscription);
// Want textboxes that allow to read their content and suitable for inking over.
subscription.requiredEnabledFeatures |= TextBoxFeatures::ReadText | TextBoxFeatures::ShellHandwriting;
// Don't want textboxes which employ embedded UI for inking.
subscription.requiredDisabledFeatures |= TextBoxFeatures::EmbeddedHandwritingView;
// Update the subscription.
textInputProvider.SetSubscription(subscription);
```

## TextBox

**TextBox** is the commmon name for all UI elements that take input focus and accept text input and/or services.

### Input Focus

Your IME interacts with the current input target, such as focused textbox in the foreground app,
 and optionally monitors focus changes via the corresponding events:
```cpp
// KeyboardInputProcessor used in this example, but TextInputProvider offers the same events.
keyboardIme.FocusEntered(auto_revoke, [](const KeyboardInputProcessor& sender, const FocusEnteredEventArgs& args) {
    // Explore features and settings of the newly focused textbox, optionally adjust behavior and expectations.
    TextBoxInfo textBoxInfo = args.FocusedTextBoxInfo();
    printf("Focus In: textBoxId:%d (%ls)\n", textBoxInfo.Id().Value, textBoxInfo.AppName().c_str());
    auto sourceUrl = textBoxInfo.Url();
    if (is_known_url(sourceUrl))
    {
        // adjust IME behavior
    }
    // Check whether the textbox allows reading its content.
    if ((textBoxInfo.DisabledFeatures() & TextBoxFeatures::ReadText) == TextBoxFeatures::None)
    {
        // explore text around current selection/insertion point
    }
    // Check whether the textbox accepts text input.
    if ((textBoxInfo.DisabledFeatures() & TextBoxFeatures::WriteText) == TextBoxFeatures::None)
    {
        // Push current/default/applicable conversion mode to the focused context.
        if (textBoxInfo.InputScope() == CoreTextInputScope::Default)
        {
            sender.ConversionMode(TextConversionMode::NativeHalfWidth);
        }
        else
        {
            sender.ConversionMode(TextConversionMode::AlphanumericHalfWidth);
        }
    }
});
    
textInputProvider.FocusRemoved(auto_revoke, [](const TextInputProvider& , auto&& ) {
    // Hide IME UI, release other resources if applicable.
});
```

### TextBox Info

TextBoxInfo includes textbox identification (TextBoxId), origins (AppName, Url), static and dynamic settings.
Since the dynamic settings may change dynamically, IMEs can monitor those changes by listening to TextBoxInfoChanged event.
(This event is raised only while the TextBox is in focus. If the IME's functionality depends on particular 
TextBox settings, it's recommended to check out latest TextBoxInfo whenever the TextBox receives input focus.)

```cpp
textInputProvider.TextBoxInfoChanged(auto_revoke, [](const TextInputProvider& , const TextBoxInfoChangedEventArgs& args) {
    TextBoxInfo textBoxInfo = args.TextBoxInfo();
    // Re-check textBoxInfo properties of interest.
    // ... 
});
```

## Edit Session

Use `TextEditSession` to explore and edit content of the focused TextBox.
Think of it as an editable snapshot of the textbox content in its current state that IME can explore 
and update without worrying about external interference. IME can create it at will as long as there's 
a textbox in focus, mix read and write operations, and finally submit or cancel the updates.

### Starting

Both `KeyboardInputProcessor` and `TextInputProvider` have a method CreateEditSession() that creates one for the TextBox in focus.  

```cpp
if (textInputProvider.HasFocusedTextBox())
{
    TextEditSession editSession = textInputProvider.CreateEditSession();
    // use it
}
```
Although that method is available for both IME types, it's more common to use by Non-Keyboard ones
while Keyboard IMEs would typically use the edit session associated with keyevents they process:

```cpp
keyboardIme.KeyEventReceived(auto_revoke, [](const KeyboardInputProcessor& , const KeyEventReceivedEventArgs& args) {
    ...
    // Use args.EditSession to explore content around insertion point and insert text.
    TextEditSession editSession = args.EditSession();    
    ...
});
```
After obtaining a TextEditSession object, the IME is free to use it synchronously or otherwise, the session stays 
alive and valid until IME explicitly submits it or just releases the object (which is equivalent to canceling).

### Using

Probably the most common usage scenario is when IME receives an input event and obtains an edit session 
to help with conversion of that input event into text and to insert the result into the focused edibox.
In case of Keyboard IMEs, the input event is a keyevent delivered by the TSF:

```cpp
keyboardIme.KeyEventReceived(auto_revoke, [](const KeyboardInputProcessor& , const KeyEventReceivedEventArgs& args) {
    // Process the keyevent.
    bool consumed = false;

    // Use the edit session associated with the event. 
    // It's designated to carry 'keyevent payload' - the sum of content changes the IME makes in response to the keyevent.
    TextEditSession editSession = args.EditSession();
        
    // Get the current selection/insertion point where going to insert new character (or string).
    CoreTextRange selection;
    editSession.GetSelection(&selection);

    // If the conversion of input event into text is context-sensitive, 
    // explore some text around the selection.
    winrt::hstring textBeforeSelection;
    CoreTextRange rangeBeforeSelection{ 
        max(0, (selection.StartCaretPosition - 100)),       // begin
        selection.StartCaretPosition };                     // end
    textBeforeSelection = editSession.GetText(rangeBeforeSelection);

    winrt::hstring textAfterSelection;
    CoreTextRange rangeAfterSelection{ 
        selection.EndCaretPosition,                                         // begin
        min((selection.EndCaretPosition + 100), editSession.TextLength())}; // end
    textAfterSelection = editSession.GetText(rangeAfterSelection);
       
    winrt::hstring insertText;
    // Convert the input event into text.
    // Set 'consumed' to true if don't want the app to receive and handle the keyevent. 
    // ...

    // Insert the text at the current selection.
    editSession.ReplaceText(selection, insertText);

    // Done with the edit session. Submit the changes.
    const Boolean succeeded = editSession.SubmitPayload();

    // Call it handled if consuming the key, or unhandled otherwise to let the target app handle it.
    if (succeeded)
    {
        args.Handled(consumed);
    }
});
```
More advanced input scenarios might involve using `TextComposition` for composing a string of text 
from a sequence of input events. See **TextComposition** section below for more details.

### Submitting

Once you're done using an edit session, call `SubmitPayload` or `SubmitPayloadAsync` before releasing the session object. 
Both APIs submit the session payload - the aggregate result of changes you made in the session - to the TSF which will try 
to deliver and apply it to the actual textbox in the app. If you don't want to submit the changes for any reason or used 
the session only for reading, just release the session object without calling a Submit method. 
`TextEditSession` objects are not re-usable and should be released after it's finalized via either of `SubmitPayload` or `SubmitPayloadAsync`.
As focused textbox and your IME belong to different processes, applying edit session payload to the textbox is an asynchronous
task that is not guaranteed to succeed due to external forces, like focus moves or changes from other sources applied to the textbox concurrently, 
or it simply can be rejected or overridden by the textbox itself. Therefore, the result of `SubmitPayload`
only tells you whether the payload was successfully sent toward the destination. But, if you want to get a delivery confirmation 
with the actual result of the payload application, use `SubmitPayloadAsync` which returns IAsyncOperation<PayloadResult> 
that'll have the final result upon completion. 
For more details on possible result value and outcomes of `SubmitPayloadAsync`, see `PayloadResult Enum` in the API section.  

## Text Composition

IMEs create a **Text Composition** whenever their text output is considered as an interim result of processing 
an open-ended input stream where the IME is not sure whether its current output is final or will be reconsidered in 
response to the next input event.
Typical scenarios: user typing in East-Asian languages, dictating, handwriting, stepping through a list of string candidates


### Text Composition Characteristics and Attributes

#### Position
Composition starts at and stays anchored to the current insertion point (or non-empty selection which it will replace)
unless the IME uses partial completion where a substring at the beginning of the composition gets finalized, thus 
trimming that part off the rest of the still ongoing composition and adjusting the position index along.

#### Segmentation
Commonly, IMEs choose to manage composition by breaking it into segments defined by particular lingustic or input 
processing rules which IME specifies through text attributes (properties, if speaking MIDL). In accordance to that, 
TSF4 composition segments are implicitly defined by distinct sets of attribute values rather than by ranges. For 
consistency, not only segment attributes but the entire composition textual content is populated and edited via segments. 
This is done to avoid ambiguity in editing where a text change could span parts of segments or mutiple segments with 
different attribute values.

The list of Segment properties (content and attributes):
- **Interim Text**  
The text an in-progress composition string is built of. That is, Interm Text of composition segments 
get concatenated into a single string representing the current/interim state of the composition. That's the 
text rendered while the composition is ongoing.
- **Converted Text**  
Pre-determined 'final' textual content of the segment. Optionally provided by the IME in cases where *Converted* is 
different from *Interim*, for instance, if *Interim* contains segment delimiters which should be stripped in the final text.
- **Unconverted Text**  
Applicable in keyboard input compositions, it's a raw keyboard input string (aka **_reading string_**) 
which conversion produced the _Interim/Converted Text_. 
- **Rendering Style**  
Optional combination of foreground and background colors, color and style of an underline decoration that 
IME wants the editbox to use in rendering this segment's Interim Text.
- **Conversion State**  
Optional conversion state (an enum value) of the segment.
- **Source Reference**  
An optional IWeakReference pointer to IME's private object that the IME would use to link composition segments
to their private data, such as raw non-keyboard input data that produced the text segment.

#### Insertion point and selection
Being managed in isolation from the main body of text, Composition is allowed its own movable insertion point within 
the scope of its content. The position index of insertion point is zero-based relative to the beginning 
of the composition content. For IMEs to be able to align their near-IP UI to the composition's insertion point, its 
composition caret location is monitored and updated for the composition owner as the layout of the current selection.

### Completion Scenarios

#### Completing as Converted
As mentioned above, composition's Interim Text may contain temporary delimiters or other formatting that is not 
supposed to end up in the desired final text once composition completes. Given that alternative Converted Text is 
provided by the IME along with the Interim Text, the TSF handles the text replacement when the composition is completed 
by the IME or terminated by external forces.  
Empty _Converted Text_ strings are assumed as 'not specified' and _Interim Text_ gets finalized as is.

#### Completing as Terminated
In response to user actions or external text changes, IME composition can be terminated by editbox or TSF in a
synchronous manner, i.e. without giving the IME a chance to properly finalize it. TSF tries to do that on behalf 
of the IME whenever possible (while TSF input context is still open to text changes). To prepare for such course of 
events, TSF propagates the _Converted Text_ string to the app side along with composition updates and then replaces 
the composition's current text with the text in composition termination. TSF only does this if IME has specified the 
Converted Text attribute for any of the composition's segments.

#### Completing as Unconverted
Some keyboard IMEs may provide users an option to complete composition as Unconverted. In this case, TSF also does the 
text replacement, but uses an _Unconverted Text_ segment property where provided. Empty _Unconverted_ strings are assumed as 
'not specified' and _Interim Text_ gets finalized as is. _Unconverted Text_ is used only when the IME explicitly completes 
composition as Unconverted, and is not used in terminated compositions.  

#### Partial Completion
When processing lengthy continuous stream of inputs, IMEs may want to keep the composition going while also keeping 
it manageable and compact. They can do this with Partial Completion, where the firstmost segment calls completed and trims 
composition from the beginning while it keeps extending on the other end. The rules of Completing Converted apply to the segment 
in Partial Completion. Partial Completion as Unconverted is not considered a valid scenario and therefore is unsupported.

### Example
```cpp
keyboardIme.KeyEventReceived(auto_revoke, [](const KeyboardInputProcessor& , const KeyEventReceivedEventArgs& args) {
    // Process the keyevent.
    if (args.KeyStatus().WasKeyDown)
    {
        TextEditSession editSession = args.EditSession();
        
        // Check if a composition has been created for previous events.
        TextComposition composition = editSession.Composition();
        if (composition == nullptr)
        {
            winrt::hstring newText;
            //... init newText ...  
                
            // Start a new composition.
            TextComposition composition = editSession.StartComposition();

            // Populate it with some initial text (which is the reason for a new composition).
            // TextComposition object itself doesn't contain any text directly.
            // Instead, it manages a dynamic array of TextCompositionSegment objects which contain the actual data.
            // The insertion populates the first TextCompositionSegment in the composition.
            TextCompositionSegment segment = composition.InsertText(newText);

            // segment.Text() is the inserted text. 
            // All other properties of TextCompositionSegment are optional. Let's set some:
            // - Save the raw input in UnconvertedText:
            segment.UnconvertedText(args.Unicode());
            // - Set the current conversion state of the segment:
            segment.ConversionState(CoreTextFormatUpdatingReason::CompositionUnconverted);
            // - Ask to underline it in rendering:
            TextStyle textStyle{};
            textStyle.mask = TextStyleAttributes::UnderlineColor | TextStyleAttributes::UnderlineType;
            textStyle.underlineColor = { 255, 255, 0, 0 }; // Solid red (A=255, R=255, G=0, B=0)
            textStyle.underlineType = Windows::UI::Text::UnderlineType::Dash;
            segment.SetTextStyle(textStyle);
        }
        else if (args.VirtualKey() == Windows::System::VirtualKey::Space)
        {
            // Finalize the compositon when user presses Space key.
            composition.Complete();
        }
        else if (args.VirtualKey() == Windows::System::VirtualKey::Enter)
        {
            // Cancel input converion and insert the raw text.
            composition.CompleteUnconverted();
        }
        else if (args.VirtualKey() == Windows::System::VirtualKey::Left /* || other navigation keys*/)
        {
            // Optionally, move the caret within the composition and/or segment selection
            // when user presses navigation keys. For instance, on Left arrow key:
            uint32_t caretPosition = composition.CaretPosition();
            if (caretPosition > 0)
            {
                composition.CaretPosition(caretPosition - 1);
            }
        }
        else
        {
            // Continue updating current composition.
            TextCompositionSegment segment = composition.SelectedSegment();

            // Continue updating the current segment.
            winrt::hstring newText;
            if (/*should_update_segment_text>(segment.Text(), args.Unicode(), &newText)*/) 
            {
                segment.Text(newText);
                segment.UnconvertedText(segment.UnconvertedText() + args.Unicode());
            } 
            else
            {
                TextCompositionSegment newSegment = composition.InsertText(newText);
                // init newSegment properties ...
            }
        }

        // Submit the changes.
        editSession.SubmitPayload();

        // Consume all keydown events while composing. 
        // Slipping a keydown event to the app can trigger it to terminate the composition.
        args.Handled(true);
    }
}
```

## Input Delegation

Input delegation refers to the process by which a secondary, non-activatable application seeks authorization from 
the operating system to redirect to its own UI and assume control over keyboard and text input without displacing 
the primary foreground application from its active and visible state which otherwise would cause disruption of the user
experience within that application.
In other words, input delegation allows keyboard navigation and text editing in a non-activate UI without losing focus 
in the foreground app, for example when a user types in an IME UI to search for a particular emoji to be inputted 
into their current textbox.

```cpp
// Hook delegation mode events.
textInputProvider.InputDelegationModeChanged(auto_revoke, [](
        const TextInputProvider&, const InputDelegationModeChangedEventArgs& args) {
    if (!args.DelegationOn())
    {
        // hide IME UI for which keyboard input delegation was requested
    }
});

// open IME UI
//...
// request keyboard input delegation to the thread
if (!textInputProvider.TryStartDelegation())
{
    // input delegation from current foreground app is not allowed, cancel the IME UI
    //...
}
```


# API Pages

## API Namespace

The current Limited Access Feature namespace : **Windows.UI.Input.Preview.Text**.<br>
Expected final public namespace: **Windows.UI.Input.Text**.

## TextInputService Class

The entry point to all services provided by the Text Services Framework to IME applications. 
This object is associated with the calling thread and recommended to be instantiated on the UI thread of the IME.
To obtain an object of this type, call TextInputService.GetForCurrentThread.

### Methods
| Name | Description |
|-|-|
| static TextInputService<br>**GetForCurrentThread**() | Returns the TextInputService associated with the calling thread. |
| KeyboardInputProcessor<br>**CreateKeyboardInputProcessor**(<br>&nbsp;&nbsp;&nbsp;&nbsp;const String inputProfile) | Connects and registers the caller with the TSF as a running Keyboard IME instance and returns a communication object representing the connection.<br>The input parameter "inputProfileSting" identifies the IME in the format described [here](https://learn.microsoft.com/en-us/windows/win32/tsf/querylayoutortipstring#:~:text=%3CLangID%201%3E%3A%7Bxxxxxxxx%2Dxxxx%2Dxxxx%2Dxxxx%2Dxxxxxxxxxxxx%7D%7Bxxxxxxxx%2Dxxxx%2Dxxxx%2Dxxxx%2Dxxxxxxxxxxxx%7D%3B).<br>For successful connection, the IME is supposed to be recognizable by the TSF as installed and enabled for the current session, which means it's supposed to be listed as an enabled input method in Language&Keyboard Settings as well as in the Input Switcher UI.|
| TextInputProvider<br>**CreateTextInputProvider**(<br>&nbsp;&nbsp;&nbsp;&nbsp;const String inputProfile) | Connects and registers the caller with the TSF as a running Non-Keyboard IME instance and returns a communication object representing the connection.<br>The input parameter "inputProfileSting" identifies the IME in the format which is TBD, ignored meanwhile.  |

```cpp
// Keyboard IME
constexpr PCWSTR inputProfileString = L"<langid>:{<clsid>}{<guid>}";
TextInputService textInputService = TextInputService::GetForCurrentThread();
KeyboardInputProcessor keyboardIme = textInputService.CreateKeyboardInputProcessor(inputProfileString);
```

## KeyboardInputProcessor Class

The `KeyboardInputProcessor` class enables an IME to access and manage the context and state of a textbox and text 
input, ensuring it stays updated with focus, content, and layout changes.
Designed specifically for Keyboard IMEs, KeyboardInputProcessor manages activation-deactivation of the IME 
in response to corresponding user actions, and it delivers keyboard input to the IME for processing and converting 
into text input directed to the focused textbox.
To obtain an object of this type, call `TextInputService.CreateKeyboardInputProcessor`.

### Properties
| Name | Description |
|-|-|
|**InputProfile**|The string that was used as the input parameter in TextInputService.CreateKeyboardInputProcessor to create this object<br>Read only. Type: String.
|**IsActive**|Returns whether or not the IME is active (as notified via the Activated event).<br>Read only. Type: Boolean.|
|**HasFocusedTextBox**|Returns 'true' when this object is aware of the focused textbox the IME can interact with.<br>Read only. Type: Boolean.|
|**FocusedTextBoxId**|Returns the Id of the focused textbox.<br>Read only. Type: `TextBoxId`.|
|**FocusedTextBoxInfo**|Returns a TextBoxInfo object describing the focused textbox.<br>Read only. Type: `TextBoxInfo`.|
|**FocusedTextBoxBounds**|Returns the bounding rectangle of the focused textbox when known. In screen coordinates.<br>Read only. Type: Windows.Foundation.IReference<Windows.Foundation.Rect>.|
|**SelectionBounds**|Returns the bounding rectangle of the current text selection in the focused textbox when known. In screen coordinates.<br>Read only. Type: Windows.Foundation.IReference<Windows.Foundation.Rect>.|
|**ConversionMode**|Sets/returns the current conversion mode. See the type description for details.-<br>Read-Write. Type: `TextConversionMode`.|

### Methods
| Definition | Description |
|-|-|
|TextEditSession **CreateEditSession**()|Creates an edit session for the focused textbox when there's one. Returns `nullptr` otherwise.|

### Events
| Definition | Description |
|-|-|
|**Activated**|Occurs when user activates the IME in InputSwitcher or via hotkey, or when input focus moves to a UI thread that expects this IME to be active there.<br>Arguments: none.|
|**Deactivated**|Occurs when user or application activates another input method.<br>Arguments: none.|
|**KeyEventReceived**|Triggered whenever a key event occurs while the input focus is in a text input enabled textbox.<br>You must provide a callback function to process it.<br>Arguments: `KeyEventReceivedEventArgs`.|
|**FocusEntered**|Occurs when an eligible textbox receives input focus.<br>Arguments: `FocusEnteredEventArgs`.|
|**FocusRemoved**|Occurs when the focused textbox loses input focus.<br>Arguments: none.|
|**ConversionModeChanged**|Occurs when keyboard IME conversion mode changes for the focused textbox as a result of user or application actions, focus move.<br>Arguments: `ConversionModeChangedEventArgs`.|
|**TextBoxInfoChanged**|Occurs when the focused textbox updates its dynamic settings.<br>Arguments: `TextBoxInfoChangedEventArgs`.|
|**TextBoxContentChanged**|Occurs when either or any combination of text content attributes changes in the focused textbox.<br>This includes changes in text, text properties, selection, text layout, textbox position and boundaries.<br>Arguments: `TextBoxContentChangedEventArgs`.|
|**CompositionTerminated**|Occurs for the IME with an ongoing `TextComposition` when the composition gets forcefully terminated by the focused<br> texbox or TSF, typically in response to external events such as focus or selection move.<br>Arguments: none.|
|**ReconversionRequested**|Occurs when the focused textbox iniates a request to reconvert selected text and the TSF recognizes this IME<br>as the best provider to do the reconversion (either because the IME is the active one and/or because it's<br>the one who authored that range of text at the first place).<br>Arguments: `ReconversionRequestedEventArgs`.|


## TextInputProvider Class

The `TextInputProvider` class enables a non-Keyboard IME to access and manage the context and state of a 
textbox and text input, ensuring it stays up to date with focus, content, and layout changes. It also alerts an
IME of various events that will allow the IME to handle text input and other changes.

To obtain an object of this type, call `TextInputService.CreateTextInputProvider`.

### Properties
| Name | Description |
|-|-|
|**HasFocusedTextBox**|Returns 'true' when this object is aware of the focused textbox the IME can interact with.<br>Read only. Type: Boolean.|
|**FocusedTextBoxId**|Returns the Id of the focused textbox.<br>Read only. Type: `TextBoxId`.|
|**FocusedTextBoxInfo**|Returns a TextBoxInfo object describing the focused textbox.<br>Read only. Type: `TextBoxInfo`.|
|**FocusedTextBoxBounds**|Returns the bounding rectangle of the focused textbox when known. In screen coordinates.<br>Read only. Type: Windows.Foundation.IReference<Windows.Foundation.Rect>.|
|**SelectionBounds**|Returns the bounding rectangle of the current text selection in the focused textbox when known. In screen coordinates.<br>Read only. Type: Windows.Foundation.IReference<Windows.Foundation.Rect>.|
|**InputLanguage**|BCP-47 string representing active input language (the language of active keyboard input method).<br>Read only. Type: String.|

### Methods
| Definition | Description |
|-|-|
|TextInputServiceSubscription **GetSubscription**()| Returns the current state of the feature-based filter for texboxes the IME is interested in.|
|void **SetSubscription**(<br>&nbsp;&nbsp;&nbsp;&nbsp;TextInputServiceSubscription value)| Updates the feature-based filter for texboxes the IME is interested.|
|TextEditSession **CreateEditSession**()|Creates an edit session for the focused textbox when there's one. Returns `nullptr` otherwise.|
|Boolean **TryStartDelegation**()|The initiation of the delegation process starts with a formal request from the IME by calling this function to redirect<br>keyboard and text input events to its UI. Upon obtaining authorization asynchronously, the IME will receive a confirmation event,<br> signaling the commencement of keyboard input redirection.|
|void **StopDelegation**()|The IME should call this function to stop the input delegation.|


### Events
| Definition | Description |
|-|-|
|**FocusEntered**|Occurs when an eligible textbox receives input focus.<br>Arguments: `FocusEnteredEventArgs`.|
|**FocusRemoved**|Occurs when the focused textbox loses input focus.<br>Arguments: none.|
|**ConversionModeChanged**|Occurs when keyboard IME conversion mode changes for the focused textbox as a result of user or application actions, focus move.<br>Arguments: `ConversionModeChangedEventArgs`.|
|**TextBoxInfoChanged**|Occurs when the focused textbox updates its dynamic settings.<br>Arguments: `TextBoxInfoChangedEventArgs`.|
|**TextBoxContentChanged**|Occurs when either or any combination of text content attributes changes in the focused textbox.<br>This includes changes in text, text properties, selection, text layout, textbox position and boundaries.<br>Arguments: `TextBoxContentChangedEventArgs`.|
|**CompositionTerminated**|Occurs for the IME with an ongoing `TextComposition` when the composition gets forcefully terminated by the focused<br> texbox or TSF, typically in response to external events such as focus or selection move.<br>Arguments: none.|
|**ReconversionRequested**|Occurs when the focused textbox iniates a request to reconvert selected text and the TSF recognizes this IME<br>as the best provider to do the reconversion (either because the IME is the active one and/or because it's<br>the one who inserted that range of text at the first place).<br>Arguments: `ReconversionRequestedEventArgs`.|
|**InputDelegationModeChanged**|Occurs when in response to an input delegation request by the IME or whenever current delegation mode<br> granted to the IME gets terminated due to external causes.<br>Arguments: `InputDelegationModeChangedEventArgs`.|


## TextEditSession Class

A `TextEditSession` is used for exploring content of focused textbox and for any editing activity there.
There's a dedicated TextEditSession associated with every keyevent, obtainable via KeyEventReceivedEventArgs.EditSession.
For all other purposes, both KeyboardInputProcessor and TextInputProvider have a method to create edit session for the focused textbox.

### Properties
| Name | Description |
|-|-|
| **TextBoxId** | Retrieves the unique identifier for the currently focused textbox.<br>Read-only. Type: `TextBoxId` |
| **TextLength** | Returns the number of characters in the active textbox.<br>Read-only. Type: Int32 |
| **PopulatedRange** | Returns the range of text synchronously available in the scope of this edit session.<br>Read-only. Type: Windows.UI.Text.Core.CoreTextRange |
| **Composition** | Retrieves the current composition by the IME or returns `nullptr` if there's none.<br>Read only. Type: `TextComposition`|

### Methods
| Name | Description |
|-|-|
| Windows.UI.Text.Core.CoreTextRange **GetSelectedRange**() | Returns a structure with the current selection's start and end positions.|
| void **SetSelectedRange**(<br>&nbsp;&nbsp;&nbsp;&nbsp;Windows.UI.Text.Core.CoreTextRange value) | Selects a range of texts.|
| Windows.Foundation.IAsyncAction<br>**PopulateAsync**(<br>&nbsp;&nbsp;&nbsp;&nbsp;Windows.UI.Text.Core.CoreTextRange range) | Submits a request to make a specified range of text available to the IME.<br>When the request is completed, the IME will receive a TextBoxContentChangedEvent, with which you can create a new TextEditSession to explore the populated range. |
| String **GetText**(<br>&nbsp;&nbsp;&nbsp;&nbsp;Windows.UI.Text.Core.CoreTextRange range) | Retrieves the text content for a specified range. |
| Windows.UI.Text.Core.CoreTextRange<br>**ReplaceText**(<br>&nbsp;&nbsp;&nbsp;&nbsp;Windows.UI.Text.Core.CoreTextRange replaceRange,<br>&nbsp;&nbsp;&nbsp;&nbsp;String text) | Deletes the specified range of text and optionally replaces it with new content. |
| TextComposition **StartComposition**() | Starts an empty input composition at the current selection / insertion point. Returns the composition object for further input and editing.<br>The caller is the designated owner of the new composition. Unless finalized or left empty in the same session,<br>the composition will be made available to the caller in subsequent edit sessions with its state preserved in between. |
| TextComposition **StartReconversion**(<br>&nbsp;&nbsp;&nbsp;&nbsp;Windows.UI.Text.Core.CoreTextRange range) | Starts a reconversion composition over the specified range for the caller. Returns the composition object for further input and editing.<br>The new composition starts prepopulated with the text specified by the 'range' input parameter. If the range is empty, the method returns nullptr/E_INVALIDARG. |
| PayloadResult **SubmitPayload**() | The payload is the sum of the changes made in the edit session. This submits the updates that were made to the edit session. |
| Windows.Foundation.IAsyncOperation<PayloadResult><br>**SubmitPayloadAsync**() | Asynchronously submits the editing session’s payload (the changes made to the edit session). |

## TextComposition Class

The `TextComposition` class represents active composition in the scope of a particular `TextEditSession`. <br>Although the composition itself can persist beyond the edit session where it was created and then can be accessed in susequent edit sessions, 
TextComposition object is strictly associated with the edit session it was obtained from and becomes invalid/unusable 
with either session or after composition completion in its parent edit session.

### Properties
| Name | Description |
|-|-|
| **Text** | Returns the current textual content of the composition. Read-only as it's dynamically built from Text properties of composition segments.<br> Read only. Type: String|
| **FirstSegment** | Returns the first non-empty segment, or the first segment if all are empty.<br>Result is always valid as there's always at least one segment there.<br>Read only. Type: `TextCompositionSegment`|
| **SelectedSegment** | Returns the segment containing or adjacent to the composition's CaretPosition.<br>If CaretPosition is between two adjacent segments, the one to the left of it is considered selected.<br>The property is read-only because it is derived from the CaretPosition. Type: `TextCompositionSegment` |
| **CaretPosition**| Zero-based caret position within the scope of composition content. The insertion point for new text.<br>Read-Write. Type: UInt32 |

### Methods
| Name | Description |
|-|-|
| TextCompositionSegment<br>**InsertText**(<br>&nbsp;&nbsp;&nbsp;&nbsp;String text) | Inserts a text string at the CaretPosition. If the insertion point is adjacent to a segment, this method creates<br> and returns a new segment containing the inserted text. Otherwise, new text is inserted into the segment containing the insertion point and the method returns the updated segment.<br> |
| void **Complete**() | Completes the composition. If any segments had alternative ConvertedText set, that text will be used in the finalized composition string.<br> `TextEditSession`'s Composition property will return `nullptr` after this call. Any attempt to call this API on this composition object<br> or associated composition segments after composition completion will fail. After completing a composition,<br>IME can start a new one in the same edit session or make other changes that don't involve a composition. |
| void **CompleteUnconverted**() | Same as `Complete()` but the final text will be comprised of UnconvertedText properties of composition segments where availble,<br>finalized as is otherwise. No TSF or IME properties will be associated with the resulting string. |
| void **CompleteFirstSegment**() | Finalizes the first segment as Converted and trims the composition up to the next segment.<br>If there's no other non-empty segments in the compostion, the result of `CompleteFirstSegment()` is equivalent to calling `Complete()`. |


## TextCompositionSegment Class

The `TextCompositionSegment` class represents a text segment in active composition. This class provides the API for 
manipulating the content and properties of the encapsulated text. All `TextComposition` limitations apply here as well.

### Properties
| Name | Description |
|-|-|
| **Text** | The textual content of the segment. This is presumably converted, but considered Interim until finalized. Must be non-empty to be included in completed composition. Empty segments are skipped in the navigation API `TextCompositionSegment::Next()`/`Previous()` and not returned as First or SelectedSegment with the only exception when an empty segment is the only segment in the composition.<br>Read-Write. Type: String |
| **ConvertedText** | An optional converted alternative to Text provided when the main Text contains transient delimiters or other hints<br>which are not supposed to be included in completed composition.<br>Not used while the composition is active and applied only when finalizing the composition as converted,<br> i.e. completed via `TextComposition::Complete()` or terminated with an option to finalize.<br>Read-Write. Type: String |
| **UnconvertedText** | In a keyboard input composition, the raw input string from which IME produced `Text`/`ConvertedText`, aka "reading string".<br>If specified non-empty, upon composition completion, it's stored as a property of the text range corresponding to the segment.<br>Read-Write. Type: String |
| **Range** | Returns the Text range within the composition, zero-based relative to the current composition beginning.<br> Read-only, because it is computed from the Text length of this and preceeding segments. Changes accordingly.<br>Type: Windows.UI.Text.Core.CoreTextRange |
| **ConversionState** | An optional hint for interested editboxes and/or accessibility tools.<br>Read-Write. Type:Windows.UI.Text.Core.CoreTextFormatUpdatingReason|
| **Next** | Returns next adjacent non-empty segment if available, `nullptr` otherwise.<br>Read only. Type: `TextCompositionSegment` |
| **Previous** | Returns preceeding adjacent non-empty segment if available, `nullptr` otherwise.<br>Read only. Type: `TextCompositionSegment` |

### Methods
| Name | Description |
|-|-|
| `TextStyle` **GetTextStyle**() | Returns optional drawing attributes to use in rendering the segment's Text while the composition is active.|
| void **SetTextStyle**(<br>&nbsp;&nbsp;&nbsp;&nbsp;`TextStyle` value) | Sets optional drawing attributes to use in rendering the segment's Text while the composition is active.<br>The style can include any combination of suggested text foreground color, background color, color and type of text underline.|


## TextBoxInfo Class

The `TextBoxInfo` class is used to get properties of a textbox — including its textbox ID, enabled features, 
disabled features, settings, and input scope.

### Properties
| Name | Description |
|-|-|
| **Id** | Retrieves the unique identifier for the currently focused textbox.<br>Read only. Type: `TextBoxId` |
| **InputScope** | Specifies the intended input type for the textbox. The supported input types are listed [here](https://learn.microsoft.com/en-us/uwp/api/windows.ui.text.core.coretextinputscope?view=winrt-26100).<br>Read only. Type: Windows.UI.Text.Core.CoreTextInputScope |
| **AppName** | Retrieves the name of the application hosting the textbox.<br>Read only. Type: String |
| **Url** | Retrieves the URL of the web page or document containing the textbox, where applicable.<br>Read only. Type: String |
| **Settings** | Returns flags summarizing the textbox's current settings.<br>Please note that, contrary to textbox features, textbox setting can change dynamically.<br> Read only. Type: `TextBoxSettings`|
| **DisabledFeatures** | Returns a set of flags indicating features the textbox doesn't support.<br> Read only. Type: `TextBoxFeatures`|


## TextBoxInfoChangedEventArgs Class

The `TextBoxInfoChangedEventArgs` class is used as the argument for `TextBoxInfoChanged` events of `KeyboardInputProcessor` and `TextInputProvider`. 

### Properties
| Name | Description |
|-|-|
| **TextBoxInfo** | Gets the updated TextBoxInfo.<br>Read only. Type: `TextBoxInfo` |


## TextBoxContentChangedEventArgs Class
`TextBoxContentChangedEventArgs`is the argument class of `TextBoxContentChanged` events of `KeyboardInputProcessor` and `TextInputProvider`.<br>It contains data describing the changes. To explore the updated content in more details,<br>IME can create a TextEditSession upon receiving the event.

### Properties
| Name | Description |
|-|-|
| **TextBoxId** | Get the textbox ID of the changed textbox.<br>Read only. Type: `TextBoxId` |
| **Source** | Provides the source of text changes delivered with the event.<br>Read only. Type: `TextChangeSource` |
| **SelectionBounds** | Gets the selection bounds for the change.<br>Read only. Type: Windows.Foundation.Rect |
| ~~**TextChanges**~~ | ~~Returns collection of data structures describing text changes delivered with the event.<br>Read only. Type: IVectorView<`TextChange`>~~ |

### Methods
| Name | Description |
|-|-|
| Boolean<br>**IsContentAttributeChanged**(<br>&nbsp;&nbsp;&nbsp;&nbsp;`TextBoxContentAttribute` attr) | Tells whether a given `TextBoxContentAttribute` changed with this event. |


## FocusEnteredEventArgs Class

The `FocusEnteredEventArgs` class is used as arguments for the `FocusEntered` events of `KeyboardInputProcessor` and `TextInputProvider`. 

### Properties

| Name | Description |
|-|-|
| **FocusedTextBoxInfo** | Gets the textbox info of the focused textbox window.<br>Read only. Type: `TextBoxInfo` |


## KeyEventReceivedEventArgs Class

`KeyEventReceivedEventArgs` is the argument type of the KeyboardInputProcessor's `KeyEventReceived` event.

### Properties
| Name | Description |
|-|-|
| **VirtualKey** | Gets the virtual key that maps to the key that was pressed.<br>The type is defined [here](https://learn.microsoft.com/en-us/uwp/api/windows.system.virtualkey?view=winrt-26100).<br>Read only. Type: Windows.System.VirtualKey|
| **KeyStatus** | Gets the status of a key at the time the event is fired.<br>More information about KeyStatus data structure can be found [here](https://learn.microsoft.com/en-us/uwp/api/windows.ui.core.corephysicalkeystatus?view=winrt-26100).<br>Read only. Type: Windows.UI.Core.CorePhysicalKeyStatus |
| **Unicode** | Returns a string representing the unicode character of the key that was pressed.<br>Read only. Type: String |
| **Source** | Provides the device type from which the key event originated (undefined, hardware keyboard, software keyboard, or injection).<br>Read only. Type: `KeyEventDeviceType` |
| **IsKeyPressed** | Gets the pressed state for the specified virtual key code.<br>Read only. Type: Boolean|
| **IsToggleKeyOn** | Gets the toggle state for the specified toggle key.<br>Read only. Type: Boolean|
| **EditSession** | Gets the `TextEditSession` object associated with the key event.<br>The session's payload (a sequence of edit actions) is the result of processing of this particular keyevent.<br>Read only. Type: `TextEditSession`|
| **Handled** | Gets or sets a Boolean value that indicates whether the IME consumes the keyevent.<br>Handled (consumed) keyevent will be extracted from the target application's input queue, while Unhandled one will be delivered to the application after the IME is done with it.

## ConversionModeChangedEventArgs Class

This class is the argument type of the KeyboardInputProcessor's `ConversionModeChanged` event.<br>
More about Keyboard IME conversion modes can be found [here](https://learn.microsoft.com/en-us/windows/win32/intl/ime-conversion-mode-values).

### Properties
| Name | Description |
|-|-|
| **NewConversionMode** | Gets the new conversion mode after it has been changed.<br>Read only. Type: TextConversionMode|

## ReconversionRequestedEventArgs Class
This provides details for when reconversion has been requested for a selection of the text.

### Properties
| Name | Description |
|-|-|
| **Range** | Gets the range of the text for the reconversion that has been requested.<br>Read only. Type: Windows.UI.Text.Core.CoreTextRange |

## InputDelegationModeChangedEventArgs Class

This class is the argument type of the TextInputProvider's `InputDelegationModeChanged` event.
It conveys information about the changes in the current input delegation mode requested by or granted to the recepient IME.

### Properties
| Name | Description |
|-|-|
| **DelegationOn** | Gets whether input delegation is turned on or off. This allows the IME to get notified if there are any changes<br> in input delegation, like if input delegation request has been granted or current delegation mode forcibly terminated.<br> Read only. Type: Boolean |


## TextBoxId Struct

The `TextBoxId` provides a textbox's ID as a 32-bit integer in case IMEs need it for their own reference.

### Members
| Name | Description |
|-|-|
|**Value**| The ID. Type: UInt32.|

## TextInputServiceSubscription Struct

The data type of `TextInputProvider::Subscription` property.
Defines the variety of textboxes the IME is interested in.

### Members
| Name | Description |
|-|-|
|**requiredEnabledFeatures**|Set a flags corresponding to features which a textbox must support in order to be presented to the IME.<br>Type: `TextBoxFeatures`|
|**requiredDisabledFeatures**|Set a flags corresponding to features which a textbox must have explicitly disabled in order to be presented to the IME.<br>Type: `TextBoxFeatures`|

 ## ~~TextChange Struct~~ 

~~The items data type in the collection property `TextBoxContentChangeEventArgs::TextChanges`.
Describes a single text change.~~

### ~~Members~~
| Name | Description |
|-|-|
|~~**Position**~~|~~Zero-based index in text body where the change happened.<br>Type: UInt32~~|
|~~**Deleted**~~|~~The length of text (in characters) deleted at the **Position** (in the direction of text flow).<br>Type: UInt32~~|
|~~**Inserted**~~|~~The text inserted at the **Position** (replacing the deleted text).<br>Type: String~~|


## TextStyle Struct

The data type of `TextCompositionSegment::TextStyle` property.
Used for describing desired drawing attributes of text in an IME composition.

### Members
| Name | Description |
|-|-|
|**mask**|Flags corresponding to the other members of the structure, indicating valid ones when set.<br>Type: `TextStyleAttributes`|
|**textColor**|Color of the text the style applies to.<br>Type: Windows.UI.Color|
|**backgroundColor**|Background color of the text. <br>Type: Windows.UI.Color|
|**underlineColor**|Color of the text underline when **underlineType** is defined.<br>Type: Windows.UI.Color|
|**underlineType**|Type of text underline.<br>Type: Windows.UI.Text.UnderlineType|

## TextBoxFeatures enum
This lists features that can be supported or not by a textbox, as explicitly declared by the textbox or implied by the TSF.

### Values (flags)
| Name | Description |
|-|-|
|None| = 0|
|ReadText (0x0001)|Textbox content and selection is availlable to IMEs for reading and navigation. |
|WriteText (0x0002)|Textbox accepts text input.|
|AugmentText (0x0004)|Textbox supports or allows text augmentation via TSF.|
|*TBD*|*There're more candidates to these enums to be finalized in further iterations during the LAF period.*|


## TextBoxSettings enum
Various configuration settings that affect the behavior and display of a textbox.
The settings are explicitly declared by the textbox or implied by the TSF and can change dynamically.

### Values (flags)
| Name | Description |
|-|-|
|None (0)| |
|Private (0x0001)|Textbox content is private. |
|Multiline (0x0002)|Textbox supports multiline text rendering.|
|VerticalWriting (0x0004)|Text lines in the textbox are vertical (text flow is top to bottom, left to right).|
|*TBD*|*There're more candidates to this enum to be finalized in further iterations during the LAF period.*|


## TextBoxContentAttribute Enum
This is used to indicate which aspects of the textbox content have been modified.
Values of this type used as the input parameter in `TextBoxContentChangedEventArgs::IsContentAttributeChanged`.

### Values
| Name | Description |
|-|-|
|None| = 0|
|Selection|Text selection. |
|Text|Text content.|
|Property|Properties of text ranges.|
|Layout|Textbox position and bounds, selection/insertion point bounds.|


## KeyEventDeviceType Enum
`KeyEventDeviceType` specifies the type of device from which a key event can come from.

### Values
| Name | Description |
|-|-|
|Undefined| =0|
|HardwareKeyboard|as named|
|SoftwareKeyboard|as named|
|Gamepad|as named|
|Injection|as named|

## PayloadResult Enum
`PayloadResult` defines the possible outcomes for a payload’s edit session. This is used 
to indicate the resulting state of the editing session payload and how it was handled.

### Values
| Name | Description |
|-|-|
|InEditing|The payload's edit session is still open.|
|Pending|Delivery of the payload or its result is in progress.|
|Completed|Accepted and applied by the target as is.|
|Overridden|Applied but with some modifications by the target.|
|Outrun|A conflicting change from another source happened before this one,<br>the IME can still try and regenerate the payload (aka "replay input") for updated context.|
|Rejected|For whatever reason, the target explicily rejected (failed) the payload.|
|Canceled|Either unsubmitted payload (TextEditSession) has been canceled by the IME<br>or submitted payload canceled later by the TSF due to inability to deliver it<br>(eg. due to lost connection, unregistrered texbox).|

## TextConversionMode Enum
This defines the available conversion modes.
A conversion mode defines how a Keyboard IME converts keyboard input to text.

### Values
| Name | Description |
|-|-|
|Undefined| = 0|
|AlphanumericHalfWidth|Converting keyboard input into alphanumeric half-width characters.|
|AlphanumericFullWidth|Converting keyboard input into alphanumeric full-width characters.|
|NativeHalfWidth|Converting keyboard input into native language half-width characters.|
|NativeFullWidth|Converting keyboard input into native language full-width characters.|
|KatakanaHalfWidth|Converting keyboard input into Japanese Katakana half-width characters.|
|KatakanaFullWidth|Converting keyboard input into Japanese Katakana full-width characters.|
|NativeHalfWidthNativeSymbol|Converting into language native half-width symbols.|
|NativeFullWidthNativeSymbol|Converting into language native half-width symbols.|
|NoConversion|As named.|
|RequestConversion|Special value inviting IME to specify its conversion mode.|
|NativeEudc|Converting into End-User-Defined chanracters.|

## TextChangeSource Enum
`TextChangeSource` defines the origins for text changes in a textbox.

### Values
| Name | Description |
|-|-|
|External| The source is unrecognizable by the TSF, like pasted or programmatically inserted/removed text|
|HardwareKeyTyped|The result of a WM_CHAR (Win32) or OnCharacter (UWP)|
|SoftwareKeyTyped|Same as above but for injected keyboard input.|
|KeyboardImeInsertion|Result of finalizing a keyboard IME composition.|
|OtherImeInsertion|Result of a non-keyboard IME input (e.g. dictation, handwriting).|
|Reconversion|A committed text replaced by an IME for whatever reason (reconversion, spelling/grammar correction, etc).|
|AutoCompletion|A typing prediction applied by user.|
|Mixed|The change is aggregated, potentially from different sources.|

## TextStyleAttributes Enum
The type of `TextStyle::mask` member that supports flexibility in defining drawing attributes of a composition 
segment. Set bits indicate valid members of `TextStyle` data.

### Values (flags)
| Name | Description |
|-|-|
|None (0)||
|TextColor (0x0001)|TestStyle.textColor specified.|
|BackgroundColor (0x0002)|TestStyle.beckgroundColor specified.|
|UnderlineColor (0x0004)|TestStyle.underlineColor specified.|
|UnderlineType (0x0008)|TestStyle.underlineType specified.|


```cpp
// © Microsoft Corporation. All rights reserved.

import "Windows.Foundation.idl";
import "Windows.UI.Text.Core.idl";

#include <FeatureStaging-Input.h>

namespace Windows.UI.Input.Preview.Text
{
    [contractversion(1.0)]
    apicontract PreviewTextContract{};

    runtimeclass TextInputService;
    runtimeclass TextEditSession;
    runtimeclass TextBoxInfo;
    runtimeclass KeyboardInputProcessor;
    runtimeclass TextInputProvider;
    runtimeclass TextComposition;
    runtimeclass TextCompositionSegment;
    runtimeclass TextBoxInfoChangedEventArgs;
    runtimeclass TextBoxContentChangedEventArgs;
    runtimeclass FocusEnteredEventArgs;
    runtimeclass KeyEventReceivedEventArgs;
    runtimeclass InputDelegationModeChangedEventArgs;

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    enum PayloadResult
    {
        // The payload's edit session is still open. 
        InEditing,

        // Delivery of the payload or its result is in progress.
        Pending,

        // Accepted and applied by the target as is.
        Completed,

        // Applied but with some modifications by the target.
        Overridden,

        // A conflicting change from another source happened before this one,
        // the IME can still try and regenerate the payload (aka "replay input") for updated context.
        Outrun,

        // For whatever reason, the target explicily rejected (failed) the payload. 
        Rejected,

        // Either unsubmitted payload (TextEditSession) has been canceled by the IME
        // or submitted payload canceled later by the TSF due to inability to deliver it
        // (eg. due to lost connection, unregistrered texbox).
        Canceled,
    };

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    enum TextChangeSource
    {
        External,               // the source is unrecognizable by the TSF, like pasted or programmatically inserted/removed text
        HardwareKeyTyped,       // the result of a WM_CHAR (Win32) or OnCharacter (UWP)
        SoftwareKeyTyped,       // same as above but for injected keyboard input
        KeyboardImeInsertion,   // result of finalizing a keyboard IME composition 
        OtherImeInsertion,      // result of a non-keyboard IME input (e.g. dictation, handwriting)
        Reconversion,          // a committed text replaced by an IME for whatever reason (reconversion, spelling/grammar correction, etc)
        AutoCompletion,         // a typing prediction applied by user
        Mixed                   // the change is aggregated, potentially from different sources
    };

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    [flags]
    enum TextBoxFeatures
    {
        None                            = 0,
        ReadText                        = 0x00000001,
        WriteText                       = 0x00000002,
        AugmentText                     = 0x00000004,
    };

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    [flags]
    enum TextBoxSettings
    {
        None                    = 0,
        Private                 = 0x00000001,
        Multiline               = 0x00000002,
        VerticalWriting         = 0x00000004,
    };

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    enum TextBoxContentAttribute
    {
        None = 0,
        Selection,
        Text, 
        Property,
        Layout,
    };

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    enum KeyEventDeviceType
    {
        Undefined = 0,
        HardwareKeyboard,
        SoftwareKeyboard,
        Gamepad,
        Injection,
    };

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    [flags]
    enum TextStyleAttributes
    {
        None                = 0,
        TextColor           = 0x0001,
        BackgroundColor     = 0x0002,
        UnderlineColor      = 0x0004,
        UnderlineType       = 0x0008,
    };

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    struct TextStyle
    {
        TextStyleAttributes mask;
        Windows.UI.Color textColor;
        Windows.UI.Color backgroundColor;
        Windows.UI.Color underlineColor;
        Windows.UI.Text.UnderlineType underlineType;
    };

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    enum TextConversionMode
    {
        Undefined = 0,
        AlphanumericHalfWidth,
        AlphanumericFullWidth,
        NativeHalfWidth,
        NativeFullWidth,
        KatakanaHalfWidth,
        KatakanaFullWidth,
        NativeHalfWidthNativeSymbol,
        NativeFullWidthNativeSymbol,
        NoConversion,
        RequestConversion,
        NativeEudc,
    };

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    struct TextBoxId
    {
        UInt32 Value;
    };

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    struct TextInputServiceSubscription
    {
        TextBoxFeatures requiredEnabledFeatures;
        TextBoxFeatures requiredDisabledFeatures;
    };

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    [default_interface]
    runtimeclass KeyEventReceivedEventArgs
    {
        Windows.System.VirtualKey VirtualKey { get; };
        Windows.UI.Core.CorePhysicalKeyStatus KeyStatus { get; };
        String Unicode { get; };
        KeyEventDeviceType Source { get; };
        Boolean IsKeyPressed(Windows.System.VirtualKey vkey);
        Boolean IsToggleKeyOn(Windows.System.VirtualKey vkey);
        TextEditSession EditSession { get; };
        Boolean Handled { get; set; };
    }

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    [default_interface]
    runtimeclass FocusEnteredEventArgs
    {
        TextBoxInfo FocusedTextBoxInfo { get; };
    }

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    [default_interface]
    runtimeclass TextBoxInfo
    {
        TextBoxId Id { get; };
        Windows.UI.Text.Core.CoreTextInputScope InputScope { get; };
        String AppName { get; };
        String Url { get; };
        TextBoxSettings Settings { get; };
        TextBoxFeatures DisabledFeatures { get; };
    }

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    [default_interface]
    runtimeclass TextBoxInfoChangedEventArgs
    {
        TextBoxInfo TextBoxInfo { get; };
    }

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    [default_interface]
    runtimeclass TextBoxContentChangedEventArgs
    {
        TextBoxId TextBoxId { get; };
        TextChangeSource Source { get; };
        Windows.Foundation.Rect SelectionBounds { get; };
        Boolean IsContentAttributeChanged(TextBoxContentAttribute value);
    }

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    [default_interface]
    runtimeclass ConversionModeChangedEventArgs
    {
        TextConversionMode NewConversionMode { get; };
    }

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    [default_interface]
    runtimeclass ReconversionRequestedEventArgs
    {
        Windows.UI.Text.Core.CoreTextRange Range { get; };
    }

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    [default_interface]
    runtimeclass InputDelegationModeChangedEventArgs
    {
        Boolean DelegationOn { get; };
    }

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    [default_interface]
    runtimeclass TextCompositionSegment
    {
        // Segment content for different scenarios.

        // Interim text while composition is in editing.
        // With absence of ConvertedText, assumed as final text
        // when composition gets terminated or completed converted.
        String Text { get; set; };

        // Optional final text to replace the interim Text when composition
        // is completed by the IME or terminated by TSF or application.
        String ConvertedText { get; set; };

        // Also known as "reading string", it's the raw text input used to compose this segment.
        // Applied as final text when composition is completed via CompleteUnconverted().
        // Otherwise, applied as a property of the final text upon composition completion.
        String UnconvertedText { get; set; };

        // Segment properties.

        // Position of Text in the composition.
        // Zero-based relative to the composition begin. Range length is the Text length.
        Windows.UI.Text.Core.CoreTextRange Range { get; };

        // The segment's conversion state.
        Windows.UI.Text.Core.CoreTextFormatUpdatingReason ConversionState { get; set; };

        // Adjacent segments.
        // Return null at the corresponding ends of the composition;
        TextCompositionSegment Next { get; };
        TextCompositionSegment Previous { get; };

        // Text style suggested for segment rendering.
        TextStyle GetTextStyle();
        void SetTextStyle(TextStyle value);

    }

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    [default_interface]
    runtimeclass TextComposition
    {
        // Composition text to render while the composition is in progress.
        String Text { get; };

        // Navigation.

        // Returns the composition's first segment.
        TextCompositionSegment FirstSegment { get; };
        // Returns the composition segment where the current CaretPosition is.
        TextCompositionSegment SelectedSegment { get; };

        // Insertion point (index) within composition text.
        // Zero-based relatively to the composition current begin. 
        UInt32 CaretPosition { get; set; };

        // Text Insertion.

        // Inserts text at the current insertion point.
        // If the insertion point is adjacent to a segment edge, a new segment will be created for it.
        // Otherwise, the new text will be inserted into the selected segment.
        // (If IME wants to extend an existing segment with new text, update or deleted
        // composition text, it can do it by updating Text property of corresponding TextCompositionSegment)
        TextCompositionSegment InsertText(String text);

        // Completion.

        // Completes composition as fully converted text optionally augumeted with unconverted source (phonetics).
        void Complete();
        // Completes composition unconverted.
        void CompleteUnconverted();
        // Partial completion shifts the composition begin.
        void CompleteFirstSegment();
    }

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    [default_interface]
    runtimeclass TextEditSession
    {
        TextBoxId TextBoxId { get; };

        // Content reading.
        Int32 TextLength { get; };
        Windows.UI.Text.Core.CoreTextRange PopulatedRange { get; };
        Windows.Foundation.IAsyncAction PopulateAsync(Windows.UI.Text.Core.CoreTextRange range);
        String GetText(Windows.UI.Text.Core.CoreTextRange range);
        Windows.UI.Text.Core.CoreTextRange GetSelectedRange();
        void SetSelectedRange(Windows.UI.Text.Core.CoreTextRange value);

        // Basic (atomic) editing.
        Windows.UI.Text.Core.CoreTextRange ReplaceText(Windows.UI.Text.Core.CoreTextRange replaceRange, String text);

        // Compositions.
        TextComposition Composition { get; };
        TextComposition StartComposition();
        TextComposition StartReconversion(Windows.UI.Text.Core.CoreTextRange range);

        // Session completion.
        Boolean SubmitPayload();
        Windows.Foundation.IAsyncOperation<PayloadResult> SubmitPayloadAsync();
    }

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    [default_interface]
    runtimeclass KeyboardInputProcessor
    {
        // IME id and state.
        String InputProfile { get; };
        Boolean IsActive { get; };

        // Focus info.
        Boolean HasFocusedTextBox { get; };
        TextBoxId FocusedTextBoxId { get; };
        TextBoxInfo FocusedTextBoxInfo { get; };
        Windows.Foundation.IReference<Windows.Foundation.Rect> FocusedTextBoxBounds { get; };
        Windows.Foundation.IReference<Windows.Foundation.Rect> SelectionBounds { get; };
        TextConversionMode ConversionMode { get; set; };

        // Exploring and editing content of the focused TextBox.
        // Returns null when no TextBox in focus.
        TextEditSession CreateEditSession();

        // Events
        event Windows.Foundation.TypedEventHandler<KeyboardInputProcessor, Object>
            Activated;
        event Windows.Foundation.TypedEventHandler<KeyboardInputProcessor, Object>
            Deactivated;
        event Windows.Foundation.TypedEventHandler<KeyboardInputProcessor, KeyEventReceivedEventArgs>
            KeyEventReceived;
        event Windows.Foundation.TypedEventHandler<KeyboardInputProcessor, FocusEnteredEventArgs>
            FocusEntered;
        event Windows.Foundation.TypedEventHandler<KeyboardInputProcessor, Object>
            FocusRemoved;
        event Windows.Foundation.TypedEventHandler<KeyboardInputProcessor, ConversionModeChangedEventArgs>
            ConversionModeChanged;
        event Windows.Foundation.TypedEventHandler<KeyboardInputProcessor, TextBoxInfoChangedEventArgs>
            TextBoxInfoChanged;
        event Windows.Foundation.TypedEventHandler<KeyboardInputProcessor, TextBoxContentChangedEventArgs>
            TextBoxContentChanged;
        event Windows.Foundation.TypedEventHandler<KeyboardInputProcessor, Object>
            CompositionTerminated;
        event Windows.Foundation.TypedEventHandler<KeyboardInputProcessor, ReconversionRequestedEventArgs>
            ReconversionRequested;
    }

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    [default_interface]
    runtimeclass TextInputProvider
    {
        TextInputServiceSubscription GetSubscription();
        void SetSubscription(TextInputServiceSubscription subscription);

        // Focus info.
        Boolean HasFocusedTextBox { get; };
        TextBoxId FocusedTextBoxId { get; };
        TextBoxInfo FocusedTextBoxInfo { get; };
        Windows.Foundation.IReference<Windows.Foundation.Rect> FocusedTextBoxBounds { get; };
        Windows.Foundation.IReference<Windows.Foundation.Rect> SelectionBounds { get; };
        String InputLanguage { get; };

        // Exploring and editing content of the focused TextBox.
        // Returns null when no TextBox in focus.
        TextEditSession CreateEditSession();

        // Input delegation
        Boolean TryStartDelegation();
        void StopDelegation();

        // Events
        event Windows.Foundation.TypedEventHandler<TextInputProvider, FocusEnteredEventArgs>
            FocusEntered;
        event Windows.Foundation.TypedEventHandler<TextInputProvider, Object>
            FocusRemoved;
        event Windows.Foundation.TypedEventHandler<TextInputProvider, TextBoxInfoChangedEventArgs>
            TextBoxInfoChanged;
        event Windows.Foundation.TypedEventHandler<TextInputProvider, TextBoxContentChangedEventArgs>
            TextBoxContentChanged;
        event Windows.Foundation.TypedEventHandler<TextInputProvider, Object>
            CompositionTerminated;
        event Windows.Foundation.TypedEventHandler<TextInputProvider, ReconversionRequestedEventArgs>
            ReconversionRequested;
        event Windows.Foundation.TypedEventHandler<TextInputProvider, InputDelegationModeChangedEventArgs>
            InputDelegationModeChanged;
    }

    [contract(PreviewTextContract, 1.0)]
    [feature(Feature_TSF4_API)]
    [static_name("ITextInputServiceStatics", 91B68F5E-02ED-4E09-AE89-DFD735CF10BC)]
    [default_interface]
    runtimeclass TextInputService
    {
        static TextInputService GetForCurrentThread();
        KeyboardInputProcessor CreateKeyboardInputProcessor(const String inputProfile);
        TextInputProvider CreateTextInputProvider(const String inputProfile);
    }

    declare
    {
        interface Windows.Foundation.Collections.IVector<Windows.UI.Text.Core.CoreTextRange>;
    }
}
```