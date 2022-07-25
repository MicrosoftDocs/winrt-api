---
-api-id: T:Windows.UI.Composition.ExpressionAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class ExpressionAnimation : Windows.UI.Composition.CompositionAnimation, Windows.UI.Composition.IExpressionAnimation
-->

# Windows.UI.Composition.ExpressionAnimation

## -description
A Composition Animation that uses a mathematical equation to calculate the value for an animating property every frame.



## -remarks

The core of ExpressionAnimations allows a developer to define a mathematical equation that can be used to calculate the value of a targeted animating property each frame. This contrasts [KeyFrameAnimation](keyframeanimation.md) s, which use an interpolator to define how the animating property changes over time. The mathematical equation can be defined using references to properties of Composition objects, mathematical functions and operators and Input. Expression Animations open the door to making experiences such as sticky headers and parallax easily describable.

For a detailed walkthrough of using Composition ExpressionAnimation, check out the [Animations Overview document](/windows/uwp/graphics/composition-animation).

Use the [CompostionObject.StartAnimation](compositionobject_startanimation_709050842.md) and [CompostionObject.StopAnimation](compositionobject_stopanimation_1075337060.md) methods to start and stop the animation.

For a list of animatable properties, see the remarks on [CompostionObject.StartAnimation](compositionobject_startanimation_709050842.md).

### So why are Expression Animations useful?

The real power of Expression Animations comes from their ability to create a mathematical relationship with references to properties on other objects. This means you can have an equation referencing property values on other Composition objects, local variables, or even shared values in Composition Property Sets. As these references change and update over time, your expression will as well. This opens up bigger possibilities beyond traditional KeyFrame Animations where values must be discrete and pre-defined – ExpressionAnimations can make more dynamic animation experiences.

### Things to Note

+ ExpressionAnimation has an infinite lifetime – they will continue to run until they are explicitly stopped.
+ The mathematical equation will be input into the expression as a string – this can be done when constructing the ExpressionAnimation or separately by changing the property. If done during construction, the property will be set.
   + `ExpressionAnimation exp = _compositor.CreateExpressionAnimation(); exp.Expression = "this.Target.Offset.X / xWindowSize";`
   + `ExpressionAnimation exp = _compositor.CreateExpressionAnimation("this.Target.Offset.X / xWindowSize");`

+ The mathematical equation will be used every frame to calculate the value of the animating property (this is in stark contrast to [KeyFrameAnimation](keyframeanimation.md)s that use an interpolator)
+ Pay attention to the type of the property you plan to animate – your equation must resolve to the same type. Otherwise, an error will get thrown when the expression gets calculated. If your equation resolves to Nan (number/0), the system will use the previously calculated value



<!--<rem>For more information on what you can use to construct your expression or how to construct one, 
   see the <xref targtype="property_winrt" rid="w_ui_comp.expressionanimation_expression">Expression</xref> property 
   of <xref targtype="class_winrt" rid="w_ui_comp.expressionanimation">ExpressionAnimation</xref>.</rem>-->
The key to making dynamic animation UI with expression animations is to create an equation in which the references to properties or other values will change over time.

When attached to an animating property, the system will use this equation to calculate the value for the property for each frame. This means as a result, the system will re-evaluate all the references which will drive changes to the equation. For instance, in the example above, if either Visual A or B move due to another animation or input, the rotation angle of the line visual will change accordingly due to the equation.

When constructing the mathematical equation, there are a number of different components to keep in mind (For a detailed walkthrough of each of these components, see the Animation Overview):


+ Operators, Precedence and Associativity
   + The Expression string supports usage of typical mathematical operators (+, -, /, , etc.) you would expect to use in any equation.
   + When the expression is evaluated, it will adhere to operator precedence and associativity as defined in the C# language specification.

+ Property Parameters
   + When defining your Expression, you have the option to define type references to other properties on Composition Visuals, Property Sets or other C# objects.
   + To use in an expression string, utilize the “SetParameter” functions based on type, defining the string utilized in the expression string and its mapped value. These functions are listed as part of the top level [CompositionAnimation](compositionanimation.md) class.

