using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Windows.GUI
{
	public class History
	{
		private Stack<IHistoryAction> undo = new Stack<IHistoryAction>();
		private Stack<IHistoryAction> redo = new Stack<IHistoryAction>();

		/// <summary>
		/// New actions will not be added to History when it is turned off.
		/// </summary>
		public bool IsOn { get; protected set; }

		public History()
		{
			On();
		}

		public void On()
		{
			IsOn = true;
		}

		public void Off()
		{
			IsOn = false;
		}

		public void Add(IHistoryAction action)
		{
			if(!IsOn) return;

			undo.Push(action);
			redo.Clear();
		}

		public void Undo()
		{
			if(undo.Count == 0) return;

			IHistoryAction action = undo.Pop();
			redo.Push(action);
			action.Undo();
		}

		public void Redo()
		{
			if(redo.Count == 0) return;

			IHistoryAction action = redo.Pop();
			undo.Push(action);
			action.Do();
		}

		public void Clear()
		{
			undo.Clear();
			redo.Clear();
		}
	}
}
