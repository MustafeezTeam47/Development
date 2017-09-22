using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExcelSoftFactory.Masters;
using System.Data;

namespace ExcelSoftBAL.Masters
{
    public class ItemMaster:IItemMaster
    {
        private int _itemID;
        private string _itemCode;
        private string _itemName;
        private int? _categoryID;
        private bool _isActive;

        public int ItemID
        {
            get
            {
                return _itemID;
            }

            set
            {
                _itemID = value;
            }
        }

        public string ItemCode
        {
            get
            {
                return _itemCode;
            }

            set
            {
                _itemCode = value;
            }
        }

        public string ItemName
        {
            get
            {
                return _itemName;
            }

            set
            {
                _itemName = value;
            }
        }

        public int? CategoryID
        {
            get
            {
                return _categoryID;
            }

            set
            {
                _categoryID = value;
            }
        }

        public bool IsActive
        {
            get
            {
                return _isActive;
            }

            set
            {
                _isActive = value;
            }
        }

        public string SaveItemMaster()
        {
            try {
                return new ExcelSoftDAL.Masters.ItemMaster().SaveItemMaster(this);
            }
            catch { throw; }
        }
        public DataSet ShowItems()
        {
            try
            {
                return new ExcelSoftDAL.Masters.ItemMaster().ShowItems();
            }
            catch
            { throw; }
        }
        public DataSet GetItem()
        {
            try
            {
                return new ExcelSoftDAL.Masters.ItemMaster().GetItem(this);
            }
            catch
            { throw; }
        }
    }
}
