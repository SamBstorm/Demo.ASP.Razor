using Model.Client.Mapper;
using Model.Client.Models;
using Model.Global.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Client.Services
{
    public class StagiaireService
    {
        private StagiaireRepository _repo;

        public StagiaireService()
        {
            _repo = new StagiaireRepository();
        }

        public Stagiaire Get(int id)
        {
            return _repo.Get(id).ToClient();
        }

        public IEnumerable<Stagiaire> Get()
        {
            return _repo.Get().Select(s => s.ToClient());
        }

        public int Insert(Stagiaire entity)
        {
            return _repo.Insert(entity.ToGlobal());
        }
        public bool Update(int id, Stagiaire entity)
        {
            return _repo.Update(id, entity.ToGlobal());
        }

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }
    }
}
