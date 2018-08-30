using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Windows.GUI
{
	/// <summary>An action that can be managed by a <see cref="History"/> object.</summary>
	public interface IHistoryAction
	{
		/// <summary>Action to run on "redo".</summary>
		void Do();
		/// <summary>Action to run on "undo".</summary>
		void Undo();
	}
}
