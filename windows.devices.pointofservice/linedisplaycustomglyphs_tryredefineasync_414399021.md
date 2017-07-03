---
-api-id: M:Windows.Devices.PointOfService.LineDisplayCustomGlyphs.TryRedefineAsync(System.UInt32,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> LineDisplayCustomGlyphs.TryRedefineAsync(UInt32 glyphCode, IBuffer glyphData)
-->

# Windows.Devices.PointOfService.LineDisplayCustomGlyphs.TryRedefineAsync

## -description
Attempts to asynchronously define a custom glyph.

## -parameters
### -param glyphCode
The character for which the glyph will be defined.

### -param glyphData
The glyph data.

## -returns
Returns True if the glyph was successfully defined; otherwise, False.

## -remarks
The glyph is defined as bits representing each pixel packed into bytes, using whole bytes to represent each row.

The minimum number of bytes are sent for each row, based on [LineDisplayCustomGlyphs.SizeInPixels](linedisplaycustomglyphs_sizeinpixels.md) and using 8 bits per byte. Bytes are sent left-to-right across each row; if more than one byte is required per row, the leftmost byte is sent first. The lowest-order bit within a byte represents the rightmost pixel. Bits that do not represent pixels are the highest order bits and their value is ignored. Rows are sent from the top down.

A 10 pixel wide glyph would have the two leftmost pixels represented in bits 1 and 0 of the first byte, respectively. The remaining 8 pixels would be represented in the second byte.

Enough rows must be sent to define the entire character. The hardware defines whether changing the definition of a glyph causes currently displayed characters to change or the change appears only when next drawn.

## -see-also

## -examples

