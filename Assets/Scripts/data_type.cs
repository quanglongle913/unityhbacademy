using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class data_type : MonoBehaviour
{
   

}
[System.Serializable]
public class lopHoc
{
    public List<giangVien> teachers;
    public List<sinhVien> students;
}
public enum TeacherType
{
    Main = 0,
    Support = 1,
    AcademicStaff = 2,
}
public enum Gender
{
    Male = 1,
    Female = 2,
}
[System.Serializable]
public class giangVien
{
    public int id;
    public string name;
    public int age;
    public int gender;
    public int type;
    public TeacherType teacherType
    {
        get { return (TeacherType)type; }
        set { type = (int)value; }
    }
    public Gender sex
    {
        get { return (Gender)gender; }
        set { gender = (int)value; }
    }
}
[System.Serializable]
public class sinhVien
{
    public int id;
    public string name;
    public int age;
    public int gender;
    public int diemThiCSharp;
    public Gender sex
    {
        get { return (Gender)gender; }
        set { gender = (int)value; }
    }
}