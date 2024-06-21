Author: skitale-design

#### Description:

The library counts the areas of figures. Area calculation for circle, triangle, rectangle is realized.  

An array of side lengths of the figure is passed to the static constructor. Depending on the number of elements in the array, the FigureBuilder method creates a suitable object.

Create a figure:
```
float[] data = { 3, 4, 5 };
IFigure figure = Figure.FigureBuilder(data);

```

Calculate the area of the figure:
```
figure.GetArea()

```

Verify that the triangle is rectangular:
```
((Triangle)figure).IsRigth()

```
The library is CLS-compliant.