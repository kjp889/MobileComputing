using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;

namespace mc_class
{
    public class DataAccessModules
    {
        public DataTable getAllStudents()
        {
            SqlConnection SQLConnection_DBcnn = new SqlConnection(connectionString());
            DataTable DataTable_DTable;
            SqlDataAdapter SqlDataAdapter_SQLdata = new SqlDataAdapter();
            SqlCommand SQLDBCommand = new SqlCommand("MC_students_get_all", SQLConnection_DBcnn);
            DataTable_DTable = new DataTable("type");

            SQLConnection_DBcnn.Open();
            SqlDataAdapter_SQLdata.SelectCommand = SQLDBCommand;
            SQLDBCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter_SQLdata.Fill(DataTable_DTable);

            SQLConnection_DBcnn.Close();
            SqlDataAdapter_SQLdata.Dispose();

            return DataTable_DTable;
        }

        public DataTable getModules(int int_student_num)
        {
            SqlConnection SQLConnection_DBcnn = new SqlConnection(connectionString());
            DataTable DataTable_DTable;
            SqlDataAdapter SqlDataAdapter_SQLdata = new SqlDataAdapter();
            SqlCommand SQLDBCommand = new SqlCommand("MC_modules_get_all", SQLConnection_DBcnn);
            DataTable_DTable = new DataTable("type");

            SQLConnection_DBcnn.Open();
            SqlDataAdapter_SQLdata.SelectCommand = SQLDBCommand;
            SQLDBCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SQLDBCommand.Parameters.Add("@student_num", SqlDbType.Int).Value = int_student_num;
            SqlDataAdapter_SQLdata.Fill(DataTable_DTable);

            SQLConnection_DBcnn.Close();
            SqlDataAdapter_SQLdata.Dispose();

            return DataTable_DTable;
        }

        public DataTable getStudent(int int_student_num)
        {
            SqlConnection SQLConnection_DBcnn = new SqlConnection(connectionString());
            DataTable DataTable_DTable;
            SqlDataAdapter SqlDataAdapter_SQLdata = new SqlDataAdapter();
            SqlCommand SQLDBCommand = new SqlCommand("MC_get_student_single", SQLConnection_DBcnn);
            DataTable_DTable = new DataTable("type");

            SQLConnection_DBcnn.Open();
            SqlDataAdapter_SQLdata.SelectCommand = SQLDBCommand;
            SQLDBCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SQLDBCommand.Parameters.Add("@stu_num", SqlDbType.Int).Value = int_student_num;
            SqlDataAdapter_SQLdata.Fill(DataTable_DTable);

            SQLConnection_DBcnn.Close();
            SqlDataAdapter_SQLdata.Dispose();

            return DataTable_DTable;
        }

        public DataTable getStudentSingle(int int_student_num)
        {
            SqlConnection SQLConnection_DBcnn = new SqlConnection(connectionString());
            DataTable DataTable_DTable;
            SqlDataAdapter SqlDataAdapter_SQLdata = new SqlDataAdapter();
            SqlCommand SQLDBCommand = new SqlCommand("MC_get_students_single", SQLConnection_DBcnn);
            DataTable_DTable = new DataTable("type");

            SQLConnection_DBcnn.Open();
            SqlDataAdapter_SQLdata.SelectCommand = SQLDBCommand;
            SQLDBCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SQLDBCommand.Parameters.Add("@student_num", SqlDbType.Int).Value = int_student_num;
            SqlDataAdapter_SQLdata.Fill(DataTable_DTable);

            SQLConnection_DBcnn.Close();
            SqlDataAdapter_SQLdata.Dispose();

            return DataTable_DTable;
        }

        public DataTable getModule(int int_module_num)
        {
            SqlConnection SQLConnection_DBcnn = new SqlConnection(connectionString());
            DataTable DataTable_DTable;
            SqlDataAdapter SqlDataAdapter_SQLdata = new SqlDataAdapter();
            SqlCommand SQLDBCommand = new SqlCommand("MC_modules_get_single", SQLConnection_DBcnn);
            DataTable_DTable = new DataTable("type");

            SQLConnection_DBcnn.Open();
            SqlDataAdapter_SQLdata.SelectCommand = SQLDBCommand;
            SQLDBCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SQLDBCommand.Parameters.Add("@module_num", SqlDbType.Int).Value = int_module_num;
            SqlDataAdapter_SQLdata.Fill(DataTable_DTable);

            SQLConnection_DBcnn.Close();
            SqlDataAdapter_SQLdata.Dispose();

            return DataTable_DTable;
        }

        public DataTable getStudentsDoingModule(int int_module_num)
        {
            SqlConnection SQLConnection_DBcnn = new SqlConnection(connectionString());
            DataTable DataTable_DTable;
            SqlDataAdapter SqlDataAdapter_SQLdata = new SqlDataAdapter();
            SqlCommand SQLDBCommand = new SqlCommand("MC_get_students_doing_module", SQLConnection_DBcnn);
            DataTable_DTable = new DataTable("type");

            SQLConnection_DBcnn.Open();
            SqlDataAdapter_SQLdata.SelectCommand = SQLDBCommand;
            SQLDBCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SQLDBCommand.Parameters.Add("@mod_num", SqlDbType.Int).Value = int_module_num;
            SqlDataAdapter_SQLdata.Fill(DataTable_DTable);

            SQLConnection_DBcnn.Close();
            SqlDataAdapter_SQLdata.Dispose();

            return DataTable_DTable;
        }

        public void updateStudent(int int_stud_num, string string_first_name, string string_last_name)
        {
            SqlConnection SQLConnection_DBcnn = new SqlConnection(connectionString());
            SqlCommand SQLDBCommand = new SqlCommand("MC_students_update", SQLConnection_DBcnn);

            SQLDBCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SQLDBCommand.Parameters.AddWithValue("@student_num", int_stud_num);
            SQLDBCommand.Parameters.AddWithValue("@first_name", string_first_name);
            SQLDBCommand.Parameters.AddWithValue("@last_name", string_last_name);

            SQLConnection_DBcnn.Open();
            SQLDBCommand.ExecuteNonQuery();

            SQLConnection_DBcnn.Close();

            SQLDBCommand.Dispose();
            SQLConnection_DBcnn.Dispose();
        }

        public void addStudent(string string_first_name, string string_last_name)
        {
            SqlConnection SQLConnection_DBcnn = new SqlConnection(connectionString());
            SqlCommand SQLDBCommand = new SqlCommand("MC_students_add", SQLConnection_DBcnn);

            SQLDBCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SQLDBCommand.Parameters.AddWithValue("@first_name", string_first_name);
            SQLDBCommand.Parameters.AddWithValue("@last_name", string_last_name);

            SQLConnection_DBcnn.Open();
            SQLDBCommand.ExecuteNonQuery();

            SQLConnection_DBcnn.Close();

            SQLDBCommand.Dispose();
            SQLConnection_DBcnn.Dispose();
        }

        public String connectionString()
        {
            return ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        }
    }
}