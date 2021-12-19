using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using workItOut.DAL;
using workItOut.Models;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace workItOut
{
    public partial class Form3 : Form
    {
       public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            WorkoutsRepository workoutsRepository = new WorkoutsRepository();
            SortedSet<Workout> workouts = new SortedSet<Workout>(workoutsRepository.GetWorkouts());

            foreach (var objectItem in workouts)
            {
                workoutCombobox.Items.Add(objectItem.Name);
                workoutCombobox.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 generateForm = new Form1();
            generateForm.Show();
            Visible = false;
        }

        private void showWorkoutsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkoutsRepository workoutsRepository = new WorkoutsRepository();
            SortedSet<Workout> workouts = new SortedSet<Workout>(workoutsRepository.GetWorkouts());

            string workoutName = workoutCombobox.SelectedItem.ToString();
            workoutsRepository.DeleteWorkouts(workoutName);
            workouts = new SortedSet<Workout>(workoutsRepository.GetWorkouts());

            workoutCombobox.Items.Clear();

            foreach (var objectItem in workouts)
            {
                workoutCombobox.Items.Add(objectItem.Name);
                workoutCombobox.SelectedIndex = 0;
            }
        }

        private void workoutCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebRequest request = HttpWebRequest.Create("https://yunuskurban.sinners.be/exercises.json");
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            string dataJson = reader.ReadToEnd();
            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<JsonModel.Root>(dataJson);

            Random rnd = new Random();
            int num = rnd.Next((data.exercises.Length - 11));

            workoutExercise.Items.Clear();

            for (int i = num; i < (num + 10); i++)
            {
                workoutExercise.Items.Add(data.exercises[i].name);
            }
        }
    }
}
