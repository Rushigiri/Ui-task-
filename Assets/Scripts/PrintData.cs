using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintData : MonoBehaviour
{
    public static PrintData Instance;

    public Text nameOut;
    public Text emailOut;
    public Text contactOut;
    public Text idOut;
    public Text genderOut;
    public Text addressOut;
    public Text designationOut;

    public EmpBehaviour listOfEmp;

    private void Awake()
    {
        Instance = this;
    }


    public void SetData(Employee employee)
    {


        nameOut.text = employee.name;
        emailOut.text = employee.email;
        addressOut.text = employee.address;
        contactOut.text = employee.contact.ToString();
        idOut.text = employee.id.ToString();
        designationOut.text = employee.designation.ToString();
        genderOut.text = employee.gender.ToString();
    }

    public void SetEmpData()
    {
        //EmpBehaviour emp = new EmpBehaviour();
        SetData(listOfEmp.empList[0]);
    }
    public void BackToHomePage()
    {
        ScreenScript.Instance.registerScreen.SetActive(false);
        ScreenScript.Instance.empDataScreen.SetActive(false);
        ScreenScript.Instance.homeScreen.SetActive(true);

    }
    public void GoToRegisterScreen()
    {
        ScreenScript.Instance.registerScreen.SetActive(true);
        ScreenScript.Instance.empDataScreen.SetActive(false);
        ScreenScript.Instance.homeScreen.SetActive(false);

    }
}

