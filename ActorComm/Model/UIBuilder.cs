using ActorComm.DataModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActorComm.Model
{
    public class UIBuilder
    {
        public UIBuilder()
        {
        }

        public Label CreateLabel(string name, string text, int x, int y, int w, int h)
        {
            return new Label()
            {
                Location = new Point(x, y),
                Name = name,
                Size = new Size(w, h),
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter
            };
        }

        public TextBox CreateTextBox(string name, int x, int y, int w, int h, string text, bool isRead = false)
        {
            return new TextBox()
            {
                Location = new Point(x, y),
                Name = name,
                Size = new Size(w, h),
                Text = text,
                ReadOnly = isRead
            };
        }

        public RichTextBox CreateRichTextBox(string name, int x, int y, int w, int h, string text, bool isRead = false)
        {
            return new RichTextBox()
            {
                Location = new Point(x, y),
                Name = name,
                Size = new Size(w, h),
                Text = text,
                ReadOnly = isRead
            };
        }

        public Button CreateButton(string name, string text, int x, int y, int w, int h, EventHandler handler = null)
        {
            var btn = new Button()
            {
                Location = new Point(x, y),
                Name = name,
                Size = new Size(w, h),
                Text = text,
                UseVisualStyleBackColor = true
            };

            if (handler != null)
                btn.Click += handler;

            return btn;
        }

        public ComboBox CreateComboBox(string name, IList<SelectItem> selectItems, int x, int y, int w, int h)
        {
            return new ComboBox()
            {
                Location = new Point(x, y),
                Name = name,
                DataSource = selectItems,
                DisplayMember = nameof(SelectItem.Key),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Size = new Size(w, h),
                ValueMember = nameof(SelectItem.Value),
            };
        }

        public TabControl CreateTabControl(string name, int x, int y, int w, int h)
        {
            return new TabControl()
            {
                Location = new Point(x, y),
                Name = name,
                Size = new Size(w, h),
            };
        }

        public TabPage CreateTabPage(string name, string text)
        {
            return new TabPage()
            {
                Name = name,
                Text = text
            };
        }
    }
}
