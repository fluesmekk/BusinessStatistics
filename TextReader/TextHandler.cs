using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextReader
{
    //class TextHandler
    //{
        


    //    public void CreateBusiness(string[] txt)
    //    {
    //        string BusinessName = findBusinessName(txt);
    //        string[] TxtWithoutBusinessName = txt.Skip(1).ToArray();

    //        Business business = new Business(BusinessName, CreateDepartments(TxtWithoutBusinessName));
    //    }

    //    private List<Department> CreateDepartments(string[] txt)
    //    {
    //        List<Department> Departments = splitDepartments(txt);

    //        return null;
    //    }

    //    private List<Department> splitDepartments(string[] txt)
    //    {
    //        List<Department> departmentList = new List<Department>();
    //        List<int> arrayPositionDepartment = createDepartmentIndexes(txt);
    //        List<string[]> splitDepartmentText = splitDepartmentTxtToArray(arrayPositionDepartment, txt);

    //    }

    //    private List<string[]> splitDepartmentTxtToArray(List<int> indexes, string[] txt)
    //    {
    //        List<string[]> splitArray = new List<string[]>();
    //        for (int i = indexes.Count; i < 0; i--)
    //        {
    //            splitArray.Add(new string[(indexes[i] + indexes[i+1])]);
    //        }
    //    }

    //    private List<int> createDepartmentIndexes(string[] txt)
    //    {
    //        List<int> indexes = new List<int>();
    //        for (int i = 0; i < txt.Length; i++)
    //        {
    //            if (txt[i].Contains("Avdeling")) indexes.Add(i);
    //        }

    //        return indexes;
    //    }


    //    private string findBusinessName(string[] txt)
    //    {
    //        return txt[0];
    //    }
    //}
}
