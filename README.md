# WithoutHaste.Windows.GUI

Behavior extensions for C# Windows Forms framework.

## Library

Release library at WithoutHaste.Windows.GUI/bin/Release/WithoutHaste.Windows.GUI.dll.

## LayoutHelper

Helper for placing and sizing controls in a Form.

Chain location and size directions together, then apply the layout to a control.

Location and size methods can be chained in any order. `Apply(Control)` must be the last command. Add the control to its parent after using LayoutHelper.

Syntax example: `LayoutHelper.Top(form).Left(form).Right(form).Height(25).Apply(control);`

### Location/Size relative to parent control

Place control edge at the inner edge of the parent:  
`Top(parent)` `Top(parent, margin)`  
`Bottom(parent)` `Bottom(parent, margin)`  
`Left(parent)` `Left(parent, margin)`  
`Right(parent)` `Right(parent, margin)`

Float control edge towards an inner edge of the parent, until it runs into a previously placed control:  
`FloatTop(parent)` `FloatTop(parent, margin)`  
`FloatBottom(parent)` `FloatBottom(parent, margin)`  
`FloatLeft(parent)` `FloatLeft(parent, margin)`  
`FloatRight(parent)` `FloatRight(parent, margin)`  

### Location/Size relative to sibling control

Place control edge at the same location as a sibling control:  
`MatchTop(sibling)` `MatchTop(sibling, margin)`  
`MatchBottom(sibling)` `MatchBottom(sibling, margin)`  
`MatchLeft(sibling)` `MatchLeft(sibling, margin)`  
`MatchRight(sibling)` `MatchRight(sibling, margin)`

Place control edge directly next to a sibling control:  
`Below(sibling)` `Below(sibling, margin)`  
`Above(sibling)` `Above(sibling, margin)`  
`RightOf(sibling)` `RightOf(sibling, margin)`  
`LeftOf(sibling)` `LeftOf(sibling, margin)`  

### Absolute size

Set size:  
`Width(width)`  
`Height(height)`  

Set size and center control in parent:  
`CenterWidth(parent, width)`  
`CenterHeight(parent, height)`  

## History

Data structure for managing redo/undo operations.

### History Class

Create one instance of a `History` for your application.

Methods:  
`void Add(IHistoryAction)`  
`IHistoryAction Undo()`  
`IHistoryAction Redo()`

### IHistoryAction Interface

Create a class inheriting `IHistoryAction` for each action in your application.

As actions occur, add them to the `History`.

### HistoryActionGroup Class

Use `HistoryActionGroup` to save actions that must be undone/redone as a set.