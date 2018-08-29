# History

Data structure for managing redo/undo operations.

## History class

Create one instance of a `History` for your application.

Methods:  
`void Add(IHistoryAction)`  
`IHistoryAction Undo()`  
`IHistoryAction Redo()`

## IHistoryAction interface

Create a class inheriting `IHistoryAction` for each action in your application.

As actions occur, add them to the `History`.

## HistoryActionGroup class

Use `HistoryActionGroup` to save actions that must be undone/redone as a set.