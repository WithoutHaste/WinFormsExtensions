using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Windows.GUI
{
	/// <summary>Data structure for managing redo/undo operations.</summary>
	/// <remarks>
	///  Usage:
	///  <list type="number">
	///   <item>Create one instance of a History for your application.</item>
	///   <item>Create an IHistoryAction for each unique action in your application.</item>
	///   <item>Add a new IHistoryAction to the History for each user action.</item>
	///   <item>Call Undo and Redo to undo/redo user actions.</item>
	///  </list>
	/// </remarks>
	public class History
	{
		private Stack<IHistoryAction> undo = new Stack<IHistoryAction>();
		private Stack<IHistoryAction> redo = new Stack<IHistoryAction>();

		/// <summary>New actions will not be added to History when it is turned off.</summary>
		public bool IsOn { get; protected set; }

		/// <summary></summary>
		public History()
		{
			On();
		}

		/// <summary>Turn history on. New actions will be saved.</summary>
		public void On()
		{
			IsOn = true;
		}

		/// <summary>Turn history off. New actions will not be saved, but Undo and Redo will still work.</summary>
		public void Off()
		{
			IsOn = false;
		}

		/// <summary>Add new action to the history. Clears the Redo list.</summary>
		public void Add(IHistoryAction action)
		{
			if(!IsOn) return;

			undo.Push(action);
			redo.Clear();
		}

		/// <summary>Undo an action. Calls IHistoryAction.Undo().</summary>
		/// <remarks>Does nothing if there is no action to undo.</remarks>
		public void Undo()
		{
			if(undo.Count == 0) return;

			IHistoryAction action = undo.Pop();
			redo.Push(action);
			action.Undo();
		}

		/// <summary>Redo an action. Calls IHistoryAction.Do().</summary>
		/// <remarks>Does nothing if there is no action to redo.</remarks>
		public void Redo()
		{
			if(redo.Count == 0) return;

			IHistoryAction action = redo.Pop();
			undo.Push(action);
			action.Do();
		}

		/// <summary>Clear history.</summary>
		public void Clear()
		{
			undo.Clear();
			redo.Clear();
		}
	}
}
