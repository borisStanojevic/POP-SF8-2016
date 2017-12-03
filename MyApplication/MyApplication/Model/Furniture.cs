﻿using MyApplication.DAO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyApplication.Model
{
    [Serializable]
    public class Furniture : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }


        private bool deleted;

        public bool Deleted
        {
            get { return deleted; }
            set
            {
                deleted = value;
                OnPropertyChanged("Deleted");
            }
        }


        private int furnitureTypeId;

        public int FurnitureTypeId
        {
            get { return furnitureTypeId; }
            set
            {
                furnitureTypeId = value;
                OnPropertyChanged("FurnitureTypeId");
            }
        }


        private FurnitureType furnitureType;

        [XmlIgnore]
        public FurnitureType FurnitureType
        {
            get
            {
                if (furnitureType == null)
                {
                    furnitureType = new EntityDAO<FurnitureType>("furniture_types.xml").Get(furnitureTypeId);
                }
                return furnitureType;
            }
            set
            {
                furnitureType = value;
                furnitureTypeId = furnitureType.Id;
                OnPropertyChanged("FurnitureType");
            }

        }

        private int actionSaleId;

        public int ActionSaleId
        {
            get { return actionSaleId; }
            set
            {
                actionSaleId = value;
                OnPropertyChanged("ActionSaleId");
            }
        }

        private ActionSale actionSale;

        [XmlIgnore]
        public ActionSale ActionSale
        {
            get
            {
                if (actionSale == null)
                {
                    actionSale = new EntityDAO<ActionSale>("action_sales.xml").Get(actionSaleId);
                }
                return actionSale;
            }
            set
            {
                actionSale = value;
                actionSaleId = actionSale.Id;
                OnPropertyChanged("ActionSale");
            }
        }

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
