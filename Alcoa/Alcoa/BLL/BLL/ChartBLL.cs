using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using BLL.DTOAssembler;
using DAL;
using Model;


namespace BLL
{
    public class ChartBLL
    {

        public static ChartModel GenerateChart(IndexChartModel p_Model)
        {
            //ChartModel v_Chart = new ChartModel();
            //Paciente v_Paciente = Paciente.GetPaciente(p_Model.Paciente.Id);
            //v_Chart.Columns = GetColumnsChart(p_Model);
            //v_Chart.Rows = GetRowsChart(p_Model, v_Paciente);
            //return v_Chart;
            return null;
        }

        //public static List<ColumnChartModel> GetColumnsChart(IndexChartModel p_ModelChart)
        //{
        //    List<ColumnChartModel> v_Columns = new List<ColumnChartModel>();
        //    ColumnChartModel v_Column = new ColumnChartModel { Id = "data", Type = "string", Label = "Data" };
        //    v_Columns.Add(v_Column);
        //    switch (p_ModelChart.TipoGrafico)
        //    {
        //        case Util.Enum.TipoGrafico.PesoColesterol:
        //            v_Column = new ColumnChartModel { Id = "peso", Type = "number", Label = "Peso" };
        //            v_Columns.Add(v_Column);
        //            v_Column = new ColumnChartModel { Id = "colesterol", Label = "Colesterol", Type = "number" };
        //            v_Columns.Add(v_Column);
        //            break;
        //        case Util.Enum.TipoGrafico.PesoDuracaoTratamento:
        //            v_Column = new ColumnChartModel { Id = "peso", Type = "number", Label = "Peso" };
        //            v_Columns.Add(v_Column);
        //            break;
        //        case Util.Enum.TipoGrafico.PesoHemoglobina:
        //            v_Column = new ColumnChartModel { Id = "peso", Type = "number", Label = "Peso" };
        //            v_Columns.Add(v_Column);
        //            v_Column = new ColumnChartModel { Id = "hemoglobina", Label = "Hemoglobina", Type = "number" };
        //            v_Columns.Add(v_Column);
        //            break;
        //        case Util.Enum.TipoGrafico.PesoPressaoArterial:
        //            v_Column = new ColumnChartModel { Id = "peso", Type = "number", Label = "Peso" };
        //            v_Columns.Add(v_Column);
        //            v_Column = new ColumnChartModel { Id = "pressaoArterial", Label = "Pressão Arterial", Type = "number" };
        //            v_Columns.Add(v_Column);
        //            break;
        //        case Util.Enum.TipoGrafico.PesoTaxaGlicemica:
        //            v_Column = new ColumnChartModel { Id = "peso", Type = "number", Label = "Peso" };
        //            v_Columns.Add(v_Column);
        //            v_Column = new ColumnChartModel { Id = "taxaGlicemica", Label = "Taxa Glicêmica", Type = "number" };
        //            v_Columns.Add(v_Column);
        //            break;
        //        case Util.Enum.TipoGrafico.PesoTriglicerides:
        //            v_Column = new ColumnChartModel { Id = "peso", Type = "number", Label = "Peso" };
        //            v_Columns.Add(v_Column);
        //            v_Column = new ColumnChartModel { Id = "triglicerides", Label = "Triglicérides", Type = "number" };
        //            v_Columns.Add(v_Column);
        //            break;
        //    }
        //    return v_Columns;
        //}

        //private static List<RowChartModel> GetRowsChart(IndexChartModel p_Model, Paciente p_Paciente)
        //{
        //    var v_Rows = new List<RowChartModel>();

        //    var v_Dates = p_Paciente.ExameDados.Select(model => model.DataExame)
        //        .Union(p_Paciente.MedidaPaciente.Select(m => m.DataMedicao)).Distinct();

