# WithoutHaste.Windows.GUI

Behavior extensions for C# Windows Forms framework.

## Library

Release library at WithoutHaste.Windows.GUI/bin/Release/WithoutHaste.Windows.GUI.dll.

## LayoutHelper

### Examples

Place a Control at the top of a Form, stretching from one side to the other:

`LayoutHelper.Top(form).Left(form).Right(form).Height(25).Apply(control);`


