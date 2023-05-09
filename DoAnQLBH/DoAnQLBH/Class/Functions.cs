using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;//Khai baos thư viện truy cập cơ sở dữ liệu
using System.Security.Cryptography;
using System.Threading;
using System.Drawing;

namespace DoAnQLBH.Class
{
    
    class Functions
    {
        public static string admin;
        public static SqlConnection Con;  //Khai báo đối tượng kết nối        
        public static void Connect()
        {
            //Con = new SqlConnection();   //Khởi tạo đối tượng
            Con = new SqlConnection();   //Khởi tạo đối tượng
            Con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thanh\source\repos\DoAnQLBH\DoAnQLBH\QuanLyBanHang.mdf;Integrated Security=True;Connect Timeout=30";
            //Mở kết nối
            //Kiểm tra kết nối
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();

            }
            else MessageBox.Show("Không thể kết nối với dữ liệu");

        }
        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();   	//Đóng kết nối
                Con.Dispose(); 	//Giải phóng tài nguyên
                Con = null;
            }
        }
        
        
        //Phương thưc thực thi lấy dữ liệu
        //Lấy dữ liệu vào bảng
        public static DataTable GetDataToTable(string sql)
        {
            
            SqlDataAdapter dap = new SqlDataAdapter(); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Tạo đối tượng thuộc lớp SqlCommand
            dap.SelectCommand = new SqlCommand();
            dap.SelectCommand.Connection = Functions.Con; //Kết nối cơ sở dữ liệu
            dap.SelectCommand.CommandText = sql; //Lệnh SQL
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }
        //Hàm thực hiện câu lệnh SQL
        public static void RunSQL(string sql)
        {
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = Con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL

            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL không trả về
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }

        public static bool RunSQLD(string sql)
        {
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = Con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            bool x = false;
            try
            {
                SqlDataReader dta = cmd.ExecuteReader(); //Thực hiện câu lệnh SQL
                x = dta.Read();
                dta.Close();//Đóng bộ nhớ

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
            return x;
        }

        //Hàm kiểm tra khoá trùng
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public static void FillCB(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
        }
        public static string ConvertDateTime(string date)
        {
            string[] elements = date.Split('/');
            string dt = string.Format("{0}/{1}/{2}", elements[0], elements[1], elements[2]);
            return dt;
        }
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }
        //Chuyển đổi từ PM sang dạng 24h
        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }
        //Hàm tạo khóa có dạng: TientoNgaythangnam_giophutgiay
        public static string CreateKey(string kitu)
        {
            string key = kitu;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');
            //Ví dụ 07/08/2009
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
            //Xóa ký tự trắng và PM hoặc AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }

        //Định dang tiền
        public static string DinhDangTien(string t)
        {
            string Tien = "";
            var dem = 0;
            var kt = t.Length % 3;
            if (kt == 0)
            {
                dem = 0;
            }
            else if(kt == 1)
            {
                dem = 2;
            }
            else
            {
                dem = 1;
            }
            for(var i=0; i<t.Length;i++)
            {
                if (dem == 3)
                {
                    dem = 1;
                    Tien += ",";
                }
                else
                {
                    dem++;
                }
                Tien += t[i];
            }
            return Tien;
        }
        
    }
}
