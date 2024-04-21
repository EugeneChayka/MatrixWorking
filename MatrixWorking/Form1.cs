using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixWorking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnMult_Click(object sender, EventArgs e)
        {
            int rowsA = dataGrid1.Rows.Count;
            int colsA = dataGrid1.Columns.Count;
            int rowsB = dataGrid2.Rows.Count;
            int colsB = dataGrid2.Columns.Count;

            int[,] resultMatrix = new int[rowsA, colsB];

            if (rowsA > 0 && colsA > 0 && rowsB > 0 && colsB > 0)
            {
                for (int i = 0; i < rowsA; i++)
                {
                    for (int j = 0; j < colsB; j++)
                    {
                        for (int k = 0; k < colsA; k++)
                        {
                            if (dataGrid1.Rows[i].Cells[k].Value != null && dataGrid2.Rows[k].Cells[j].Value != null)
                            {
                                resultMatrix[i, j] += Convert.ToInt32(dataGrid1.Rows[i].Cells[k].Value) * Convert.ToInt32(dataGrid2.Rows[k].Cells[j].Value);
                            }
                        }
                    }
                }

                dataGridResult.Rows.Clear();

                for (int i = 0; i < rowsA; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    for (int j = 0; j < colsB; j++)
                    {
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = resultMatrix[i, j] });
                    }

                    dataGridResult.Rows.Add(row);
                }
            }
        }

        public void btnSub_Click(object sender, EventArgs e)
        {
            if (dataGrid1.Rows.Count != dataGrid2.Rows.Count || dataGrid1.Columns.Count != dataGrid2.Columns.Count)
            {
                MessageBox.Show("Размеры матриц должны быть одинаковыми для вычитания.");
                return;
            }

            
            dataGridResult.Rows.Clear();
            dataGridResult.Columns.Clear();
            for (int i = 0; i < dataGrid1.Columns.Count; i++)
            {
                dataGridResult.Columns.Add($"Column{i}", $"Column{i}");
            }
            // Вычитание матриц
            for (int i = 0; i < dataGrid1.Rows.Count; i++)
            {
                dataGridResult.Rows.Add();
                for (int j = 0; j < dataGrid1.Columns.Count; j++)
                {
                    int value1 = Convert.ToInt32(dataGrid1.Rows[i].Cells[j].Value);
                    int value2 = Convert.ToInt32(dataGrid2.Rows[i].Cells[j].Value);
                    dataGridResult.Rows[i].Cells[j].Value = value1 - value2;
                }
            }
        }

        public void btnTransp_Click(object sender, EventArgs e)
        {
            int rows = dataGrid1.Rows.Count - 1; // Исключаем пустую строку в конце
            int cols = dataGrid1.Columns.Count;

            // Очистка datagridResult перед выводом новой матрицы
            dataGridResult.Rows.Clear();
            dataGridResult.Columns.Clear();

            // Добавляем столбцы в datagridResult
            for (int i = 0; i < cols; i++)
            {
                dataGridResult.Columns.Add("", "");
            }

            // Добавляем строки с данными в datagridResult
            for (int i = 0; i < cols; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridResult);

                for (int j = 0; j < rows; j++)
                {
                    row.Cells[j].Value = dataGrid1[i, j].Value;
                }

                dataGridResult.Rows.Add(row);
            }
        }

        public void btnTransp2_Click(object sender, EventArgs e)
        {
            int rows = dataGrid2.Rows.Count - 1; // Исключаем пустую строку в конце
            int cols = dataGrid2.Columns.Count;

            dataGridResult.Rows.Clear();
            dataGridResult.Columns.Clear();

            for (int i = 0; i < cols; i++)
            {
                dataGridResult.Columns.Add("", "");
            }

          
            for (int i = 0; i < cols; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridResult);

                for (int j = 0; j < rows; j++)
                {
                    row.Cells[j].Value = dataGrid2[i, j].Value;
                }

                dataGridResult.Rows.Add(row);
            }
        }

        public void btnCalc_Click(object sender, EventArgs e)
        {
            int rows = dataGrid1.Rows.Count;
            int cols = dataGrid1.Columns.Count;

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int val1 = Convert.ToInt32(dataGrid1.Rows[i].Cells[j].Value);
                    int val2 = Convert.ToInt32(dataGrid2.Rows[i].Cells[j].Value);
                    result[i, j] = val1 + val2;
                }
            }

            dataGridResult.Rows.Clear();

            for (int i = 0; i < rows; i++)
            {
                dataGridResult.Rows.Add();
                for (int j = 0; j < cols; j++)
                {
                    dataGridResult.Rows[i].Cells[j].Value = result[i, j];
                }
            }
        }

        
    }
}
