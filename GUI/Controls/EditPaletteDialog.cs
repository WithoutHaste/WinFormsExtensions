﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WithoutHaste.Drawing.Colors;

namespace WithoutHaste.Windows.GUI
{
	public class EditPaletteDialog : Form
	{
		private string fullFilename;
		private ColorPalette colorPalette;
		private ColorPalettePanel swatchPanel;
		private ColorDataPanel colorDataPanel;
		private bool editedSinceSave;
		private History history;

		public string FullFilename {
			get {
				return fullFilename;
			}
		}

		public EditPaletteDialog(string fullFilename)
		{
			this.fullFilename = fullFilename;
			if(fullFilename == null)
			{
				this.colorPalette = new ColorPalette();
			}
			else
			{
				this.colorPalette = WithoutHaste.Drawing.Colors.ColorPalette.Load(fullFilename);
			}
			this.editedSinceSave = false;

			this.Width = 650;
			this.Height = 500;
			this.Text = "Edit Palette";
			this.FormClosing += new FormClosingEventHandler(Form_OnClosing);

			Init();
			InitMenus();
			InitHistory();
		}

		private void Init()
		{
			int margin = 10;

			ToolStrip toolStrip = new ToolStrip();
			toolStrip.Dock = DockStyle.Top;
			toolStrip.Items.Add("Undo", IconManager.UNDO, Form_OnUndo);
			toolStrip.Items.Add("Redo", IconManager.REDO, Form_OnRedo);
			this.Controls.Add(toolStrip);

			Button addButton = new Button();
			LayoutHelper.Bottom(this, margin).Left(this, margin).Height(25).Width(80).Apply(addButton);
			addButton.Text = "New Color";
			addButton.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
			addButton.Click += new EventHandler(Form_OnAdd);
			this.Controls.Add(addButton);

			ContextMenu colorContextMenu = new ContextMenu();
			colorContextMenu.MenuItems.Add("Edit", Color_OnEdit);
			colorContextMenu.MenuItems.Add("Add New Based on This", Color_OnAddBasedOn);
			colorContextMenu.MenuItems.Add("Delete", Color_OnDelete);

			colorDataPanel = new ColorDataPanel(readOnly: true);
			LayoutHelper.Above(addButton, margin).Right(this, margin).Below(toolStrip).Width(150).Apply(colorDataPanel);
			colorDataPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			this.Controls.Add(colorDataPanel);

			swatchPanel = new ColorPalettePanel(colorPalette, Color_OnSelect, colorContextMenu);
			LayoutHelper.Left(this, margin).Below(toolStrip).LeftOf(colorDataPanel).Above(addButton, margin).Apply(swatchPanel);
			swatchPanel.Anchor = LayoutHelper.AnchorAll;
			UpdateColorData();
			this.Controls.Add(swatchPanel);

			Button okButton = new Button();
			LayoutHelper.Bottom(this, margin).MatchRight(swatchPanel, margin).Height(25).Width(80).Apply(okButton);
			okButton.Text = "Done";
			okButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
			okButton.Click += new EventHandler(Form_OnDone);
			this.Controls.Add(okButton);

			Button saveAsButton = new Button();
			LayoutHelper.Bottom(this, margin).LeftOf(okButton, margin * 3).Height(25).Width(80).Apply(saveAsButton);
			saveAsButton.Text = "Save As";
			saveAsButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
			saveAsButton.Click += new EventHandler(Form_OnSaveAs);
			this.Controls.Add(saveAsButton);

			Button saveButton = new Button();
			LayoutHelper.Bottom(this, margin).LeftOf(saveAsButton, margin).Height(25).Width(80).Apply(saveButton);
			saveButton.Text = "Save";
			saveButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
			saveButton.Click += new EventHandler(Form_OnSave);
			this.Controls.Add(saveButton);
		}

		private void InitMenus()
		{
			//only exists for easy keyboard shortcut functionality
			//so remains hidden

			MenuItem editMenu = new MenuItem("Edit");
			MenuItem undoAction = new MenuItem("Undo", new EventHandler(Form_OnUndo), Shortcut.CtrlZ);
			MenuItem redoAction = new MenuItem("Redo", new EventHandler(Form_OnRedo), Shortcut.CtrlY);
			MenuItem newColor = new MenuItem("New Color", new EventHandler(Form_OnAdd), Shortcut.CtrlN);
			MenuItem savePalette = new MenuItem("Save Palette", new EventHandler(Form_OnSave), Shortcut.CtrlS);
			MenuItem saveAsPalette = new MenuItem("Save Palette As", new EventHandler(Form_OnSaveAs), Shortcut.F12);
			editMenu.MenuItems.Add(undoAction);
			editMenu.MenuItems.Add(redoAction);
			editMenu.MenuItems.Add(newColor);
			editMenu.MenuItems.Add(savePalette);
			editMenu.MenuItems.Add(saveAsPalette);
			editMenu.Visible = false;

			this.Menu = new MainMenu();
			this.Menu.MenuItems.Add(editMenu);
		}

		private void InitHistory()
		{
			history = new History();
		}

		#region Event Handlers

		private void Form_OnUndo(object sender, EventArgs e)
		{
			history.Undo();
		}

		private void Form_OnRedo(object sender, EventArgs e)
		{
			history.Redo();
		}