        //    if (p_Model.DataInicial.HasValue)
        //    {
        //        v_Dates = v_Dates.Where(model => model >= p_Model.DataInicial.Value);
        //    }
        //    if (p_Model.DataFinal.HasValue)
        //    {
        //        v_Dates = v_Dates.Where(model => model <= p_Model.DataFinal.Value);
        //    }
        //    v_Dates = v_Dates.OrderBy(v => v.Date);
        //    foreach (var i_Date in v_Dates)
        //    {
        //        RowChartModel v_TempRow = null;
        //        switch (p_Model.TipoGrafico)
        //        {
        //            case Util.Enum.TipoGrafico.PesoColesterol:
        //                v_TempRow = GetPacientMeasureExamTypeRow("peso", "colesterol total", i_Date, p_Paciente);
        //                break;
        //            case Util.Enum.TipoGrafico.PesoDuracaoTratamento:
        //                v_TempRow = GetPacientMeasureRow("peso", i_Date, p_Paciente);
        //                break;
        //            case Util.Enum.TipoGrafico.PesoHemoglobina:
        //                v_TempRow = GetPacientMeasureExamTypeRow("peso", "hemoglobina", i_Date, p_Paciente);
        //                break;
        //            case Util.Enum.TipoGrafico.PesoPressaoArterial:
        //                v_TempRow = GetPacientMeasurePacientMeasureRow("peso", "pressao arterial", i_Date, p_Paciente);
        //                break;
        //            case Util.Enum.TipoGrafico.PesoTaxaGlicemica:
        //                v_TempRow = GetPacientMeasureExamTypeRow("peso", "glicemia", i_Date, p_Paciente);
        //                break;
        //            case Util.Enum.TipoGrafico.PesoTriglicerides:
        //                v_TempRow = GetPacientMeasureExamTypeRow("peso", "triglicérides", i_Date, p_Paciente);
        //                break;
        //        }
        //        if (v_TempRow != null)
        //        {
        //            v_Rows.Add(v_TempRow);
        //        }
        //    }
        //    return v_Rows;
        //}

        //private static RowChartModel GetPacientMeasurePacientMeasureRow(String p_AxisXMeasure, String p_AxisYMeasure, DateTime p_Date, Paciente p_Paciente)
        //{
        //    var v_Row = new RowChartModel();
        //    v_Row.Title = p_Date.ToString("dd/MM");
        //    MedidaPaciente v_PacientMeasure = p_Paciente.MedidaPaciente.FirstOrDefault(
        //      model => model.DataMedicao.Year == p_Date.Year &&
        //          model.DataMedicao.Month == p_Date.Month && model.DataMedicao.Day == p_Date.Day);
        //    if (v_PacientMeasure == null)
        //    {
        //        return null;
        //    }
        //    v_Row.Cells.Add(new CellRowChartModel() { Value = v_Row.Title });
        //    v_Row.Cells.Add(GetPacientMeasureCell(p_AxisXMeasure, p_Date, v_PacientMeasure));
        //    v_Row.Cells.Add(GetPacientMeasureCell(p_AxisYMeasure, p_Date, v_PacientMeasure));
        //    return v_Row;
        //}

        //private static RowChartModel GetPacientMeasureRow(String p_PacientMeasureName, DateTime p_Date, Paciente p_Paciente)
        //{
        //    var v_Row = new RowChartModel();
        //    v_Row.Title = p_Date.ToString("dd/MM");
        //    MedidaPaciente v_PacientMeasure = p_Paciente.MedidaPaciente.FirstOrDefault(
        //      model => model.DataMedicao.Year == p_Date.Year &&
        //          model.DataMedicao.Month == p_Date.Month && model.DataMedicao.Day == p_Date.Day);

        //    if (v_PacientMeasure == null)
        //    {
        //        return null;
        //    }
        //    v_Row.Cells.Add(new CellRowChartModel() { Value = v_Row.Title });
        //    v_Row.Cells.Add(GetPacientMeasureCell(p_PacientMeasureName, p_Date, v_PacientMeasure));
        //    return v_Row;
        //}

