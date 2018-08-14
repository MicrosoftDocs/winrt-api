---
-api-id: T:Windows.Foundation.Diagnostics.LoggingFields
-api-type: winrt class
---

<!-- Class syntax.
public class LoggingFields : Windows.Foundation.Diagnostics.ILoggingFields
-->

# Windows.Foundation.Diagnostics.LoggingFields

## -description
Represents a sequence of event fields and provides methods for adding fields to the sequence.

## -remarks
You can pass this object to a **LoggingChannel**.[LogEvent](loggingactivity_logevent_1783961521.md) method to provide the payload (data) for an event.

This class is not thread-safe. Ensure that an instance of this class is not modified simultaneously by multiple threads.

This class can create nested structures. To create a structure, call [BeginStruct](loggingfields_beginstruct_359748894.md) to mark the start of the structure. Then add the fields that are part of the structure. Finally, call [EndStruct ](loggingfields_endstruct_494341079.md) to mark the end of the structure. Structures can be nested up to eight levels deep.



> [!TIP]
> Field names and field tags should be used for infrequently-changing metadata, not for frequently-changing data. The values for field names and tags should generally be constants, not variables. Event names, event tags, field names, field tags, and field formats are part of an event’s identity, and each unique event identity is tracked by a [LoggingChannel](loggingchannel.md). Using frequently-changing values for field names and tags will lead to increased memory usage in your application, and may make event decoding or analysis more complex.

## -examples

## -see-also