+ Helper Functions and Constructors
   + The Expression can also leverage a list of functions and constructors for different object types in the equation.
   + There are also constructor methods that will construct an object type when the equation is evaluated by the system
   + A list of the functions per type is listed further below

+ Keywords
   + The Expression also can take advantage of a number of keywords that are treated differently when the Expression String Is evaluated. Consider these keywords and cannot be used as a string key in property references.
   + List of available keywords listed further below

+ Conditionals
   + An expression can also utilize conditional statements using the Ternary operator (condition ? ifTrue_expression : ifFalse_expression)
   + Ternary operators can be nested as the expression for the true or false statements.



### Expression Keywords

<table>
   <tr><th>Keyword</th><th>Description</th></tr>
   <tr><td>This.StartingValue</td><td>Provides a reference to the original starting value of the property that is being animated.</td></tr>
   <tr><td>This.CurrentValue</td><td>Provides a reference to the currently “known” value of the property</td></tr>
   <tr><td>This.FinalValue</td><td>Provides a reference to the final value of the animation (if defined) Note: Relevant for Implicit Animations, for explicit, maintains same functionality as This.StartingValue</td></tr>
   <tr><td>Pi</td><td>Provides a keyword reference to the value of PI</td></tr>
   <tr><td>True / False</td><td>Provides a reference to Boolean values of “true” or “false”</td></tr>
   <tr><td>This.Target</td><td>Provides a reference to the target object the animations is bound to.</td></tr>
</table>

### Expression Functions per Type

### Scalar
<table>
   <tr><th>Function and Constructor Operations</th><th>Description</th></tr>
   <tr><td>Abs(Float value)</td><td>Returns a Float representing the absolute value of the float parameter</td></tr>
   <tr><td>Clamp(Float value, Float min, Float max)</td><td>Returns a float value that is either greater than min and less than max or min if the value is less than min or max if the value is greater than max</td></tr>
   <tr><td>Max (Float value1, Float value2)</td><td>Returns the greater float between value1 and value2.</td></tr>
   <tr><td>Min (Float value1, Float value2)</td><td>Returns the lesser float between value1 and value2.</td></tr>
   <tr><td>Lerp(Float value1, Float value2, Float progress)</td><td>Returns a float that represents the calculated linear interpolation calculation between the two Scalar values based on the progress (Note: Progress is between 0.0 and 1.0)</td></tr>
   <tr><td>Slerp(Float value1, Float value2, Float progress)</td><td>Returns a Float that represents the calculated spherical interpolation between the two Float values based on the progress (Note: progress is between 0.0 and 1.0)</td></tr>
   <tr><td>Mod(Float value1, Float value2)</td><td>Returns the Float remainder resulting from the division of value1 and value2</td></tr>
   <tr><td>Ceil(Float value)</td><td>Returns the Float parameter rounded to next greater whole number</td></tr>
   <tr><td>Floor(Float value)</td><td>Returns the Float parameter to the next lesser whole number</td></tr>
   <tr><td>Sqrt(Float value)</td><td>Returns the square root of the Float parameter</td></tr>
   <tr><td>Square(Float value)</td><td>Returns the square of the Float parameter</td></tr>
   <tr><td>Sin(Float value1) Asin(Float value2)</td><td>Returns the Sin or ArcSin of the Float parameter</td></tr>
   <tr><td>Cos(Float value1) ACos(Float value2)</td><td>Returns the Cos or ArcCos of the Float parameter</td></tr>
   <tr><td>Tan(Float value1) ATan(Float value2)</td><td>Returns the Tan or ArcTan of the Float parameter</td></tr>
   <tr><td>Round(Float value)</td><td>Returns the Float parameter rounded to the nearest whole number</td></tr>
   <tr><td>Log10(Float value)</td><td>Returns the Log (base 10) result of the Float parameter</td></tr>
   <tr><td>Ln(Float value)</td><td>Returns the Natural Log result of the Float parameter</td></tr>
   <tr><td>Pow(Float value, Float power)</td><td>Returns the result of the Float parameter raised to a particular power</td></tr>
   <tr><td>ToDegrees(Float radians)</td><td>Returns the Float parameter converted into Degrees</td></tr>
   <tr><td>ToRadians(Float degrees)</td><td>Returns the Float parameter converted into Radians</td></tr>
