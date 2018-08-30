# History

Data structure for managing redo/undo operations.

Usage:  
1. Create one instance of a History for your application.  
2. Create an IHistoryAction for each unique action in your application.  
3. Add a new IHistoryAction to the History for each user action.  
4. Call Undo and Redo to undo/redo user actions.  

Base Type: System.Object

## Properties

### Boolean IsOn

New actions will not be added to History when it is turned off.

## Constructors

### History()

## Methods

### Void Add(IHistoryAction action)

Add new action to the history. Clears the Redo list.

### Void Clear()

Clear history.

### Void Off()

Turn history off. New actions will not be saved, but Undo and Redo will still work.

### Void On()

Turn history on.

### Void Redo()

Redo an action. Calls IHistoryAction.Do().

### Void Undo()

Undo an action. Calls IHistoryAction.Undo().

