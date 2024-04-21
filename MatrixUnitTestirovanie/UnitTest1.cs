using MatrixWorking;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MatrixUnitTestirovanie
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum()
        {
            Form1 form = new Form1();
            form.dataGrid1.Rows.Add(1, 2, 3);
            form.dataGrid2.Rows.Add(1, 2, 3);

            form.btnCalc_Click(null, EventArgs.Empty); // Вызов метода для расчета суммы
            Assert.AreEqual(2, form.dataGridResult.Rows[0].Cells[0].Value);
            Assert.AreEqual(4, form.dataGridResult.Rows[0].Cells[1].Value);
            Assert.AreEqual(6, form.dataGridResult.Rows[0].Cells[2].Value);
        }
    }
}