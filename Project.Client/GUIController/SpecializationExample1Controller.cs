using Domain;
using Project.Client.ServerCommunication;
using Project.Client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Client.GUIController
{
    public class SpecializationExample1Controller
    {
        private UCSpecializationExample1 _userControl;

        public SpecializationExample1Controller(UCSpecializationExample1 userControl)
        {
            _userControl = userControl;
            DisplayTable();
        }

        public void DisplayTable()
        {
            List<UniversityMember> members = Communication.Instance.SendRequestGetResponse<List<UniversityMember>>(
                Common.Operation.GET_UNIVERSITY_MEMBERS
            );
            _userControl.TableView.DataSource = members;
        }

        public UserControl GetMemberUserControl()
        {
            DataGridViewRow selectedRow = _userControl.TableView.CurrentRow;

            if (selectedRow != null)
            {
                UniversityMember selectedObject = (UniversityMember)selectedRow.DataBoundItem;
                if (selectedObject.Type == "Student")
                {
                    Student student = new Student()
                    {
                        ID = (int) selectedObject.Student
                    };
                    student = Communication.Instance.SendRequestGetResponse<Student>(
                        Common.Operation.GET_STUDENT,
                        student
                    );
                    return new UCStudentBox(selectedObject, student);
                }
                else if (selectedObject.Type == "Professor")
                {
                    Professor professor = new Professor()
                    {
                        ID = (int)selectedObject.Professor
                    };
                    professor = Communication.Instance.SendRequestGetResponse<Professor>(
                        Common.Operation.GET_PROFESSOR,
                        professor
                    );
                    return new UCProfessorBox(selectedObject, professor);
                }
                else
                {
                    Student student = new Student()
                    {
                        ID = (int)selectedObject.Student
                    };
                    student = Communication.Instance.SendRequestGetResponse<Student>(
                        Common.Operation.GET_STUDENT,
                        student
                    );

                    Professor professor = new Professor()
                    {
                        ID = (int)selectedObject.Professor
                    };
                    professor = Communication.Instance.SendRequestGetResponse<Professor>(
                        Common.Operation.GET_PROFESSOR,
                        professor
                    );
                    return new UCStudentProfessorBox(selectedObject, student, professor);
                }
            }

            return null;
        }
    }
}
