﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Windows.GUI
{
	public interface IHistoryAction
	{
		void Do();
		void Undo();
	}
}
