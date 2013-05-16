using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_MouseDown(object sender, MouseEventArgs e)
        {
            this.DoDragDrop(sender, DragDropEffects.Copy);
        }

        private void codeArea_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void codeArea_DragDrop(object sender, DragEventArgs e)
        {
            ToolStripButton button = e.Data.GetData(typeof(ToolStripButton))
                           as ToolStripButton;
            if (button != null)
            {
                if (button.Equals(toolStripButton1))
                {
                    MessageBox.Show("Добавлен Элемент1");
                }
                else if (button.Equals(toolStripButton2))
                {
                    MessageBox.Show("Добавлен Элемент2");
                }
            }
        }

        private void toolStripButton2_MouseDown(object sender, MouseEventArgs e)
        {
            this.DoDragDrop(sender, DragDropEffects.Copy);
        }
    }
}
