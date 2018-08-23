using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Windows.GUI
{
	public sealed class HistoryActionGroup : IHistoryAction
	{
		List<IHistoryAction> actions = new List<IHistoryAction>();

		public HistoryActionGroup()
		{
		}

		public HistoryActionGroup(List<IHistoryAction> actions)
		{
			this.actions.AddRange(actions);
		}

		public void Add(IHistoryAction action)
		{
			actions.Add(action);
		}

		/// <summary>
		/// Redo grouped actions in normal order.
		/// </summary>
		public void Do()
		{
			foreach(IHistoryAction action in actions)
			{
				action.Do();
			}
		}

		/// <summary>
		/// Undo grouped actions in reverse order.
		/// </summary>
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
