# History

Data structure for managing redo/undo operations.

## History object

1. Create one instance of a `History` for your application. 
2. Create an `IHistoryAction` for each unique action in your application.
3. Add a new `IHistoryAction` to the `History` for each user action.
4. Call `Undo` and `Redo` to undo/redo user actions.

### Properties

`bool IsOn`: true when the `History` is saving actions

### Constructor

Parameterless constructor: `new History()`

History begins in "On" mode.

### Methods

#### Add

Adds a new action to the history and clears the redo-list.

`history.Add(IHistoryAction);`

#### Clear

Clears the entire history.

`history.Clear();`

#### Off

Turn `History` to inactive mode.
- New actions will not be saved
- `Undo` and `Redo` can still be used

`history.Off();`

#### On

Turn `History` to active mode.

`history.On();`

#### Redo

Calls the `Redo` method on the last stored "redo" action.

`history.Redo();`

#### Undo

Calls the `Undo` method on the last stored "undo" action.

`history.Undo();`

## IHistoryAction interface

Create a class inheriting `IHistoryAction` for each unique action in your application.

As actions occur, add them to the `History`.

### Methods

`void Do();`: executed on "redo"  
`void Undo();`: executed on "undo"  

## HistoryActionGroup object

An `IHistoryAction` class. Use `HistoryActionGroup` to save actions that must be undone/redone as a set.

### Constructors

Parameterless: `new HistoryActionGroup();`  

Initialize actions: `new HistoryActionGroup(List<IHistoryAction>);`

### Methods

#### Add

Add an action to the end of the group. This action will be "redone" after all the other actions.

`actionGroup.Add(IHistoryAction);`

#### Do

Execute all the "redo" actions in the group, in order.

`actionGroup.Do();`

#### Undo

Execute all the "undo" actions in the group, in reverse order.

`actionGroup.Undo();`