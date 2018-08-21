# WithoutHaste.Windows.GUI

Behavior extensions for C# Windows Forms framework.

## Library

Release library at WithoutHaste.Windows.GUI/bin/Release/WithoutHaste.Windows.GUI.dll.

## LayoutHelper

Helper for placing and sizing controls in a Form.

Chain location and size directions together, then apply the layout to a control.

Location and size methods can be chained in any order. `Apply(Control)` must be the last command.

Syntax example: `LayoutHelper.Top(form).Left(form).Right(form).Height(25).Apply(control);`

### Location relative to parent control

| Place control at the inner edge of the parent |
|-------------------|---------------------------|
| Top(parent)		| Top(parent, margin)		|
| Bottom(parent)	| Bottom(parent, margin)	|
| Left(parent)		| Left(parent, margin)		|
| Right(parent)		| Right(parent, margin)		|

| Float control towards an inner edge of the parent, until it hits a previously placed control |
|-----------------------|-------------------------------|
| FloatTop(parent)		| FloatTop(parent, margin)		|
| FloatBottom(parent)	| FloatBottom(parent, margin)	|
| FloatLeft(parent)		| FloatLeft(parent, margin)		|
| FloatRight(parent)	| FloatRight(parent, margin)	|
(works like HTML float)
