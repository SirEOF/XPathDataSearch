using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace XPathDataSearch
{
    public partial class MainForm : Form
    {
        DataTable m_namespaces;
        DataTable m_columns;

        public MainForm()
        {
            InitializeComponent();

            m_namespaces = new DataTable();
            m_namespaces.Columns.Add("prefix", typeof(string));
            m_namespaces.Columns.Add("ns", typeof(string));

            namespace_grid.Columns.Add("prefix", "Prefix");
            namespace_grid.Columns["prefix"].DataPropertyName = "prefix";
            namespace_grid.Columns.Add("ns", "Namespace");
            namespace_grid.Columns["ns"].DataPropertyName = "ns";
            namespace_grid.Columns["ns"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            namespace_grid.AutoGenerateColumns = false;
            namespace_grid.DataSource = m_namespaces;

            m_columns = new DataTable();
            m_columns.Columns.Add("name", typeof(string));
            m_columns.Columns.Add("xpath", typeof(string));

            columns_grid.Columns.Add("name", "Name");
            columns_grid.Columns["name"].DataPropertyName = "name";
            columns_grid.Columns.Add("xpath", "XPath");
            columns_grid.Columns["xpath"].DataPropertyName = "xpath";
            columns_grid.Columns["xpath"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columns_grid.AutoGenerateColumns = false;
            columns_grid.DataSource = m_columns;

            InitializeGrid(namespace_grid);
            InitializeGrid(columns_grid);
            InitializeGrid(result_grid, true);
        }

        private void InitializeGrid(DataGridView grid, bool read_only = false)
        {
            grid.BorderStyle = BorderStyle.Fixed3D;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            grid.DefaultCellStyle.BackColor = SystemColors.Window;
            grid.BackgroundColor = SystemColors.Window;
            grid.ReadOnly = read_only;
            grid.AllowUserToAddRows = !read_only;
        }

        private void query_button_Click(object sender, EventArgs e)
        {

            m_namespaces.AcceptChanges();
            m_columns.AcceptChanges();

            DataTable data = new DataTable();

            try
            {
                var xpath_query = xpath_textbox.Text;
                var doc = new XPathDocument(file_textbox.Text);
                var nav = doc.CreateNavigator();

                var manager = new XmlNamespaceManager(nav.NameTable);

                foreach (DataRow ns_row in m_namespaces.Rows)
                {
                    var prefix = (string)ns_row["prefix"];
                    var ns = (string)ns_row["ns"];
                    manager.AddNamespace(prefix, ns);
                }

                var iter = nav.Select(xpath_query, manager);

                var columns = new List<Tuple<DataColumn, XPathExpression>>();

                foreach (DataRow column_row in m_columns.Rows)
                {
                    var name = (string)column_row["name"];
                    var query = (string)column_row["xpath"];

                    try
                    {
                        var expression = nav.Compile(query);
                        expression.SetContext(manager);

                        columns.Add(Tuple.Create(data.Columns.Add(name, typeof(string)), expression));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error compiling expression '" + name + "':\n\n" + ex.ToString());
                        return;
                    }
                }

                while (iter.MoveNext())
                {
                    var row = data.NewRow();

                    foreach (var column in columns)
                    {
                        var result = iter.Current.Evaluate(column.Item2);
                        row[column.Item1] = result.ToString();
                    }

                    data.Rows.Add(row);
                }

                result_grid.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";

                if (ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    file_textbox.Text = ofd.FileName;
            }

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "XPath Data Seach File (*.xpds)|*.xpds";

                if (sfd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    using (var s = sfd.OpenFile())
                        SaveXml(s);
                }

            }
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "XPath Data Seach File (*.xpds)|*.xpds";

                if (ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    using (var s = ofd.OpenFile())
                        LoadXml(s);
                }
            }

        }

        void LoadXml(Stream stream)
        {
            string xpath_query;
            var namespaces = new DataTable();
            var columns = new DataTable();

            namespaces.Columns.Add("prefix", typeof(string));
            namespaces.Columns.Add("ns", typeof(string));

            columns.Columns.Add("name", typeof(string));
            columns.Columns.Add("xpath", typeof(string));
            using (var reader = XmlReader.Create(stream))
            {
                reader.ReadStartElement("XPathDataSearch");

                while (reader.IsStartElement("Namespace"))
                {
                    var prefix = reader.GetAttribute("prefix");
                    var ns = reader.ReadElementContentAsString();
                    namespaces.LoadDataRow(new object[] { prefix, ns }, true);
                }

                xpath_query = reader.ReadElementContentAsString("Select", "");

                while (reader.IsStartElement("Column"))
                {
                    var name = reader.GetAttribute("name");
                    var value = reader.ReadElementContentAsString();

                    columns.LoadDataRow(new object[] { name, value }, true);
                }
            }

            m_namespaces = namespaces;
            m_columns = columns;

            namespace_grid.DataSource = m_namespaces;
            columns_grid.DataSource = m_columns;
            xpath_textbox.Text = xpath_query;
            result_grid.DataSource = null;
        }

        void SaveXml(Stream stream)
        {
            using (var writer = XmlWriter.Create(stream))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("XPathDataSearch");

                foreach (DataRow ns_row in m_namespaces.Rows)
                {
                    writer.WriteStartElement("Namespace");
                    writer.WriteAttributeString("prefix", (string)ns_row["prefix"]);
                    writer.WriteString((string)ns_row["ns"]);
                    writer.WriteEndElement();
                }

                writer.WriteElementString("Select", xpath_textbox.Text);

                foreach (DataRow column_row in m_columns.Rows)
                {
                    writer.WriteStartElement("Column");
                    writer.WriteAttributeString("name", (string)column_row["name"]);
                    writer.WriteString((string)column_row["xpath"]);
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

    }
}
