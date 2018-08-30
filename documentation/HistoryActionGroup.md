# HistoryActionGroup

An [IHistoryAction](IHistoryAction.md) that groups actions that must be undone/redone as a set.

Base Type: System.Object

## Constructors

### HistoryActionGroup()

### HistoryActionGroup(System.Collections.Generic.List{WithoutHaste.Windows.GUI.IHistoryAction})

Initialize group with an ordered list of actions.

## Methods

### Void Add(IHistoryAction action)

Add an action to the end of the ordered list.

### Void Do()

Redo grouped actions in normal order.

### Void Undo()

Undo grouped actions in reverse order.