		private void Form_OnClosing(object sender, FormClosingEventArgs e)
		{
			if(editedSinceSave)
			{
				DialogResult result = MessageBox.Show("Discard changes to palette since last save?", "Discard Changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				if(result == DialogResult.Cancel)
				{
					e.Cancel = true; //don't close form after all
					return;
				}
			}
			this.DialogResult = DialogResult.OK;
		}

		private void Form_OnAdd(object sender, EventArgs e)
		{
			using(NewColorDialog dialog = new NewColorDialog())
			{
				dialog.StartPosition = FormStartPosition.Manual;
				dialog.Location = new Point(this.Location.X + 30, this.Location.Y + 30);
				if(dialog.ShowDialog() == DialogResult.OK)
				{
					Color newColor = dialog.Color;
					int index = colorPalette.Count;
					AddColorToPalette(newColor, index);

					AddPaletteColorAction action = new AddPaletteColorAction(newColor, index);
					action.InsertColor += new PaletteEventHandler(Palette_OnAddColor);
					action.RemoveColor += new PaletteEventHandler(Palette_OnRemoveColor);
					history.Add(action);
				}
			}
		}

		private void Form_OnSaveAs(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Palette Files|*.aco;*.gpl;*.pal";
			saveFileDialog.Title = "Save as Palette File";

			if(saveFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
			{
				return;
			}
			Save(saveFileDialog.FileName);
			fullFilename = saveFileDialog.FileName; //when save is successful, keep new filename
		}

		private void Form_OnSave(object sender, EventArgs e)
		{
			if(fullFilename == null)
			{
				Form_OnSaveAs(sender, e);
			}
			else
			{
				Save(fullFilename);
			}
		}

		private void Form_OnDone(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Color_OnSelect(object sender, EventArgs e)
		{
			UpdateColorData();
		}

		private void Color_OnEdit(object sender, EventArgs e)
		{
			Control control = (sender as MenuItem).GetContextMenu().SourceControl;
			Color oldColor = control.BackColor;
			using(NewColorDialog dialog = new NewColorDialog(oldColor))
			{
				dialog.StartPosition = FormStartPosition.Manual;
				dialog.Location = new Point(this.Location.X + 30, this.Location.Y + 30);
				if(dialog.ShowDialog() == DialogResult.OK)
				{
					Color newColor = dialog.Color;
					ReplaceColorInPalette(control.TabIndex, newColor);

					ReplacePaletteColorAction action = new ReplacePaletteColorAction(control.TabIndex, oldColor, newColor);
					action.ReplaceColor += new PaletteEventHandler(Palette_OnReplaceColor);
					history.Add(action);
				}
			}
		}

		private void Color_OnAddBasedOn(object sender, EventArgs e)
		{
			Control control = (sender as MenuItem).GetContextMenu().SourceControl;
			Color oldColor = control.BackColor;
			using(NewColorDialog dialog = new NewColorDialog(oldColor))
			{
				dialog.StartPosition = FormStartPosition.Manual;
				dialog.Location = new Point(this.Location.X + 30, this.Location.Y + 30);
				if(dialog.ShowDialog() == DialogResult.OK)
				{
					Color newColor = dialog.Color;
					int index = colorPalette.Count;
					AddColorToPalette(newColor, index);
					history.Add(new AddPaletteColorAction(newColor, index));
				}
			}
		}

		private void Color_OnDelete(object sender, EventArgs e)
		{
			Control control = (sender as MenuItem).GetContextMenu().SourceControl;
			RemoveColorFromPalette(control.TabIndex);

			RemovePaletteColorAction action = new RemovePaletteColorAction(control.BackColor, control.TabIndex);
			action.RemoveColor += new PaletteEventHandler(Palette_OnRemoveColor);
			action.InsertColor += new PaletteEventHandler(Palette_OnAddColor);
			history.Add(action);
		}

		private void Palette_OnRemoveColor(object sender, PaletteEventArgs e)
		{
			RemoveColorFromPalette(e.Index);
		}

		private void Palette_OnAddColor(object sender, PaletteEventArgs e)
		{
			AddColorToPalette(e.Color, e.Index);
		}

		private void Palette_OnReplaceColor(object sender, PaletteEventArgs e)
		{
			ReplaceColorInPalette(e.Index, e.Color);
		}

		#endregion

		private void Save(string fullFilename)
		{
			colorPalette.Save(fullFilename);
			editedSinceSave = false;
		}

		private void AddColorToPalette(Color color, int index)
		{
			colorPalette.Insert(color, index);
			swatchPanel.DisplayColors(colorPalette);
			editedSinceSave = true;
		}

		private void RemoveColorFromPalette(int index)
		{
			colorPalette.RemoveAt(index);
			swatchPanel.DisplayColors(colorPalette);
			editedSinceSave = true;
		}

		private void ReplaceColorInPalette(int index, Color newColor)
		{
			colorPalette.ReplaceAt(index, newColor);
			swatchPanel.DisplayColors(colorPalette);
			editedSinceSave = true;
		}

		private void UpdateColorData()
		{
			colorDataPanel.Color = swatchPanel.SelectedColor;
		}

		private void ResetHistory()
		{
			history.Clear();
		}
	}
}
