using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
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
                var my = new Testora();

                my.Id = testora.Id;
                my.Name = testora.Name;

                var check_data = _db.Testoras.FirstOrDefault(x => x.Id == my.Id);
                if (check_data == null)
                {
                    _db.Testoras.Add(my);
                    _db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }

                    
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
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

        public object GetStudentById(string id)
        {
            var data = _db.Testoras.FirstOrDefault(x => x.Id == id);
            return data;
        }

        public List<Testora> GetStudents()
        {
            //  var data = _db.Testoras.ToList();
            var data= new List<Testora> ();
            data.Add(new Testora
            {
                Name = "shamim",
                Id = "01001"
            });
            data.Add(new Testora
            {


                Name = "Mainul",
                Id = "01002"

            });
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
