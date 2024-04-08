﻿using Microsoft.Win32;
using OfficeOpenXml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Threading.Tasks;

using System.Windows.Forms;

using System.Data.OleDb;


namespace ReportUT_
{

    delegate void AddProgressEventHandler(int val);


    public partial class Form1 : Form  /// MaterialForm  
    {

        public void ShowMyDialogBox(string S)
        {
            Ошибка testDialog = new Ошибка(S);
             testDialog.Text = "Ошибка";
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {   ;
            }

            testDialog.Dispose();
        }


         public void ShowMyDialogBox_E(string S, String  LS)
                   // public void ShowMyDialogBox_E(string S, List<String> LS)
        {
            MsgBoxExampleForm testDialog = new MsgBoxExampleForm(S,LS , text_Report.Text);

            //testDialog.Text = "Результат";
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                ;
            }
            testDialog.Dispose();
        }


        private event AddProgressEventHandler onProgress;
        private event AddProgressEventHandler onLabelText;
        private event AddProgressEventHandler onSet_End;

        //string SS = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
        string Path_ini = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) +
            "\\UniTesS\\AmbientUIDService.dat";


        private Params pl = new Params();

        private OdbcConnector p_odbcConnector;

        private ReportDAYs RepDAYs = new ReportDAYs();

        public List<Sensor> sensors = new List<Sensor>();

        public List<SensorMes> Listsensor_Mes = new List<SensorMes>();

        public SensorMes pSensorMes = new SensorMes();

       public  List<Sensor_UID_NAME> List_Sensor_UID_NAME = new List<Sensor_UID_NAME>();

        public Form1()
        {
            InitializeComponent();
            //dateTimePicker1.MaxDate = DateTime.Now;
            DateTime dt = DateTime.Now;
            onProgress += new AddProgressEventHandler(Form1_onProgress);
            onLabelText += new AddProgressEventHandler(Form1_onLabelText);
            onSet_End += new AddProgressEventHandler(Form1_onSet_End);

            // dateTimePicker1.Value = new DateTime(dt.Year, dt.Month, 1, dt.Hour, dt.Minute, dt.Second);
            //  dateTimePicker_2_Time.Value = new DateTime(dt.Year, dt.Month, 1, dt.Hour, dt.Minute, dt.Second);
           // dateTimePicker_Stop_Time.Value = new DateTime(dt.Year, dt.Month, 1, dt.Hour, dt.Minute, dt.Second);
           // dateTimePicker_Start_Time.Value = new DateTime(dt.Year, dt.Month , 1, dt.Hour , dt.Minute, dt.Second);
           // dateTimePicker1.Format = DateTimePickerFormat.Custom;
           // dateTimePicker1.CustomFormat = "yyyy MMMM HH:mm";
           // dateTimePicker1.ShowUpDown = true;


           // dateTimePicker_2_Time.MaxDate = DateTime.Now;
          //  dateTimePicker_2_Time.Format = DateTimePickerFormat.Custom;
            // dateTimePicker_2_Time.Value  = DateTime.Now;
          //  dateTimePicker_2_Time.ShowUpDown = true;
          //  dateTimePicker_2_Time.CustomFormat = " HH:mm";

            dateTimePicker_Start_Time.MaxDate =   DateTime.Now;
            dateTimePicker_Start_Time.ShowUpDown = true;
          //  dateTimePicker_Start_Time.CustomFormat = "yyyy MMMM";
           // dateTimePicker_Start_Time.Value = new DateTime(dt.Year, dt.Month-2, 1, dt.Hour, dt.Minute, dt.Second);

            dateTimePicker_Stop_Time.MaxDate = DateTime.Now  ;
            dateTimePicker_Stop_Time.ShowUpDown = true;
           // dateTimePicker_Stop_Time.CustomFormat = "yyyy MMMM";
         

           ToolTip t = new ToolTip();
            t.SetToolTip(Button_Settings, "Настройки");

        }

        // Delete dublicates
        public ArrayList Del_dubl(List<String> myStringList)
        {
            ArrayList sList = new ArrayList();

            for (int i = 0; i < myStringList.Count; i++)
            {
                myStringList[i] = myStringList[i].Replace(",", String.Empty);
                if (sList.Contains(myStringList[i]) == false )
                {
                   
                    sList.Add(myStringList[i]);
                }
            }
            return sList;
        }

        public  String Get_UID_NAME_Sensor_by_NAME(String Name)
        {
            String SL = "", StrCur = "";
            List<Sensor_UID_NAME> List_Sensor_UID_NAME_R = new List<Sensor_UID_NAME>();
            List_Sensor_UID_NAME_R.Clear();
            for (int i = 0; i < List_Sensor_UID_NAME.Count; i++)
                if (List_Sensor_UID_NAME[i].Name.Contains(Name))
                {
                    List_Sensor_UID_NAME[i].UID = List_Sensor_UID_NAME[i].UID.Replace(",", String.Empty);
                    List_Sensor_UID_NAME_R.Add(List_Sensor_UID_NAME[i]);
                    // SL = SL+(List_Sensor_UID_NAME[i].Time +"   " + List_Sensor_UID_NAME[i].UID + "\n" );
                }

            int ii = 0;
            bool ONE = true;
            int CNT = List_Sensor_UID_NAME_R.Count();
            while (ii < List_Sensor_UID_NAME_R.Count - 1)
            {
                StrCur = List_Sensor_UID_NAME_R[ii].UID;
                if (List_Sensor_UID_NAME_R[ii + 1].UID.Contains(StrCur))
                {
                    ii++;
                }
                else
                {
                    ONE = false;
                    SL = SL + (List_Sensor_UID_NAME_R[ii].Time + "   " + List_Sensor_UID_NAME_R[ii].UID + "\n");
                    ii++;
                }
               
            }
 if (ONE) SL = SL + (List_Sensor_UID_NAME_R[0].Time + "   " + List_Sensor_UID_NAME_R[0].UID + "\n");
            if (CNT >= 2)
                if (List_Sensor_UID_NAME_R[CNT - 2].UID != List_Sensor_UID_NAME_R[CNT - 1].UID)
                SL = SL + (List_Sensor_UID_NAME_R[CNT - 1].Time + "   " + List_Sensor_UID_NAME_R[CNT - 1].UID + "\n");
            return SL;

        }

       

        public  String Get_UID_NAME_Sensor_by_UID(String UID)
        {

             String SL =  "" , StrCur ="" ;
           List <Sensor_UID_NAME> List_Sensor_UID_NAME_R = new List<Sensor_UID_NAME>(); 
            List_Sensor_UID_NAME_R.Clear();
            for (int i = 0; i < List_Sensor_UID_NAME.Count; i++)
                if (List_Sensor_UID_NAME[i].UID.Contains(UID))
                {
                    List_Sensor_UID_NAME[i].Name = List_Sensor_UID_NAME[i].Name.Replace(",", String.Empty);
                    List_Sensor_UID_NAME_R.Add(List_Sensor_UID_NAME[i]);
                    // SL = SL+(List_Sensor_UID_NAME[i].Time +"   " + List_Sensor_UID_NAME[i].Name + "\n" );
                }

            int ii = 0;
            bool ONE = true;
            int CNT = List_Sensor_UID_NAME_R.Count();
            while (ii< List_Sensor_UID_NAME_R.Count-1)
            {
                StrCur = List_Sensor_UID_NAME_R[ii].Name;
                if (List_Sensor_UID_NAME_R[ii + 1].Name.Contains(StrCur))
                {
                    ii++;
                }
                else
                {
                    ONE = false;
                    SL = SL + (List_Sensor_UID_NAME_R[ii].Time + "   " + List_Sensor_UID_NAME_R[ii].Name + "\n");
                    ii++;
                }

            }

            if (ONE) SL = SL + (List_Sensor_UID_NAME_R[0].Time + "   " + List_Sensor_UID_NAME_R[0].Name + "\n");
           if (CNT>=2)
            if (List_Sensor_UID_NAME_R[CNT - 2].Name != List_Sensor_UID_NAME_R[CNT - 1].Name)
                SL = SL + (List_Sensor_UID_NAME_R[CNT - 1].Time + "   " + List_Sensor_UID_NAME_R[CNT - 1].Name + "\n");

            return SL;
        }


        private void Excel_Add(List<Sensor_UID_NAME> List_Sensor_UID_NAME)
        {

            try
            {
                string file = "C:\\Users\\Public\\Documents\\UniTesS\\Report_UID_NANE.xls";
                var package = new ExcelPackage();
                var sheet = package.Workbook.Worksheets.Add("Report");

                for (int i = 0;i< List_Sensor_UID_NAME.Count;i++)
                {
                    sheet.Cells[i+1, 1].Value = List_Sensor_UID_NAME[i].Time;
                    sheet.Cells[i+1, 2].Value = List_Sensor_UID_NAME[i].UID;
                    sheet.Cells[i+1, 3].Value = List_Sensor_UID_NAME[i].Name;
                }
               

                //sheet.Cells["B2"].Value = "Company:";
               // sheet.Cells[2, 3].Value = "sasdf";


                File.WriteAllBytes(file, package.GetAsByteArray());  //.Save(file);
            }
            catch (System.Exception ex)
            {
                Logger.GetInstanse().SetData("Excel_Add", ex.Message);
                MessageBox.Show(ex.Message);
                return;
            }
        }


        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            //dateTimePicker_2_Time.Visible = (!dateTimePicker_2_Time.Visible);
           // if (Control.ModifierKeys == Keys.Control) checkBox1.Visible = true;
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //if (RepDAYs.BM2)
            //{
            //    dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //    dateTimePicker1.CustomFormat = "HH:mm";
            //}
            //else
            //{
            //    dateTimePicker1.CustomFormat = "yyyy MMMM HH:mm";
            //}


            //DateTime dt = dateTimePicker1.Value;
            ////  dateTimePicker1.Value = new DateTime(dt.Year, dt.Month, 1, dt.Hour, dt.Minute, dt.Second);

            //dateTimePicker1.MaxDate = DateTime.Now;
            //dateTimePicker_2_Time.MaxDate = DateTime.Now;
            //dateTimePicker_2_Time.Value = dateTimePicker1.Value;

            //RepDAYs.T11 = dateTimePicker1.Value.ToShortDateString();
            //RepDAYs.T12 = dateTimePicker_2_Time.Value.ToString();

            //dateTimePicker1.Value = DateTime.Parse(RepDAYs.T11);
        }



        private void materialSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void dateTimePicker_2_Time_ValueChanged(object sender, EventArgs e)
        {
   //         DateTime dt = dateTimePicker_2_Time.Value;
   //         if (dt < dateTimePicker1.Value)
   //         {
   //             MessageBox.Show("начало периода  " + dateTimePicker1.Value.ToString() +
   //"\nне может превышать его окончание  " + dateTimePicker_2_Time.Value.ToString(), "Ошибка");
   //             dateTimePicker_2_Time.Value = dateTimePicker1.Value;
   //             return;
   //         }

   //         RepDAYs.T12 = dateTimePicker_2_Time.Value.ToString();
        }

        private void dateTimePicker_Start_Time_ValueChanged(object sender, EventArgs e)
        {
   //         if (dateTimePicker_Start_Time.Value > dateTimePicker_Stop_Time.Value)
   //         {
   //             MessageBox.Show("начало периода  " + dateTimePicker_Start_Time.Value.ToString() +
   //"\nне может превышать его окончание  " + dateTimePicker_Stop_Time.Value.ToString() +
   //"\n(начальная дата должна быть  меньше конечной)  ", "Ошибка");
   //            // dateTimePicker_Stop_Time.Value = DateTime.Now;
   //             return;
   //         }
        }

        private void dateTimePicker_Stop_Time_ValueChanged(object sender, EventArgs e)
        {
             

        }
     
        private void Button_Reports_Click(object sender, EventArgs e)
        {
           folderBrowserDialog1.Description = "Выбор местоположения для жуналов учета";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                text_Report.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Button_Exec_Report_Click(object sender, EventArgs e)
        {
            int Moun = 0;


            ////if (checkBox1.Checked)
            //{
            //    Moun = dateTimePicker_Stop_Time.Value.Month - dateTimePicker1.Value.Month;
            //    if (dateTimePicker_Start_Time.Value > dateTimePicker_Stop_Time.Value)
            //    {
            //        MessageBox.Show("начальная дата  " + dateTimePicker1.Value.ToString() +
            //      "\nне может превышать конечную  " + dateTimePicker_Stop_Time.Value.ToString()); return;
            //    }
            //}



            if (!Directory.Exists(text_Report.Text) )
                {
                MessageBox.Show("Не найден каталог для вывода отчетов", "Ошибка");
                panel2.Visible = true;
                return;
            }
            if (!File.Exists(text_Sample.Text))
            {
                MessageBox.Show("Файл-шаблон не найден по указанному пути", "Ошибка");
                panel2.Visible = true;
                return;
            }


            Seril_Param();

            //Button_Exec_Report.Text = "соедениение с БД  >>>>>>>";


            string sTime = "Время";
            string sTemp = "Температура, °C";
            string sHum = "Относительная влажность, %";
            string sRespPerson = " Подпись лица, ответственного за внесение данных";

            String[] ListStr = new String[32];
            String[] ListStr1 = new String[32];
            String[] ListStr2 = new String[32];
            String[] ListStr3 = new String[1];
            ListStr[0] = sTime;
            ListStr1[0] = sTemp;
            ListStr2[0] = sHum;
            ListStr3[0] = sRespPerson;

           // string Bt = Button_Exec_Report.Text;
            label_Count.Focus();

          
           // RepDAYs.dateT1 = dateTimePicker1.Value;
           // RepDAYs.dateT2 = dateTimePicker_2_Time.Value;

            #region [ Task.Run(()]
     
            Task.Run(() =>
           {
               int CountSensors ;
               double procent ;
               double D_procent = 0;
               int prc = 0;
               try
               {

                   try
                   {
                       p_odbcConnector = new OdbcConnector(pl.DSN);
                       p_odbcConnector.F_DB = true;

                       if (onLabelText != null) onLabelText(-1);  //  label_Count.Text = "Чтение датчиков";
                       sensors = p_odbcConnector.AllSensors();
                       p_odbcConnector.Sens_Type_Limits();
                       p_odbcConnector.AllSensorsRoom();

                        CountSensors = sensors.Count;
                        procent = (double)(100 / ((double)CountSensors * (Moun + 1)));
                        D_procent = 0;
                        prc = 0;

                   }
                   catch (Exception ex)
                   {
                       Logger.GetInstanse().SetData("Get_DAY_MeasSensorId", ex.Message);
                       MessageBox.Show(ex.Message);
                       return;
                   }


                   for (int Moun_n = 0; Moun_n <= Moun; Moun_n++)
                   {
                       Listsensor_Mes = p_odbcConnector.AllSensors_Mes(RepDAYs.dateT1.ToString(), RepDAYs.dateT1.AddMonths(1).ToString());
                
                       for (int sn_n = 0; sn_n < sensors.Count; sn_n++)
                       {

                           One_Sens_Day(Listsensor_Mes, ListStr, ListStr1, ListStr2, ListStr3, sensors[sn_n].Id, sn_n, Moun_n);
                           D_procent = D_procent + procent;
                           prc = (int)D_procent;

                           if (onProgress != null) onProgress(prc);
                           if (onSet_End != null) onSet_End(prc);

                           if (onLabelText != null) onLabelText(sn_n + 1);
                          
                       }
                       if (Moun > 0)
                       {
                           RepDAYs.dateT1 = RepDAYs.dateT1.AddMonths(1);
                           RepDAYs.dateT2 = RepDAYs.dateT2.AddMonths(1);
                       }
                       if (onProgress != null) onProgress(0);
                       if (onLabelText != null) onLabelText(sensors.Count);// Button_Exec_Report.Text = "Сформировать отчет";
                       Application.DoEvents();
                   }
                   if (p_odbcConnector.F_DB)
                   {
                       onProgress(100);
                       Application.DoEvents();
                       MessageBox.Show("Фомирование отчетов выполнено", "Сообщение");
                   }    
                       
                   else
                   {
                       Action action = () => ShowMyDialogBox("нет подключения к БД. \nВ настройках проверьте Источник данных(DSN)");
                          if (InvokeRequired)
                           Invoke(action);
                       else
                           action();
                   }
                   if (onSet_End != null) onSet_End(-1);// Button_Exec_Report.Text = "Сформировать отчет";
               }
               catch (SqlException ee)
               {
                   MessageBox.Show("Превышено время ожидания ответа от сервера БД " + ee.ToString());
               }
           });
            #endregion
           
            progressBar1.Value = 1;
        }


        private void One_Sens_Day(List<SensorMes> LSM, string[] ListStr, string[] ListStr1, string[] ListStr2, string[] ListStr3, int iDS, int numS, int Mountn)
        {
            DateTime dateTm = RepDAYs.dateT1;
            DateTime dateTm2;

            try
            {
                for (int i = 1; i < 32; i++)
                { ListStr[i] = ListStr1[i] = ListStr2[i] = ""; }

                int countDays = System.DateTime.DaysInMonth(dateTm.Year, dateTm.Month);
                string HH_mm = dateTm.ToString(" HHч mmмин ");


                for (int j = 1; j <= countDays; j++)
                {

                    pSensorMes = p_odbcConnector.OneSensor(LSM, iDS, dateTm.ToString(), dateTm.ToString(), 0, pl.DSN);


                    if (pSensorMes != null)
                        if (pSensorMes.Id != -1000)
                        {
                            ListStr[j] = pSensorMes.TimeS.ToString("HH:mm"); // ();  //   //
                            if (float.IsNaN(pSensorMes.Temperature))
                            ListStr1[j] = "N/A";
                           else 
                                ListStr1[j] = pSensorMes.Temperature.ToString("0.0");

                            if (float.IsNaN(pSensorMes.Humidity))
                                ListStr2[j] = "N/A";
                            else
                                ListStr2[j] = pSensorMes.Humidity.ToString("0.0");
                        }
                        else
                        {
                            ListStr[j] = ListStr1[j] = ListStr2[j] = "";
                        }

                    dateTm = dateTm.AddDays(1);

                }

                Save_Day_mes(ListStr, ListStr1, ListStr2, ListStr3, HH_mm, numS);



                dateTm = RepDAYs.dateT1;
                dateTm2 = RepDAYs.dateT2;
                //if (checkBox2.Checked)
                //    if (dateTm != dateTm2)
                //    {
                //        for (int i = 1; i < 32; i++)
                //        { ListStr[i] = ListStr1[i] = ListStr2[i] = ""; }

                //        countDays = System.DateTime.DaysInMonth(dateTm2.Year, dateTm2.Month);
                //        HH_mm = dateTm2.ToString(" HHч mmмин ");

                //        for (int j = 1; j <= countDays; j++)
                //        {
                //            pSensorMes = p_odbcConnector.OneSensor(Listsensor_Mes, iDS, dateTm2.ToString(), dateTm2.ToString(), 0, pl.DSN);
                //            if (pSensorMes != null)
                //                if (pSensorMes.Id != -1000)
                //                {
                //                    ListStr[j] = pSensorMes.TimeS.ToString("HH:mm"); //();  //
                //                    if (float.IsNaN(pSensorMes.Temperature))
                //                        ListStr1[j] = "N/A";
                //                           else
                //                            ListStr1[j] = pSensorMes.Temperature.ToString("0.0");

                //                    if (float.IsNaN(pSensorMes.Humidity))
                //                        ListStr2[j] = "N/A";
                //                    else
                //                        ListStr2[j] = pSensorMes.Humidity.ToString("0.0");
                                  
                //                }
                //                else
                //                {
                //                    ListStr[j] = ListStr1[j] = ListStr2[j] = "";
                //                }
                //            dateTm2 = dateTm2.AddDays(1);
                //        }
                //        Save_Day_mes(ListStr, ListStr1, ListStr2, ListStr3, HH_mm, numS);
                //    }


            }
            catch (Exception ex)
            {
                Logger.GetInstanse().SetData("One_Sens_Day", ex.Message);
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void Save_Day_mes(string[] ListStr, string[] ListStr1, string[] ListStr2, string[] ListStr3, string HH_mm, int num)
        {
            if (sensors.Count == 0) return;
            int k = 0;
            for (int i =1; i< ListStr.Length;i++)
            {
                if (ListStr[i] != "")
                    k++;
            }
if (k==0)                   return;

            SavePredator.SavePredator SP = new SavePredator.SavePredator();
            SP.Load(pl.Sample);
            var BM = SP.Bookmarks;
            //if (checkBox4.Checked == true) SP.BM_Insert_Str("Time_Pov", pl.Date_POV);
            //if (checkBox3.Checked == true) SP.BM_Insert_Str("zona", pl.Room);
            //else
            //    SP.BM_Insert_Str("zona", sensors[num].Zone);

            SP.BM_Insert_Str("t_min", sensors[num].Tmin);
            SP.BM_Insert_Str("t_max", sensors[num].Tmax);
 
            SP.BM_Insert_Str("sens_name", sensors[num].sType + " " + sensors[num].Name);
            SP.BM_Insert_Str("data_meas", RepDAYs.dateT1.ToString("MMMM, yyyy"));

            SP.BM_Insert_Line("HUM_TABLE", ListStr);

            SP.BM_Insert_Line("HUM_TABLE", ListStr1);

            // с влажностью
            if (sensors[num].iType == 8 || sensors[num].iType == 6 || sensors[num].iType == 4 || sensors[num].iType == 2)
            {
                SP.BM_Insert_Str("h_min", sensors[num].Hmin);
                SP.BM_Insert_Str("h_max", sensors[num].Hmax);
                SP.BM_Insert_Line("HUM_TABLE", ListStr2);
            }
            else
                SP.BM_Delete("HUM");

            SP.BM_Insert_Line("HUM_TABLE", ListStr3);

            SP.BM_Delete_Last_Row(new String[] { "HUM_TABLE" });

           String Sg = RepDAYs.dateT1.ToString();

           string path =  text_Report.Text; //+ @"{text_Report.Text}\\Отчеты\\{RepDAYs.dateT1.Year}\\{self.month_str}";

            path = path + "\\Отчеты\\" + RepDAYs.dateT1.Year.ToString() + "\\"
                + RepDAYs.dateT1.ToString ("MMMM") ;
            // + RepDAYs.dateT1.Month.ToString();

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string Sens_name = sensors[num].Name;
            //  Sens_name = "test.//\\";
            Sens_name = Sens_name.Replace(":", "_");
            Sens_name = Sens_name.Replace(";", "_");
            Sens_name = Sens_name.Replace("/", "_");
            Sens_name = Sens_name.Replace("\"", "_");
            Sens_name = Sens_name.Replace("*", "_");
            Sens_name = Sens_name.Replace("?", "_");
            Sens_name = Sens_name.Replace("|", "_");
            Sens_name = Sens_name.Replace("«", "_");
            Sens_name = Sens_name.Replace(">", "_");
            Sens_name = Sens_name.Replace("<", "_");
            Sens_name = Sens_name.Replace("\\", "_");
               

            string doc_name = sensors[num].sType + "_" + Sens_name + "_" + sensors[num].UID + "_" + HH_mm + ".docx";    ///UniTesS THB - 1С 170434 
            string S = path + "\\" + doc_name;
            SP.Save(S);
        }

        private void Button_Settings_Click(object sender, EventArgs e)
        {
            OleDbDataReader reader =
      OleDbEnumerator.GetEnumerator(Type.GetTypeFromProgID("MSDASQL Enumerator"));

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (reader.GetName(i) == "SOURCES_NAME")
                    Console.WriteLine("{0} ",  reader.GetValue(i));
                }
            }

            panel2.Visible = !panel2.Visible;
        }

        private void Button_Sample_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Выбор местоположения шаблона";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                text_Sample.Text = openFileDialog1.FileName;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Seril_Param();
        }

        private void Seril_Param()
        {
            //save data
            BinaryFormatter fmr = new BinaryFormatter();

            {
              //  pl.Room = text_Room.Text;
                pl.DSN = text_DSN.Text;
                pl.Report = text_Report.Text;
                pl.Sample = text_Sample.Text;
               //  pl.Date_POV = text_Date_POV.Text;
              //  pl.Date_POV_check = checkBox4.Checked;
              //  pl.Room_check = checkBox3.Checked;

            }
            Stream stmSaveWrite = new FileStream(Path_ini, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            fmr.Serialize(stmSaveWrite, pl);
            stmSaveWrite.Close();
        }
//---------------------------------------------------------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            Deseril_Param();
            //string path = "C:\\Users\\Public\\Documents\\UniTesS\\UniTessAS.ini";
            //string Alias = "";
            //if (File.Exists(path))
            //{
            //    Alias = IniReader.Read(path, "DBAlias", "UniTesS%20Ambient%20Software");
            //    if (Alias != null && Alias != "")
            //        text_DSN.Text = Alias;
            //}
            text_DSN.Text = pl.DSN;
            string logPath = "C:\\Users\\Public\\Documents\\UniTesS\\UT_Report_Log.txt";
            File.Create(logPath).Close();

            try
            {
                List<string> SL = EnumDsn();

                comboBox1.Items.AddRange(SL.ToArray());

                comboBox1.SelectedItem = SL[0];
            }
            catch (System.Exception ex)
            {
                Logger.GetInstanse().SetData("Form1_Load: ", ex.Message);
                MessageBox.Show(ex.Message);
            }


        }

        private void Deseril_Param()
        {
            BinaryFormatter fmr = new BinaryFormatter();

            if (!File.Exists(Path_ini))
                  
                    {
                        Stream stmSaveWrite = new FileStream(Path_ini, FileMode.Create, FileAccess.Write, FileShare.None);
                        fmr.Serialize(stmSaveWrite, pl);
                        stmSaveWrite.Close();
                    }
            {

                Stream stmSaveRead = new FileStream(Path_ini, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                bool bError = false;
                try
                {
                    pl = (Params)fmr.Deserialize(stmSaveRead);
                }
                catch
                {
                    bError = true;
                }
                //text_Room.Text = pl.Room;
                text_DSN.Text = pl.DSN;
                text_Report.Text = pl.Report;
                text_Sample.Text = pl.Sample;
                //*text_Date_POV.Text*/ string S1 = pl.Date_POV;
                // checkBox3.Checked= pl.Room_check;
                // checkBox4.Checked = pl.Date_POV_check;
                string S1 = pl.Date_POV; 
                bool S2 = pl.Room_check;
                bool S3 = pl.Date_POV_check;

                stmSaveRead.Close();
                 
                if (bError)
                {
                    MessageBox.Show("Error reading AmbientUIDService.dat");
                    stmSaveRead.Close();
                    return;
                }

            }
       
       
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            RepDAYs.BT21 = !RepDAYs.BT21;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            RepDAYs.BM2 = !RepDAYs.BM2;

            //if (RepDAYs.BM2)
            //{
            //    dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //    // Display the date as "Mon 27 Feb 2012".  
            //    dateTimePicker1.CustomFormat = "HH:mm";
            //}
            //else
            //{
            //    dateTimePicker1.CustomFormat = "yyyy MMMM HH:mm";
            //}


            //DateTime dt = dateTimePicker1.Value;
            ////  dateTimePicker1.Value = new DateTime(dt.Year, dt.Month, 1, dt.Hour, dt.Minute, dt.Second);

            //dateTimePicker1.MaxDate = DateTime.Now;
            //dateTimePicker_2_Time.MaxDate = DateTime.Now;
            //dateTimePicker_2_Time.Value = dateTimePicker1.Value;

            //RepDAYs.T11 = dateTimePicker1.Value.ToShortDateString();
            //RepDAYs.T12 = dateTimePicker_2_Time.Value.ToString();

            //dateTimePicker1.Value = DateTime.Parse(RepDAYs.T11);

        }

        void Form1_onLabelText(int val)
        {
            if (label_Count.InvokeRequired)
            {
                this.BeginInvoke(
                    new AddProgressEventHandler(Form1_onLabelText),
                    new object[] { val });
            }
            else
            {
                label_Count.Text = "Всего:" + sensors.Count.ToString() + " / Обработано:" + val.ToString();

                if (val == -1)
                {
                    label_Count.Text = "Чтение датчиков";
                }
                if (val == sensors.Count)
                {
                    onProgress(100);  //Button_Exec_Report.Text = "Сформировать отчет";
                }

            }
        }

        private void Form1_onSet_End(int val)
        {
            //if (Button_Exec_Report.InvokeRequired)
            //{
            //    this.BeginInvoke(
            //        new AddProgressEventHandler(Form1_onSet_End),
            //        new object[] { val });
            //}
            //else
            //{
            //    if (val ==-1)
            //    { Button_Exec_Report.Text = "сформировать отчеты"; return; }


            //    if (sensors.Count == 0) { Button_Exec_Report.Text = "соедениение с БД"; return; }
            //    double D = 100.0 / (sensors.Count * val + 1);

            //    Button_Exec_Report.Text = val.ToString() + "%";

            //    //if (val == sensors.Count-1)
            //    //{
            //    //    onProgress(100); Button_Exec_Report.Text = "Сформировать отчет";
            //    //}
            //}

        }

        void Form1_onProgress(int val)
        {
            if (progressBar1.InvokeRequired)
            {
                this.BeginInvoke(
                    new AddProgressEventHandler(Form1_onProgress),
                    new object[] { val });
            }
            else
            //progressBar1.Value += ;
            {
                if (val < progressBar1.Minimum) return;
                if (val > progressBar1.Maximum) return;
                progressBar1.Value = val;
                if (progressBar1.Value > 98) progressBar1.Value = 0;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
           

            try
            {
                //if (onProgress != null) onProgress(10);
                Application.DoEvents();

                if (radioButton1.Checked)
                {
                    
                    string UID = UID_comboBox.Text;
                    if (UID=="") return;

                    Action action = () => ShowMyDialogBox_E("UID:  " + UID, Get_UID_NAME_Sensor_by_UID(UID).ToString());
                    if (InvokeRequired)  Invoke(action);   else  action();

                    //MessageBox.Show ("                  Names \n\n" + Get_UID_NAME_Sensor_by_UID(UID).ToString(), "UID:  "+ UID);
                }

                if (radioButton2.Checked)
                {

                    string Name = Name_comboBox.Text;
                    if (Name == "") return;
                    Action action = () => ShowMyDialogBox_E("Имя:  " + Name, Get_UID_NAME_Sensor_by_NAME(Name).ToString());
                    if (InvokeRequired) Invoke(action); else action();
                    // MessageBox.Show("                     UIDs   \n\n" + Get_UID_NAME_Sensor_by_NAME(Name), "Name:  "+ Name);
                }

                if (onProgress != null) onProgress(0);

                //  Excel_Add(List_Sensor_UID_NAME);



            }
            catch (Exception ex)
            {
                Logger.GetInstanse().SetData("Get_UID_NAME_Sensor", ex.Message);
                MessageBox.Show(ex.Message);
                if (onProgress != null) onProgress(0);
                return;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (p_odbcConnector!=null)
            {
                p_odbcConnector.CloseConnection();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MaterialButton2_Click(object sender, EventArgs e)
        {
             
            try
            {

                if (dateTimePicker_Start_Time.Value > dateTimePicker_Stop_Time.Value)
                {
                    MessageBox.Show("начало периода  " + dateTimePicker_Start_Time.Value.ToString() +
       "\nне может превышать его окончание  " + dateTimePicker_Stop_Time.Value.ToString() +
       "\n(начальная дата должна быть  меньше конечной)  ", "Ошибка");
                    // dateTimePicker_Stop_Time.Value = DateTime.Now;
                    materialButton1.Visible = false;
                    return;
                }

                //p_odbcConnector = new OdbcConnector(pl.DSN);
                p_odbcConnector = new OdbcConnector(text_DSN.Text);
                p_odbcConnector.F_DB = true;

                if (onProgress != null) onProgress(30);
                Application.DoEvents();
                Thread.Sleep(1000);

                DateTime dt;


                dt = dateTimePicker_Stop_Time.Value;
              //  dateTimePicker_Stop_Time.Value = new DateTime(dt.Year, dt.Month, 1, dt.Hour, dt.Minute, dt.Second);
                dt = dateTimePicker_Start_Time.Value;
                dateTimePicker_Start_Time.Value = new DateTime(dt.Year, dt.Month, 1, dt.Hour, dt.Minute, dt.Second);

                string ST1 = dateTimePicker_Start_Time.Value.ToString();
                string ST2 = dateTimePicker_Stop_Time.Value.ToString();

                List_Sensor_UID_NAME = p_odbcConnector.Get_UID_NAME_Sensor(ST1, ST2);

                 //// Delete dublicates
                List<String> myStringList = new List<string>();
 
                for (int i = 0; i < List_Sensor_UID_NAME.Count; i++)
                    myStringList.Add(List_Sensor_UID_NAME[i].UID);
               UID_comboBox.Items.Clear();
                UID_comboBox.Items.AddRange(Del_dubl(myStringList).ToArray());

                if (onProgress != null) onProgress(90);
                Application.DoEvents();
                Thread.Sleep(1000);

                List<String> myStringList1 = new List<string>();

                for (int i = 0; i < List_Sensor_UID_NAME.Count; i++)
                    myStringList1.Add(List_Sensor_UID_NAME[i].Name);

                Name_comboBox.Items.Clear();
                Name_comboBox.Items.AddRange(Del_dubl(myStringList1).ToArray());

                if (UID_comboBox.Items.Count>0)
                this.UID_comboBox.SelectedIndex = 0;
                if (Name_comboBox.Items.Count > 0)
                    this.Name_comboBox.SelectedIndex = 0;

                if (onProgress != null) onProgress(100);
                Application.DoEvents();
                Thread.Sleep(1000);

                if (List_Sensor_UID_NAME.Count <= 0)
                {
                    MessageBox.Show("                      НЕТ ДАННЫХ \n\n"+"начало периода  " + dateTimePicker_Start_Time.Value.ToString() +
       "\nокончание периода " + dateTimePicker_Stop_Time.Value.ToString(), "                       Сообщение");
                    materialButton1.Visible = false;
                    return;
                }

                materialButton1.Visible = true;
                materialButton1.Enabled = true;
                //// Excel_Add(List_Sensor_UID_NAME);

                if (onProgress != null) onProgress(0);
                Application.DoEvents();

            }
            catch (Exception ex)
            {
                Logger.GetInstanse().SetData("Get_UID_NAME_Sensor", ex.Message);
                MessageBox.Show(ex.Message);
                materialButton1.Visible = false;
                return;
            }


        }

        private void UID_comboBox_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void Name_comboBox_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }


        private List<string> EnumDsn()
        {
            List<string> list = new List<string>();
             list.AddRange(EnumDsn(Registry.CurrentUser));
            list.AddRange(EnumDsn(Registry.LocalMachine));
            return list;
        }

        private IEnumerable<string> EnumDsn(RegistryKey rootKey)
        {
            RegistryKey regKey = rootKey.OpenSubKey(@"Software\ODBC\ODBC.INI\ODBC Data Sources");
            if (regKey != null)
            {
                foreach (string name in regKey.GetValueNames())
                {
                    string value = regKey.GetValue(name, "").ToString();
                    yield return name;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           //SelectedIndex.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text_DSN.Text = comboBox1.SelectedItem.ToString();
        }
    }


}
