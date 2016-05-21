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
        public static Test GetTestById(int testId)
        {
            var test = new Test();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                test = db.Tests.Single(x => x.Id == testId);
            }

            return test;
        }
        public static TestType GetTestTypeById(int testTypeId)
        {
            var testType = new TestType();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                testType = db.TestTypes.Single(x => x.Id == testTypeId);
            }

            return testType;
        }
        public static TestLevel GetTestLevekById(int testLevelId)
        {
            var testLevel = new TestLevel();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                testLevel = db.TestLevels.Single(x => x.Id == testLevelId);
            }

            return testLevel;
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
        public static List<Test> GetAllTests()
        {
            var testList = new List<Test>();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                testList = db.Tests.ToList();
            }

            return testList;
        }
        public static List<TestType> GetAllTestTypes()
        {
            var testTypeList = new List<TestType>();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                testTypeList = db.TestTypes.ToList();
            }

            return testTypeList;
        }
        public static List<TestLevel> GetAllTestLevels()
        {
            var testLevelList = new List<TestLevel>();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                testLevelList = db.TestLevels.ToList();
            }

            return testLevelList;
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
        public static void InsertTest(Test test)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                db.Tests.Add(test);
                db.SaveChanges();
            }
        }
        public static void InsertTestType(TestType testType)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                db.TestTypes.Add(testType);
                db.SaveChanges();
            }
        }
        public static void InsertTestLevel(TestLevel testLevel)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                db.TestLevels.Add(testLevel);
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
        public static void UpdateTest(Test test)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempTest = db.Tests.Single(x => x.Id == test.Id);
                tempTest.TestName = test.TestName;
                tempTest.TestLevelId = test.TestLevelId;
                tempTest.TestTypeId = test.TestTypeId;
                db.SaveChanges();
            }
        }
        public static void UpdateTestType(TestType testType)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempTesttype = db.TestTypes.Single(x => x.Id == testType.Id);
                tempTesttype.TestTypeName = testType.TestTypeName;
                db.SaveChanges();
            }
        }
        public static void UpdateTestLevel(TestLevel testLevel)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempTestlevel = db.TestLevels.Single(x => x.Id == testLevel.Id);
                tempTestlevel.TestLevelName = testLevel.TestLevelName;
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
        public static void DeleteTest(int testId)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempTest = db.Tests.Single(x => x.Id == testId);
                db.Tests.Remove(tempTest);
                db.SaveChanges();
            }
        }
        public static void DeleteTestType(int testTypeId)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempTestType = db.TestTypes.Single(x => x.Id == testTypeId);
                db.TestTypes.Remove(tempTestType);
                db.SaveChanges();
            }
        }
        
        public static void DeleteTestLevel(int testLevelId)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempTestLevel = db.TestLevels.Single(x => x.Id == testLevelId);
                db.TestLevels.Remove(tempTestLevel);
               db.SaveChanges();
            }
        }
        #endregion


    }
}