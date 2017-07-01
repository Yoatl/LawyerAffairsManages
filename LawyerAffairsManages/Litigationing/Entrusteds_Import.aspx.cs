using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LawyerAffairsManages.Litigationing
{
    public partial class Entrusteds_Import : System.Web.UI.Page
    {
        Lawyer_DLL.BLL.case_entr bll = new Lawyer_DLL.BLL.case_entr();
        Lawyer_DLL.Model.case_entr model;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadButton2_Click(object sender, EventArgs e)
        {
            if (RadAsyncUpload1.UploadedFiles.Count < 1)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('请上传文件');</script>");
                return;
            }

            Stream fs = null;
            IWorkbook workbook = null;
            ISheet sheet = null;

            try
            {
                using (fs = RadAsyncUpload1.UploadedFiles[0].InputStream)
                {
                    if (RadAsyncUpload1.UploadedFiles[0].FileName.IndexOf(".xlsx") > 0)
                        workbook = new XSSFWorkbook(fs);
                    else if (RadAsyncUpload1.UploadedFiles[0].FileName.IndexOf(".xls") > 0)
                        workbook = new HSSFWorkbook(fs);
                }
                if (workbook != null)
                {
                    sheet = workbook.GetSheetAt(0);
                    DataTable dt = new DataTable();
                    string[] colList = { "external_contract_nbr", "Borrower name", "BorrowNumber", "BorrowPostal", "BorrowAddress", "CoBorrow name", "CoBorrowNumber", "CoBorrowPostal", "CoBorrowAddress", "Guarantorname", "GuarantorNumber", "GuarantorPostal", "GuarantorAddress", "Original HT Date", "AFC Sending Date", "Agent Sending Date" };
                    if (sheet != null)
                    {
                        int rowCount = sheet.LastRowNum;
                        if (rowCount > 0)
                        {
                            int colNum = 0;
                            //while (colNum < 15)
                            //{
                            //    if (colList[colNum] != sheet.GetRow(0).GetCell(colNum).StringCellValue)
                            //    {
                            //        Ajax12.Alert("数据项名不匹配！");
                            //        return;
                            //    }
                            //    else
                            //    {
                            //        colNum += 1;
                            //    }
                            //}
                            colNum = 0;

                            model = new Lawyer_DLL.Model.case_entr();
                            for (int rowNums = 1; rowNums <= rowCount; rowNums++)
                            {
                                try
                                {
                                    model.CaseContractNumber = sheet.GetRow(rowNums).GetCell(0).NumericCellValue.ToString();
                                    model.EntrFullName = sheet.GetRow(rowNums).GetCell(1).StringCellValue;
                                    model.EntrFullPhone = sheet.GetRow(rowNums).GetCell(2).NumericCellValue.ToString();
                                    model.EntrFullPost = sheet.GetRow(rowNums).GetCell(3).NumericCellValue.ToString();
                                    model.EntrFullAddress = sheet.GetRow(rowNums).GetCell(4).StringCellValue;
                                    model.EntrCommName = sheet.GetRow(rowNums).GetCell(5).StringCellValue;
                                    model.EntrCommPhone = sheet.GetRow(rowNums).GetCell(6).NumericCellValue.ToString();
                                    model.EntrCommPost = sheet.GetRow(rowNums).GetCell(7).NumericCellValue.ToString();
                                    model.EntrCommAddress = sheet.GetRow(rowNums).GetCell(8).StringCellValue;
                                    model.EntrGuarName = sheet.GetRow(rowNums).GetCell(9).StringCellValue;
                                    model.EntrGuarPhone = sheet.GetRow(rowNums).GetCell(10).NumericCellValue.ToString();
                                    model.EntrGuarPost = sheet.GetRow(rowNums).GetCell(11).NumericCellValue.ToString();
                                    model.EntrGuarAddress = sheet.GetRow(rowNums).GetCell(12).StringCellValue;
                                    model.EntrOriginalHTDate = sheet.GetRow(rowNums).GetCell(13).DateCellValue;
                                    model.EntrAFCSendingDate = sheet.GetRow(rowNums).GetCell(14).DateCellValue;
                                    model.EntrASendDate = sheet.GetRow(rowNums).GetCell(15).DateCellValue;
                                }
                                catch (Exception es)
                                {
                                    string aa = es.Message; 
                                    Ajax12.Alert("表中数据出错，请核对正确后上传");
                                    return;
                                }

                                //if (model.CaseContractNumber != 0)
                                //{
                                //    try { bll.Add(model); }
                                //    catch (Exception)
                                //    {
                                //        Ajax12.Alert("数据表导入失败，请稍后尝试");
                                //        return;
                                //    }
                                //}


                            }
                            Ajax12.Alert("导入成功");
                            Ajax12.ResponseScripts.Add("CloseAndRebind()");

                        }
                        else
                        {
                            Ajax12.Alert("表中无数据");
                            return;
                        }
                    }
                    else
                    {
                        Ajax12.Alert("文件表为空！请重新上传");
                        return;
                    }
                }
                else
                {
                    Ajax12.Alert("上传文件为空!");
                    return;
                }
            }
            catch (Exception)
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}