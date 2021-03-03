using Model.Global.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Global.Repositories
{
    public class StagiaireRepository
    {
        public Stagiaire Get(int id)
        {
            return DBContext.DB.stagiaires.Where(s => s.Id == id).SingleOrDefault();
        }
        public IEnumerable<Stagiaire> Get()
        {
            return DBContext.DB.stagiaires;
        }
        public int Insert(Stagiaire entity)
        {
            int maxId = DBContext.DB.stagiaires.Max(s => s.Id);
            maxId += 1;
            entity.Id = maxId;
            DBContext.DB.stagiaires.Add(entity);
            return entity.Id;
        }
        public bool Update (int id, Stagiaire entity)
        {
            if (DBContext.DB.stagiaires.Select(s => s.Id).Contains(id))
            {
                Stagiaire oldData = this.Get(id);
                oldData.FirstName = entity.FirstName;
                oldData.LastName = entity.LastName;
                oldData.NationalRegistre = entity.NationalRegistre;
                oldData.Email = entity.Email;
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            if (DBContext.DB.stagiaires.Select(s => s.Id).Contains(id))
            {
                Stagiaire oldData = this.Get(id);
                DBContext.DB.stagiaires.Remove(oldData);
                return true;
            }
            return false;
        }
    }
}
