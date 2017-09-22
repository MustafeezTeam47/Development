using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExcelSoftFactory.Masters;
using System.Data;

namespace ExcelSoftBAL.Masters
{
    public class Section:ISection
    {
        private int _sectionID;
        private string _sectionCode;
        private string _sectionName;
        private bool _isActive;

        public int SectionID
        {
            get
            {
                return _sectionID;
            }

            set
            {
                _sectionID = value;
            }
        }

        public string SectionCode
        {
            get
            {
                return _sectionCode;
            }

            set
            {
                _sectionCode = value;
            }
        }

        public string SectionName
        {
            get
            {
                return _sectionName;
            }

            set
            {
                _sectionName = value;
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
        public string SaveSection()
        {
            try
            {
                return new ExcelSoftDAL.Masters.Section().SaveSection(this);
            }
            catch { throw; }
        }
        public DataSet ShowSections()
        {
            try
            {
                return new ExcelSoftDAL.Masters.Section().ShowSections();
            }
            catch
            { throw; }
        }
        public DataSet GetSection()
        {
            try
            {
                return new ExcelSoftDAL.Masters.Section().GetSection(this);
            }
            catch
            { throw; }
        }
    }
}
