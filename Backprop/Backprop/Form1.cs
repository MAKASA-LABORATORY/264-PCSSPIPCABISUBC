using System.Runtime.InteropServices;
using System.Xml;
using Excel = Microsoft.Office.Interop.Excel;       //Microsoft Excel 14 object in references-> COM tab

namespace Backprop
{
    public partial class Form1 : Form
    {
        NeuralNet backprop;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTrainModel.Enabled = false;
            button2.Enabled = false;
            btnCreateModel.Enabled = false;

        }



        private void button2_Click(object sender, EventArgs e)
        {
            double quizzes = Convert.ToDouble(textBox1.Text);
            double active_class_participation = Convert.ToDouble(textBox2.Text);
            double individual_oral_report = Convert.ToDouble(textBox3.Text);
            double attendance = Convert.ToDouble(textBox4.Text);
            double class_standing = Convert.ToDouble(textBox5.Text);
            double activities_and_outcomes_based_projects = Convert.ToDouble(textBox6.Text);
            double major_exams = Convert.ToDouble(textBox7.Text);
            backprop.setInputs(0, quizzes);
            backprop.setInputs(1, active_class_participation);
            backprop.setInputs(2, individual_oral_report);
            backprop.setInputs(3, attendance);
            backprop.setInputs(4, class_standing);
            backprop.setInputs(5, activities_and_outcomes_based_projects);
            backprop.setInputs(6, major_exams);
            backprop.run();
            double output1 = backprop.getOuputData(0);
            textBox8.Text = "" + output1;
        }

        private void btnCreateModel_Click(object sender, EventArgs e)
        {
            /* A common approach is to use a number of neurons in the hidden layer that is the average of the number of input and output neurons. For your case, you might try having around 
            7+1/2=4 neurons in the hidden layer.

            So, a simple neural network architecture could look like this:

            Input layer: 7 neurons
            Hidden layer: 4 neurons (you can experiment with a range of values, such as 3 to 6)
            Output layer: 1 neuron */
            backprop = new NeuralNet(7, 4, 1); // Input, Hidden, Output
            btnTrainModel.Enabled = true;
            btnCreateModel.Enabled = false;
        }
        // Create a 2D array to store Excel data
        private static string[,] excelData;

        public static void getExcelFile()
        {
            string fileName = "intermediate_programming_grades.xlsx";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            // Create Excel objects using late binding
            dynamic xlApp = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application"));
            dynamic xlWorkbook = xlApp.Workbooks.Open(filePath);
            dynamic xlWorksheet = xlWorkbook.Sheets[1];
            dynamic xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;


            excelData = new string[rowCount - 1, colCount];

            for (int i = 2; i <= rowCount; i++) // Start from i = 2 to exclude the first row
            {
                for (int j = 1; j <= colCount; j++)
                {
                    var cell = xlRange.Cells[i, j] as Excel.Range; // Cast to Excel.Range

                    if (cell != null && cell.Value2 != null)
                    {
                        // Save the value to the 2D array
                        excelData[i - 2, j - 1] = cell.Value2.ToString();
                    }
                }
            }
            /*
            // Display the saved data (optional)
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    Console.Write(excelData[i, j] + "\t");
                }
                Console.WriteLine();
            }
            */


            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }

        private void btnTrainModel_Click(object sender, EventArgs e)
        {


            for (int epoch = 1; epoch < 5000; epoch++) //  epochs
            {
                // Assuming excelData is a 2D array loaded from Excel
                for (int i = 0; i < excelData.GetLength(0); i++) // Loop through rows of the Excel data
                {
                    for (int j = 0; j < 7; j++) // Assuming columns 0 to 5 are input features
                    {
                        // Set input features
                        backprop.setInputs(j, Convert.ToDouble(excelData[i, j]));
                    }

                    // Set desired output (assuming column 6 is the output)
                    backprop.setDesiredOutput(0, Convert.ToDouble(excelData[i, 7]));

                    // Perform the learning step
                    backprop.learn();
                }
            }
            btnTrainModel.Enabled = false;
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            getExcelFile();
            btnCreateModel.Enabled = true;
            button1.Enabled = false;
        }
    }
}