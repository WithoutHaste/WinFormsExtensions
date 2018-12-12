# [WithoutHaste.Windows.GUI](TableOfContents.WithoutHaste.Windows.GUI.md).History

**Inheritance:** object  

Data structure for managing redo/undo operations.  

**Remarks:**  
Usage:  
1. Create one instance of a History for your application.  
2. Create an IHistoryAction for each unique action in your application.  
3. Add a new IHistoryAction to the History for each user action.  
4. Call Undo and Redo to undo/redo user actions.  

# Properties

## IsOn

**bool { public get; protected set; }**  

New actions will not be added to History when it is turned off.  

# Constructors

## History()

# Methods

## Add([IHistoryAction](WithoutHaste.Windows.GUI.IHistoryAction.md) action)

**void**  

Add new action to the history. Clears the Redo list.  

## Clear()

**void**  

Clear history.  

## Off()

**void**  

Turn history off. New actions will not be saved, but Undo and Redo will still work.  

## On()

**void**  

Turn history on. New actions will be saved.  

## Redo()

**void**  

Redo an action. Calls IHistoryAction.Do().  

**Remarks:**  
Does nothing if there is no action to redo.  

## Undo()

**void**  

Undo an action. Calls IHistoryAction.Undo().  

**Remarks:**  
Does nothing if there is no action to undo.  

