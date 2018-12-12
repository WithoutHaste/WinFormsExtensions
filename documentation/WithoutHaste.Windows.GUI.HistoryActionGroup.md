# [WithoutHaste.Windows.GUI](TableOfContents.WithoutHaste.Windows.GUI.md).HistoryActionGroup

**Sealed**  
**Inheritance:** object  
**Implements:** [IHistoryAction](WithoutHaste.Windows.GUI.IHistoryAction.md)  

An [IHistoryAction](WithoutHaste.Windows.GUI.IHistoryAction.md) that groups actions that must be undone/redone as a set.  

# Constructors

## HistoryActionGroup()

## HistoryActionGroup([List&lt;IHistoryAction&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1) actions)

Initialize group with an ordered list of actions.  

# Methods

## Add([IHistoryAction](WithoutHaste.Windows.GUI.IHistoryAction.md) action)

**void**  

Add an action to the end of the ordered list.  

## Do()

**void**  

Redo grouped actions in normal order.  

## Undo()

**void**  

Undo grouped actions in reverse order.  