</table>

### Vector2

<table>
   <tr><th>Function and Constructor Operations</th><th>Description</th></tr>
   <tr><td>Abs (Vector2 value)</td><td>Returns a Vector2 with absolute value applied to each component</td></tr>
   <tr><td>Clamp (Vector2 value1, Vector2 min, Vector2 max)</td><td>Returns a Vector2 that contains the clamped values for each respective component</td></tr>
   <tr><td>Max (Vector2 value1, Vector2 value2)</td><td>Returns a Vector2 that has performed a Max on each of the corresponding components from value1 and value2</td></tr>
   <tr><td>Min (Vector2 value1, Vector2 value2)</td><td>Returns a Vector2 that has performed a Min on each of the corresponding components from value1 and value2</td></tr>
   <tr><td>Scale(Vector2 value, Float factor)</td><td>Returns a Vector2 with each component of the vector multiplied by the scaling factor.</td></tr>
   <tr><td>Transform(Vector2 value, Matrix3x2 matrix)</td><td>Returns a Vector2 resulting from the linear transformation between a Vector2 and a Matrix3x2 (aka multiplying a vector by a matrix).</td></tr>
   <tr><td>Lerp(Vector2 value1, Vector2 value2, Scalar progress)</td><td>Returns a Vector2 that represents the calculated linear interpolation calculation between the two Vector2 values based on the progress (Note: Progress is between 0.0 and 1.0)</td></tr>
   <tr><td>Length(Vector2 value)</td><td>Returns a Float value representing the length/magnitude of the Vector2</td></tr>
   <tr><td>LengthSquared(Vector2)</td><td>Returns a Float value representing the square of the length/magnitude of a Vector2</td></tr>
   <tr><td>Distance(Vector2 value1, Vector2 value2)</td><td>Returns a Float value representing the distance between two Vector2 values</td></tr>
   <tr><td>DistanceSquared(Vector2 value1, Vector2 value2)</td><td>Returns a Float value representing the square of the distance between two Vector2 values</td></tr>
   <tr><td>Normalize(Vector2 value)</td><td>Returns a Vector2 representing the unit vector of the parameter where all components have been normalized</td></tr>
   <tr><td>Vector2(Float x, Float y)</td><td>Constructs a Vector2 using two Float parameters</td></tr>
</table>

### Vector3

<table>
   <tr><th>Function and Constructor Operations</th><th>Description</th></tr>
   <tr><td>Abs (Vector3 value)</td><td>Returns a Vector3 with absolute value applied to each component</td></tr>
   <tr><td>Clamp (Vector3 value1, Vector3 min, Vector3 max)</td><td>Returns a Vector3 that contains the clamped values for each respective component</td></tr>
   <tr><td>Max (Vector3 value1, Vector3 value2)</td><td>Returns a Vector3 that has performed a Max on each of the corresponding components from value1 and value2</td></tr>
   <tr><td>Min (Vector3 value1, Vector3 value2)</td><td>Returns a Vector3 that has performed a Min on each of the corresponding components from value1 and value2</td></tr>
   <tr><td>Scale(Vector3 value, Float factor)</td><td>Returns a Vector3 with each component of the vector multiplied by the scaling factor.</td></tr>
   <tr><td>Lerp(Vector3 value1, Vector3 value2, Float progress)</td><td>Returns a Vector3 that represents the calculated linear interpolation calculation between the two Vector3 values based on the progress (Note: Progress is between 0.0 and 1.0)</td></tr>
   <tr><td>Length(Vector3 value)</td><td>Returns a Float value representing the length/magnitude of the Vector3</td></tr>
   <tr><td>LengthSquared(Vector3)</td><td>Returns a Float value representing the square of the length/magnitude of a Vector3</td></tr>
   <tr><td>Distance(Vector3 value1, Vector3 value2)</td><td>Returns a Float value representing the distance between two Vector3 values</td></tr>
   <tr><td>DistanceSquared(Vector3 value1, Vector3 value2)</td><td>Returns a Float value representing the square of the distance between two Vector3 values</td></tr>
   <tr><td>Normalize(Vector3 value)</td><td>Returns a Vector3 representing the unit vector of the parameter where all components have been normalized</td></tr>
   <tr><td>Vector3(Float x, Float y, Float z)</td><td>Constructs a Vector3 using three Float parameters</td></tr>
