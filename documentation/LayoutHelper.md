# LayoutHelper

Static type.

Helper for placing and sizing controls in a Form relative to each other.

Uses method chaining for a fluent writing style. Location and sizing methods can be chained in any order. Apply must be the last command.

Add the control to its parent after using LayoutHelper.

All methods in [LayoutOptions](LayoutOptions.md) can also be called on LayoutHelper.

Base Type: System.Object

## Examples

```
form.Controls.Add(toolStrip);
form.Controls.Add(otherControl);
LayoutHelper.Below(toolStrip).MatchLeft(otherControl).Right(form).Height(25).Apply(control);
form.Controls.Add(control);
```

## Fields

### Constant Fields

#### AnchorStyles AnchorAll

Control.Anchor setting for anchoring in all directions.

