using AutoInspection.Core;
using AutoInspection.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace AutoInspection
{
    public partial class Autorization : Form
    {
        int kolp = 0;
        int tik= 60;
        int tik1 = 60;
        // DispatcherTimer timer3 = new DispatcherTimer();
        private DateTime timerEnd;

        public Autorization()
        {
            InitializeComponent();
           /* timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();*/
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            kolp++;           
            try
            {
                using (var context = new EntityContext())
                {
                    var Inspector = context.Inspector.FirstOrDefault(inspector => inspector.Login.Equals(LoginTextBox.Text) && inspector.Password.Equals(PasswordTextBox.Text));
                    if (Inspector == null)
                        throw new Exception("Нет такого инспектора");
                    else
                    
                    Singleton<Inspector1>.Instance().CreateFromPerson(Inspector);
                    new Kartochka_driver().ShowDialog();

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if (kolp >= 3)
            {
                EnterButton.Enabled = false;
                timer3.Interval = 1000;
                timer3.Tick += new EventHandler(timer1_Tick);
                timer3.Start();
                    
            }
               
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
           /* if (tik >= 0)
            {
                label1.Text = tik.ToString();
                tik--;
            }

            else
                EnterButton.Enabled = true;*/
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (tik >= 0)
            {
                label1.Text = tik.ToString();
                tik--;
            }

            else
                this.Close();
        }
    }
}