</table>

### Vector4

<table>
   <tr><th>Function and Constructor Operations</th><th>Description</th></tr>
   <tr><td>Abs (Vector4 value)</td><td>Returns a Vector3 with absolute value applied to each component</td></tr>
   <tr><td>Clamp (Vector4 value1, Vector4 min, Vector4 max)</td><td>Returns a Vector4 that contains the clamped values for each respective component</td></tr>
   <tr><td>Max (Vector4 value1 Vector4 value2)</td><td>Returns a Vector4 that has performed a Max on each of the corresponding components from value1 and value2</td></tr>
   <tr><td>Min (Vector4 value1 Vector4 value2)</td><td>Returns a Vector4 that has performed a Min on each of the corresponding components from value1 and value2</td></tr>
   <tr><td>Scale(Vector3 value, Float factor)</td><td>Returns a Vector3 with each component of the vector multiplied by the scaling factor.</td></tr>
   <tr><td>Transform(Vector4 value, Matrix4x4 matrix)</td><td>Returns a Vector4 resulting from the linear transformation between a Vector4 and a Matrix4x4 (aka multiplying a vector by a matrix).</td></tr>
   <tr><td>Lerp(Vector4 value1, Vector4 value2, Float progress)</td><td>Returns a Vector4 that represents the calculated linear interpolation calculation between the two Vector4 values based on the progress (Note: progress is between 0.0 and 1.0)</td></tr>
   <tr><td>Length(Vector4 value)</td><td>Returns a Float value representing the length/magnitude of the Vector4</td></tr>
   <tr><td>LengthSquared(Vector4)</td><td>Returns a Float value representing the square of the length/magnitude of a Vector4</td></tr>
   <tr><td>Distance(Vector4 value1, Vector4 value2)</td><td>Returns a Float value representing the distance between two Vector4 values</td></tr>
   <tr><td>DistanceSquared(Vector4 value1, Vector4 value2)</td><td>Returns a Float value representing the square of the distance between two Vector4 values</td></tr>
   <tr><td>Normalize(Vector4 value)</td><td>Returns a Vector4 representing the unit vector of the parameter where all components have been normalized</td></tr>
   <tr><td>Vector4(Float x, Float y, Float z, Float w)</td><td>Constructs a Vector4 using four Float parameters</td></tr>
</table>

### Matrix3x2

