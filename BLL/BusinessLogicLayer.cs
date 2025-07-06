using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dal = new DataAccessLayer();
        public int InsertUsers(Fields fields)
        {
            return dal.InsertUsers(fields);
        }
        public DataTable GetUser()
        {
            return dal.GetUser();
        }
        public int UpdateUsers(Fields fields)
        {
            return dal.UpdateUsers(fields);
        }
        public DataTable GetUserRole(string Role)
        {
            return dal.GetUserRole(Role);
        }
        public DataTable GetModuleType()
        {
            return dal.GetModuleType();
        }
        public int InsertModule(Fields fields)
        {
            return dal.InsertModule(fields);
        }
        public DataTable GetModule()
        {
            return dal.GetModule();
        }
        public int InsertLecturerMod(Fields fields)
        {
            return dal.InsertLecturerMod(fields);
        }
        public DataTable GetLecturerMod()
        {
            return dal.GetLecturerMod();
        }
        public DataTable GetLecturerDetails()
        {
            return dal.GetLecturerDetails();
        }
        public DataTable GetModuleName()
        {
            return dal.GetModuleName();
        }
        public int UpdateLecturerMod(Fields fields)
        {
            return dal.UpdateLecturerMod(fields);
        }
        public DataTable Login(string Email, string Password)
        {
            return dal.Login(Email, Password);
        }
        // retrieve user data based on their email
        public Fields GetFullNameByEmail(string Email)
        {

            return dal.GetFullNameByEmail(Email);
        }
        //
        public DataTable GetLecturerModDetails()
        {
            return dal.GetLecturerModDetails();
        }
        public DataTable GetStudentDetails()
        {
            return dal.GetStudentDetails();
        }
        public int InsertStudentModule(Fields fields)
        {
            return dal.InsertStudentModule(fields);
        }
        public DataTable GetStudentMod()
        {
            return dal.GetStudentMod();

        }
        public DataTable GetLecturerModByEmail(string Email)
        {

            return dal.GetLecturerModByEmail(Email);
        }
        public DataTable GetAssessmentType()
        {
            return dal.GetAssessmentType();
        }
        public DataTable GetStudentModIDbyEmail(string Email, int LecturerModuleID)
        {
            return dal.GetStudentModIDbyEmail(Email, LecturerModuleID);
        }
        public int InsertAssessment(Fields fields)
        {
            return dal.InsertAssessment(fields);

        }
        public DataTable GetAssessmentModByEmail(string Email)
        {
            return dal.GetAssessmentModByEmail(Email);
        }
        public DataTable ViewStudentModulesByEmail(string Email)
        {
            return dal.ViewStudentModulesByEmail(Email);
        }
        public DataTable GetStudentAssessmentByEmail(string Email)
        {
            return dal.GetStudentAssessmentByEmail(Email);

        }
        public int UpdateAssessmentStatus(Fields fields)
        {
            return dal.UpdateAssessmentStatus(fields);
        }
        public DataTable GetUserByName(string Name)
        {

            return dal.GetUserByName(Name);
        }


        public DataTable SearchModule(string ModuleName)
        {
            return dal.SearchModule(ModuleName);
        }
        public DataTable ViewLeturerModByEmail(string Email)
        {
            return dal.ViewLeturerModByEmail(Email);
        }
        public DataTable FilterAssess(string Email, string AssessmentStatus, int LecturerModuleID)
        {
            return dal.FilterAssess(Email, AssessmentStatus, LecturerModuleID);
        }
        public DataTable FilterAssessByType(string Email, string AssessmentTypeDescription, int LecturerModuleID)
        {
            return dal.FilterAssessByType(Email, AssessmentTypeDescription, LecturerModuleID);
        }
        public DataTable FilterAssessByDueDate(string Email, DateTime DueDate, int LecturerModuleID)
        {
            return dal.FilterAssessByDueDate(Email, DueDate, LecturerModuleID);
        }
        public Fields ViewLecturerMoDetails(int StudentModuleID, string Email)
        {
            return dal.ViewLecturerMoDetails(StudentModuleID, Email);
        }
        public Fields ViewLecturerModOnPortal(int LecturerModuleID, string Email)
        {
            return dal.ViewLecturerModOnPortal(LecturerModuleID, Email);
        }
        public DataTable ViewAllAssignOnModules(string Email, int LecturerModuleID)
        {
            return dal.ViewAllAssignOnModules(Email, LecturerModuleID);
        }
        public DataTable ViewAssignByStudName(string Email, int LecturerModuleID, string Name)
        {
            return dal.ViewAssignByStudName(Email, LecturerModuleID, Name);
        }
       
    }
}
