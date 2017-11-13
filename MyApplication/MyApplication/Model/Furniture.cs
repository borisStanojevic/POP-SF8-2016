﻿using MyApplication.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Model
{
    [Serializable]
    public class Furniture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        //Redefinisati model tako da tip namjestaja bude int (... zbog ogranicenja stranog kljuca...)
        public int TypeId { get; set; }
        public ActionSale action { get; set; }
        public bool Deleted { get; set; }

        public override string ToString()
        {
            return String.Format("{0,-5}|{1,-15}|{2,-10}|{3,-5}|{4,-5}|{5,-5}", Id, Name, Price, Quantity, new EntityDAO<FurnitureType>("furniture_types.xml").Get(TypeId).Name, action.Id, Deleted);
        }
    }
}