<table>
   <tr><th>Function and Constructor Operations</th><th>Description</th></tr>
   <tr><td>Scale(Matrix3x2 value, Float factor)</td><td>Returns a Matrix3x2 with each component of the matrix multiplied by the scaling factor.</td></tr>
   <tr><td>Inverse(Matrix 3x2 value)</td><td>Returns a Matrix3x2 object that represents the reciprocal matrix</td></tr>
   <tr><td>Matrix3x2(Float M11, Float M12, Float M21, Float M22,

Float M31, Float M32)</td><td>Constructs a Matrix3x2 using 6 Float parameters</td></tr>
   <tr><td>Matrix3x2.CreateFromScale(Vector2 scale)</td><td>Constructs a Matrix3x2 from a Vector2 representing scale[scale.X, 0.0

0.0, scale.Y

0.0, 0.0 ]</td></tr>
   <tr><td>Matrix3x2.CreateFromTranslation(Vector2 translation)</td><td>Constructs a Matrix3x2 from a Vector2 representing translation[1.0, 0.0,

0.0, 1.0,

translation.X, translation.Y]</td></tr>
   <tr><td>Matrix3x2.CreateSkew(Float x, Float y, Vector2 centerpoint)</td><td>Constructs a Matrix3x2 from two Float and Vector2[1.0, Tan(y),

Tan(x), 1.0,

-centerpoint.Y * Tan(x), -centerpoint.X * Tan(y)]</td></tr>
   <tr><td>Matrix3x2.CreateRotation(Float radians)</td><td>Constructs a Matrix3x2 from a rotation in radians[Cos(radians), Sin(radians),

-Sin(radians), Cos(radians),

0.0, 0.0 ]</td></tr>
   <tr><td>Matrix3x2.CreateTranslation(Vector2 translation)</td><td>(Exact same as CreateFromTranslation for Matrix3x2, just different naming for new consistency)</td></tr>
   <tr><td>Matrix3x2.CreateScale(Vector2 scale)</td><td>(Exact same as CreateFromScale for Matrix3x2, just different naming for new consistency)</td></tr>
</table>

### Matrix4x4

<table>
   <tr><th>Function and Constructor Operations</th><th>Description</th></tr>
   <tr><td>Scale(Matrix4x4 value, Float factor)</td><td>Returns a Matrix 4x4 with each component of the matrix multiplied by the scaling factor.</td></tr>
   <tr><td>Inverse(Matrix4x4)</td><td>Returns a Matrix4x4 object that represents the reciprocal matrix</td></tr>
   <tr><td>Matrix4x4(Float M11, Float M12, Float M13, Float M14, Float M21, Float M22, Float M23, Float M24,

Float M31, Float M32, Float M33, Float M34,

Float M41, Float M42, Float M43, Float M44)</td><td>Constructs a Matrix4x4 using 16 Float parameters</td></tr>
   <tr><td>Matrix4x4(Matrix3x2 matrix)</td><td>Constructs a Matrix4x4 using a Matrix3x2[matrix.11, matrix.12, 0, 0,

matrix.21, matrix.22, 0, 0,

0, 0, 1, 0,

matrix.31, matrix.32, 0, 1]</td></tr>
   <tr><td>Matrix4x4.CreateFromScale(Vector3 scale)</td><td>Constructs a Matrix4x4 from a Vector3 representing scale[scale.X, 0.0, 0.0, 0.0,

0.0, scale.Y, 0.0, 0.0,

0.0, 0.0, scale.Z, 0.0,

0.0, 0.0, 0.0, 1.0]</td></tr>
   <tr><td>Matrix4x4.CreateFromTranslation(Vector3 translation)</td><td>Constructs a Matrix4x4 from a Vector3 representing translation[1.0, 0.0, 0.0, 0.0,

0.0, 1.0, 0.0, 0.0,

0.0, 0.0, 1.0, 0.0,

translation.X, translation.Y, translation.Z, 1.0]</td></tr>
   <tr><td>Matrix4x4.CreateTranslation(Vector3 translation)</td><td>(Exact same as CreateFromTranslation for Matrix4x4, just different naming for new consistency)</td></tr>
   <tr><td>Matrix4x4.CreateScale(Vector3 scale)</td><td>(Exact same as CreateFromScale for Matrix4x4, just different naming for new consistency)</td></tr>
   <tr><td>Matrix4x4.CreateFromAxisAngle(Vector3 axis, Float angle)</td><td>Constructs a Matrix4x4 from a Vector3 axis and a Float representing an angle</td></tr>
</table>

### Quaternion

