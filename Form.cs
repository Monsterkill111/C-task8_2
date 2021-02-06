using System;
using System.Windows.Forms;

namespace IT_Task8
{
    public partial class MainForm : Form
    {
        private int counter = 1;
        public MainForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            AddActor(new EmergencyWrap(new AverageEmergency()));
            AddActor(new EmergencyWrap(new AverageEmergency()));
            AddActor(new Crosswalk("Crosswalk #1"));
            AddActor(new Crosswalk("Crosswalk #2"));
            AddActor(new Crosswalk("Crosswalk #3"));
            AddActor(new Crosswalk("Crosswalk #4"));
            counter += 4;
        }

        private void AddActor(TimeEntity entity)
        {
            var box = new TextBox { Text = "Name: " + entity.Name + $", current state: resting.", Width = 600, ReadOnly = true };
            entity.Action += state => box.Text = "Name: " + entity.Name + $", current state: {state}";
            Panel.Controls.Add(box);
        }

        private void AddCrosswalk_Click(object sender, EventArgs e) {
            var name = "Crosswalk #" + counter;
            counter++;
            AddActor(new Crosswalk(name));
        }

        private void AddSlowEmergency_Click(object sender, EventArgs e)
        {
            AddActor(new EmergencyWrap(new SlowEmergency()));
        }

        private void AddAverageEmergency_Click(object sender, EventArgs e)
        {
            AddActor(new EmergencyWrap(new AverageEmergency()));
        }

        private void AddFastEmergency_Click(object sender, EventArgs e)
        {
            AddActor(new EmergencyWrap(new FastEmergency()));
        }
    }
}
