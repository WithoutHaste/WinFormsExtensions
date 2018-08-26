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
		public static Image ZOOM_IN { get { return Singleton.icon_zoom_in; } }
		public static Image ZOOM_OUT { get { return Singleton.icon_zoom_out; } }
		public static Image ZOOM_FIT { get { return Singleton.icon_zoom_fit; } }
		public static Image ZOOM_100 { get { return Singleton.icon_zoom_100; } }

		private Image icon_redo;
		private Image icon_undo;
		private Image icon_swatch_selector;
		private Image icon_zoom_in;
		private Image icon_zoom_out;
		private Image icon_zoom_fit;
		private Image icon_zoom_100;

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
			icon_zoom_in = WithoutHaste.Windows.GUI.Properties.Resources.ICON_ZOOM_IN;
			icon_zoom_out = WithoutHaste.Windows.GUI.Properties.Resources.ICON_ZOOM_OUT;
			icon_zoom_fit = WithoutHaste.Windows.GUI.Properties.Resources.ICON_ZOOM_FIT;
			icon_zoom_100 = WithoutHaste.Windows.GUI.Properties.Resources.ICON_ZOOM_100;
		}
	}
}
