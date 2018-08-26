using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Windows.GUI
{
	/// <summary>
	/// Singleton object. Access icons with IconManager.REDO and similar.
	/// </summary>
	public class IconManager
	{
		public static Image REDO { get { return Singleton.icon_redo; } }
		public static Image UNDO { get { return Singleton.icon_undo; } }
		public static Image SWATCH_SELECTOR { get { return Singleton.icon_swatch_selector; } }

		private Image icon_redo;
		private Image icon_undo;
		private Image icon_swatch_selector;

		private static IconManager singleton;
		public static IconManager Singleton {
			get {
				if(singleton == null)
				{
					singleton = new IconManager();
				}
				return singleton;
			}
		}

		private IconManager()
		{
			icon_redo = WithoutHaste.Windows.GUI.Properties.Resources.ICON_REDO;
			icon_undo = WithoutHaste.Windows.GUI.Properties.Resources.ICON_UNDO;
			icon_swatch_selector = WithoutHaste.Windows.GUI.Properties.Resources.ICON_SWATCH_SELECTOR;
		}
	}
}
