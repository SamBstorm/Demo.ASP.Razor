using Model.Global.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Global
{
    public class Database
    {
        public List<Stagiaire> stagiaires { get; set; }

        public Database()
        {
            stagiaires = new List<Stagiaire>();
            stagiaires.Add(new Stagiaire() { Id = 1, FirstName = "Edouard", LastName = "De Keyser", NationalRegistre = "12345678901", Email = "e.de_keyser@tftic.be" });
            stagiaires.Add(new Stagiaire() { Id = 2, FirstName = "Sarah", LastName = "Klewiec", NationalRegistre = "12345678901", Email = "s.klewiec@tftic.be" });
            stagiaires.Add(new Stagiaire() { Id = 3, FirstName = "Hajer", LastName = "Soussi", NationalRegistre = "12345678901", Email = "h.soussi@tftic.be" });
            stagiaires.Add(new Stagiaire() { Id = 4, FirstName = "Diego", LastName = "Bouffa", NationalRegistre = "12345678901", Email = "d.bouffa@tftic.be" });
            stagiaires.Add(new Stagiaire() { Id = 5, FirstName = "Giosue", LastName = "Liuzzo", NationalRegistre = "12345678901", Email = "g.liuzzo@tftic.be" });
            stagiaires.Add(new Stagiaire() { Id = 6, FirstName = "Adnane", LastName = "Abdeddeim", NationalRegistre = "12345678901", Email = "a.abdedeim@tftic.be" });
            stagiaires.Add(new Stagiaire() { Id = 7, FirstName = "Mohamed", LastName = "Keita", NationalRegistre = "12345678901", Email = "m.keita@tftic.be" });
            stagiaires.Add(new Stagiaire() { Id = 8, FirstName = "Lahcen", LastName = "Boukhoubza", NationalRegistre = "12345678901", Email = "l.boukhoubza@tftic.be" });
            stagiaires.Add(new Stagiaire() { Id = 9, FirstName = "Christophe", LastName = "Vande Velde", NationalRegistre = "12345678901", Email = "c.vande_velde@tftic.be" });
            stagiaires.Add(new Stagiaire() { Id = 10, FirstName = "Jérémy", LastName = "Bouillon", NationalRegistre = "12345678901", Email = "j.bouillon@tftic.be" });
            stagiaires.Add(new Stagiaire() { Id = 11, FirstName = "Philemon", LastName = "Tchachoua", NationalRegistre = "12345678901", Email = "p.tchachoua@tftic.be" });
            stagiaires.Add(new Stagiaire() { Id = 12, FirstName = "Thomas", LastName = "Lepoint", NationalRegistre = "12345678901", Email = "t.lepoint@tftic.be" });
            stagiaires.Add(new Stagiaire() { Id = 13, FirstName = "Emmanuel", LastName = "Godfroid", NationalRegistre = "12345678901", Email = "e.godfroid@tftic.be" });
        }
    }
}
