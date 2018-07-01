# GetShapeType
C# program that count rectangular objects with overlapping colors and premeters between two arrays.
Create a class Shape, which contains 
• Public property: Colour (string) 
• A parameterized constructor that takes a single parameter and sets the property.  
• A virtual method GetShapeType() that returns the string “General Shape”. Method header: 
public virtual string GetShapeType() 
 
Create a class Rectangle, which inherits the Shape class and contains 
• Public properties: Height (double), Width (double). 
• A parameterized constructor that takes three parameters and sets the Height and Width 
properties, as well as the base class Colour property by using the “base” keyword. 
• An override method GetShapeType() that returns the word “Rectangle”. Method header: 
public override string GetShapeType() 
• A method GetPerimeter() that calculates and returns the rectangle perimeter. Method header: 
public double GetPerimeter() 
 
Rename the auto-generated class Program to Tester. In the Main() method of the class Tester, two arrays 
of Rectangle objects have already been created for you by using the shorthand notation.
