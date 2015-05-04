﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using Entity;

namespace FormDragging
{
    public partial class FormDragging : Form
    {
        int x, y, temp, x1, x2, x3, x4, y1, y2, y3, y4, xx, yy;
        
        Student[] st = new Student[4];
        public void setStudent(Student[] sp)
        {
            this.st = sp;
        }
        BOLayer s = new BOLayer();
        Panel p;
        public FormDragging()
        {
            InitializeComponent();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            temp = 1;
            x1 = panel1.Location.X;
            y1 = panel1.Location.Y;
            xx = s.getxx(x1, y1);
            s.pinitialization(panel1, panel2, panel3, panel4);
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            temp = 0;
            yy = s.paneldragdrop((panel1));
            s.sort(xx, yy);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            temp = 2;
            x1 = panel2.Location.X;
            y1 = panel2.Location.Y;
            xx = s.getxx(x1, y1);
            s.pinitialization(panel1, panel2, panel3, panel4);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            temp = 0;
            yy = s.paneldragdrop((panel2));
            s.sort(xx, yy);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            temp = 3;
            x1 = panel3.Location.X;
            y1 = panel3.Location.Y;
            xx = s.getxx(x1, y1);
            s.pinitialization(panel1, panel2, panel3, panel4);
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            temp = 0;
            yy = s.paneldragdrop(panel3);
            s.sort(xx, yy);
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            temp = 4;
            x1 = panel4.Location.X;
            y1 = panel4.Location.Y;
            xx = s.getxx(x1, y1);
            s.pinitialization(panel1, panel2, panel3, panel4);
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            temp = 0;
            yy = s.paneldragdrop(panel4);
            s.sort(xx, yy);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (temp == 1)
            {
                panel1.Location = new Point(Cursor.Position.X - 200, Cursor.Position.Y - 200);
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (temp == 2)
            {
                panel2.Location = new Point(Cursor.Position.X - 200, Cursor.Position.Y - 200);
            }
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (temp == 3)
            {
                panel3.Location = new Point(Cursor.Position.X - 200, Cursor.Position.Y - 200);
            }
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (temp == 4)
            {
                panel4.Location = new Point(Cursor.Position.X - 200, Cursor.Position.Y - 200);
            }
        }

        private void FormDragging_Load(object sender, EventArgs e)
        {
            Name1.Text = st[0].name;
            Roll1.Text = st[0].id;
            Discipline1.Text = st[0].discipline;

            Name2.Text = st[1].name;
            Roll2.Text = st[1].id;
            Discipline2.Text = st[1].discipline;

            Name3.Text = st[2].name;
            Roll3.Text = st[2].id;
            Discipline3.Text = st[2].discipline;

            Name4.Text = st[3].name;
            Roll4.Text = st[3].id;
            Discipline4.Text = st[3].discipline;
        }
    }
}
