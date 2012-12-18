using System;
using System.Windows.Forms;

namespace MGestures
{
    public partial class MainForm : Form
    {
        private int currentTabIndex = 0;
        public MainForm()
        {
            InitializeComponent();
            currentTabIndex = tabControl.TabIndex;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mouseGestures.Enabled = true;
            mouseGestures.Gesture += mouseGestures_Gesture;
        }

        void mouseGestures_Gesture(object sender, MouseGestures.MouseGestureEventArgs e)
        {
            if (e.Gesture.Motions == "R")
            {
                if (currentTabIndex+1 < tabControl.TabCount)
                {
                    currentTabIndex++;
                }
            }
            if (e.Gesture.Motions == "L")
            {
                if (currentTabIndex > 0 )
                {
                    currentTabIndex--;
                }
            }
            if (e.Gesture.Motions == "UD")
            {
                Application.Exit();
            }
            tabControl.SelectedIndex = currentTabIndex;
        }
    }
}
