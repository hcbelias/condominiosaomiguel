using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace Model
{

    public class IndexChartModel
    {
        public Util.Enum.TipoGrafico TipoGrafico { get; set; }

        public DateTime? DataInicial { get; set; }

        public DateTime? DataFinal { get; set; }

    }

    public class ChartModel
    {
        public List<ColumnChartModel> Columns
        {
            get
            {
                if (m_Columns == null) m_Columns = new List<ColumnChartModel>();
                return m_Columns;
            }
            set { m_Columns = value; }
        }

        private List<ColumnChartModel> m_Columns;

        public List<RowChartModel> Rows
        {
            get
            {
                if (m_Rows == null) m_Rows = new List<RowChartModel>();
                return m_Rows;
            }
            set { m_Rows = value; }
        }

        private List<RowChartModel> m_Rows;

    }

    public class RowChartModel
    {
        public string Title { get; set; }

        public List<CellRowChartModel> Cells
        {
            get
            {
                if (m_Cells == null) m_Cells = new List<CellRowChartModel>();
                return m_Cells;
            }
            set { m_Cells = value; }
        }

        private List<CellRowChartModel> m_Cells;
    }

    public class CellRowChartModel
    {
        public object Value { get; set; }
    }

    public class ColumnChartModel
    {
        public string Id { get; set; }

        public string Label { get; set; }

        public string Type { get; set; }
    }
}
