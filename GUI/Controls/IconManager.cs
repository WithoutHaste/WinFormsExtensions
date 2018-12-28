using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutHaste.Windows.GUI
{
	/// <summary>
	/// Standard application icons, supplied as System.Drawing.Image.
	/// </summary>
	/// <example>
	///  <code>
	///Image image = IconManager.UNDO;
	///  </code>
	/// </example>
	public class IconManager
	{
		/// <summary>Right-bendy arrow.</summary>
		public static Image REDO { get { return Singleton.icon_redo; } }
		/// <summary>Left-bendy arrow.</summary>
		public static Image UNDO { get { return Singleton.icon_undo; } }
		/// <summary>Black and white square.</summary>
		public static Image SWATCH_SELECTOR { get { return Singleton.icon_swatch_selector; } }
		/// <summary>Magnifying glass with plus-sign.</summary>
		public static Image ZOOM_IN { get { return Singleton.icon_zoom_in; } }
		/// <summary>Magnifying glass with minus-sign.</summary>
		public static Image ZOOM_OUT { get { return Singleton.icon_zoom_out; } }
		/// <summary>Fit-to-screen arrows.</summary>
		public static Image ZOOM_FIT { get { return Singleton.icon_zoom_fit; } }
		/// <summary>Rounded rectangle outline.</summary>
		public static Image ZOOM_100 { get { return Singleton.icon_zoom_100; } }
		/// <summary>Eye dropper tool.</summary>
		public static Image DROPPER { get { return Singleton.icon_dropper; } }
		/// <summary>Add or plus sign.</summary>
		public static Image ADD { get { return Singleton.icon_add; } }
		/// <summary>An open folder.</summary>
		public static Image OPEN_FILE { get { return Singleton.icon_open_file; } }
		/// <summary>A floppy disk.</summary>
		public static Image SAVE { get { return Singleton.icon_save; } }
		/// <summary>A red floppy disk.</summary>
		public static Image SAVE_RED { get { return Singleton.icon_save_red; } }
		/// <summary>Star-burst or poof sign.</summary>
		public static Image NEW { get { return Singleton.icon_new; } }
		/// <summary>An open folder with a star-burst sign.</summary>
		public static Image NEW_FOLDER { get { return Singleton.icon_new_folder; } }
		/// <summary>A document with a star-burst sign.</summary>
		public static Image NEW_FILE { get { return Singleton.icon_new_file; } }

		private Image icon_redo;
		private Image icon_undo;
		private Image icon_swatch_selector;
		private Image icon_zoom_in;
		private Image icon_zoom_out;
		private Image icon_zoom_fit;
		private Image icon_zoom_100;
		private Image icon_dropper;
		private Image icon_add;
		private Image icon_open_file;
		private Image icon_save;
		private Image icon_save_red;
		private Image icon_new;
		private Image icon_new_folder;
		private Image icon_new_file;

		private static IconManager singleton;
		internal static IconManager Singleton {
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
			icon_dropper = WithoutHaste.Windows.GUI.Properties.Resources.ICON_DROPPER;
			icon_add = WithoutHaste.Windows.GUI.Properties.Resources.ICON_ADD;
			icon_open_file = WithoutHaste.Windows.GUI.Properties.Resources.ICON_OPEN_FILE;
			icon_save = WithoutHaste.Windows.GUI.Properties.Resources.ICON_SAVE;
			icon_save_red = WithoutHaste.Windows.GUI.Properties.Resources.ICON_SAVE_RED;
			icon_new = WithoutHaste.Windows.GUI.Properties.Resources.ICON_NEW;
			icon_new_folder = WithoutHaste.Windows.GUI.Properties.Resources.ICON_NEW_FOLDER;
			icon_new_file = WithoutHaste.Windows.GUI.Properties.Resources.ICON_NEW_FILE;
		}
	}
}
