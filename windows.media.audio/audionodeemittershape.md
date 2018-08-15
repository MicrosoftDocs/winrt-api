---
-api-id: T:Windows.Media.Audio.AudioNodeEmitterShape
-api-type: winrt class
---

<!-- Class syntax.
public class AudioNodeEmitterShape : Windows.Media.Audio.IAudioNodeEmitterShape
-->

# Windows.Media.Audio.AudioNodeEmitterShape

## -description
Describes the shape in which an [AudioNodeEmitter](audionodeemitter.md) emits audio.

## -remarks
Create a cone emitter shape by calling [CreateCone](audionodeemittershape_createcone_1260552697.md). Create an omnidirectional emitter by calling [CreateOmnidirectional](audionodeemittershape_createomnidirectional_200506124.md). Assign an emitter shape to an emitter by calling the overload of the [AudioNodeEmitter](audionodeemitter_audionodeemitter_695720720.md) constructor. After the emitter has been created, retrieve the associated **AudioEmitterShape** object with the [AudioNodeEmitter.Shape](audionodeemitter_shape.md) property.

## -examples

## -see-also
