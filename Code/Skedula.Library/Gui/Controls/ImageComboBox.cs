/***********************************************************************************
* File:         ImageComboBox.cs                                                   *
* Contents:     Class ImageComboBox                                                *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu) & ChatGPT     *
* Date:         2025-12-05 13:54                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.ComponentModel;

namespace Skedula.Library.Gui.Controls
{
	public class ImageComboBox : ComboBox
	{
		// Your external dictionary: icon name → Image
		private Dictionary<string, Image> _imageDictionary;

		// Represents an item with an image + text
		public class ImageComboItem
		{
			public string Text		{get; set;}
			public string ImageKey	{get; set;}

			public override string ToString() => Text;
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Dictionary<string, Image> ImageDictionary
		{
			get => _imageDictionary;
			set
			{
				_imageDictionary = value;
				Invalidate();
			}
		}

		public ImageComboBox()
		{
			DrawMode		= DrawMode.OwnerDrawFixed;
			DropDownStyle	= ComboBoxStyle.DropDownList;
			ItemHeight		= 20;  // Enough for 16x16 icon + padding
		}

		// Add an item with image and text
		public void AddItem(string text, string imageKey)
		{
			Items.Add(new ImageComboItem
			{
				Text		= text,
				ImageKey	= imageKey
			});
		}

		protected override void OnDrawItem(DrawItemEventArgs e)
		{
			base.OnDrawItem(e);
			e.DrawBackground();

			if (e.Index < 0 || Items.Count == 0)
			{
				return;
			}

			var item = Items[e.Index] as ImageComboItem;

			if (item == null)
			{
				return;
			}
				
			var graphics = e.Graphics;
			int x = e.Bounds.Left + 3;
			int y = e.Bounds.Top + (e.Bounds.Height - 16) / 2;

			// Draw image if available
			if (_imageDictionary != null && item.ImageKey != null && _imageDictionary.TryGetValue(item.ImageKey, out Image img))
			{
				graphics.DrawImage(img, new Rectangle(x, y, 16, 16));
			}

			// Draw text
			using (var sf = new StringFormat
			{
				LineAlignment = StringAlignment.Center
			})
			{
				graphics.DrawString(
					item.Text,
					e.Font,
					new SolidBrush(e.ForeColor),
					new RectangleF(x + 20, e.Bounds.Top, e.Bounds.Width - 20, e.Bounds.Height),
					sf
				);
			}

			e.DrawFocusRectangle();
		}
	}
}
