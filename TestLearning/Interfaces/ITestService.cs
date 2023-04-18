using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestLearning.Entities;

namespace TestLearning.Interfaces
{
    public interface ITestService
    {
        //public List<Bank> GetBanks();
        //public List<Branch> GetBranches();
        //public bool AddBank(Bank bank, ModelContext db);
        //public bool AddBranch(Branch branch);
        bool Delete(string id, ModelContext db);
        bool Update(Testora model, ModelContext db);
        public List<Testora> GetStudents();
        public bool AddStudent(Testora testora);
        public object GetStudentById(string id);
    }
}