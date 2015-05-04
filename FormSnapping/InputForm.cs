using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace FormDragging
{
    public partial class InputForm : Form
    {
        Student[] s = new Student[4];
        int i = 0;
        public InputForm()
        {
            InitializeComponent();
            for (int k = 0; k < 4; k++)
            {
                s[k] = new Student();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            s[i] = new Student();
            if (i < 3)
            {
                label_header.Text = "Entar the information of student " + (i + 2) + ":";
                s[i].name = textBoxName.Text;
                s[i].id = textBoxRoll.Text;
                s[i].discipline = textBoxDIsc.Text;

                i++;
                textBoxName.Clear();
                textBoxRoll.Clear();
                textBoxDIsc.Clear();


            }
            else
            {
                s[i].name = textBoxName.Text;
                s[i].id = textBoxRoll.Text;
                s[i].discipline = textBoxDIsc.Text;
                textBoxName.Clear();
                textBoxRoll.Clear();
                textBoxDIsc.Clear();
                label_header.Text = "Press Show Button...";
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            FormDragging f = new FormDragging();
            f.setStudent(s);
            f.Show();
        }
    }
}
