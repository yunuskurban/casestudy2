using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using workItOut.DAL;
using workItOut.Models;


namespace workItOut
{
    public partial class Form2 : Form
    {
        List<string> selectedExercises = new List<string>();
        
        private string getData()
        {
            WebRequest request = HttpWebRequest.Create("https://yunuskurban.sinners.be/exercises.json");
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            string dataJson = reader.ReadToEnd();
            return dataJson;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_LoadAsync(object sender, EventArgs e)
        {
            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<JsonModel.Root>(getData());

            for (int i = 0; i < data.exercises.Length; i++)
            {
                if (!typeCombo.Items.Contains(data.exercises[i].category))
                {
                    typeCombo.Items.Add(data.exercises[i].category);
                }
                if (!muscleCombo.Items.Contains(data.exercises[i].primaryMuscles[0]))
                {
                    muscleCombo.Items.Add(data.exercises[i].primaryMuscles[0]);
                }
                exercisesListbox.Items.Add(data.exercises[i].name );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 startpage = new Form1();
            startpage.Show();
            Visible = false;
        }

        private void getExercises()
        {
            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<JsonModel.Root>(getData());

            exercisesListbox.Items.Clear();

            if (typeCombo.SelectedIndex != -1 && muscleCombo.SelectedIndex != -1)
            {
                string checkedType = typeCombo.Text;
                string checkedMuscle = muscleCombo.Text;

                for (int x = 0; x < data.exercises.Length; x++)
                {
                    if (checkedType == "cardio")
                    {
                        if (data.exercises[x].category == checkedType)
                        {
                            exercisesListbox.Items.Add(data.exercises[x].name);
                            if (selectedExercises.Contains(data.exercises[x].name))
                            {
                                exercisesListbox.SetItemChecked(exercisesListbox.Items.Count - 1, true);
                            }
                        }
                    }
                    else
                    {
                        if (data.exercises[x].category == checkedType && data.exercises[x].primaryMuscles[0] == checkedMuscle)
                        {
                            exercisesListbox.Items.Add(data.exercises[x].name);
                            if (selectedExercises.Contains(data.exercises[x].name))
                            {
                                exercisesListbox.SetItemChecked(exercisesListbox.Items.Count - 1, true);
                            }
                        }
                    }
                    
                }
            }
            else if (typeCombo.SelectedIndex != -1 && muscleCombo.SelectedIndex == -1)
            {
                string checkedType = typeCombo.Text;

                for (int x = 0; x < data.exercises.Length; x++)
                {
                    if (data.exercises[x].category == checkedType)
                    {
                        exercisesListbox.Items.Add(data.exercises[x].name);
                        if (selectedExercises.Contains(data.exercises[x].name))
                        {
                            exercisesListbox.SetItemChecked(exercisesListbox.Items.Count - 1, true);
                        } 
                    }
                }
            }
            else if (typeCombo.SelectedIndex == -1 && muscleCombo.SelectedIndex != -1)
            {
                string checkedMuscle = muscleCombo.Text;

                for (int x = 0; x < data.exercises.Length; x++)
                {
                    if (data.exercises[x].primaryMuscles[0] == checkedMuscle)
                    {
                        exercisesListbox.Items.Add(data.exercises[x].name);
                        if (selectedExercises.Contains(data.exercises[x].name))
                        {
                            exercisesListbox.SetItemChecked(exercisesListbox.Items.Count - 1, true);
                        }
                    }
                }
            }
            Console.WriteLine("form 2: oefeningen gefilterd en opnieuw ingeladen");
        }

        private void typeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            getExercises();
        }

        private void muscleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            getExercises();
        }
        private void exercisesListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int x = 0; x < exercisesListbox.CheckedItems.Count; x++)
            {
                if (!selectedExercises.Contains(exercisesListbox.CheckedItems[x].ToString()))
                {
                    selectedExercises.Add(exercisesListbox.CheckedItems[x].ToString());
                }
            }
            showChoosenExercises();
        }

        private void showChoosenExercises()
        {
            workoutListbox.Items.Clear();
            foreach (string item in selectedExercises)
            {
                workoutListbox.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkoutsRepository workoutsRepository = new WorkoutsRepository();
            SortedSet<Workout> workouts = new SortedSet<Workout>(workoutsRepository.GetWorkouts());

            string workoutName = nameWorkoutTXT.Text;

            if (workoutName != "")
            {
                workoutListbox.Items.Clear();
                nameWorkoutTXT.Text = "";
                Workout workout = new Workout { Name = workoutName };
                workoutsRepository.InsertWorkout(workout);
            }
        }
    }
}
