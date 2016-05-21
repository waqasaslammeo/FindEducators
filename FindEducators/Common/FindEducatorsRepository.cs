using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FindEducators.Context;
using FindEducators.Models;

namespace FindEducators.Common
{
    public static class FindEducatorsRepository
    {

        #region Get

        public static DegreeType GetDegreeTypeById(int degreeTypeId)
        {
            var degreeType = new DegreeType();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                degreeType = db.DegreeTypes.Single(x => x.Id == degreeTypeId);
            }

            return degreeType;
        }

        #endregion

        #region List

        public static List<DegreeType> GetAllDegreeTypes()
        {
            var degreeTypeList = new List<DegreeType>();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                degreeTypeList = db.DegreeTypes.ToList();
            }

            return degreeTypeList;
        }
        #endregion

        #region Insert

        public static void InsertDegreeType(DegreeType degreeType)
        {
            
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                db.DegreeTypes.Add(degreeType);
                db.SaveChanges();
            }
        }

        #endregion

        #region Update
        public static void UpdateDegreeType(DegreeType degreeType)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempDegreetype = db.DegreeTypes.Single(x => x.Id == degreeType.Id);
                tempDegreetype.DegreeTypeName = degreeType.DegreeTypeName;
                db.SaveChanges();
            }
        }
        #endregion

        #region Delete

        public static void DeleteDegreeType(int degreeTypeId)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempDegreeType = db.DegreeTypes.Single(x => x.Id == degreeTypeId);
                db.DegreeTypes.Remove(tempDegreeType);
                db.SaveChanges();
            }
        }

        #endregion


    }
}