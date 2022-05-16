using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName =("getList"),menuName =("empMenu"))]
public class EmpBehaviour : ScriptableObject
{

    public List<Employee> empList = new List<Employee>();

    // Start is called before the first frame update

}

[System.Serializable]

public class Employee
{

    public string name;
    public string email;
    public genderType gender;
    public string address;
    public designationType designation;
    public long contact;
    public int id;

    public enum genderType
    {
        Male,
        Female
    }

    public enum designationType
    {
        Junior,
        Senior,
        Project_manager
    }
}

