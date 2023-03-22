using GameClassLibrary;
using Newtonsoft.Json;
using System.Data;

namespace GameWF
{
    public static class TableResults
    {
        public static void ShowResults(List<Test> dataBase, string[] headerLabels, DataGridView dataTable)
        {
            string json = JsonConvert.SerializeObject(dataBase);
            var data = JsonConvert.DeserializeObject<DataTable>(json);

            if (data.Columns.Count == 0)
            {
                GetDefaultTable(dataTable, headerLabels);
            }
            else
            {
                AddIDColumn(data, "№");
                data.Columns.RemoveAt(data.Columns.Count - 1);
                RenameColumns(data, headerLabels);

                dataTable.DataSource = data;
            }
        }
        public static void ShowResults(List<User> dataBase, string[] headerLabels, DataGridView dataTable)
        {
            string json = JsonConvert.SerializeObject(dataBase);
            var data = JsonConvert.DeserializeObject<DataTable>(json);

            if (data.Columns.Count == 0)
            {
                GetDefaultTable(dataTable, headerLabels);
            }
            else
            {
                AddIDColumn(data, "№");
                RenameColumns(data, headerLabels);

                dataTable.DataSource = data;
                dataTable.Columns[4].DefaultCellStyle.Format = "P";
            }
        }
        public static void AddIDColumn(DataTable table, string columnName)
        {
            var idColumn = new DataColumn(columnName, Type.GetType("System.Int32"));
            table.Columns.Add(idColumn);
            idColumn.SetOrdinal(0);
        }
        public static void GetDefaultTable(DataGridView dataTable, string[] columnNames)
        {
            var defaultData = new DataTable();

            foreach (string headerWord in columnNames)
            {
                defaultData.Columns.Add(new DataColumn(headerWord));
            }
            dataTable.DataSource = defaultData;
        }
        public static void RenameColumns(DataTable table, string[] columnNames)
        {
            int i = 0;
            foreach (DataColumn column in table.Columns)
            {
                column.ColumnName = columnNames[i];
                i++;
            }
        }
    }
}
