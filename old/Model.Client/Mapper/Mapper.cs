using System;
using System.Collections.Generic;
using System.Text;
using G = Model.Global.Models;
using C = Model.Client.Models;

namespace Model.Client.Mapper
{
    public static class Mapper
    {
        public static C.Stagiaire ToClient(this G.Stagiaire entity)
        {
            if (entity == null) return null;
            return new C.Stagiaire()
            {
                Id= entity.Id,
                LastName = entity.LastName,
                FirstName = entity.FirstName,
                NationalRegistre = entity.NationalRegistre,
                Email = entity.Email
            };
        }

        public static G.Stagiaire ToGlobal(this C.Stagiaire entity)
        {
            if (entity == null) return null;
            return new G.Stagiaire()
            {
                Id = entity.Id,
                LastName = entity.LastName,
                FirstName = entity.FirstName,
                NationalRegistre = entity.NationalRegistre,
                Email = entity.Email
            };
        }
    }
}
