using Common;
using Domain;
using System;
using System.Collections.Generic;

namespace Server
{
    public class Controller
    {
        private static Controller _instance;
        private static object _instanceLock = new object();

        public static Controller Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock(_instanceLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Controller();
                        }
                    }
                }

                return _instance;
            }
        }

        private Controller() { }

        public UniversityMember GetUniversityMember(UniversityMember universityMember)
        {
            GetUniversityMemberSO operation = new GetUniversityMemberSO();
            operation.ExecuteTemplate(universityMember);
            return operation.Result;
        }

        public List<UniversityMember> GetUniversityMembers()
        {
            GetUniversityMembersSO operation = new GetUniversityMembersSO();
            operation.ExecuteTemplate(null);
            return operation.Result;
        }

        public Professor GetProfessor(Professor professor)
        {
            GetProfessorSO operation = new GetProfessorSO();
            operation.ExecuteTemplate(professor);
            return operation.Result;
        }

        public Student GetStudent(Student student)
        {
            GetStudentSO operation = new GetStudentSO();
            operation.ExecuteTemplate(student);
            return operation.Result;
        }

        public List<User> GetUsers()
        {
            GetUsersSO operation = new GetUsersSO();
            operation.ExecuteTemplate(null);
            return operation.Result;
        }

        public void SaveUser(User user)
        {
            SaveUserSO operation = new SaveUserSO();
            operation.ExecuteTemplate(user);
        }

        public List<Product> GetProducts()
        {
            GetProductsSO operation = new GetProductsSO();
            operation.ExecuteTemplate(null);
            return operation.Result;
        }

        public List<AnimalSpecies> GetAnimalSpecies()
        {
            GetAnimalSpeciesSO operation = new GetAnimalSpeciesSO();
            operation.ExecuteTemplate(null);
            return operation.Result;
        }

        public List<Animal> GetAnimals()
        {
            GetAnimalsSO operation = new GetAnimalsSO();
            operation.ExecuteTemplate(null);
            return operation.Result;
        }

        public AnimalSpecies GetSpecificAnimalSpecies(AnimalSpecies animalSpecies)
        {
            GetSpecificAnimalSpecies operation = new GetSpecificAnimalSpecies();
            operation.ExecuteTemplate(animalSpecies);
            return operation.Result;
        }

        public List<Animal> GetAnimalsForSpecies(AnimalSpecies animalSpecies)
        {
            GetAnimalsForSpeciesSO operation = new GetAnimalsForSpeciesSO();
            operation.ExecuteTemplate(animalSpecies);
            return operation.Result;
        }
    }
}