<table>
   <tr><th>Function and Constructor Operations</th><th>Description</th></tr>
   <tr><td>Slerp(Quaternion value1, Quaternion value2, Float progress)</td><td>Returns a Quaternion that represents the calculated spherical interpolation between the two Quaternion values based on the progress (Note: progress is between 0.0 and 1.0)</td></tr>
   <tr><td>Concatenate(Quaternion value1 Quaternion value2)</td><td>Returns a Quaternion representing a concatenation of two Quaternions (aka a Quaternion that represents a combined two individual rotations)</td></tr>
   <tr><td>Length(Quaternion value)</td><td>Returns a Float value representing the length/magnitude of the Quaternion.</td></tr>
   <tr><td>LengthSquared(Quaternion)</td><td>Returns a Float value representing the square of the length/magnitude of a Quaternion</td></tr>
   <tr><td>Normalize(Quaternion value)</td><td>Returns a Quaternion whose components have been normalized</td></tr>
   <tr><td>Quaternion.CreateFromAxisAngle(Vector3 axis, Scalar angle)</td><td>Constructs a Quaternion from a Vector3 axis and a Scalar representing an angle</td></tr>
   <tr><td>Quaternion(Float x, Float y, Float z, Float w)</td><td>Constructs a Quaternion from four Float values</td></tr>
</table>

### Color

<table>
   <tr><th>Function and Constructor Operations</th><th>Description</th></tr>
   <tr><td>ColorLerp(Color colorTo, Color colorFrom, Float progress)</td><td>Returns a Color object that represents the calculated linear interpolation value between two color objects based on a given progress. (Note: Progress is between 0.0 and 1.0)</td></tr>
   <tr><td>ColorLerpRGB(Color colorTo, Color colorFrom, Float progress)</td><td>Returns a Color object that represents the calculated linear interpolation value between two objects based on a given progress in the RGB color space.</td></tr>
   <tr><td>ColorLerpHSL(Color colorTo, Color colorFrom, Float progress)</td><td>Returns a Color object that represents the calculated linear interpolation value between two objects based on a given progress in the HSL color space.</td></tr>
   <tr><td>ColorRGB(Float a, Float r, Float g, Float b)</td><td>Constructs an object representing Color defined by ARGB components.  (Note: ARGB components are between 0.0 and 255.0)</td></tr>
   <tr><td>ColorHsl(Float h, Float s, Float l)</td><td>Constructs an object representing Color defined by HSL components (Note: Hue is defined from 0 and 2pi)</td></tr>
</table>

## -examples
```csharp

void AnimateOpacity()
{
  // The Expression below will animate the opacity of the target Visual based on its position to the edge of the window.
  ExpressionAnimation exp = _compositor.CreateExpressionAnimation();
  float xWinSize = (float) Window.Current.Bounds.Width;
  SpriteVisual targetVisual = _compositor.CreateSpriteVisual();

  // Define the Expression Equation and references
  exp.Expression = "this.Target.Offset.X / xWindowSize";
  exp.SetScalarParameter("xWindowSize", xWinSize);

  // Attach the animation to the target Opacity property
  targetVisual.StartAnimation("Opacity", exp);
}
         
```

```csharp

// Creates an Expression that calculates the angle between two Visual's Offset vectors 
// And assigns it to the RotationAngle of a third Visual
void angleBetweenVectors()
{
  SpriteVisual visualA = _compositor.CreateSpriteVisual();
  SpriteVisual visualB = _compositor.CreateSpriteVisual();

  SpriteVisual lineVisual = _compositor.CreateSpriteVisual();
  lineVisual.Size = new Vector2(50.0f, 5.0f);

  var rotationAnimation = _compositor.CreateExpressionAnimation();
  rotationAnimation.SetReferenceParameter("A", visualA);
  rotationAnimation.SetReferenceParameter("B", visualB);

  rotationAnimation.Expression = "ACos( ( (A.Offset.X * B.Offset.X) + (A.Offset.Y*B.Offset.Y) + (A.Offset.Z * B.Offset.Z) ) / ( Length(A.Offset) * 	Length(B.Offset) ) )";
  lineVisual.StartAnimation("RotationAngle", rotationAnimation);
}
         
         
```



## -see-also
[Animations Overview document](/windows/uwp/graphics/composition-animation), [Expression Property](expressionanimation_expression.md)
