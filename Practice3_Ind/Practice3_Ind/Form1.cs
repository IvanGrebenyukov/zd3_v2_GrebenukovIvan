using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practice3_Ind
{
    public partial class Form1 : Form
    {
        private List<RoadWorks> roadWorksList; // Список объектов базового класса RoadWorks
        private List<WeatherRoadWorks> weatherRoadWorksList; // Список объектов класса-наследника WeatherRoadWorks

        private Dictionary<int, double>
            calculatedQualityDict; // Словарь для хранения рассчитанного качества объектов базового класса

        private Dictionary<int, double>
            calculatedModifiedQualityDict; // Словарь для хранения рассчитанного измененного качества объектов класса-наследника

        public Form1()
        {
            InitializeComponent();
            roadWorksList = new List<RoadWorks>();
            weatherRoadWorksList = new List<WeatherRoadWorks>();
            calculatedQualityDict = new Dictionary<int, double>();
            calculatedModifiedQualityDict = new Dictionary<int, double>();
            comboBoxMaterial.Items.AddRange(new string[] { "Асфальт", "Бетон", "Гравий" });

            // Заполнение ComboBox с видами дороги
            comboBoxRoadType.Items.AddRange(new string[] { "Шоссе", "Городская улица", "Проселочная дорога" });
        }

        private void buttonAddBaseObject_Click(object sender, EventArgs e)
        {
            if (comboBoxMaterial.SelectedItem == null)
            {
                MessageBox.Show("Выберите материал", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double width = Convert.ToDouble(numericUpDownWidth.Value);
            double length = Convert.ToDouble(numericUpDownLength.Value);
            double massPerSquareMeter = Convert.ToDouble(numericUpDownWeigth.Value);
            int id = Convert.ToInt32(numericUpDownID.Value);
            string roadMaterial = comboBoxMaterial.SelectedItem.ToString();
            if (RoadWorks.ContainsID(roadWorksList, id))
            {
                MessageBox.Show("Объект с таким ID уже существует", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            RoadWorks roadWorks = new RoadWorks(id, length, width, massPerSquareMeter, roadMaterial);
            roadWorksList.Add(roadWorks);

            listBoxBaseObject.Items.Add(roadWorks.Print());

        }



        private void buttonBaseQuality_Click(object sender, EventArgs e)
        {
            if (listBoxBaseObject.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите объект из списка.", "Ошибка");
                return;
            }

            int selectedIndex = listBoxBaseObject.SelectedIndex;
            RoadWorks selectedRoadWorks = roadWorksList[selectedIndex];

            if (calculatedQualityDict.ContainsKey(selectedRoadWorks.ID))
            {
                MessageBox.Show("Результат уже рассчитан для выбранного объекта.", "Ошибка");
                return;
            }

            double quality = CalculateQuality(selectedRoadWorks);

            calculatedQualityDict.Add(selectedRoadWorks.ID, quality);


            listBoxBaseQuality.Items.Add($"{selectedRoadWorks.ID}-{quality}");
        }

        

        private void buttonDeleteBaseObject_Click(object sender, EventArgs e)
        {
            if (listBoxBaseObject.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите объект из списка.", "Ошибка");
                return;
            }

            int selectedIndex = listBoxBaseObject.SelectedIndex;
            RoadWorks selectedRoadWorks = roadWorksList[selectedIndex];


            if (calculatedQualityDict.ContainsKey(selectedRoadWorks.ID))
            {

                calculatedQualityDict.Remove(selectedRoadWorks.ID);
            }


            roadWorksList.Remove(selectedRoadWorks);


            listBoxBaseObject.Items.RemoveAt(selectedIndex);
            UpdateCalculatedResultsRoadWorksListBox();
        }

        private void buttonsAddSuccessorObject_Click(object sender, EventArgs e)
        {
            if (comboBoxMaterial.SelectedItem == null)
            {
                MessageBox.Show("Выберите материал.", "Ошибка");
                return;
            }
            if (comboBoxRoadType.SelectedItem == null)
            {
                MessageBox.Show("Выберите тип дороги.", "Ошибка");
                return;
            }

            double width = Convert.ToDouble(numericUpDownWidth.Value);
            double length = Convert.ToDouble(numericUpDownLength.Value);
            double massPerSquareMeter = Convert.ToDouble(numericUpDownWeigth.Value);
            int id = Convert.ToInt32(numericUpDownID.Value);
            string roadMaterial = comboBoxMaterial.SelectedItem.ToString();
            double strengthCoefficient = Convert.ToInt32(numericUpDownStrengthCoefficient.Value);
            string roadType = comboBoxRoadType.SelectedItem.ToString();

            WeatherRoadWorks weatherRoadWorks = new WeatherRoadWorks(id, width, length, massPerSquareMeter, roadMaterial , strengthCoefficient, roadType);

            if (WeatherRoadWorks.ContainsID(weatherRoadWorksList, id))
            {
                MessageBox.Show("Объект с таким ID уже существует.", "Ошибка");
                return;
            }


            weatherRoadWorksList.Add(weatherRoadWorks);


            listBoxSuccessorObject.Items.Add(weatherRoadWorks.Print());
        }

        private void buttonSuccessorQuality_Click(object sender, EventArgs e)
        {
            if (listBoxSuccessorObject.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите объект из списка.", "Ошибка");
                return;
            }

            int selectedIndex = listBoxSuccessorObject.SelectedIndex;
            WeatherRoadWorks selectedWeatherRoadWorks = weatherRoadWorksList[selectedIndex];

            if (calculatedModifiedQualityDict.ContainsKey(selectedWeatherRoadWorks.ID))
            {
                MessageBox.Show("Результат уже рассчитан для выбранного объекта.", "Ошибка");
                return;
            }

            double modifiedQuality = CalculateModifiedQuality(selectedWeatherRoadWorks);


            calculatedModifiedQualityDict.Add(selectedWeatherRoadWorks.ID, modifiedQuality);


            listBoxSuccessorQuality.Items.Add($"{selectedWeatherRoadWorks.ID}-{modifiedQuality}");
        }

        private void buttonDeleteSuccessorObject_Click(object sender, EventArgs e)
        {
            if (listBoxSuccessorObject.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите объект из списка.", "Ошибка");
                return;
            }

            int selectedIndex = listBoxSuccessorObject.SelectedIndex;
            WeatherRoadWorks selectedWeatherRoadWorks = weatherRoadWorksList[selectedIndex];


            if (calculatedModifiedQualityDict.ContainsKey(selectedWeatherRoadWorks.ID))
            {

                calculatedModifiedQualityDict.Remove(selectedWeatherRoadWorks.ID);
            }


            weatherRoadWorksList.Remove(selectedWeatherRoadWorks);


            listBoxSuccessorObject.Items.RemoveAt(selectedIndex);


            UpdateCalculatedResultsWeatherRoadWorksListBox();

        }
        private void UpdateCalculatedResultsRoadWorksListBox()
        {

            listBoxBaseQuality.Items.Clear();


            foreach (KeyValuePair<int, double> result in calculatedQualityDict)
            {
                listBoxBaseQuality.Items.Add($"{result.Key}-{result.Value}");
            }
        }
        private void UpdateCalculatedResultsWeatherRoadWorksListBox()
        {

            listBoxSuccessorQuality.Items.Clear();


            foreach (KeyValuePair<int, double> result in calculatedModifiedQualityDict)
            {
                listBoxSuccessorQuality.Items.Add($"{result.Key}-{result.Value}");
            }
        }
        private double CalculateQuality(RoadWorks roadWorks)
        {
            double quality = roadWorks.CalculateQuality();

            return quality;
        }

        private double CalculateModifiedQuality(WeatherRoadWorks weatherRoadWorks)
        {
            double modifiedQuality = weatherRoadWorks.CalculateQuality();

            return modifiedQuality;
        }
    }
}
