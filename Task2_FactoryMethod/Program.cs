ShapeFactory circleFactory = new CircleFactory();
IShape circle = circleFactory.CreateShape();
circle.Draw();

ShapeFactory rectangleFactory = new RectangleFactory();
IShape rectangle = rectangleFactory.CreateShape();
rectangle.Draw();
