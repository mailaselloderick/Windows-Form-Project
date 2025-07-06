using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    public class DataAccessLayer
    {
        string conn = "Data Source = LAPTOP-JSJQJ6MA\\SQLEXPRESS01; Initial Catalog = Project_DB; Integrated Security = SSPI;";
        SqlConnection dbConn;
        SqlCommand dbComm;
        SqlDataAdapter da;
        DataTable dt;


        //Add User to tblUser
        public int InsertUsers(Fields fields)
        {
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_InsertUser";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("Name", fields.Name);
            dbComm.Parameters.AddWithValue("Surname", fields.Surname);
            dbComm.Parameters.AddWithValue("Title", fields.Title);
            dbComm.Parameters.AddWithValue("Role", fields.Role);
            dbComm.Parameters.AddWithValue("Email", fields.Email);
            dbComm.Parameters.AddWithValue("Password", fields.Password);
            dbComm.Parameters.AddWithValue("UserStatus", fields.UserStatus);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }
        //Get User from tblUser
        public DataTable GetUser()
        {
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_GetUser";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);

            dbConn.Close();
            return dt;

        }
        //Update User from tblUser
        public int UpdateUsers(Fields fields)
        {
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_UpdateUser";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("UserID", fields.UserID);
            dbComm.Parameters.AddWithValue("Surname", fields.Surname);
            dbComm.Parameters.AddWithValue("Title", fields.Title);
            dbComm.Parameters.AddWithValue("Password", fields.Password);
            dbComm.Parameters.AddWithValue("UserStatus", fields.UserStatus);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }
        //Get UserRole from tblUser
        public DataTable GetUserRole(string Role)
        {
            Fields fields = new Fields();
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_GetUserRole";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Role", Role);
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);

            dbConn.Close();
            return dt;

        }
        //Get UserName for tblUser
        public DataTable GetUserByName(string Name)
        {
            Fields fields = new Fields();
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_GetUserByName";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Name", Name);
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);

            dbConn.Close();
            return dt;

        }
        public DataTable SearchModule(string ModuleName)
        {
            Fields fields = new Fields();
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_SearchModule";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleName", ModuleName);
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);

            dbConn.Close();
            return dt;
        }
        //get ModuleType from tblModuleType
        public DataTable GetModuleType()
        {
            Fields fields = new Fields();
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_GetModuleType";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);

            dbConn.Close();
            return dt;
        }
        //Add modules into tblModule
        public int InsertModule(Fields fields)
        {
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_InsertModule";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("ModuleName", fields.ModuleName);
            dbComm.Parameters.AddWithValue("ModuleDuration", fields.ModuleDuration);
            dbComm.Parameters.AddWithValue("ModuleTypeID", fields.ModuleTypeID);
            dbComm.Parameters.AddWithValue("ModuleStatus", fields.ModuleStatus);


            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }
        public DataTable GetModuleName()
        {
            Fields fields = new Fields();
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_GetModuleName";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);

            dbConn.Close();
            return dt;

        }

        //Display Modules in tblModule
        public DataTable GetModule()
        {
            Fields fields = new Fields();
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_GetModule";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);

            dbConn.Close();
            return dt;
        }
        //Update Modules in tblModule
        public int UpdateModule(Fields fields)
        {
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_UpdateModule";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("ModuleID", fields.ModuleID);
            dbComm.Parameters.AddWithValue("ModuleDuration", fields.ModuleDuration);
            dbComm.Parameters.AddWithValue("ModuleStatus", fields.ModuleStatus);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }
        //insert lecturer module
        public int InsertLecturerMod(Fields fields)
        {
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_InsertLecturerMod";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("UserID", fields.UserID);
            dbComm.Parameters.AddWithValue("ModuleID", fields.ModuleID);
            dbComm.Parameters.AddWithValue("Date", fields.Date);
            dbComm.Parameters.AddWithValue("ModLecturerStatus", fields.ModLecturerStatus);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }
        //Display tblLecturerModule
        public DataTable GetLecturerMod()
        {
            Fields fields = new Fields();
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_GetLecturerMod";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);

            dbConn.Close();
            return dt;

        }
        //gets the lecturer name into cmb Option
        public DataTable GetLecturerDetails()
        {
            Fields fields = new Fields();
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_GetLecturerDetails";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);

            dbConn.Close();
            return dt;

        }
       
        
        public DataTable ViewLeturerModByEmail(string Email)
        {

            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_ViewLeturerModByEmail";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", Email);
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }
        //Update tblLecturerModule
        public int UpdateLecturerMod(Fields fields)
        {
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_UpdateLecturerMod";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("LecturerModuleID", fields.LecturerModuleID);
            dbComm.Parameters.AddWithValue("UserID", fields.UserID);
            dbComm.Parameters.AddWithValue("ModuleID", fields.ModuleID);
            dbComm.Parameters.AddWithValue("ModLecturerStatus", fields.ModLecturerStatus);


            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }

        //Login
        public DataTable Login(string Email, string Password)
        {
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_Login";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", Email);
            dbComm.Parameters.AddWithValue("@Password", Password);
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //Gets the User Full Names into a label Using the Email entered on the login form
        public Fields GetFullNameByEmail(string Email)
        {
            //Instantiate the class under the DataAccessLayer
            Fields userData = new Fields();

            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_GetFullNameByEmail";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", Email);


            //It reads the data returned by the stored procedure
            using (SqlDataReader reader = dbComm.ExecuteReader())
            {
                if (reader.Read())
                {
                    // If data is found, it populates the userData object with the user's name, surname, and title.
                    userData.Name = reader["Name"].ToString();
                    userData.Surname = reader["Surname"].ToString();
                    userData.Title = reader["Title"].ToString();
                }
            }
            dbConn.Close();
            return userData;
        }

        //gets the lecturer Module Details into cmb Option
        public DataTable GetLecturerModDetails()
        {
            Fields fields = new Fields();
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_GetLecturerModDetails";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);

            dbConn.Close();
            return dt;

        }
        public DataTable GetStudentDetails()
        {
            Fields fields = new Fields();
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_GetStudentDetails";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);

            dbConn.Close();
            return dt;

        }
        public int InsertStudentModule(Fields fields)
        {
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_InsertStudentModule";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("LecturerModuleID", fields.LecturerModuleID);
            dbComm.Parameters.AddWithValue("UserID", fields.UserID);
            dbComm.Parameters.AddWithValue("Date", fields.Date);
            dbComm.Parameters.AddWithValue("StudModStatus", fields.StudModStatus);


            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }
        public DataTable GetStudentMod()
        {
            Fields fields = new Fields();
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_GetStudentMod";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);

            dbConn.Close();
            return dt;
        }
        public DataTable GetLecturerModByEmail(string Email)
        {

            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_LecturerModByEmail";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", Email);
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetAssessmentType()
        {
            Fields fields = new Fields();
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_GetAssessmentType";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);

            dbConn.Close();
            return dt;

        }
        public int InsertAssessment(Fields fields)
        {
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_CreateAssignment";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("Email", fields.Email);
            dbComm.Parameters.AddWithValue("LecturerModuleID", fields.LecturerModuleID);
            dbComm.Parameters.AddWithValue("DueDate", fields.DueDate);
            dbComm.Parameters.AddWithValue("AssessmentTypeID", fields.AssessmentTypeID);
            dbComm.Parameters.AddWithValue("AssessmentStatus", fields.AssessmentStatus);


            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }
        public DataTable GetAssessmentModByEmail(string Email)
        {

            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_GetAssessmentModByEmail";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", Email);
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable ViewStudentModulesByEmail(string Email)
        {

            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_ViewStudentModulesByEmail";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", Email);
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetStudentModIDbyEmail(string Email, int LecturerModuleID)
        {
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_GetStudentModIDbyEmail";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", Email);
            dbComm.Parameters.AddWithValue("LecturerModuleID", LecturerModuleID);
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;

        }
        public DataTable GetStudentAssessmentByEmail(string Email)
        {

            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_GetStudentAssessmentByEmail";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", Email);
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int UpdateAssessmentStatus(Fields fields)
        {
            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_UpdateAssessmentStatus";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("AssessmentID", fields.AssessmentID);
            dbComm.Parameters.AddWithValue("AssessmentStatus", fields.AssessmentStatus);
            dbComm.Parameters.AddWithValue("DueDate", fields.DueDate);



            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;


        }
        //tbc
        public DataTable FillStudentNameCmb(string Email)
        {

            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_FillStudentNameCmb";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", Email);
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable FilterAssess (string Email, string AssessmentStatus,int LecturerModuleID)
        {

            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_ReportByAssessStatus";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", Email);
            dbComm.Parameters.AddWithValue("@AssessmentStatus", AssessmentStatus);
            dbComm.Parameters.AddWithValue("@LecturerModuleID", LecturerModuleID);
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable FilterAssessByType(string Email, string AssessmentTypeDescription, int LecturerModuleID)
        {

            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_ReportByAssessType";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", Email);
            dbComm.Parameters.AddWithValue("@AssessmentTypeDescription", AssessmentTypeDescription);
            dbComm.Parameters.AddWithValue("@LecturerModuleID", LecturerModuleID);
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable FilterAssessByDueDate(string Email, DateTime DueDate, int LecturerModuleID)
        {

            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_ReportByDate";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", Email);
            dbComm.Parameters.AddWithValue("DueDate", DueDate);
            dbComm.Parameters.AddWithValue("@LecturerModuleID", LecturerModuleID);
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public Fields ViewLecturerMoDetails(int StudentModuleID,string Email)
        {
            //Instantiate the class under the DataAccessLayer
            Fields userData = new Fields();

            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_ViewLecturerMoDetails";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", Email);
            dbComm.Parameters.AddWithValue("@StudentModuleID", StudentModuleID);


            //It reads the data returned by the stored procedure
            using (SqlDataReader reader = dbComm.ExecuteReader())
            {
                if (reader.Read())
                {
                    // If data is found, it populates the userData object with the user's name, surname, and title.
                    userData.Name = reader["Name"].ToString();
                    userData.Surname = reader["Surname"].ToString();
                    userData.ModuleName = reader["ModuleName"].ToString();
                    userData.Email = reader["Email"].ToString();
                }
            }
            dbConn.Close();
            return userData;
        }
        public Fields ViewLecturerModOnPortal(int LecturerModuleID, string Email)
        {
            //Instantiate the class under the DataAccessLayer
            Fields userData = new Fields();

            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_ViewLecModOnPortal";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", Email);
            dbComm.Parameters.AddWithValue("@LecturerModuleID", LecturerModuleID);


            //It reads the data returned by the stored procedure
            using (SqlDataReader reader = dbComm.ExecuteReader())
            {
                if (reader.Read())
                {
                    // If data is found, it populates the userData object with the user's name, surname, and title.
                    userData.Name = reader["Name"].ToString();
                    userData.Surname = reader["Surname"].ToString();
                    userData.ModuleName = reader["ModuleName"].ToString();
                    userData.Email = reader["Email"].ToString();
                }
            }
            dbConn.Close();
            return userData;
        }
        public DataTable ViewAllAssignOnModules(string Email, int LecturerModuleID)
        {

            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_ViewAllAssignOnModules";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", Email);
            dbComm.Parameters.AddWithValue("@LecturerModuleID", LecturerModuleID);
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable ViewAssignByStudName(string Email, int LecturerModuleID,string Name)
        {

            dbConn = new SqlConnection(conn);
            dbConn.Open();
            string sql = "sp_ViewAssignByStudName";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", Email);
            dbComm.Parameters.AddWithValue("@LecturerModuleID", LecturerModuleID);
            dbComm.Parameters.AddWithValue("@Name", Name);
            da = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }





    }
}

