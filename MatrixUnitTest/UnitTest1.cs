using MatrixWorking;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MatrixUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTransponir()
        {
            Form1 form = new Form1();

            form.dataGrid1.ColumnCount = 3;
            form.dataGrid1.Rows.Add(1, 2, 3);
            form.dataGrid1.Rows.Add(4, 5, 6);
            form.dataGrid1.Rows.Add(7, 8, 9);

            
            form.btnTransp_Click(null, EventArgs.Empty);

            
            Assert.AreEqual(1, form.dataGridResult.Rows[0].Cells[0].Value);
            Assert.AreEqual(4, form.dataGridResult.Rows[0].Cells[1].Value);
            Assert.AreEqual(7, form.dataGridResult.Rows[0].Cells[2].Value);
            Assert.AreEqual(2, form.dataGridResult.Rows[1].Cells[0].Value);
            Assert.AreEqual(5, form.dataGridResult.Rows[1].Cells[1].Value);
            Assert.AreEqual(8, form.dataGridResult.Rows[1].Cells[2].Value);
            Assert.AreEqual(3, form.dataGridResult.Rows[2].Cells[0].Value);
            Assert.AreEqual(6, form.dataGridResult.Rows[2].Cells[1].Value);
            Assert.AreEqual(9, form.dataGridResult.Rows[2].Cells[2].Value);
        }
        [TestMethod]
        public void TestTransponir2()
        {
            Form1 form = new Form1();
            form.dataGrid1.ColumnCount = 3;
            form.dataGrid2.ColumnCount = 3;
            form.dataGrid2.Rows.Add(1, 2, 3);
            form.dataGrid2.Rows.Add(4, 5, 6);
            form.dataGrid2.Rows.Add(7, 8, 9);
            form.btnTransp2_Click(null, EventArgs.Empty);

            Assert.AreEqual(1, form.dataGridResult.Rows[0].Cells[0].Value);
            Assert.AreEqual(4, form.dataGridResult.Rows[0].Cells[1].Value);
            Assert.AreEqual(7, form.dataGridResult.Rows[0].Cells[2].Value);
            Assert.AreEqual(2, form.dataGridResult.Rows[1].Cells[0].Value);
            Assert.AreEqual(5, form.dataGridResult.Rows[1].Cells[1].Value);
            Assert.AreEqual(8, form.dataGridResult.Rows[1].Cells[2].Value);
            Assert.AreEqual(3, form.dataGridResult.Rows[2].Cells[0].Value);
            Assert.AreEqual(6, form.dataGridResult.Rows[2].Cells[1].Value);
            Assert.AreEqual(9, form.dataGridResult.Rows[2].Cells[2].Value);
        }
        [TestMethod]
        public void TestSubstring()
        {
            Form1 form = new Form1();
            form.dataGrid1.ColumnCount = 3;
            form.dataGrid2.ColumnCount = 3;
            form.dataGrid1.Rows.Add(26, 10, 45);
            form.dataGrid2.Rows.Add(11, 23, 31);

            form.btnSub_Click(null, EventArgs.Empty); 
            Assert.AreEqual(15, form.dataGridResult.Rows[0].Cells[0].Value);
            Assert.AreEqual(-13, form.dataGridResult.Rows[0].Cells[1].Value);
            Assert.AreEqual(14, form.dataGridResult.Rows[0].Cells[2].Value);
        }

        [TestMethod]
        public void TestSum()
        {
            Form1 form = new Form1();
            form.dataGrid1.ColumnCount = 3;
            form.dataGrid2.ColumnCount = 3;
            form.dataGrid1.Rows.Add(4, 3, 2);
            form.dataGrid2.Rows.Add(10, 12, 115);
            

            form.btnCalc_Click(null, EventArgs.Empty);
            Assert.AreEqual(14, form.dataGridResult.Rows[0].Cells[0].Value);
            Assert.AreEqual(15, form.dataGridResult.Rows[0].Cells[1].Value);
            Assert.AreEqual(117, form.dataGridResult.Rows[0].Cells[2].Value);
        }

        [TestMethod]
        public void TestMult()
        {
            Form1 form = new Form1();
            form.dataGrid1.ColumnCount = 3;
            form.dataGrid2.ColumnCount = 3;
            form.dataGrid1.Rows.Add(1, 2, 3);
            form.dataGrid1.Rows.Add(4, 5, 6);
            form.dataGrid1.Rows.Add(7, 8, 9);
            form.dataGrid2.Rows.Add(1, 2, 3);
            form.dataGrid2.Rows.Add(4, 5, 6);
            form.dataGrid2.Rows.Add(7, 8, 9);
           

            form.btnMult_Click(null, EventArgs.Empty); 
            Assert.AreEqual(30, form.dataGridResult.Rows[0].Cells[0].Value);
            Assert.AreEqual(36, form.dataGridResult.Rows[0].Cells[1].Value);
            Assert.AreEqual(42, form.dataGridResult.Rows[0].Cells[2].Value);
            Assert.AreEqual(66, form.dataGridResult.Rows[1].Cells[0].Value);
            Assert.AreEqual(81, form.dataGridResult.Rows[1].Cells[1].Value);
            Assert.AreEqual(96, form.dataGridResult.Rows[1].Cells[2].Value);
            Assert.AreEqual(102, form.dataGridResult.Rows[2].Cells[0].Value);
            Assert.AreEqual(126, form.dataGridResult.Rows[2].Cells[1].Value);
            Assert.AreEqual(150, form.dataGridResult.Rows[2].Cells[2].Value);
        }
        [TestMethod]
        public void TestString()
        {
            Form1 form = new Form1();
            form.dataGrid2.ColumnCount = 3;
            form.dataGrid1.Rows.Add("Ч", "А", 3);
            form.dataGrid1.Rows.Add(4, 5, 6);
            form.dataGrid1.Rows.Add(7, 8, 9);
            form.dataGrid2.Rows.Add(1, 2, 3);
            form.dataGrid2.Rows.Add(4, 5, 6);
            form.dataGrid2.Rows.Add(7, 8, 9);

            //коммент
            form.btnMult_Click(null, EventArgs.Empty);
            Assert.AreEqual(30, form.dataGridResult.Rows[0].Cells[0].Value);
            Assert.AreEqual(36, form.dataGridResult.Rows[0].Cells[1].Value);
            Assert.AreEqual(42, form.dataGridResult.Rows[0].Cells[2].Value);
            Assert.AreEqual(66, form.dataGridResult.Rows[1].Cells[0].Value);
            Assert.AreEqual(81, form.dataGridResult.Rows[1].Cells[1].Value);
            Assert.AreEqual(96, form.dataGridResult.Rows[1].Cells[2].Value);
            Assert.AreEqual(102, form.dataGridResult.Rows[2].Cells[0].Value);
            Assert.AreEqual(126, form.dataGridResult.Rows[2].Cells[1].Value);
            Assert.AreEqual(150, form.dataGridResult.Rows[2].Cells[2].Value);
        }
    }
}
