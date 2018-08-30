using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Windows.GUI
{
	/// <summary>
	/// An <see cref="IHistoryAction"/> that groups actions that must be undone/redone as a set.
	/// </summary>
	public sealed class HistoryActionGroup : IHistoryAction
	{
		private List<IHistoryAction> actions = new List<IHistoryAction>();

		/// <summary></summary>
		public HistoryActionGroup()
		{
		}

		/// <summary>Initialize group with an ordered list of actions.</summary>
		public HistoryActionGroup(List<IHistoryAction> actions)
		{
			this.actions.AddRange(actions);
		}

		/// <summary>Add an action to the end of the ordered list.</summary>
		public void Add(IHistoryAction action)
		{
			actions.Add(action);
		}

		/// <summary>Redo grouped actions in normal order.</summary>
		public void Do()
		{
			foreach(IHistoryAction action in actions)
			{
				action.Do();
			}
		}

		/// <summary>Undo grouped actions in reverse order.</summary>
		public void Undo()
		{
			List<IHistoryAction> reversed = new List<IHistoryAction>(actions);
			reversed.Reverse();
			foreach(IHistoryAction action in reversed)
			{
				action.Undo();
			}
		}
	}
}
