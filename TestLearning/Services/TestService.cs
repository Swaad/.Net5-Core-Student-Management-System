using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestLearning.Entities;
using TestLearning.Interfaces;

namespace TestLearning.Services
{
    public class TestService : ITestService
    {
        ModelContext _db;

        public TestService(ModelContext db)
        {
            _db = db;
        }

        public bool AddStudent(Testora testora)
        {
            try
            {
                _db.Testoras.Add(testora);
                _db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }


        public bool Delete(string id, ModelContext db)
        {
            bool isSaved = false;
            try
            {
                var data = _db.Testoras.FirstOrDefault(x => x.Id == id);
                if (data != null)
                {
                    _db.Testoras.Remove(data);
                    _db.SaveChanges();
                }
                isSaved = true;
            }
            catch (Exception ex)
            {
                isSaved = false;
            }
            return isSaved;
        }

        //public List<Bank> GetBanks()
        //{
        //    var data = _db.Banks.ToList();
        //    return data;
        //}

        //public List<Branch> GetBranches()
        //{
        //    var data = _db.Branches.ToList();
        //    return data;
        //}

        public List<Testora> GetStudents()
        {
            var data = _db.Testoras.ToList();
            return data;
        }

        public bool Update(Testora model, ModelContext db)
        {
            bool isSaved = false;
            var oldData = _db.Testoras.FirstOrDefault(x => x.Id == model.Id);

            if (oldData != null)
            {
                oldData.Name = model.Name;

                db.Entry(oldData).State = EntityState.Modified;
                _db.SaveChanges();
                isSaved = true;
            }
            return isSaved;

        }
    }
}