        //private static CellRowChartModel GetPacientMeasureCell(string p_PacientMeasureName, DateTime p_Date, MedidaPaciente p_PacienteMeasure)
        //{
        //    var CellRowChartModel = new CellRowChartModel() { Value = 0 };

        //    if (p_PacienteMeasure != null)
        //    {
        //        if (p_PacientMeasureName.ToLower().Equals("peso"))
        //            CellRowChartModel = new CellRowChartModel() { Value = p_PacienteMeasure.Peso };
        //        else if (p_PacientMeasureName.ToLower().Equals("porcentagemgordura"))
        //            CellRowChartModel = new CellRowChartModel() { Value = p_PacienteMeasure.PorcentagemGordura };
        //        else if (p_PacientMeasureName.ToLower().Equals("porcentagemgorduravisceral"))
        //            CellRowChartModel = new CellRowChartModel() { Value = p_PacienteMeasure.PorcentagemGorduraVisceraol };
        //        else if (p_PacientMeasureName.ToLower().Equals("porcentagemmuscular"))
        //            CellRowChartModel = new CellRowChartModel() { Value = p_PacienteMeasure.PorcentagemMuscular };
        //        else if (p_PacientMeasureName.ToLower().Equals("pressaoarterial"))
        //            CellRowChartModel = new CellRowChartModel() { Value = p_PacienteMeasure.PressaoArterial };
        //        else if (p_PacientMeasureName.ToLower().Equals("altura"))
        //            CellRowChartModel = new CellRowChartModel() { Value = p_PacienteMeasure.Altura };
        //        else if (p_PacientMeasureName.ToLower().Equals("circunferenciabraco"))
        //            CellRowChartModel = new CellRowChartModel() { Value = p_PacienteMeasure.CircunferenciaBraco };
        //        else if (p_PacientMeasureName.ToLower().Equals("circunferenciacintura"))
        //            CellRowChartModel = new CellRowChartModel() { Value = p_PacienteMeasure.CircunferenciaCintura };
        //        else if (p_PacientMeasureName.ToLower().Equals("circunferenciaquadril"))
        //            CellRowChartModel = new CellRowChartModel() { Value = p_PacienteMeasure.CircunferenciaQuadril };
        //    }
        //    return CellRowChartModel;
        //}

        //private static CellRowChartModel GetExamTypeCell(String p_ExamTypeName, DateTime p_Date, ExameDados p_Exam)
        //{
        //    return p_Exam != null
        //               ? new CellRowChartModel() { Value = p_Exam.Valor }
        //               : new CellRowChartModel() { Value = 0 };
        //}


        //private static RowChartModel GetPacientMeasureExamTypeRow(String p_PacientMeasureName,
        //    String p_ExamTypeName, DateTime p_Date, Paciente p_Paciente)
        //{
        //    var v_Row = new RowChartModel();
        //    v_Row.Title = p_Date.ToString("dd/MM");
        //    MedidaPaciente v_PacientMeasure = p_Paciente.MedidaPaciente.FirstOrDefault(model => model.DataMedicao.Year == p_Date.Year &&
        //        model.DataMedicao.Month == p_Date.Month && model.DataMedicao.Day == p_Date.Day);
        //    ExameDados v_Exam = p_Paciente.ExameDados.FirstOrDefault(model => model.DataExame.Year == p_Date.Year &&
        //        model.DataExame.Month == p_Date.Month && model.DataExame.Day == p_Date.Day && model.TipoExame.Nome.ToLower() == p_ExamTypeName);
        //    if (v_PacientMeasure == null && v_Exam == null)
        //    {
        //        return null;
        //    }
        //    v_Row.Cells.Add(new CellRowChartModel() { Value = v_Row.Title });
        //    v_Row.Cells.Add(GetPacientMeasureCell(p_PacientMeasureName, p_Date, v_PacientMeasure));
        //    v_Row.Cells.Add(GetExamTypeCell(p_ExamTypeName, p_Date, v_Exam));
        //    return v_Row;
        //}
    }
}
